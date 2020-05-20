using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using timtro.Models;

namespace timtro.Services
{
    public class NewsService : INewsService
    {
        private DataContext _context;
        public NewsService (DataContext context)
        {
            _context=context;
        }

        public List<News> GetNews()
         {
             return _context.News.ToList();
         }


        public News GetNewsById(int id)
        {
            return _context.News.FirstOrDefault(x=> x.NewsId==id);
        }

        public bool AddNews(News news)
        {
            try
           {
            news.DateCreate=DateTime.Now;
            _context.Add(news);
            _context.SaveChanges();
               
           }
           catch (System.Exception)
           {
               
               return false;
           } 
            return true;
        }

        public bool DeleteNews(int id)
        {
            try
            {
                _context.News.Remove(GetNewsById(id));
                _context.SaveChanges();
            }
            catch (System.Exception)
            {
                
                return false;
            }

            return true;
        }


        

        public bool UpdateNews(News news)
        {
            try
            {
            var news1 = _context.News.FirstOrDefault(x=> x.NewsId == news.NewsId);
            news1.Title= news.Title;
            news1.Status= news.Status;
            news1.Description= news.Description;
            news1.Price= news.Price;
            news1.Area= news.Area;
            news1.Address= news.Address;
            news1.Picture= news.Picture;
            news1.DateUpdate=DateTime.Now;
            _context.SaveChanges();
            }
            catch (System.Exception)
            {
                return false;
            }
            return true;
        }


    }
    
}