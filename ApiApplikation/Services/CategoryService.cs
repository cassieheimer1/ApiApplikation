using ApiApplikation.Models;
using ApiApplikation.Models.Data;
using ApiApplikation.Models.Entities;
using ApiApplikation.Models.Forms;
using Microsoft.EntityFrameworkCore;

namespace ApiApplikation.Services
{   
    public interface ICategoryService
    {
        Task<Category> CreateAsync(CategoryForm form);
        Task<IEnumerable<Category>> GetAllAsync();
    }

    public class CategoryService : ICategoryService
    {
        private readonly DataContext _context;


        public CategoryService(DataContext context)
        {
            _context = context;
        }

        public async Task<Category> CreateAsync(CategoryForm form)
        {
            if(await _context.Categories.AnyAsync(x => x.Name == form.Name))
            {
                var categoryEntity = new CategoryEntity { Name = form.Name };
                _context.Categories.Add(categoryEntity);
                await _context.SaveChangesAsync();

                return new Category { Id = categoryEntity.Id, CategoryName = categoryEntity.Name };
            }
            return null!;
        }

        public async Task<IEnumerable<Category>> GetAllAsync()
        {
            var items = new List<Category>();
            foreach (var categoryEntity in await _context.Categories.ToListAsync())
                items.Add(new Category { Id = categoryEntity.Id, CategoryName = categoryEntity.Name });
            return items;
        }
    }
}
