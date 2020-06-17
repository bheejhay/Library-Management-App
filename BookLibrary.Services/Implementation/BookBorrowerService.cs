using BookLibrary.Entity;
using BookLibrary.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary.Services.Implementation
{
    public class BookBorrowerService : IBookBorrowers
    {
        private readonly ApplicationDbContext context;
        public BookBorrowerService(ApplicationDbContext _context)
        {
            context = _context;
        }
        public async Task CreateAsync(BookBorrowers bookBorrowers)
        {
           await context.BookBorrowers.AddAsync(bookBorrowers);
           await context.SaveChangesAsync();
        }

        public async Task Delete(int BorrowerId)
        {
            var borrower = GetById(BorrowerId);
            context.Remove(borrower);
          await  context.SaveChangesAsync();
        }

        public async Task DeleteAsync(BookBorrowers bookBorrowers)
        {
            context.BookBorrowers.Remove(bookBorrowers);
          await  context.SaveChangesAsync();
        }

        public IEnumerable<BookBorrowers> GetAll() =>
            context.BookBorrowers;


        public BookBorrowers GetById(int borrowerId) =>
             context.BookBorrowers.Where(e => e.Id == borrowerId).FirstOrDefault();
        

        public async Task UpdateAsync(BookBorrowers bookBorrowers)
        {
            context.BookBorrowers.Update(bookBorrowers);
          await  context.SaveChangesAsync();
        }

        public async Task UpdateId(int Id)
        {
           var borrower = GetById(Id) ;
            context.BookBorrowers.Update(borrower);
          await context.SaveChangesAsync();
        }
    }
}
