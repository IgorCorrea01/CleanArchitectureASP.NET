using CleanArchMVC.Domain.Entities;
using CleanArchMVC.Domain.Interfaces;
using CleanArchMVC.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace CleanArchMVC.Infra.Data.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        ApplicationDbContext _categoryContent;

        public CategoryRepository(ApplicationDbContext context)
        {
            _categoryContent = context;
        }

        public async Task<Category> Create(Category category)
        {
            _categoryContent.Add(category);
            await _categoryContent.SaveChangesAsync();
            return category;
        }

        public async Task<Category> GetById(int id)
        {
            return await _categoryContent.Categories.FindAsync(id);
        }

        public async Task<IEnumerable<Category>> GetCategories()
        {
            return await _categoryContent.Categories.ToListAsync();
        }

        public async Task<Category> Remove(Category category)
        {
            _categoryContent.Remove(category);
            await _categoryContent.SaveChangesAsync();
            return category;
        }

        public async Task<Category> Update(Category category)
        {
            _categoryContent.Update(category);
            await _categoryContent.SaveChangesAsync();
            return category;
        }
    }
}
