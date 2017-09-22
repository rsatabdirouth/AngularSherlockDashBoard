using ProjectOnSherlockAngular.Models;
using ProjectOnSherlockAngular.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;


namespace ProjectOnSherlockAngular.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class LeadController : ApiController
    {
        SatabdiEntities _db = new SatabdiEntities();


     
        [HttpGet]
        /*public IHttpActionResult getlead(int? leadId=null)*/
        public IHttpActionResult getlead(int? leadId)
        {
            var product = _db.ProductMasters.ToList();
            var Buyer = _db.BuyerMasters.ToList();
            var Website = _db.WebsiteMasters.ToList();
            var LeadStatus = _db.LeadStatusByNames.ToList();
            var leads = new List<lead>();
            var leadsInfos = _db.SP_LEADINFO_DATA(null
                ,null,null,null,null,null,null,null,null,null,null,null,leadId,null,null,null).ToList();

            foreach (var lead in leadsInfos)
            {
                leads.Add(new lead()
                {
                    AdditionalInformation = lead?.AdditionalInformation,
                    commonleadID = lead.commonleadID,
                    CreatedBy = lead.CreatedBy,
                    CreatedOn = lead.CreatedOn,
                    Description = lead.TransferlogDescription,
                    Email = lead.Email,
                    FullName = lead?.FullName,
                    //HomePhone = lead.HomePhone,
                    //LeadStatus = lead.LeadStatus,
                    //Keyword = lead.Keyword,
                    PostCode = lead?.PostCode,
                    ProductName = lead.ProductName,
                    //Source = lead.Source,
                    //TransferlogIsActualPrice = lead.TransferlogIsActualPrice,
                    //TransferlogPrice = lead.TransferlogPrice,
                    //TransferlogTransferredOn = lead.TransferlogTransferredOn,
                    //BuyerName = lead.BuyerName,
                    //UpdatedBy = lead.UpdatedBy,
                    //UpdatedOn = lead.UpdatedOn,
                    WebsiteName = lead?.WebsiteName,
                    //WebsiteStatus = lead.WebsiteStatus,
                 });
                
            }
            var Dashboard = new Dashboard() {
                ProductList = product,
                BuyerList = Buyer,
                WebsiteList = Website,
                leadStatus = LeadStatus,
                lead = leads
            };
            return Ok(Dashboard);
        }
    }
}
