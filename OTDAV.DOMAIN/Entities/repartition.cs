using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace OTDAV.DOMAIN.Entities
{
    [Table("otdav.repartition")]
    public partial class repartition
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_repartition { get; set; }

        public float Montant { get; set; }

        [Column("_passage")]
        public int C_passage { get; set; }

        [Column(TypeName = "tinyblob")]
        public byte[] exploitant { get; set; }

        public int minutage { get; set; }

        [Column(TypeName = "tinyblob")]
        public byte[] perception { get; set; }

        public float perdiode_exploitation { get; set; }
    }
}
