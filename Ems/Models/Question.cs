using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Ems.Models
{
    [Table("question")]
    public class Question
    {

        [Key]
        public int qid { get; set; }
        public String questions { get; set; }
        public String subject { get; set; }
        public String answer { get; set; }

    }

}
