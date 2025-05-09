﻿using API.Models;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace API.Services
{
    public interface ICategory
    {
        public Task<IEnumerable<Category>> GetCategories();
        public Task<Category> GeCategory(int IDCate);
        public Task<Category> AddCategory(Category category);
        public Task<Category> UpdateCategory(int IDCate, Category category);
        public Task<Category> DeleteCategory(int IDCate);
       public Task<Category> GetCategoryByName(string name);

    }
}
