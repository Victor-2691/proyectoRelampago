//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace capa_datos
{
    using System;
    using System.Collections.Generic;
    
    public partial class Factores
    {
        public int Id_factor { get; set; }
        public int Id_idea { get; set; }
        public string aspectoPositivo { get; set; }
        public string aspectoNegativo { get; set; }
        public int Id_hoja_resultados { get; set; }
    
        public virtual Hoja_Resultados Hoja_Resultados { get; set; }
        public virtual Ideas Ideas { get; set; }
    }
}
