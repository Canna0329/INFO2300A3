using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ServiceReference1;
using System.ComponentModel.Design;

namespace wcf_assignment3_interface.Pages
{
    public class ShowModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public ShowModel(ILogger<IndexModel> logger)
        {
            Singleton.UpdateSingleton();
            _logger = logger;
        }

        public void OnGet()
        {
        }

    }
}