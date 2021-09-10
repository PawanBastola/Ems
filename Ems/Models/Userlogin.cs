using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Ems.Models
{
    [Table("userlogin")]
    public class Userlogin
    {
        [Key]
        public int uid { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string role { get; set; }
    }
}
