//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace E_CommerceF.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class HISTORIAL_PRECIO
    {
        public int Id { get; set; }
        public int FK_PRODUCTOS { get; set; }
        public double PRECIO { get; set; }
        public Nullable<System.DateTime> FECHA_ACTUALIZACION { get; set; }
        public int STATUS { get; set; }
        public string RAZON { get; set; }
        public string OBSERVACIÓN { get; set; }
        public string FECHA_SOLITUD { get; set; }
        public Nullable<double> PRECIOANTERIOR { get; set; }
    
        public virtual PRODUCTO PRODUCTO { get; set; }
    }
}
