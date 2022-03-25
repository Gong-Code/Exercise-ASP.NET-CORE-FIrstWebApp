using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FIrstWebApp.Pages
{
    public class MyPageModel : PageModel
    {
        public string Name { get; set; }
        public int Age { get; set; }
  
        public void OnGet()
        {
            Name = "Kalle";
            Age = 27;
        }
    }
}
