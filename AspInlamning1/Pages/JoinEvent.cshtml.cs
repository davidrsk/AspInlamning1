using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspInlamning1.Data;
using AspInlamning1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace AspInlamning1
{
    public class JoinEventModel : PageModel
    {
        private readonly EventDbContext _context;

        public JoinEventModel(EventDbContext context)
        {
            _context = context;
        }

        public Event Event { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Event = await _context.Events.FirstOrDefaultAsync(m => m.Id == id);

            if (Event == null)
            {
                return NotFound();
            }
            return Page();
        }
        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Event = await _context.Events.Include(e => e.Attendees).FirstOrDefaultAsync(m => m.Id == id);

            if (Event == null)
            {
                return NotFound();
            }

            var attendee = await _context.Attendees.FirstOrDefaultAsync();

            if (!Event.Attendees.Contains(attendee))
            {
                Event.Attendees.Add(attendee);
                await _context.SaveChangesAsync();
            }

            return Page();
        }
    }
}
