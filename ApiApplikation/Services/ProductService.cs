using ApiApplikation.Models.Data;
using ApiApplikation.Models.Entities;
using ApiApplikation.Models.Forms;
using Microsoft.EntityFrameworkCore;

namespace ApiApplikation.Services
{
    public interface IProductService
    {
        Task<Product> CreateAsync(ProductForm form);
    }

    public class ProductService : IProductService
    {
        private readonly DataContext _context;

        public ProductService(DataContext context)
        {
            _context = context;
        }

        public async Task<Product> CreateAsync(ProductForm form)
        {
            var categoryEntity = await _context.Categories.FindAsync(form.CategoryId);

            if (categoryEntity != null)
            {
                var productEntity = new ProductEntity(form.Name, form.Price, form.CategoryId);
                _context.Products.Add(productEntity);
                await _context.SaveChangesAsync();

                return new Product(productEntity.Id, productEntity.Name, productEntity.Price, categoryEntity.Name);
            }

            return null!;
        }
    }
}
