using System;
using System.Collections.Generic;
using System.Text;

namespace ToutDeSuiteOuPlusTard
{
    class ForwardOrder : Order
    {

        int price;
        Client client;

        public ForwardOrder(Client client, int price)
        {
            this.client = client;
            this.price = price;
        }

        //On imagine que le client paye directement sur sa fiche de paie.
        public void Pay()
        {
            client.salaireMensuel -= price / 3;
        }


        public void AfterPayed()
        {
            client.salaireMensuel += price / 3;
        }


        public bool IsValid()
        {
            if(client.salaireMensuel > price/3)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
