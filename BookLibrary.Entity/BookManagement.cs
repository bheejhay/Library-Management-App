using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BookLibrary.Entity
{
    public class BookManagement
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ISBN { get; set; }
        public int BookBorrowersId { get; set; }

        public BookBorrowers BookBorrowers { get; set; }
        public int CatalogueId { get; set; }
        public Catalogue Catalogue { get; set; }
        public BookStatus BookStatus { get; set; }
    }
}
