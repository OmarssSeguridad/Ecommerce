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
    
    public partial class DIRECCION
    {
        public int ID { get; set; }
        public string ESTADO { get; set; }
        public string CIUDAD { get; set; }
        public string MUNICIPIO { get; set; }
        public string COLONIA { get; set; }
        public string CALLE { get; set; }
        public string CP { get; set; }
        public string NUMERO { get; set; }
        public int ACTIVO { get; set; }
        public System.DateTime CREATED_AT { get; set; }
        public int FK_CLIENTE { get; set; }
    
        public virtual USUARIO USUARIO { get; set; }
    }
}
