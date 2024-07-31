using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Web.Front.Pages
{
    public class QuestionnaireResultsModel : PageModel
    {
        private readonly ILogger<QuestionnaireResultsModel> _logger;

        public QuestionnaireResultsModel(ILogger<QuestionnaireResultsModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}
