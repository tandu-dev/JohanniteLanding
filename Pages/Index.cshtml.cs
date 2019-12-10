using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using JohanniteLanding.Data;
using JohanniteLanding.Models;

namespace JohanniteLanding.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly LinkContext db;
        public List<Link> Links = new List<Link>();

        public IndexModel(ILogger<IndexModel> logger, LinkContext db)
        {
            _logger = logger;
            this.db = db;
        }

        public void OnGet()
        {
            Links = db.Links.ToList();
        }
    }
}
