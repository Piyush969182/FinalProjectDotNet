using FinalProject.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Infra
{
    public interface ICategory
    {
        public List<Category> GetCategory();
        public Category GetCategoryById(int CategoryId);
        public void AddCategory(Category Books);
        public void UpdateCategory(Category Books);
        public void DeleteCategory(int CategoryId);
    }
}
