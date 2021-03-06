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
    
    public partial class CommonLead
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CommonLead()
        {
            this.ASULeads = new HashSet<ASULead>();
            this.CorporateHealthLeads = new HashSet<CorporateHealthLead>();
            this.DebtLeads = new HashSet<DebtLead>();
            this.EquityReleaseLeads = new HashSet<EquityReleaseLead>();
            this.HealthLeads = new HashSet<HealthLead>();
            this.LifeLeads = new HashSet<LifeLead>();
            this.LoanLeads = new HashSet<LoanLead>();
            this.MortgageLeads = new HashSet<MortgageLead>();
            this.PensionLeads = new HashSet<PensionLead>();
            this.PrepaidFuneralLeads = new HashSet<PrepaidFuneralLead>();
        }
    
        public int ID { get; set; }
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get; set; }
        public string City { get; set; }
        public string PostCode { get; set; }
        public string WorkPhone { get; set; }
        public string Homephone { get; set; }
        public string Address1 { get; set; }
        public string Email { get; set; }
        public int WebsiteMasterId { get; set; }
        public string ProductName { get; set; }
        public int ProductMasterId { get; set; }
        public string IpAddress { get; set; }
        public string Source { get; set; }
        public string MatchType { get; set; }
        public string Keyword { get; set; }
        public Nullable<int> LeadStatus { get; set; }
        public Nullable<int> DNC { get; set; }
        public string SourceUid { get; set; }
        public string PostcodeOutWard { get; set; }
        public string PostcodeInWard { get; set; }
        public int OrganizationMasterId { get; set; }
        public string OperatorName { get; set; }
        public int ContactTime { get; set; }
        public int LeadCategory { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public Nullable<System.DateTime> UpdatedOn { get; set; }
        public string OrganizationHashCode { get; set; }
        public int CreatedBy { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
        public int DeleteStatus { get; set; }
        public Nullable<int> BuyerMaster_ID { get; set; }
        public string OperatorSpecificComments { get; set; }
        public Nullable<int> LeadType { get; set; }
        public bool Opt { get; set; }
        public string LeadComment { get; set; }
        public double NotifyPrice { get; set; }
        public string AdditionalInformation { get; set; }
        public string UserAgent { get; set; }
        public string Description { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ASULead> ASULeads { get; set; }
        public virtual BuyerMaster BuyerMaster { get; set; }
        public virtual OrganizationMaster OrganizationMaster { get; set; }
        public virtual ProductMaster ProductMaster { get; set; }
        public virtual UserMaster UserMaster { get; set; }
        public virtual WebsiteMaster WebsiteMaster { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CorporateHealthLead> CorporateHealthLeads { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DebtLead> DebtLeads { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EquityReleaseLead> EquityReleaseLeads { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HealthLead> HealthLeads { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LifeLead> LifeLeads { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LoanLead> LoanLeads { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MortgageLead> MortgageLeads { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PensionLead> PensionLeads { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PrepaidFuneralLead> PrepaidFuneralLeads { get; set; }
    }
}
