using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FIrstWebApp.Pages
{
    public class RandomNumberModel : PageModel
    {
        private static Random rnd = new Random();
        public int RandomNum { get; set; }
        public string CurrentTime { get; set; }
        public void OnGet()
        {
            CurrentTime = DateTime.Now.ToString();
            RandomNum = rnd.Next(0, 300000);
        }
    }
}
