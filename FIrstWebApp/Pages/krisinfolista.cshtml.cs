using FIrstWebApp.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FIrstWebApp.Pages
{
    public class krisinfolistaModel : PageModel
    {
        private readonly IKrisInfoService _krisInfoService;

        public krisinfolistaModel(IKrisInfoService krisInfoService)
        {
            _krisInfoService = krisInfoService;
        }
        public List<NewsListItem> Items { get; set; }
        public class NewsListItem
        {
            public string Id { get; set; }
            public string Title { get; set; }
            
        }
        public void OnGet()
        {
            Items = _krisInfoService.GetAllKrisInformation().Select(r => new NewsListItem
            {
                Id = r.Id,
                Title = r.Title,
            }).ToList();

        }
    }
}
