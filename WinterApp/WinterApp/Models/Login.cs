using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WinterApp.Models
{
    public class Login
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(50)]
        public string UserName { get; set; }
        [MaxLength(250)]
        public string Password { get; set; }
        [MaxLength(1000)]
        public string SubTitle { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
