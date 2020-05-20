using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using timtro.Models;

namespace timtro.Services
{
    public class NewService : INewService
    {
        private DataContext _context;
        public NewService (DataContext context)
        {
            _context=context;
        }

        public List<New> GetNews()
         {
             return _context.News.ToList();
         }


        public New GetNewById(int id)
        {
            return _context.News.FirstOrDefault(x=> x.NewId==id);
        }

        public bool AddNew(New news)
        {
            try
           {
            _context.Add(news);
            _context.SaveChanges();
               
           }
           catch (System.Exception)
           {
               
               return false;
           } 
            return true;
        }

        public bool DeleteNew(int id)
        {
            try
            {
                _context.News.Remove(GetNewById(id));
                _context.SaveChanges();
            }
            catch (System.Exception)
            {
                
                return false;
            }

            return true;
        }


        

        public bool UpdateNew(New news)
        {
            try
            {
            var news1 = _context.News.FirstOrDefault(x=> x.NewId == news.NewId);
            news1.Title= news.Title;
            news1.Status= news.Status;
            news1.Description= news.Description;
            news1.Price= news.Price;
            news1.Area= news.Area;
            news1.Address= news.Address;
            news1.Picture= news.Picture;
            news1.Time= news.Time;
            
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