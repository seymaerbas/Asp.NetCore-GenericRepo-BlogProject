using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IBlogDal:IGenericDal<Blog>
    {
        //GenericRepositorye ek olarak sadece ilgili entitye ait olan methodları burada tanımlarız
        List<Blog> GetListWithCategory();
       
    }
}
