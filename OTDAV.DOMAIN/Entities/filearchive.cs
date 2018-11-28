using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace OTDAV.DOMAIN.Entities
{
    [Table("otdav.filearchive")]
    public partial class filearchive
    {
        [Key]
        public int idFileArchive { get; set; }

        [Column(TypeName = "date")]
        public DateTime? dateUpload { get; set; }

        [StringLength(255)]
        public string description { get; set; }

        [StringLength(255)]
        public string fileName { get; set; }

        public int? archivefile { get; set; }

        public virtual archive archive { get; set; }
    }
}
