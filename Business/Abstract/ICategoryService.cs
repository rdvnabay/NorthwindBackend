﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICategoryService
    {
        Category GetById(int categoryId);
        List<Category> GetAll();
        void Add(Category category);
        void Update(Category category);
        void Delete(Category category);
    }
}
