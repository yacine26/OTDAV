using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace OTDAV.DOMAIN.Entities
{
    [Table("otdav.depot")]
    public partial class depot
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public depot()
        {
            payement = new HashSet<payement>();
        }

        public int id { get; set; }

        [StringLength(255)]
        public string Cdep { get; set; }

        public int Cin { get; set; }

        [StringLength(255)]
        public string adresse { get; set; }

        public int? category { get; set; }

        [StringLength(255)]
        public string Cann { get; set; }

        [StringLength(255)]
        public string cpermis { get; set; }

        [StringLength(255)]
        public string Creg { get; set; }

        [Column(TypeName = "date")]
        public DateTime? datedebut { get; set; }

        [Column(TypeName = "date")]
        public DateTime? datefin { get; set; }

        [StringLength(255)]
        public string email { get; set; }

        [StringLength(255)]
        public string etat { get; set; }

        public int fax { get; set; }

        [StringLength(255)]
        public string nom { get; set; }

        public int numero { get; set; }

        [StringLength(255)]
        public string prenom { get; set; }

        [StringLength(255)]
        public string raisonsociale { get; set; }

        [StringLength(255)]
        public string typedep { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<payement> payement { get; set; }
    }
}
