using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace OTDAV.DOMAIN.Entities
{
    [Table("otdav.espace")]
    public partial class espace
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public espace()
        {
            exploitation = new HashSet<exploitation>();
            formuleperception = new HashSet<formuleperception>();
        }

        [Key]
        public int ID_espace { get; set; }

        [StringLength(255)]
        public string Nom_espace { get; set; }

        public int? idCperception { get; set; }

        public virtual categorie_perception categorie_perception { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<exploitation> exploitation { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<formuleperception> formuleperception { get; set; }
    }
}
