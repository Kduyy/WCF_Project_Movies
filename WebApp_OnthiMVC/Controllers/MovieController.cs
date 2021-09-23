using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApp_OnthiMVC.ServiceReference1;

namespace WebApp_OnthiMVC.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movie
        private Service1Client obj = new Service1Client();
       
        public ActionResult Index(String Search)
        {
            List<Movie> mve_list = new List<Movie>();
            if (!(String.IsNullOrEmpty(Search)))
            {
                var list1 = obj.Search(Search);
                foreach (var item in list1)
                {
                    Movie mve = new Movie();
                    mve.MovieId = item.MovieId;
                    mve.Title = item.Title;
                    mve.ReleaseDate = item.ReleaseDate;
                    mve.RunningTime = item.RunningTime;
                    mve.GenreId = item.GenreId;
                    mve.BoxOffice = item.BoxOffice;
                    mve_list.Add(mve);
                }
                return View(mve_list);
            }


            var list = obj.getAll();

            foreach (var item in list)
            {
                Movie mve = new Movie();
                mve.MovieId = item.MovieId;
                mve.Title = item.Title;
                mve.ReleaseDate = item.ReleaseDate;
                mve.RunningTime = item.RunningTime;
                mve.GenreId = item.GenreId;
                mve.BoxOffice = item.BoxOffice;
                mve_list.Add(mve);
            }
            return View(mve_list);
        }
        [HttpGet]
        public ActionResult Create()
        {

            //ViewBag.lisMovie = obj.getAll();

            return View();
        }
        [HttpPost]
        public ActionResult Create(Movie m)
        {

            //ViewBag.lisMovie = obj.getAll();
            obj.Add(m);
            return RedirectToAction("Index", "Movie");
        }
        public ActionResult Edit(int id)
        {
            var item = obj.GetbyId(id);
            Movie mve = new Movie();
            mve.MovieId = item.MovieId;
            mve.Title = item.Title;
            mve.ReleaseDate = item.ReleaseDate;
            mve.RunningTime = item.RunningTime;
            mve.GenreId = item.GenreId;
            mve.BoxOffice = item.BoxOffice;
            //mve.Genre.GenreId = item.GenreId;
            return View(mve);
        }

        [HttpPost]
        public ActionResult Edit(Movie item)
        {
            if (ModelState.IsValid)
            {

                Movie ms = new Movie();

                ms.MovieId = item.MovieId;
                ms.Title = item.Title;
                ms.ReleaseDate = item.ReleaseDate;
                ms.RunningTime = item.RunningTime;
                ms.GenreId = item.GenreId;
                ms.BoxOffice = item.BoxOffice;
                //ms.GenreId = item.Genre.GenreId;

                int i = 0;
                i++;
                obj.Edit(ms);
                return RedirectToAction("Index", "Movie");
            }
            return View();
        }
        public ActionResult Delete(int id)
        {
            if (ModelState.IsValid)
            {
                obj.Delete(id);
                return RedirectToAction("Index", "Movie");
            }
            return View();
        }
        public ActionResult Details(int id)
        {
            var list = obj.GetbyId(id);
            Movie cls = new Movie();
            cls.MovieId = list.MovieId;
            cls.Title = list.Title;
            cls.ReleaseDate = list.ReleaseDate;
            cls.RunningTime = list.RunningTime;
            cls.GenreId = list.GenreId;
            cls.BoxOffice = list.BoxOffice;
            return View(cls);
        }
    }
}
    
