using DevCard.Models;
using Microsoft.AspNetCore.Mvc;

namespace DevCard.ViewComponents
{
	public class LatestArticleViewComponent : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			var article = new List<Article>
			{
				new Article(1,"آموزش ASP .NET Core","کاملترین پکیج آموزش ASP .NET Core 6","blog-post-thumb-card-1.jpg"),
				new Article(2,"آموزش Git & Github","کاملترین پکیج آموزش Git & Github","blog-post-thumb-card-2.jpg"),
				new Article(3,"آموزش Onion Architecture","کاملترین پکیج آموزش Onion Architecture","blog-post-thumb-card-3.jpg"),
				new Article(4,"آموزش طراحی سایت","کاملترین پکیج آموزش طراحی سایت","blog-post-thumb-card-4.jpg")
			};
			return View("_LatestArticles", article);
		}
	}
}
