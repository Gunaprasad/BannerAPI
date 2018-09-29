using BusinessLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.BannerDataAccess;

namespace BusinessLayer
{
    public class BAL_Banner : IBanner
    {

        private BannerModel objBanner;
        private IBannerDataAccess objDataAccess;
        private Banner objBannerDAL;
        public BAL_Banner()
        {
            objBanner = new BannerModel();
            objDataAccess = new BannerDataAccess();
        }

        public bool Add(BannerModel item)
        {
            bool sucess = false;
            if(item != null)
            {
                objBannerDAL.Id = item.Id;
                objBannerDAL.Html = item.Html;
                objBannerDAL.createdOn = item.createdOn;
                objBannerDAL.ModifiedOn = item.ModifiedOn;
                objDataAccess.Add(objBannerDAL);
                sucess = true;
            }
            else
            {
                sucess = false;
            }
            return sucess;
        }

        public BannerModel Get(string customerID)
        {
            objBannerDAL = objDataAccess.Get(customerID);
            objBanner.Id = objBannerDAL.Id;
            objBanner.Html = objBanner.Html;
            objBanner.createdOn = objBanner.createdOn;
            objBanner.ModifiedOn = objBanner.ModifiedOn;
            return objBanner;
        }

        public IEnumerable<BannerModel> GetAll()
        {
            objBanner = new BannerModel();
            foreach (var item in objDataAccess.GetAll())
            {
                objBanner.Id = item.Id;
                objBanner.Html = item.Html;
                objBanner.createdOn = item.createdOn;
                objBanner.ModifiedOn = item.ModifiedOn;
                objBanner.GetAllBannerItems.Add(objBanner);
            }
            return objBanner.GetAllBannerItems.ToList();
        }

        public void Remove(string customerID)
        {
            objDataAccess.Remove(customerID);
        }

        public bool Update(BannerModel item)
        {
            bool sucess = false;
            if(item != null)
            { 
                objBannerDAL.Id = item.Id;
                objBannerDAL.Html = item.Html;
                objBannerDAL.createdOn = item.createdOn;
                objBannerDAL.ModifiedOn = item.ModifiedOn;
                objDataAccess.Update(objBannerDAL);
                sucess = true;
            }
            else
            {
                sucess = false;
            }
            return sucess;
        }
    }
}
