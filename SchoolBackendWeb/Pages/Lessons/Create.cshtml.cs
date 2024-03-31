using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using SchoolBackendWeb.Data;
using SchoolBackendWeb.Models;

namespace SchoolBackendWeb.Pages.Lessons
{
    public class CreateModel : PageModel
    {
        private readonly SchoolBackendWeb.Data.SchoolBackendWebContext _context;

        public CreateModel(SchoolBackendWeb.Data.SchoolBackendWebContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Lesson Lesson { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Lesson == null || Lesson == null)
            {
                return Page();
            }

            _context.Lesson.Add(Lesson);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
