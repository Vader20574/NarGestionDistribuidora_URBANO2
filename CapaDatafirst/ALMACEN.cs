//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CapaDatafirst
{
    using System;
    using System.Collections.Generic;
    
    public partial class ALMACEN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ALMACEN()
        {
            this.ARTIDATs = new HashSet<ARTIDAT>();
        }
    
        public string codempresa { get; set; }
        public string CODALMACEN { get; set; }
        public Nullable<System.DateTime> DATETRANS { get; set; }
        public Nullable<bool> TRANS { get; set; }
        public Nullable<bool> ESTADO { get; set; }
        public Nullable<bool> AJUSTESTOCK { get; set; }
        public Nullable<System.DateTime> FECTOMAINV { get; set; }
        public string TERMINAL { get; set; }
        public Nullable<bool> ACTIVO { get; set; }
        public string DESALMACEN { get; set; }
        public string direccion { get; set; }
        public string CDTIPO { get; set; }
        public Nullable<bool> TIPO { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ARTIDAT> ARTIDATs { get; set; }
    }
}
