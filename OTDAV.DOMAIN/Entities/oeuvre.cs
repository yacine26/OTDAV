using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace OTDAV.DOMAIN.Entities
{
    [Table("otdav.oeuvre")]
    public partial class oeuvre
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public oeuvre()
        {
            archive = new HashSet<archive>();
            perception = new HashSet<perception>();
            adherent1 = new HashSet<adherent>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_oeuvre { get; set; }

        public int? category { get; set; }

        public DateTime? dateAjout { get; set; }

        [StringLength(255)]
        public string descritpion { get; set; }

        [StringLength(255)]
        public string titre { get; set; }

        public int? adherent_id_adh { get; set; }

        public virtual adherent adherent { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<archive> archive { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<perception> perception { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<adherent> adherent1 { get; set; }
    }
}
