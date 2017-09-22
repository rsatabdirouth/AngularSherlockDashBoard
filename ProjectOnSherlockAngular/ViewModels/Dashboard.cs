using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProjectOnSherlockAngular.Models;
using ProjectOnSherlockAngular.ViewModels;
using System.ComponentModel.DataAnnotations;


namespace ProjectOnSherlockAngular.ViewModels
{
    public class Dashboard
    {

        [Display(Name = "Search By ProductName")]
        public ICollection<ProductMaster> ProductList { get; set; }
        [Display(Name = "Search By BuyerName")]
        public ICollection<BuyerMaster> BuyerList { get; set; }
        [Display(Name = "Search By transferStatus")]
        public ICollection<LeadStatusByName> leadStatus { get; set; }
        [Display(Name = "Search By WebsiteName")]
        public ICollection<WebsiteMaster> WebsiteList { get; set; }
        public ICollection<TransferLog> TransferList { get; set; }

        public ICollection<lead> lead { get; set; }
    }
}