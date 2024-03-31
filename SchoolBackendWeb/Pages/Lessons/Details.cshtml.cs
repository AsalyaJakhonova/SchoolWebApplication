using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SchoolBackendWeb.Data;
using SchoolBackendWeb.Models;

namespace SchoolBackendWeb.Pages.Lessons
{
    public class DetailsModel : PageModel
    {
        private readonly SchoolBackendWeb.Data.SchoolBackendWebContext _context;

        public DetailsModel(SchoolBackendWeb.Data.SchoolBackendWebContext context)
        {
            _context = context;
        }

      public Lesson Lesson { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Lesson == null)
            {
                return NotFound();
            }

            var lesson = await _context.Lesson.FirstOrDefaultAsync(m => m.Id == id);
            if (lesson == null)
            {
                return NotFound();
            }
            else 
            {
                Lesson = lesson;
            }
            return Page();
        }
    }
}
