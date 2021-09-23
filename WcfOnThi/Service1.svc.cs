using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfOnThi
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
        ExamEntities1 movieService = new ExamEntities1();
        public List<Movie> getAll()
        {

            List<Movie> movie_list = new List<Movie>();
            var list = from m in movieService.Movies select m;
            foreach (var item in list)
            {
                Movie mve = new Movie();
                mve.MovieId = item.MovieId;
                mve.Title = item.Title;
                mve.ReleaseDate = item.ReleaseDate;
                mve.RunningTime = item.RunningTime;
                mve.GenreId = item.GenreId;
                mve.BoxOffice = item.BoxOffice;
                movie_list.Add(mve);
            }
            return movie_list;
        }

        public List<Movie> Search(string Search)
        {
            List<Movie> movie_list = new List<Movie>();
            var list = from m in movieService.Movies where m.Title.Contains(Search) select m;
            foreach (var item in list)
            {
                Movie mve = new Movie();
                mve.MovieId = item.MovieId;
                mve.Title = item.Title;
                mve.ReleaseDate = item.ReleaseDate;
                mve.RunningTime = item.RunningTime;
                mve.GenreId = item.GenreId;
                mve.BoxOffice = item.BoxOffice;
                movie_list.Add(mve);
            }
            return movie_list;
        }
    

        public Movie GetbyId(int id)
        {
           var list = from m in movieService.Movies where m.MovieId == id select m;
            List<Movie> movie_list = new List<Movie>();
            Movie mve = null;
            foreach (var item in list)
            {
                mve = new Movie();
                mve.MovieId = item.MovieId;
                mve.Title = item.Title;
                mve.ReleaseDate = item.ReleaseDate;
                mve.RunningTime = item.RunningTime;
                mve.GenreId = item.GenreId;
                mve.BoxOffice = item.BoxOffice;
                movie_list.Add(mve);
            }
            return mve;
        }

        public void Add(Movie m)
        {
            Movie mve = new Movie();
            mve.Title = m.Title;
            mve.ReleaseDate = m.ReleaseDate;
            mve.RunningTime = m.RunningTime;
            mve.GenreId = m.GenreId;
            mve.BoxOffice = m.BoxOffice;
            movieService.Movies.Add(mve);

            movieService.SaveChanges();
        }

        public void Edit(Movie m)
        {
            movieService.Entry(m).State = EntityState.Modified;
            movieService.SaveChanges();
        }

        public void Delete(int id)
        {
            Movie mve = new Movie();
            mve.MovieId = id;
            movieService.Entry(mve).State = EntityState.Deleted;
            try
            {
                movieService.SaveChanges();
            }
            catch
            {

            }
        }
    }
}
