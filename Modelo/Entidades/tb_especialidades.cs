//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Modelo.Entidades
{
    using System;
    using System.Collections.Generic;
    
    public partial class tb_especialidades
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_especialidades()
        {
            this.tb_terapeutas = new HashSet<tb_terapeutas>();
        }
    
        public int Id { get; set; }
        public string Nombre { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_terapeutas> tb_terapeutas { get; set; }
    }
}