using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyCms.Models;

namespace MyCms.Controllers
{
    public class ClientNewsController : Controller
	{
		private MyCmsContext db = new MyCmsContext();
		// GET: ClientNews
		public ActionResult ShowGroup()
		{
			return PartialView(db.PageGroups.ToList());
		}
		public ActionResult ShowNewsByGroup(int? id)
		{
			return View(db.News.Where(p => p.GroupId == id).ToList());
		}

		public ActionResult ShowNews(int id)
		{

			var News = db.News.Find(id);
			if (News==null)
			{
				return HttpNotFound();

			}
			News.NewsSeen += 1;
			db.SaveChanges();

			return View(News);
				
		}
	}
}