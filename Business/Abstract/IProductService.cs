using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IProductService
    {
        Product GetById(int productId);
        List<Product> GetAll();
        void Add(Product product);
        void Update(Product product);
        void Delete(Product product);

    }
}
