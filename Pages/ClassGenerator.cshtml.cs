using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ClassGenerator.Pages
{
    public class ClassGeneratorModel : PageModel
    {
        [BindProperty]
        public ClassGenerator.Models.ClassGenerator ConfigurationForm { get; set; }

        public void OnGet()
        {
        }
    }
}
