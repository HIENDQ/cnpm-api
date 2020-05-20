using System.Collections.Generic;
using timtro.Models;

namespace timtro.Services
{
    public interface INewService
    {
        public List<New> GetNews();
        public New GetNewById(int id);

        public bool AddNew(New news);

        public bool UpdateNew(New news);

        public bool DeleteNew(int id);
    }
}