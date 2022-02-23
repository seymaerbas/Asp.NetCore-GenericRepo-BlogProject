using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.ViewComponents
{
    public class CommentsList: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();

        }
    }
}
