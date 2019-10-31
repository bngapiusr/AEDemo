using System;
using System.Collections.Generic;

namespace AEEFCore3.Web.Models
{
    public partial class Customer
    {
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CreditCardNumber { get; set; }
        public decimal? Total { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
