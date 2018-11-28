using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OTDAV.DOMAIN.Entities
{
    [Table("otdav.category")]
    public partial class category
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int idC { get; set; }

        [StringLength(255)]
        public string nomC { get; set; }
    }
}
