using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace OTDAV.DOMAIN.Entities
{
    [Table("otdav.formuleperception")]
    public partial class formuleperception
    {
        [Key]
        public int id_formulePer { get; set; }

        public int frais { get; set; }

        [StringLength(255)]
        public string nom_formule { get; set; }

        public float pourcentage { get; set; }

        public int? Espace_ID_espace { get; set; }

        public virtual espace espace { get; set; }
    }
}
