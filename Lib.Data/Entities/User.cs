using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib.Data.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }  // Роль пользователя

        // Связь с заимствованными книгами
        public List<BorrowBook> BorrowedBooks { get; set; } = new List<BorrowBook>();
    }
}
