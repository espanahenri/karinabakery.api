using System;
using System.Collections.Generic;
using System.Text;

namespace KarinaBakery.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string fName { get; set; }
        public string lName { get; set; }
        public string phoneNum { get; set; }
        public DateTime readyBy { get; set; }
        public decimal total { get; set; }
    }
}
