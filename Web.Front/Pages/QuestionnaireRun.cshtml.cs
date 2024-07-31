using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Web.Front.Pages
{
    public class QuestionnaireRunModel : PageModel
    {
        private readonly ILogger<QuestionnaireRunModel> _logger;

        public QuestionnaireRunModel(ILogger<QuestionnaireRunModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}
