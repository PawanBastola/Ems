using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Ems.Models
{
    [Table("options")]
    public class Options
    {
        [Key]
        public int opid { get; set; }
        public int qid { get; set; }
        public String mcqoption { get; set; }


    }
}
