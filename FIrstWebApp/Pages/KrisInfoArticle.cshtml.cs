using FIrstWebApp.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FIrstWebApp.Pages
{
    public class KrisInfoArticleModel : PageModel
    {
        private readonly IKrisInfoService _krisInfoService;

        public string Title { get; set; }

        public string Text { get; set; }

        public string Link { get; set; }

        public KrisInfoArticleModel(IKrisInfoService krisInfoService)
        {
            _krisInfoService = krisInfoService;
        }

        public void OnGet(string articleId)
        {
            var krisinfo = _krisInfoService.GetKrisInformation(articleId);
            Title = krisinfo.Title;
            Text = krisinfo.Text;
            Link = krisinfo.LinkUrl;
        }
    }
}
