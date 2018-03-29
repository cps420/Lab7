using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7.Models
{
    public class Book
    {
        public string ID { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public DateTime DateOfRelease { get; set; }
    }

    public class SalesData
    {
        public string ID { get; set; }
        public Student Customer { get; set; }
    }
}
