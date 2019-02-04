using System;
using System.Collections.Generic;
using System.Text;

namespace GirlScoutCookies
{
    public class MasterOrder
    {
      public  List<CookieOrder> orders = new List<CookieOrder>();

        public MasterOrder()
        {

        }

        public void AddOrder(CookieOrder theOrder)
        {
            orders.Add(theOrder);
        }

        public int GetTotalBoxes()
        {
            int numberofboxes = 0;

            for (int i = 0; i < orders.Count; i++)
            {
                numberofboxes += orders[i].NumBoxes;
            }
            return numberofboxes;
        }

        public void RemoveVariety(string variety)
        {
                    orders.RemoveAll(x => x.Variety == variety);
        }

        public int GetVarietyBoxes(string variety)
        {
            int returnvalue = 0;
            for (int i = 0; i < orders.Count; i++)
            {
                if (orders[i].Variety.Equals(variety))
                {
                    returnvalue += orders[i].NumBoxes;
                }
            }
            return returnvalue;
        }

        public void ShowOrder()
        {
            for (int i = 0; i < orders.Count; i++)
            {
                Console.WriteLine("Variety : {0}\nBoxes : {1}",
                    orders[i].Variety,
                    orders[i].NumBoxes);
            }
        }
    }
}
