//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace capa_datos
{
    using System;
    using System.Collections.Generic;
    
    public partial class Hoja_Resultados
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Hoja_Resultados()
        {
            this.Caracteristicas = new HashSet<Caracteristica>();
        }
    
        public int Id_hoja_resultados { get; set; }
        public string usuario { get; set; }
        public System.DateTime Fecha_registro { get; set; }
        public bool estado { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Caracteristica> Caracteristicas { get; set; }
        public virtual Usuario Usuario1 { get; set; }
    }
}