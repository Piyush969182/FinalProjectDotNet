using FinalProject.Infra;
using FinalProject.models;
using FinalProject.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.services
{
    public class CategoryServices
    {
        ICategory _service;
        public CategoryServices(ICategory service)
        {
            _service = service;
        }
        public List<Category> GetCategory()
        {
            return _service.GetCategory().ToList();
        }
        public Category GetCategoryById(int CategoryId)
        {
            return _service.GetCategoryById(CategoryId);
        }
        public void AddCategory(CategoryVM CategoryVM)
        {
            Category category = new Category()
            {
                CategoryId = CategoryVM.CategoryId,
                CategoryName = CategoryVM.CategoryName,
                CategoryImage = CategoryVM.CategoryImage
            };
            _service.AddCategory(category);
        }
        public void UpdateCategory(CategoryVM CategoryVM)
        {
            Category category = new Category()
            {
                CategoryId = CategoryVM.CategoryId,
                CategoryName = CategoryVM.CategoryName,
                CategoryImage = CategoryVM.CategoryImage
            };
            _service.UpdateCategory(category);
        }
        public void DeleteCategory(int CategoryId)
        {
            _service.DeleteCategory(CategoryId);
        }
    }
}
