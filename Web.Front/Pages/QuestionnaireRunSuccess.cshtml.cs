using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Web.Front.Pages
{
    public class QuestionnaireRunSuccessModel : PageModel
    {
        private readonly ILogger<QuestionnaireRunSuccessModel> _logger;

        public QuestionnaireRunSuccessModel(ILogger<QuestionnaireRunSuccessModel> logger)
        {
            _logger = logger;
        }
        public void OnGet()
        {
        }
    }
}
