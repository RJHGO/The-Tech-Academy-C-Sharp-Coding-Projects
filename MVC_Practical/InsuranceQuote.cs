//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVC_Practical
{
    using System;
    using System.Collections.Generic;
    
    public partial class InsuranceQuote
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public Nullable<int> NewQuote { get; set; }
        public Nullable<System.DateTime> DateOfBirth { get; set; }
        public Nullable<int> CarYear { get; set; }
        public string carMake { get; set; }
        public string carModel { get; set; }
        public string DUI { get; set; }
        public Nullable<int> SpeedingTickets { get; set; }
        public string coverage { get; set; }
    }
}
