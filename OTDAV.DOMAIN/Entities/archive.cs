using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OTDAV.DOMAIN.Entities
{
    [Table("otdav.archive")]
    public partial class archive
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public archive()
        {
            filearchive = new HashSet<filearchive>();
        }

        [Key]
        public int idArchive { get; set; }

        [StringLength(255)]
        public string dateArchivage { get; set; }

        [StringLength(255)]
        public string description { get; set; }

        [StringLength(255)]
        public string nameOeuvre { get; set; }

        public int? oeuvre_id_oeuvre { get; set; }

        public virtual oeuvre oeuvre { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<filearchive> filearchive { get; set; }
    }
}
