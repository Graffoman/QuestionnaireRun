using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Web.Front.Pages
{
    public class WelcomPageModel : PageModel
    {
        private readonly ILogger<WelcomPageModel> _logger;

        public WelcomPageModel(ILogger<WelcomPageModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}
