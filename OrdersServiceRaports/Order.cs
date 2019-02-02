using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersServiceRaports
{
    /// <summary>
    /// Klasa obiektu Order, przechowująca poszczególne linie zamówienia
    /// </summary>
    public class Order
    {
        #region Pola
        private String clientId;
        private long requestId;
        private String name;
        private int quantity;
        private double price;

        public static List<Order> Orders = new List<Order>();     

        #endregion

        #region Właściwości

        #endregion

        #region Konstruktory
        public Order(string clientId, long requestId, string name, int quantity, double price)
        {
            this.clientId = clientId;
            this.requestId = requestId;
            this.name = name;
            this.quantity = quantity;
            this.price = price;
        }
        #endregion

        #region Metody

        #endregion


    }
}
