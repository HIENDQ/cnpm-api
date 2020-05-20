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
    public class NewController : ControllerBase
    {
        private INewService _service;

        public NewController(INewService service)
        {
            _service = service;
        }


        [HttpGet("/api/new")]
        public ActionResult<List<New>> GetNews()
        {
            return _service.GetNews();
        }

        [HttpPost("/api/new")]
        public ActionResult<Boolean> AddNew(New news)
        {
            
            return _service.AddNew(news) ;
        }

        [HttpPut("/api/new/{id}")]
        public ActionResult<Boolean> UpdateNew(int id,New news)
        {
            news.NewId = id;
            return _service.UpdateNew(news);
        }

        [HttpDelete("/api/new/{id}")]
        public ActionResult<Boolean> DeleteNew(int id)
        {
            return _service.DeleteNew(id);
        }
    }
}