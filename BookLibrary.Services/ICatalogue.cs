using BookLibrary.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary.Services
{
    public interface ICatalogue
    {
        Task CreateAsync(Catalogue catalogue);

        Catalogue GetById(int CatalogueId);

        Task UpdateAsync(Catalogue catalogue);

        Task UpdateAsync(int Id);

        Task Delete(int CatalogueId);

        Task DeleteAsync(Catalogue catalogue);

        IEnumerable<Catalogue> Catalogues();


    }
}
