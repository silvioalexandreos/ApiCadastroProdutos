using Stock.Business.Entities;
using System;
using System.Collections.Generic;

namespace Stock.Business.Interfaces.Repositories
{
    public interface ICategoryRepository
    {
        bool Delete(Guid id);
        Category GetById(Guid id);
        IEnumerable<Category> GetAll();
        Category Insert(Category category);
        Category Update(Category category);
    }
}
