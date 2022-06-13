
namespace A001sql
{
	partial class Form1
	{
		/// <summary>
		/// Variable del diseñador necesaria.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpiar los recursos que se estén usando.
		/// </summary>
		/// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código generado por el Diseñador de Windows Forms

		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido de este método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.buttonProbar = new System.Windows.Forms.Button();
			this.errorProviderControl = new System.Windows.Forms.ErrorProvider(this.components);
			this.controlErrorBBDD = new LibreriaControles.ControlErrorCentrado();
			this.controlErrorServidor = new LibreriaControles.ControlErrorCentrado();
			this.buttonGuardar = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.errorProviderControl)).BeginInit();
			this.SuspendLayout();
			// 
			// buttonProbar
			// 
			this.buttonProbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(120)))));
			this.buttonProbar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonProbar.ForeColor = System.Drawing.Color.White;
			this.buttonProbar.Location = new System.Drawing.Point(133, 210);
			this.buttonProbar.Name = "buttonProbar";
			this.buttonProbar.Size = new System.Drawing.Size(200, 60);
			this.buttonProbar.TabIndex = 6;
			this.buttonProbar.Text = "PROBAR CONEXIÓN";
			this.buttonProbar.UseVisualStyleBackColor = false;
			this.buttonProbar.Click += new System.EventHandler(this.Button1_Click);
			// 
			// errorProviderControl
			// 
			this.errorProviderControl.ContainerControl = this;
			// 
			// controlErrorBBDD
			// 
			this.controlErrorBBDD.Location = new System.Drawing.Point(100, 90);
			this.controlErrorBBDD.Margin = new System.Windows.Forms.Padding(5);
			this.controlErrorBBDD.Name = "controlErrorBBDD";
			this.controlErrorBBDD.Size = new System.Drawing.Size(460, 60);
			this.controlErrorBBDD.TabIndex = 8;
			this.controlErrorBBDD.TextError = "";
			this.controlErrorBBDD.TextEtiqueta = "Base de Datos:";
			this.controlErrorBBDD.TextInput = "";
			// 
			// controlErrorServidor
			// 
			this.controlErrorServidor.Location = new System.Drawing.Point(100, 20);
			this.controlErrorServidor.Margin = new System.Windows.Forms.Padding(4);
			this.controlErrorServidor.Name = "controlErrorServidor";
			this.controlErrorServidor.Size = new System.Drawing.Size(460, 60);
			this.controlErrorServidor.TabIndex = 7;
			this.controlErrorServidor.TextError = "";
			this.controlErrorServidor.TextEtiqueta = "Servidor:";
			this.controlErrorServidor.TextInput = "";
			// 
			// buttonGuardar
			// 
			this.buttonGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(120)))), ((int)(((byte)(60)))));
			this.buttonGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonGuardar.ForeColor = System.Drawing.Color.White;
			this.buttonGuardar.Location = new System.Drawing.Point(393, 210);
			this.buttonGuardar.Name = "buttonGuardar";
			this.buttonGuardar.Size = new System.Drawing.Size(200, 60);
			this.buttonGuardar.TabIndex = 9;
			this.buttonGuardar.Text = "GUARDAR DATOS";
			this.buttonGuardar.UseVisualStyleBackColor = false;
			this.buttonGuardar.Click += new System.EventHandler(this.ButtonGuardar_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(727, 304);
			this.Controls.Add(this.buttonGuardar);
			this.Controls.Add(this.controlErrorBBDD);
			this.Controls.Add(this.controlErrorServidor);
			this.Controls.Add(this.buttonProbar);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.errorProviderControl)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Button buttonProbar;
		private LibreriaControles.ControlErrorCentrado controlErrorServidor;
		private System.Windows.Forms.ErrorProvider errorProviderControl;
		private LibreriaControles.ControlErrorCentrado controlErrorBBDD;
		private System.Windows.Forms.Button buttonGuardar;
	}
}

