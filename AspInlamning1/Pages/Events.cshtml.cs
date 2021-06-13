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
    public class EventsModel : PageModel
    {
        private readonly EventDbContext _context;

        public EventsModel(EventDbContext context)
        {
            _context = context;
        }

        public IList<Event> Event { get; set; }

        public async Task OnGetAsync()
        {
            Event = await _context.Events.ToListAsync();
        }
    }
}
