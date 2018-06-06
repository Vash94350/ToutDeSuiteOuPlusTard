using System;
using System.Collections.Generic;
using System.Text;

namespace ToutDeSuiteOuPlusTard
{
    class OrderCreator
    {
        public void CreateNewOrder()
        {
            Order order = CreateOrder();
            if(order.IsValid())
            {
                order.Pay();
            }
        }

        private Order CreateOrder()
        {
            if(paymentType == PaymentType.Spot)
            {
                return new SpotOrder();
            }
            else
            {
                return new ForwardOrder();
            }
        }
    }
}
