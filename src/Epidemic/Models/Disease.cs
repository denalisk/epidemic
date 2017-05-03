using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Epidemic.Models
{
    [Table("Diseases")]
    public class Disease
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public int Contagiousness { get; set; }
        public int Lethality { get; set; }
        public virtual ICollection<Trait> Traits { get; set; }


    }
}
