using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiCore.Models
{
    public class Delivery
    {
        public string ID { get; set; }

        public string CourierID { get; set; }
        public string DispatcherID { get; set; }

        public string NameStart { get; set; }
        public string NameEnd { get; set; }

        public string PhoneOfStart { get; set; }
        public string PhoneOfEnd { get; set; }

        public Addres StartAdress { get; set; }
        public Addres EndAdress { get; set; }

        public string Description { get; set; }

        public Pin StartPin { get; set; }
        public Pin EndPin { get; set; }


        public int ZoneStart { get; set; }//1,2,3
        public int ZoneEnd { get; set; }//1,2,3

        public int WaitingInMinutes { get; set; }

        public decimal DeliveryPrice { get; set; }

        public DateTime CreateTime { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        public int DeliveryTypeID { get; set; }
        public DeliveryType DeliveryType { get; set; }
    }
}
