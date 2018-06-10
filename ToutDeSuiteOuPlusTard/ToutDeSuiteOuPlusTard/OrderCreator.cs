using System;
using System.Collections.Generic;
using System.Text;

namespace ToutDeSuiteOuPlusTard
{
    class OrderCreator
    {
        public void CreateNewOrder(PaymentType paymentType,Client client,int price)
        {
            Order order = CreateOrder(paymentType,client,price);
            if(order.IsValid())
            {
                order.Pay();
            }
        }

        private Order CreateOrder(PaymentType paymentType,Client client,int price)
        {
            if(paymentType == PaymentType.Spot)
            {
                return new SpotOrder(client,price);
            }
            else
            {
                return new ForwardOrder(client,price);
            }
        }
    }
}
