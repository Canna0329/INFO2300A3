using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ServiceReference1;

namespace wcf_assignment3_interface.Pages
{
    public class GetModel : PageModel
    {
        private readonly ILogger<GetModel> _logger;
        [BindProperty]
        public FlowerDetails FlowerDetails { get; set; }

        public GetModel(ILogger<GetModel> logger)
        {
            _ = Singleton.Instance;
            _logger = logger;
            FlowerDetails=new FlowerDetails();
        }

        public void OnGet(int selection)
        {
            GetFlower(selection);
            Singleton.selectedFlower = selection;
        }
        public void GetFlower(int selection)
        {
            FlowerServiceClient client = new();
            GetFlowerRequest getFlower = new(selection);
            var value =  client.GetFlower(getFlower);
            GetFlowerResponse flowerResponse = value;
            FlowerDetails = flowerResponse.GetFlowerResult;
        }
    }
}