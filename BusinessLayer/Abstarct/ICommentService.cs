using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstarct
{
    public interface ICommentService
    {
        void CommentAdd(Comment comment);
        void CommentDleete(Comment comment);
        void CommentUpdate(Comment comment);
        List<Comment> GetList();
        Comment GetById(int id);
    }
}
