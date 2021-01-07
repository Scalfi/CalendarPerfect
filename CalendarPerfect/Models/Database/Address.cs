using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CalendarPerfect.Models.Database
{
    public class Address : BaseEntity
    {
        [Column("country")]
        public string Country { get; set; } = "Brasil";

        [Column("state")]
        public string State { get; set; }

        [Column("number")]
        public int Number { get; set; }

        [Column("cep")]
        public int CEP { get; set; }
        [NotMapped]
        public string Name { get; set; }
    }
}
