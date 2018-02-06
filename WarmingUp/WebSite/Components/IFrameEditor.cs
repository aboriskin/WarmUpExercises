using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebSite.DataAccess;

namespace WebSite.Components
{
    public class IFrameEditor : ViewComponent
    {
        private readonly WarmingUpDbContext _context;

        public IFrameEditor(WarmingUpDbContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke(int exerciseId)
        {
            var exercise = _context.Exercises.FirstOrDefault(e => e.Id == exerciseId);

            return View(exercise);
        }
    }
}
