using System;
using System.Collections.Generic;
using System.Text;

namespace ToutDeSuiteOuPlusTard
{
    class Client
    {
       public Client(int salaireMensuel, int fortune)
       {
            this.salaireMensuel = salaireMensuel;
            this.fortune = fortune;
       }

        public int salaireMensuel
        {
            get; set;
        }

        public int fortune
        {
            get; set;
        }
    }
}
