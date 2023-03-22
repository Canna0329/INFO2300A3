using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ServiceReference1;

namespace wcf_assignment3_interface.Pages
{
    public class DeleteModel : PageModel
    {
        private readonly ILogger<DeleteModel> _logger;
        [BindProperty]
        public FlowerDetails FlowerDetails { get; set; }

        public DeleteModel(ILogger<DeleteModel> logger)
        {
            _logger = logger;
            FlowerDetails = new FlowerDetails();
        }

        public void OnGet()
        {
            GetFlower(Singleton.selectedFlower);
        }
        public void OnPost() 
        {
            DeleteFlower(Singleton.selectedFlower);
            Singleton.UpdateSingleton();
            Response.Redirect("/ShowAll");
        }

        public void GetFlower(int selection)
        {
            FlowerServiceClient client = new FlowerServiceClient();
            GetFlowerRequest getFlower = new GetFlowerRequest(selection);
            var value = client.GetFlower(getFlower);
            GetFlowerResponse flowerResponse = value;
            FlowerDetails = flowerResponse.GetFlowerResult;
        }
        public string DeleteFlower(int selection)
        {
            FlowerServiceClient client = new FlowerServiceClient();
            DeleteFlowerRequest removeFlower = new DeleteFlowerRequest(selection);
            var value = client.DeleteFlower(removeFlower);
            DeleteFlowerResponse flowerResponse = value;
            return flowerResponse.DeleteFlowerResult;
        }
    }
}