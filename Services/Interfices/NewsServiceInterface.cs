using System.Collections.Generic;
using timtro.Models;

namespace timtro.Services
{
    public interface INewsService
    {
        public List<News> GetNews();
        public News GetNewsById(int id);

        public bool AddNews(News news);

        public bool UpdateNews(News news);

        public bool DeleteNews(int id);
    }
}