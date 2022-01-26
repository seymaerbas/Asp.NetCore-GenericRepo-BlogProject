using BusinessLayer.Abstarct;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    
    public class CategoryManager : ICategoryService
    {
        //CategoryRepositoryden değer oluşturmak için:
        EFCategoryRepository efCategoryRepository;
        //Categorymanager sınıfı üzerinden atama yapabilmemiz için constructer method oluşturmamız gerekir:
        public CategoryManager()
        {
            //yapıcı method içinde newleme işlemi:
            efCategoryRepository = new EFCategoryRepository();
        }
        public void CategoryAdd(Category category)
        {

            efCategoryRepository.Insert(category);
        }

        public void CategoryDleete(Category category)
        {
            efCategoryRepository.Delete(category);
        }

        public void CategoryUpdate(Category category)
        {
            efCategoryRepository.Update(category);
        }

        public Category GetById(int id)
        {
            return efCategoryRepository.GetByID(id);
        }

        public List<Category> GetList()
        {
            return efCategoryRepository.GetListAll();
        }
    }
}
