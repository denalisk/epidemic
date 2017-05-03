using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Epidemic.Models
{
    [Table("Games")]
    public class Game
    {
        [Key]
        public int Id { get; set; }
        public bool Status { get; set; }
        public int Turns { get; set; }
        public int Score { get; set; }
        public virtual Disease Disease { get; set; }
        public virtual ICollection<Country> Countries { get; set; }

    }
}
