using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;
using ValidarForms;

namespace A001sql
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();

			PrepararInputs();
			buttonGuardar.Enabled = false;
		}

		private void PrepararInputs()
		{
			LeerConfiguracion(out string servidor, out string baseDatos, out string usuario,
				out string password);
			controlErrorServidor.TextEtiqueta = "Servidor:";
			controlErrorServidor.TextError = "";
			controlErrorServidor.TextInput = servidor;
			controlErrorBBDD.TextEtiqueta = "Base de Datos:";
			controlErrorBBDD.TextError = "";
			controlErrorBBDD.TextInput = baseDatos;
		}

		private void LeerConfiguracion(out string servidor, out string baseDatos, out string usuario,
				out string password)
		{
			servidor = ConfigurationManager.AppSettings["Servidor"] ?? "";
			baseDatos = ConfigurationManager.AppSettings["BaseDatos"] ?? "";
			usuario = ConfigurationManager.AppSettings["Usuario"] ?? "";
			password = ConfigurationManager.AppSettings["Password"] ?? "";

			if (servidor != "")
			{
				servidor = EncriptarTexto.DesEncriptar(servidor);
			}
			if (baseDatos != "")
			{
				baseDatos = EncriptarTexto.DesEncriptar(baseDatos);
			}
			if (usuario != "")
			{
				usuario = EncriptarTexto.DesEncriptar(usuario);
			}
			if (password != "")
			{
				password = EncriptarTexto.DesEncriptar(password);
			}
		}

		private void Button1_Click(object sender, System.EventArgs e)
		{
			bool correctos = ValidarCampos();

			buttonGuardar.Enabled = false;
			if (correctos)
			{
				string cadenaConexion = $"Initial Catalog={controlErrorBBDD.TextInput};"+
					$"server={controlErrorServidor.TextInput};user={controlErrorUsuario.TextInput};";

				using (SqlConnection conexion = new SqlConnection(cadenaConexion))
				{
					Cursor = Cursors.WaitCursor;
					try
					{
						conexion.Open();
						Cursor = Cursors.Default;
						MessageBox.Show("Puedes cerrar la ventana de conexión.", "Conexión correcta ...",
							MessageBoxButtons.OK);
						buttonGuardar.Enabled = true;
					}
					catch (Exception)
					{
						Cursor = Cursors.Default;
						MessageBox.Show("Algún parámetro no es correcto.", "Conexión fallida ...",
							MessageBoxButtons.OK);
					}
				}
			}
		}

		private bool ValidarCampos()
		{
			bool salida = FormsValidacion.ValidarLongitudTexto(errorProviderControl,
				controlErrorServidor, "Servidor", 1, 55);

			salida &= FormsValidacion.ValidarLongitudTexto(errorProviderControl,
				controlErrorBBDD, "Base de Datos", 1, 55);

			return salida;
		}

		private void ButtonGuardar_Click(object sender, EventArgs e)
		{
			Configuration configuracion =
				ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
			var settings = configuracion.AppSettings.Settings;
			string servidor = controlErrorServidor.TextInput, baseDatos = controlErrorBBDD.TextInput;

			servidor = EncriptarTexto.Encriptar(servidor);
			baseDatos = EncriptarTexto.Encriptar(baseDatos);
			if (settings.Count == 0)
			{
				settings.Add("Servidor", servidor);
				settings.Add("BaseDatos", baseDatos);
			}
			else
			{
				if (settings["Servidor"] is null)
				{
					settings.Add("Servidor", servidor);
				}
				else
				{
					settings["Servidor"].Value = servidor;
				}
				if (settings["BaseDatos"] is null)
				{
					settings.Add("BaseDatos", baseDatos);
				}
				else
				{
					settings["BaseDatos"].Value = baseDatos;
				}
			}

			configuracion.Save(ConfigurationSaveMode.Full, true);
			ConfigurationManager.RefreshSection("appSettings");
		}
	}
}
