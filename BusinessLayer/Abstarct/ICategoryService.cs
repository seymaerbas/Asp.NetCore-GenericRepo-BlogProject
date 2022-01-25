using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstarct
{
   public interface ICategoryService
    {
        void CategoryAdd(Category category);
        void CategoryDleete(Category category);
        void CategoryUpdate(Category category);
        List<Category> GetList();
        Category GetById(int id);
    }
}
