using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ServiceReference1;

namespace wcf_assignment3_interface.Pages
{
    public class AddModel : PageModel
    {
        private readonly ILogger<AddModel> _logger;
        [BindProperty]
        public FlowerDetails FlowerDetails { get; set; }

        public AddModel(ILogger<AddModel> logger)
        {
            _logger = logger;
            FlowerDetails= new FlowerDetails();
        }

        public void OnGet()
        {

        }
        public void OnPost() {
            if (ModelState.IsValid)
            {
                SaveFlower();
                Response.Redirect("Index");
            }
                     
        }

        private void SaveFlower()
        {
            FlowerServiceClient client = new FlowerServiceClient();
            InsertFlowerRequest insertFlower = new InsertFlowerRequest(FlowerDetails);
            var value = client.InsertFlower(insertFlower);
            InsertFlowerResponse flowerResponse = value;
        }
    }
}