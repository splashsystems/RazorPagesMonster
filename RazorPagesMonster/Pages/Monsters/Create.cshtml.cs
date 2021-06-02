using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RazorPagesMonster.Data;
using RazorPagesMonster.Models;

namespace RazorPagesMonster.Pages.Monsters
{
    public class CreateModel : PageModel
    {
        private readonly RazorPagesMonster.Data.RazorPagesMonsterContext _context;

        public CreateModel(RazorPagesMonster.Data.RazorPagesMonsterContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Monster Monster { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Monster.Add(Monster);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
