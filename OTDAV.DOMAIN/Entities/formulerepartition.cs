using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace OTDAV.DOMAIN.Entities

{
    [Table("otdav.formulerepartition")]
    public partial class formulerepartition
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_formuleRep { get; set; }
    }
}
