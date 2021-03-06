//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MyGitProj.DataAccessLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class AddDoctrsDetail
    {
        public int DoctorId { get; set; }
        public string CustomerName { get; set; }
        public string Address { get; set; }
        public string Pincode { get; set; }
        public string MoblieNo { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        public Nullable<System.DateTime> DateOfBirth { get; set; }
        public Nullable<bool> Status { get; set; }
        public Nullable<int> StateID { get; set; }
        public Nullable<int> StateHqID { get; set; }
        public Nullable<int> CityID { get; set; }
        public Nullable<int> QualificationID { get; set; }
        public Nullable<int> SpecializationID { get; set; }
        public Nullable<int> ProuctId { get; set; }
    
        public virtual SelectProduct SelectProduct { get; set; }
        public virtual Qualification Qualification { get; set; }
        public virtual Specialization Specialization { get; set; }
        public virtual StateHQ StateHQ { get; set; }
    }
}
