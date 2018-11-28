using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace OTDAV.DOMAIN.Entities
{
    [Table("otdav.demandeadhesion")]
    public partial class demandeadhesion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public demandeadhesion()
        {
            payement = new HashSet<payement>();
        }

        [Key]
        public int id_demAdh { get; set; }

        [StringLength(255)]
        public string adresse { get; set; }

        public int cin { get; set; }

        public DateTime? date_demAdh { get; set; }

        [StringLength(255)]
        public string email { get; set; }

        [StringLength(255)]
        public string nom { get; set; }

        public int numTel { get; set; }

        [StringLength(255)]
        public string prenom { get; set; }

        [StringLength(255)]
        public string texteDemAdh { get; set; }

        public int? typeAdh { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<payement> payement { get; set; }
    }
}
