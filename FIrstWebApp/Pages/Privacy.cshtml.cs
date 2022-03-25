using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Globalization;

namespace FIrstWebApp.Pages
{
    public class PrivacyModel : PageModel
    {
        private readonly ILogger<PrivacyModel> _logger;

        public string WeekDayInSwedish { get; set; }

        public PrivacyModel(ILogger<PrivacyModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            var svenska = new CultureInfo("sv-SE");
            WeekDayInSwedish = DateTime.Now.ToString("dddd", svenska);
        }
    }
}