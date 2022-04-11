using FinalProject.Data;
using FinalProject.Infra;
using FinalProject.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Repo
{
    public class CategoryRepo: ICategory
    {
        DataBaseContext _context;
        IBooks _booksRepo;
        public CategoryRepo(DataBaseContext context, IBooks booksRepo)
        {
            _context = context;
            _booksRepo = booksRepo;
        }
        public List<Category> GetCategory()
        {
            var categories = _context.Category.ToList();
            return categories;
        }
        public Category GetCategoryById(int CategoryId)
        {
            return _context.Category.FirstOrDefault(e => e.CategoryId == CategoryId);
        }
        public void AddCategory(Category Category)
        {
            _context.Add(Category);
            _context.SaveChanges();
        }
        public void UpdateCategory(Category Category)
        {
            _context.Update(Category);
            _context.SaveChanges();
        }

        public void DeleteCategory(int CategoryId)
        {
            var Category = _context.Category.Where(s => s.CategoryId == CategoryId).FirstOrDefault();
            if (Category != null)
            {
                _context.Remove(Category);
                _context.SaveChanges();
            }
        }
    }
}
