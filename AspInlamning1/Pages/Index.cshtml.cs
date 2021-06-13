using AspInlamning1.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspInlamning1.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly EventDbContext _context;

        public IndexModel(ILogger<IndexModel> logger, EventDbContext context)
        {
            _logger = logger;
            _context = context;
        }
    }
}
