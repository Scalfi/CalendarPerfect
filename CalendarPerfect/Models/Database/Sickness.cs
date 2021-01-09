using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CalendarPerfect.Models.Database
{
    [Table("sicknesses")]
    public class Sickness : BaseEntity
    {
        [Column("description")]
        public string Description { get; set; }
    }
}
