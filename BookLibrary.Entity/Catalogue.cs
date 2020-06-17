using System;
using System.Collections.Generic;
using System.Text;

namespace BookLibrary.Entity
{
   public  class Catalogue
    {
        public int Id { get; set; }
        public string catalogueName { get; set; }
        public IEnumerable<BookManagement> BookManagements { get; set; }
    }
}
