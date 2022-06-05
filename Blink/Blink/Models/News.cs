using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blink.Models
{
    public class News : BaseEntity
    {
        public string PathImage { get; set; }
        public int CategoryId { get; set; }
        public  Category Category { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public string Link { get; set; }
        public DateTime Date { get; set; }
        public string Author { get; set; }


    }
}
