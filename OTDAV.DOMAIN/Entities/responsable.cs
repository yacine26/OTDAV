using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace OTDAV.DOMAIN.Entities

{
    [Table("otdav.responsable")]
    public partial class responsable
    {
        [Key]
        public int id_resp { get; set; }

        public int cin { get; set; }

        [StringLength(255)]
        public string email { get; set; }

        [StringLength(255)]
        public string mdp_resp { get; set; }

        [StringLength(255)]
        public string nom { get; set; }

        [StringLength(255)]
        public string prenom { get; set; }

        [StringLength(255)]
        public string pseudo_resp { get; set; }
    }
}
