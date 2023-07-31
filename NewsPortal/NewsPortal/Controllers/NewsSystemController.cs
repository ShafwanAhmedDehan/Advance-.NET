using NewsPortal.DataBase;
using NewsPortal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace NewsPortal.Controllers
{
    public class NewsSystemController : ApiController
    {
        [HttpGet]
        [Route("api/Catagory/all")]
        public HttpResponseMessage showAllCat()
        {
            var DBcontext = new NewsPortalEntities();
            var AllCatagory = (from t in DBcontext.Catagories select new { t.id, t.Name }).ToList();
            return Request.CreateResponse(HttpStatusCode.OK, AllCatagory);
        }

        [HttpPost]
        [Route("api/InsertCatagory/Insert")]
        public HttpResponseMessage insertCat(Catagory cat)
        {
            var DBcontext = new NewsPortalEntities();
            try
            {
                DBcontext.Catagories.Add(cat);
                DBcontext.SaveChanges();
                var notification = new
                {
                    Notification = "Your Catagory Inserted Successfully"
                };
                return Request.CreateResponse(HttpStatusCode.OK, notification);
            }
            catch (Exception exp)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, exp.Message);
            }
        }

        [HttpPost]
        [Route("api/UpdateCatagory/Update")]
        public HttpResponseMessage updateCat(catagoryDTO cat)
        {
            var DBcontext = new NewsPortalEntities();
            var CatValue = DBcontext.Catagories.Find(cat.id);
            CatValue.Name = cat.Name;
            try
            {
                DBcontext.SaveChanges();
                return Request.CreateResponse(HttpStatusCode.OK, new { Notification = "Your Catagory Updated Successfully" });
            }
            catch (Exception exp)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, exp.Message);
            }
        }

        [HttpDelete]
        [Route("api/DeleteCatagory/Delete")]
        public HttpResponseMessage deleteCat(catagoryDTO cat)
        {
            var DBcontext = new NewsPortalEntities();
            var CatValue = DBcontext.Catagories.Find(cat.id);
            DBcontext.Catagories.Remove(CatValue);
            try
            {
                DBcontext.SaveChanges();
                return Request.CreateResponse(HttpStatusCode.OK, new { Notification = "Catagory Deleted Successfully" });
            }
            catch (Exception exp)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, exp.Message);
            }
        }

        [HttpGet]
        [Route("api/CatagorySerially")]
        public HttpResponseMessage showInOrder ()
        {
            var DBcontext = new NewsPortalEntities();
            var AllCatagory = (from t in DBcontext.Catagories orderby t.Name select new { t.Name }).ToList();
            return Request.CreateResponse(HttpStatusCode.OK, AllCatagory);
        }
        

        [HttpGet]
        [Route("api/NewsAll/all")]
        public HttpResponseMessage showAllnews()
        {
            var DBcontext = new NewsPortalEntities();
            var AllNews = (from t in DBcontext.News select new { t.id, t.Title, t.Description, t.Date }).ToList();
            return Request.CreateResponse(HttpStatusCode.OK, AllNews);
        }

        [HttpPost]
        [Route("api/InsertNews/Insert")]
        public HttpResponseMessage insertNews(News newsDT)
        {
            var DBcontext = new NewsPortalEntities();
            try
            {
                DBcontext.News.Add(newsDT);
                DBcontext.SaveChanges();
                var notification = new
                {
                    Notification = "Your News Inserted Successfully"
                };
                return Request.CreateResponse(HttpStatusCode.OK, notification);
            }
            catch (Exception exp)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, exp.Message);
            }
        }

        [HttpPost]
        [Route("api/UpdateNews/Update")]
        public HttpResponseMessage updateNews(NewsDTO DTnews)
        {
            var DBcontext = new NewsPortalEntities();
            var NewsValue = DBcontext.News.Find(DTnews.id);
            NewsValue.Title = DTnews.Title;
            NewsValue.Description = DTnews.Description;
            try
            {
                DBcontext.SaveChanges();
                return Request.CreateResponse(HttpStatusCode.OK, new { Notification = "Your News Updated Successfully" });
            }
            catch (Exception exp)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, exp.Message);
            }
        }

        [HttpDelete]
        [Route("api/DeleteNews/Delete")]
        public HttpResponseMessage deleteNews(NewsDTO DTnews)
        {
            var DBcontext = new NewsPortalEntities();
            var NewsValue = DBcontext.News.Find(DTnews.id);
            DBcontext.News.Remove(NewsValue);
            try
            {
                DBcontext.SaveChanges();
                return Request.CreateResponse(HttpStatusCode.OK, new { Notification = "News Deleted Successfully" });
            }
            catch (Exception exp)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, exp.Message);
            }
        }

        [HttpGet]
        [Route("api/News/Today")]
        public HttpResponseMessage showTodayNews()
        {
            DateTime today = DateTime.Today;
            var DBcontext = new NewsPortalEntities();
            var todayNews = (from t in DBcontext.News where t.Date == today select new { t.Title, t.Description });
            return Request.CreateResponse(HttpStatusCode.OK, todayNews);
        }

        [HttpGet]
        [Route("api/News/{catName}")]
        public HttpResponseMessage showNewsCatwise(string catName)
        {
            var DBcontext = new NewsPortalEntities();
            var SearchValue = (from t in DBcontext.Catagories where t.Name.Contains(catName) select t.id).ToList();
            var NewsValue = (from t in DBcontext.News where SearchValue.Contains(t.cid) select new { t.Title, t.Description, t.Date }).ToList();
            return Request.CreateResponse(HttpStatusCode.OK, NewsValue);
        }

        [HttpGet]
        [Route("api/NewsByDate/{Date}")]
        public HttpResponseMessage showNewsDateWise (DateTime date)
        {
            var DBcontext = new NewsPortalEntities();
            var NewsValue = (from t in DBcontext.News where t.Date == date select new { t.Title, t.Description, t.Date }).ToList();
            return Request.CreateResponse(HttpStatusCode.OK, NewsValue);
        }

        [HttpGet]
        [Route("api/NewsbyCatagoryDate/{catname}/{Date}")]
        public HttpResponseMessage showNewsCatDateWise (string catName, DateTime date)
        {
            var DBcontext = new NewsPortalEntities();
            var SearchValue = (from t in DBcontext.Catagories where t.Name.Contains(catName) select t.id).ToList();
            var NewsValue = (from t in DBcontext.News where SearchValue.Contains(t.cid) && t.Date == date select new { t.Title, t.Description, t.Date }).ToList();
            return Request.CreateResponse(HttpStatusCode.OK, NewsValue);
        }
    }
}
