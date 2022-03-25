using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FIrstWebApp.Pages
{
    public class NewsModel : PageModel
    {
        public List<NewsListItem> News { get; set; }

        public class NewsListItem
        {
            public string Title { get; set; }
            public string Description { get; set; }

        }

        public void OnGet()
        {
            News = new List<NewsListItem>
            {
                new NewsListItem{ Description = "dasfasdf", Title="23123312"},
                new NewsListItem{ Description = "dasfasdf", Title="978745"},
                new NewsListItem{ Description = "dasfasdf", Title="675785"},
            };
        }
    }

    
}
