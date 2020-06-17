using BookLibrary.Entity;
using BookLibrary.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary.Services.Implementation
{
    public class CatalogueService : ICatalogue
    {
        private readonly ApplicationDbContext context;
        public CatalogueService(ApplicationDbContext _context)
        {
            _context = context;
        }
        public IEnumerable<Catalogue> Catalogues() =>
            context.Catalogue;  
        

        public async Task CreateAsync(Catalogue catalogue)
        {
           await  context.Catalogue.AddAsync(catalogue);
            await context.SaveChangesAsync();
        }

        public async Task Delete(int CatalogueId)
        {
            var catalogue = GetById(CatalogueId);
             context.Remove(catalogue);
           await  context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Catalogue catalogue)
        {
             context.Catalogue.Remove(catalogue);
           await context.SaveChangesAsync();
        }

        public Catalogue GetById(int CatalogueId) =>
            context.Catalogue.Where(e => e.Id == CatalogueId).FirstOrDefault();
        
         
        public async Task UpdateAsync(Catalogue catalogue)
        {
            context.Catalogue.Update(catalogue);
           await context.SaveChangesAsync();
        }

        public async Task UpdateAsync(int Id)
        {
            var catalogue = GetById(Id);
            context.Catalogue.Update(catalogue);
           await context.SaveChangesAsync();
        }
    }
}
