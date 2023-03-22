using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ServiceReference1;

namespace wcf_assignment3_interface.Pages
{
    public class SearchModel : PageModel
    {
        private readonly ILogger<GetModel> _logger;
        [BindProperty]
        public static FlowerDetails[] FlowerDetails { get; set; }

        public SearchModel(ILogger<GetModel> logger)
        {
            _ = Singleton.Instance;
            _logger = logger;
            FlowerDetails = Array.Empty<FlowerDetails>();
        }

        public void OnGet(string selection)
        {
            GetFlowerByName(selection);
        }
        public void GetFlowerByName(string selection)
        {
            FlowerServiceClient client = new();
            GetFlowersByNameRequest getFlower = new(selection);
            var value = client.GetFlowersByName(getFlower);
            GetFlowersByNameResponse flowerResponse = value;
            FlowerDetails = flowerResponse.GetFlowersByNameResult;

        }
    }
}