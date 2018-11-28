using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;
namespace OTDAV.DOMAIN.Entities
{
    [Table("otdav.payement")]
    public partial class payement
    {
        [Key]
        public int idPayement { get; set; }

        [StringLength(255)]
        public string categoriePayement { get; set; }

        [StringLength(255)]
        public string datePayement { get; set; }

        public float prix { get; set; }

        public int? adhesion_id_demAdh { get; set; }

        public int? depot_id { get; set; }

        public virtual demandeadhesion demandeadhesion { get; set; }

        public virtual depot depot { get; set; }
    }
}
