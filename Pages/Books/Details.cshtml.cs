using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TRIFAN_RAUL_LAB6.Data;
using TRIFAN_RAUL_LAB6.Models;

namespace TRIFAN_RAUL_LAB6.Pages.Books
{
    public class DetailsModel : PageModel
    {
        private readonly TRIFAN_RAUL_LAB6.Data.TRIFAN_RAUL_LAB6Context _context;

        public DetailsModel(TRIFAN_RAUL_LAB6.Data.TRIFAN_RAUL_LAB6Context context)
        {
            _context = context;
        }

        public Book Book { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Book = await _context.Book.FirstOrDefaultAsync(m => m.ID == id);

            if (Book == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
