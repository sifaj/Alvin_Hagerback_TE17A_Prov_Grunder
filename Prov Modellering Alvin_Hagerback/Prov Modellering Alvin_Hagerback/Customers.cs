using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prov_Modellering_Alvin_Hagerback
{
    class Customers
    {

        public List<string> NameList = new List<string>() { "Gandalf", "Varok"}; // En lista med olika namn för att kunna namnge en customer

        Random generator = new Random(); // En generator för att generara slumpade tal

        public string name = ""; // Ett namn på den som köper / säljer

        public int money = 0; //En int för att kunna påverka hur mycket pengar en customer har

        public Customers() // EN konstruktor som namnger en customer med ett slumpat namn från listan och ger money ett slumpat värde mellan 0 och 300
        {
            money = generator.Next(301);
            name = NameList[generator.Next(NameList.Count)];
        }


    }
}
