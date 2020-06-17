using BookLibrary.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary.Services
{
    public interface IBookBorrowers
    {
        Task CreateAsync(BookBorrowers bookBorrowers);

        BookBorrowers GetById(int Id);

        Task UpdateAsync(BookBorrowers bookBorrowers);

        Task UpdateId(int Id);

        Task Delete(int BorrowerId);

        Task DeleteAsync(BookBorrowers bookBorrowers);

        IEnumerable<BookBorrowers> GetAll();
    }
}
