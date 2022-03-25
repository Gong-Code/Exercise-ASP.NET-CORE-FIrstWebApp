using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FIrstWebApp.Pages
{
    public class PlayersModel : PageModel
    {
        public List<string> Players { get; set; }

        public void OnGet()
        {
            Players = new List<string>
            {
                "Sam Salme",
                "Gong MP",
                "Melvin Anderhagen",
                "Robert Robban",
                "David Beckham"
            };
           
        }
    }

}
