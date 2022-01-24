using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entidades
{
    public class Payment
    {
        public int paymentId { get; set; }
        public Customer customer { get; set; }
        public int customer_id { get; set; }
        public int staff_id { get; set; }
        public  Rental rental { get; set; }
        public int rental_id { get; set; }
        public decimal amount { get; set; }
        public DateTime payment_date { get; set; }



    }
}
