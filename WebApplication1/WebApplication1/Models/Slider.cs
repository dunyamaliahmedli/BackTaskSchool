using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Slider
    {
        public int Id { get; set; }
        public string Title1 { get; set; }
        public string Title2 { get; set; }

        public string Description { get; set; }
        public int Price { get; set; }
        public string UrlText { get; set; }
        public string Image { get; set; }
    }
}
