using System;

namespace CoffeeVendingMachine.Models
{
    public class TradingAutomat
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Model { get; set; }
        public int? FranchiseeId { get; set; }
        public string FranchiseeName { get; set; }
        public int? ModemId { get; set; }
        public string Address { get; set; }
        public string Status { get; set; }
        public DateTime InstallDate { get; set; }
        public bool IsActive { get; set; }

        public string StatusText
        {
            get
            {
                if (Status == "Working") return "Работает";
                if (Status == "NotWorking") return "Не работает";
                if (Status == "Maintenance") return "На обслуживании";
                return Status;
            }
        }

        public string StatusColor
        {
            get
            {
                if (Status == "Working") return "#4CAF50";
                if (Status == "NotWorking") return "#F44336";
                if (Status == "Maintenance") return "#FF9800";
                return "#9E9E9E";
            }
        }
    }
}