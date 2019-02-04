using System;
using System.Collections.Generic;
using System.Text;

namespace GirlScoutCookies
{
    public class CookieOrder
    {
        public string Variety { get; set; }
        public int NumBoxes { get; set; }

        public CookieOrder(string variety, int numBoxes)
        {
            Variety = variety;
            NumBoxes = numBoxes;
        }
    }
}
