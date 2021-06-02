using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesMonster.Data;
using RazorPagesMonster.Models;

namespace RazorPagesMonster.Pages.Monsters
{
    public class DetailsModel : PageModel
    {
        private readonly RazorPagesMonster.Data.RazorPagesMonsterContext _context;

        public DetailsModel(RazorPagesMonster.Data.RazorPagesMonsterContext context)
        {
            _context = context;
        }

        public Monster Monster { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Monster = await _context.Monster.FirstOrDefaultAsync(m => m.ID == id);

            if (Monster == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
