using System;

namespace TRIPLOGS.Models
{
    public class TripLog
    {
        public int TripLogID { get; set; }
        public string Driver { get; set; }
        public string Helper { get; set; }
        public string BrokerClient { get; set; }
        public string Consignee { get; set; }
        public string Destination { get; set; }
        public string ContainerNumber { get; set; }
        public string ContainerSize { get; set; }
        public string ShippingLine { get; set; }
        public string BLRefNo { get; set; }
        public string Status { get; set; }
        public string Dispatcher { get; set; }
        public decimal CashAdvance { get; set; }
        public decimal AdditionalCashAdvance { get; set; }
        public decimal DieselCash { get; set; }
        public decimal TotalAmount { get; set; }
        public string FCL { get; set; }
        public DateTime DateAdded { get; set; }
    }
}