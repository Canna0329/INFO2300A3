using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ServiceReference1;
using System.ComponentModel.Design;

namespace wcf_assignment3_interface.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _ = Singleton.Instance;
            _logger = logger;
        }

        public void OnGet()
        {
            Singleton.UpdateSingleton();
        }

    }
}