using BookLibrary.Entity;
using BookLibrary.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary.Services.Implementation
{
    class BookManagementService : IBookManagement
    {
        private readonly ApplicationDbContext _context;

        public BookManagementService(ApplicationDbContext context)
        {
            _context = context;
        } 
        public async Task CreateAsync(BookManagement bookManagement)
        {
          await  _context.BookManagement.AddAsync(bookManagement);
          await _context.SaveChangesAsync();
        }

        public BookManagement GetById(int bookId) =>
             _context.BookManagement.Where(e => e.Id == bookId).FirstOrDefault() ; 
        

        public async Task Delete(int BookId)
        {
            var Book = GetById(BookId);
             _context.Remove(Book);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(BookManagement bookManagement)
        {
           _context.BookManagement.Remove(bookManagement);
            await _context.SaveChangesAsync();
        }

        public IEnumerable<BookManagement> GetAll() =>
            _context.BookManagement;       

        public async Task UpdateAsync(BookManagement bookManagement)
        {
            _context.BookManagement.Update(bookManagement);
          await  _context.SaveChangesAsync();
        }

        public async Task UpdateId(int Id)
        {
          var Books = GetById(Id);
             _context.Update(Books);
           await _context.SaveChangesAsync();
        }
    }
}
