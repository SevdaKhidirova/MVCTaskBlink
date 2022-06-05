using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Blink.Models
{
    public class Messages : BaseEntity
    {
        [Required,MaxLength(200),MinLength(5)]
        public string Comment { get; set; }

        [Required, MaxLength(200), MinLength(5)]
        public string SenderName { get; set; }

        [Required, EmailAddress]
        public string SenderEmail { get; set; }
        public DateTime Date { get; set; }
        public int NewsId { get; set; }

    }
}
