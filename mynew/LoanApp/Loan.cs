//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LoanApp
{
    using System;
    using System.Collections.Generic;
    
    public partial class Loan
    {
        public int Id { get; set; }
        public System.DateTime LoanDate { get; set; }
        public decimal Amount { get; set; }
        public int CustomerId { get; set; }
    
        public virtual Customer Customer { get; set; }
    }
}