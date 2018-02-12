using DataAccess;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebSite.Models;

namespace WebSite.Components
{
    public class IFrameEditor : ViewComponent
    {        
        public IFrameEditor()
        {            
        }

        public IViewComponentResult Invoke(IFrameEditorModel model, string idPrefix)
        {
            ViewBag.IdPrefix = idPrefix;
            return View(model);
        }
    }
}
