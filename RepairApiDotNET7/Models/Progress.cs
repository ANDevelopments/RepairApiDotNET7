using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations;
namespace RepairApiDotNET7.Models
{
    [Keyless]
    public class Progress
    {
        [Key]
        public string ProgressName { get; set; }
    }
}
