using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CalendarPerfect.Models.Database
{
    [Table("medicines")]
    public class Medicine : BaseEntity
    {
        [Column("description")]
        public string Description { get; set; }

        [ForeignKey(nameof(SicknessId))]
        [Column("sickness_id")]
        public int SicknessId { get; set; }

        public Sickness Sickness { get; set; }
    }
}
