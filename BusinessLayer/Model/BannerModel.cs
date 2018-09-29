using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Model
{
    public class BannerModel 
    {
        public BannerModel objBanner { get; set; }
        public BannerModel()
        {
            objBanner = new BannerModel();
        }

        private string _id { get; set; }
        private string _html { get; set; }
        private DateTime _created { get; set; }
        private DateTime? _modified { get; set; }

        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string Html
        {
            get { return _html; }
            set { _html = value; }
        }
        public DateTime createdOn
        {
            get { return _created; }
            set { _created = value; }
        }
        public DateTime? ModifiedOn
        {
            get { return _modified; }
            set { _modified = value; }
        }

        public ICollection<BannerModel> GetAllBannerItems { get; set; }
    }
}
