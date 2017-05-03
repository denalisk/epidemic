using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Epidemic.Models
{
    [Table("Countries")]
    public class Country
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Population { get; set; }
        public int Infected { get; set; }
        public int Dead { get; set; }

    }
}
