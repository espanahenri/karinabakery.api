using System;
using System.Collections.Generic;
using System.Text;

namespace KarinaBakery.Models.Interfaces
{
    interface IProduct
    {
        public int Id { get; set; }
        public string name { get; set; }
        public decimal price { get; set; }

    }
}
