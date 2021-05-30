using DesktopAppTrouvaille.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopAppTrouvaille.Processors
{
    public interface IProductProcessor
    {
        Task<Product> LoadProduct(Guid productID);
        Task<bool> SaveNewProduct(Product product);
        Task<bool> UpdateProduct(Product product);
        Task<bool> DeleteProduct(Product p);
        Task<List<Product>> LoadProducts(int from, int to);
        Task<bool> AddCategories(Guid id, List<Guid> categoryGuids);
        Task<bool> RemoveCategories(Guid id, List<Guid> categoryGuids);
    }
}
