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
    
    public partial class LifeLead
    {
        public int ID { get; set; }
        public int LeadId { get; set; }
        public Nullable<int> Age { get; set; }
        public System.DateTime Dob { get; set; }
        public bool Single { get; set; }
        public bool Smoker { get; set; }
        public int Period { get; set; }
        public int PremiumType { get; set; }
        public int InsuranceType { get; set; }
        public int Amount { get; set; }
        public System.DateTime GeneratedDate { get; set; }
        public string ProductType { get; set; }
        public string PartnerTitle { get; set; }
        public string PartnerFirstName { get; set; }
        public string PartnerLastName { get; set; }
        public bool PartnerSmoker { get; set; }
        public Nullable<System.DateTime> PartnerDob { get; set; }
        public string AdditionalInformation { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public System.DateTime UpdatedOn { get; set; }
        public int CreatedBy { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
        public int DeleteStatus { get; set; }
    
        public virtual CommonLead CommonLead { get; set; }
        public virtual UserMaster UserMaster { get; set; }
    }
}