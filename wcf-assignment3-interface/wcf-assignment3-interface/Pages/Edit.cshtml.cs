using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ServiceReference1;

namespace wcf_assignment3_interface.Pages
{
    public class EditModel : PageModel
    {
        private readonly ILogger<EditModel> _logger;
        [BindProperty]
        public FlowerDetails FlowerDetails { get; set; }

        public EditModel(ILogger<EditModel> logger)
        {
            _logger = logger;
            FlowerDetails=new FlowerDetails();
        }

        public void OnGet()
        {
            GetFlower(Singleton.selectedFlower);
        }
        public void OnPost() 
        {
            if (ModelState.IsValid)
            {
                SetFlower(Singleton.selectedFlower);
                Singleton.UpdateSingleton();
                Response.Redirect("/ShowAll");
            }
            
        }

        public void GetFlower(int selection)
        {
            FlowerServiceClient client = new FlowerServiceClient();
            GetFlowerRequest getFlower = new GetFlowerRequest(selection);
            var value = client.GetFlower(getFlower);
            GetFlowerResponse flowerResponse = value;
            FlowerDetails = flowerResponse.GetFlowerResult;
        }
        public string SetFlower(int selection) {
            FlowerServiceClient client = new FlowerServiceClient();
            UpdateFlowerRequest getFlower = new UpdateFlowerRequest(FlowerDetails,selection);
            var value = client.UpdateFlower(getFlower);
            UpdateFlowerResponse flowerResponse = value;
            return flowerResponse.UpdateFlowerResult;
        }
    }
}