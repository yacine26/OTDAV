using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OTDAV.DOMAIN.Entities
{
    [Table("otdav.adherent")]
    public partial class adherent
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public adherent()
        {
           
        }

        [Key]
        public int id_adh { get; set; }

        public int cin { get; set; }

        [StringLength(255)]
        public string email { get; set; }

        [StringLength(255)]
        public string mdp_adh { get; set; }

        [StringLength(255)]
        public string nom { get; set; }

        [StringLength(255)]
        public string prenom { get; set; }

        [StringLength(255)]
        public string pseudo_adh { get; set; }

        public int? typeAdh { get; set; }

     
    }
}
