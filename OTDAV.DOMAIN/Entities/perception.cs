using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace OTDAV.DOMAIN.Entities
{
    [Table("otdav.perception")]
    public partial class perception
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public perception()
        {
            exploitant = new HashSet<exploitant>();
        }

        [Key]
        public int id_perception { get; set; }

        public float montant { get; set; }

        public float montanttotal { get; set; }

        public int? oeuvre_id_oeuvre { get; set; }

        public virtual oeuvre oeuvre { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<exploitant> exploitant { get; set; }
    }
}
