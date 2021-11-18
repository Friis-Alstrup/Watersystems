using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Watersystems.Models
{
    public class Order
    {
        public int OrderNumber { get; set; }
        public string OrderedBy { get; set; }
        public DateTime DateRecived { get; set; }
        public string RecivedBy { get; set; }
        public Order(int orderNumber, string orderedBy) : this(orderNumber, orderedBy, DateTime.Now, string.Empty)
        {
           
        }
        public Order(int orderNumber, string orderedBy, string recivedBy) : this(orderNumber, orderedBy, DateTime.Now, recivedBy)
        {

        }
        public Order(int orderNumber, string orderedBy, DateTime dateRecived, string recivedBy)
        {
            this.OrderNumber = orderNumber;
            this.OrderedBy = orderedBy;
            this.DateRecived = dateRecived;
            this.RecivedBy = recivedBy;
        }

    }


}
