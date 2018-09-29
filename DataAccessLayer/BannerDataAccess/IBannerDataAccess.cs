using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.BannerDataAccess
{
    public interface IBannerDataAccess
    {
        IEnumerable<Banner> GetAll();
        Banner Get(string customerID);
        Banner Add(Banner item);
        void Remove(string customerID);
        bool Update(Banner item);
    }
}
