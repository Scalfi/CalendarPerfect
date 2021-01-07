using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CalendarPerfect.Models.Database
{
    [Table("reports")]
    public class Report : BaseEntity
    {
        [Column("description")]
        [Required( ErrorMessage = "The descrition is riquered")]
        public string Description{ get; set; }
    }
}
