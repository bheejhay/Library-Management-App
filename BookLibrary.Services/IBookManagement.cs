using BookLibrary.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary.Services
{
   public  interface IBookManagement
    {
        Task CreateAsync(BookManagement bookManagement);

        BookManagement GetById(int bookId);

        Task UpdateAsync(BookManagement bookManagement);

        Task UpdateId(int Id);

        Task Delete(int BookId);

        Task DeleteAsync(BookManagement bookManagement);

        IEnumerable<BookManagement> GetAll();



    }
}
