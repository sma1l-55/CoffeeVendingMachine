using System;

namespace CoffeeVendingMachine.Models
{
    public class Sale
    {
        public int Id { get; set; }
        public int AutomatId { get; set; }
        public string AutomatName { get; set; }
        public decimal Amount { get; set; }
        public int Quantity { get; set; }
        public DateTime SaleDate { get; set; }
    }
}