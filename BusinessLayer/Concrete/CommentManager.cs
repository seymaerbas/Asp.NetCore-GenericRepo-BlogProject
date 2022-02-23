using BusinessLayer.Abstarct;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CommentManager : ICommentService
    {
        ICommentDal _commentdal;
        public CommentManager(ICommentDal commentDal)
        {
            _commentdal = commentDal;
        }
        public void CommentAdd(Comment comment)
        {
            throw new NotImplementedException();
        }

       
        public List<Comment> GetList(int id)
        {
            return _commentdal.GetListAll(x => x.BlogID == 1);
        }
    }
}
