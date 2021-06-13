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
    public class MyEventsModel : PageModel
    {
        private readonly EventDbContext _context;


        public MyEventsModel(EventDbContext context)
        {
            _context = context;
        }

        public IList<Event> Event { get; set; }
        public Attendee Attendee { get; set; }

        public async Task OnGetAsync()
        {
            var name = Attendee.Name;
            Attendee = await _context.Attendees.Where(a => a.Name == name).Include(h => h.Events).FirstOrDefaultAsync();
            Event = Attendee.Events;
        }
    }
}
