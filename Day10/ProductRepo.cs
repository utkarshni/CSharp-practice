using System;
using System.Collections.Generic;
using System.Text;

namespace eventdelegatedemo
{
     class ProductRepo : IRepo<Product>

    {
        public bool Add(Product obj)
        {
            throw new NotImplementedException();
        }
        public Product SearchByID(int id)
        {
            throw new NotImplementedException(); 
        }
    }
}
