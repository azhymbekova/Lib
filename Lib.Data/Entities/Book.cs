using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib.Data.Entities
{
    public class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string BookDescription { get; set; }
        public DateTime PublishDate { get; set; }
        public string AmountPages { get; set; }
        public int Rating { get; set; }
        public string Genre { get; set; }
        public Library Library { get; set; }
        public int LibraryId { get; set; }




    }
}
