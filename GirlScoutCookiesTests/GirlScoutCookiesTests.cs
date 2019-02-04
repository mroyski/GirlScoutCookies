using GirlScoutCookies;
using System;
using Xunit;
using System.Linq;
using System.Collections.Generic;


namespace GirlScoutCookiesTests
{
    public class GirlScoutCookiesTests
    {
        [Fact]
        public void Add_Order_Test()
        {//rrange
            MasterOrder order = new MasterOrder();
            //act
            order.AddOrder(new CookieOrder("mint", 5));
            Assert.Equal("mint",order.orders[0].Variety);
        }
        
        [Fact]
        public void Remove_by_variety()
        {
            //ARRANGE
            MasterOrder order = new MasterOrder();
            //ACT
            order.AddOrder(new CookieOrder("mint", 5));
            order.AddOrder(new CookieOrder("Joescookies", 5));
            order.AddOrder(new CookieOrder("mint", 5));
           
            order.RemoveVariety("mint");
            bool mybool = order.orders.Exists(x => x.Variety.Contains("mint"));
            //ASSERT
            Assert.False(mybool);
        }
        [Fact]
        public void shouldgetvarietyboxes()
        {
            MasterOrder order = new MasterOrder();
            //ACT
            order.AddOrder(new CookieOrder("mint", 5));
            order.AddOrder(new CookieOrder("Joescookies", 5));
            order.AddOrder(new CookieOrder("mint", 5));
            int k = order.GetVarietyBoxes("mint");
            Assert.Equal(10, k);
        }
        [Fact]
        public void Testtotalboxes()
        {

            MasterOrder order = new MasterOrder();
            //ACT
            order.AddOrder(new CookieOrder("mint", 5));
            order.AddOrder(new CookieOrder("Joescookies", 5));
            order.AddOrder(new CookieOrder("mint", 5));
            int total = order.GetTotalBoxes();

            //assert
            Assert.Equal(15, total);
        }
    }
}
