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
    
    public partial class PRODUCTO_PROVEEDOR
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PRODUCTO_PROVEEDOR()
        {
            this.PRODUCTO_PEDIDO = new HashSet<PRODUCTO_PEDIDO>();
        }
    
        public int ID { get; set; }
        public string NOMBRE { get; set; }
        public string DESCRIPCION { get; set; }
        public double PRECIO { get; set; }
        public Nullable<int> GARANTIA { get; set; }
        public System.DateTime CRATED_AT { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRODUCTO_PEDIDO> PRODUCTO_PEDIDO { get; set; }
    }
}
