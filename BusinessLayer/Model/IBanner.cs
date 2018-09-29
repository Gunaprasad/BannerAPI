using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Model
{
    public interface IBanner
    {
        /// <summary>
        /// Gets all the Banner Items
        /// </summary>
        /// <returns></returns>
        IEnumerable<BannerModel> GetAll();
        BannerModel Get(string customerID);
        bool Add(BannerModel item);
        void Remove(string customerID);
        bool Update(BannerModel item);
    }
}
