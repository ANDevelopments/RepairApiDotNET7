using System;
using System.ComponentModel.DataAnnotations;
namespace RepairApiDotNET7.Models
{
    public class Register
    {
        [Key]
        public int UserID { get; set; }
        public string UserLogin { get; set; }
        public string UserPassword { get; set; }
    }
}
