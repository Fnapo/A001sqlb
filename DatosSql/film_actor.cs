//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DatosSql
{
    using System;
    using System.Collections.Generic;
    
    public partial class film_actor
    {
        public int actor_id { get; set; }
        public int film_id { get; set; }
        public System.DateTime last_update { get; set; }
    
        public virtual actor actor { get; set; }
        public virtual film film { get; set; }
    }
}
