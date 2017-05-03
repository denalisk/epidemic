using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Epidemic.Models
{
    [Table("Traits")]
    public class Trait
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int LethalityModifier { get; set; }
        public int ContagiousnessModifier { get; set; }

    }
}
