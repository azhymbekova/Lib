using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib.Data.Entities
{
    public class BorrowBook
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public int UserId { get; set; }
        public int Amount { get; set; }
        public DateTime DueDate { get; set; }

        public Book Book { get; set; }
        public User User { get; set; }
    }
}
