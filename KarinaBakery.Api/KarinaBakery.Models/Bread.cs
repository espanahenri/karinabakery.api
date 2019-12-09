using KarinaBakery.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace KarinaBakery.Models
{
    public class Bread : IProduct
    {
        public int Id { get; set; }
        public string name { get; set; }
        public decimal price { get; set; }
        public bool isSweet { get; set; }

    }
}
