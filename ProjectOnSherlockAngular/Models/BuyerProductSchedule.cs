//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjectOnSherlockAngular.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class BuyerProductSchedule
    {
        public int ID { get; set; }
        public int BuyerMasterId { get; set; }
        public int ProductMasterId { get; set; }
        public Nullable<System.DateTime> StartDateTime { get; set; }
        public Nullable<System.DateTime> EndDateTime { get; set; }
        public int ActiveState { get; set; }
        public int Demand { get; set; }
        public int TimePeriod { get; set; }
        public int DailyDemand { get; set; }
        public int PaymentMode { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public Nullable<System.DateTime> UpdatedOn { get; set; }
        public int CreatedBy { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
        public int DeleteStatus { get; set; }
    
        public virtual BuyerMaster BuyerMaster { get; set; }
        public virtual ProductMaster ProductMaster { get; set; }
        public virtual UserMaster UserMaster { get; set; }
    }
}
