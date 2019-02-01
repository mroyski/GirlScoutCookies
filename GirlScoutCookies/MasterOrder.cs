using System;
using System.Collections.Generic;
using System.Text;

namespace GirlScoutCookies
{
    public class MasterOrder
    {
        public List<string> variety = new List<string>() { "Smores", "Thin Mints", "Samoas", "Tagalongs", "Trefoils", "Do-si-dos", "Lemonades"};
        public List<CookieOrder> orders {get; set;}

        public MasterOrder()
        {
            //orders = new List<CookieOrder>();
        }

        public void AddOrder(CookieOrder theOrder)
        {
           orders.Add(theOrder);
        }

        public int GetTotalBoxes()
        {
            foreach()
        }
    }
}
