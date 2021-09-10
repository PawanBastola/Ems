using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Ems.Models
{
    [Table("answers")]
    public class Answers
    {
        [Key]
        public int ansid { get; set; }
        public String answer { get; set; }
    }
}
