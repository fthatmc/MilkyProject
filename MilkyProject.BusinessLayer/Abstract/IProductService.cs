using MilkyProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilkyProject.BusinessLayer.Abstract
{
    public interface IProductService : IGenericService<Product>
    {
        public List<Product> TGetProductsWithCategory();
        void TChangeToProductStatusFalse(int id);
        void TChangeToProductStatusTrue(int id);
    }
}
