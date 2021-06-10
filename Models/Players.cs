using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppcore_exercise.Models
{[Table("Players")]
    public class Players
    {[Key]
        public int PId { get; set; }
        public string Name { get; set; }
        public string Team { get; set; }
    }
}
