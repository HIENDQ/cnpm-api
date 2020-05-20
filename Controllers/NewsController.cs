using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using timtro.Models;
using timtro.Services;

namespace timtro.Controller
{
    [ApiController]
    [Route("controller")]
    public class NewsController : ControllerBase
    {
        private INewsService _service;

        public NewsController(INewsService service)
        {
            _service = service;
        }


        [HttpGet("/api/news")]
        public ActionResult<List<News>> GetNews()
        {
            return _service.GetNews();
        }

        [HttpPost("/api/news")]
        public ActionResult<Boolean> AddNew(News news)
        {
            
            return _service.AddNews(news) ;
        }

        [HttpPut("/api/news/{id}")]
        public ActionResult<Boolean> UpdateNew(int id,News news)
        {
            news.NewsId = id;
            return _service.UpdateNews(news);
        }

        [HttpDelete("/api/news/{id}")]
        public ActionResult<Boolean> DeleteNew(int id)
        {
            return _service.DeleteNews(id);
        }
    }
}