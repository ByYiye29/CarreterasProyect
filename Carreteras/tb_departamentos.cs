//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Carreteras
{
    using System;
    using System.Collections.Generic;
    
    public partial class tb_departamentos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_departamentos()
        {
            this.tb_ciudades = new HashSet<tb_ciudades>();
        }
    
        public string dep_id { get; set; }
        public string dep_descripcion { get; set; }
        public string dep_usuario_crea { get; set; }
        public Nullable<System.DateTime> dep_fecha_crea { get; set; }
        public string dep_usuario_modifica { get; set; }
        public Nullable<System.DateTime> dep_fecha_modifica { get; set; }
        public Nullable<bool> dep_estado { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_ciudades> tb_ciudades { get; set; }
        public virtual tb_usuarios tb_usuarios { get; set; }
        public virtual tb_usuarios tb_usuarios1 { get; set; }
    }
}
