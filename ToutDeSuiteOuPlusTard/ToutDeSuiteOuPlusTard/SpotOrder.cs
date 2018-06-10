using System;
using System.Collections.Generic;
using System.Text;

namespace ToutDeSuiteOuPlusTard
{
    class SpotOrder : Order
    {
        Client client;
        int price;

        public SpotOrder(Client client,int price)
        {
            this.client = client;
            this.price = price;
        }

        public void Pay()
        {
            client.fortune = client.fortune - price;
        }

        public bool IsValid()
        {
            if(client.fortune >= price)
            return true;

            return false;
        }
    }
}
