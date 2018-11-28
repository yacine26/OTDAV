using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace OTDAV.DOMAIN.Entities
{
    [Table("otdav.reclamation")]
    public partial class reclamation
    {
        [Key]
        public int idRec { get; set; }

        [Column(TypeName = "date")]
        public DateTime? dateRec { get; set; }

        [StringLength(255)]
        public string etat { get; set; }

        [StringLength(255)]
        public string priorite { get; set; }

        [StringLength(255)]
        public string reponse { get; set; }

        [StringLength(255)]
        public string textRec { get; set; }
    }
}
