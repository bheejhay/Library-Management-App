using System;
using System.Collections.Generic;
using System.Text;

namespace BookLibrary.Entity
{
   public  class BookBorrowers
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNum { get; set; }
        public IEnumerable<BookManagement> BookManagements { get; set; }

    }
}
