using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BC5MVCGroupProject.Models
{
    public class Events
    {
        [Key]
        public int EventID { get; set; }
        [MaxLength(100)]
        public string Subject { get; set; }
        [MaxLength(300)]
        public string  Description { get; set; }
        public DateTime Start { get; set; }
        public DateTime ? End { get; set; }
        [MaxLength(10)]
        public string ThemeColor { get; set; }
        public bool IsFullDay { get; set; }
    }
}