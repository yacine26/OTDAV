using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OTDAV.DOMAIN.Entities
{
    [Table("otdav.categorie_perception")]
    public partial class categorie_perception
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public categorie_perception()
        {
            espace = new HashSet<espace>();
        }

        [Key]
        public int Id_categorie { get; set; }

        [StringLength(255)]
        public string nom_categorie { get; set; }

        public int? sous_categorie { get; set; }

        public int? sous_sous_categorie { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<espace> espace { get; set; }
    }
}
