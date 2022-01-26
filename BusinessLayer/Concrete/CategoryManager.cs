using BusinessLayer.Abstarct;
using DataAccessLayer.Abstract;
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
        //EFCategoryRepository efCategoryRepository;
        //Categorymanager sınıfı üzerinden atama yapabilmemiz için constructer method oluşturmamız gerekir:


        //public CategoryManager()
        //{
        //    //yapıcı method içinde newleme işlemi:
        //    efCategoryRepository = new EFCategoryRepository();
        //}

        ICategoryDal _categoryDal;
        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public void CategoryAdd(Category category)
        {

            _categoryDal.Insert(category);
        }

        public void CategoryDleete(Category category)
        {
            _categoryDal.Delete(category);
        }

        public void CategoryUpdate(Category category)
        {
            _categoryDal.Update(category);
        }

        public Category GetById(int id)
        {
            return _categoryDal.GetByID(id);
        }

        public List<Category> GetList()
        {
            return _categoryDal.GetListAll();
        }
    }
}
