using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace HarryPotter.Logic
{
    public class HarryPotterLogic
    {
        public double BookPrice = 8;
        public List<string> MasterBasket = new List<string>();
        public List<List<string>> Baskets = new List<List<string>>();

        public void Add(string bookName)
        {
            var added = false;
            foreach (var basket in Baskets)
            {
                if (basket.All(basketItem => basketItem != bookName))
                {
                    basket.Add(bookName);
                    added = true;
                    break;
                }
            }

            if (added == false)
            {
                var basket = new List<string>();
                basket.Add(bookName);
                Baskets.Add(basket);
            }
        }


        public double GetTotal()
        {
            var total = 0d;
            foreach (var basket in Baskets)
            {
                var totalUnique = UniqueBooksTotal(basket);  //total for unique (discounted books)
                total += totalUnique;
            }
            return Math.Round(total, 2);        //i want the grand total of both lists' books' prices
        }

        private double UniqueBooksTotal(List<string> uniqueBooks)
        {
            if (uniqueBooks.Count == 1)
            {
                return BookPrice;
            }
            else if (uniqueBooks.Count == 2)
            {
                return BookPrice * 2 * 0.95;
            }
            else if (uniqueBooks.Count == 3)
            {
                return BookPrice * 3 * 0.90;
            }
            else if (uniqueBooks.Count == 4)
            {
                return BookPrice * 4 * 0.85;
            }
            else if (uniqueBooks.Count == 5)
            {
                return BookPrice * 5 * 0.80;
            }
            else if (uniqueBooks.Count == 6)
            {
                return BookPrice * 6 * 0.75;
            }
            else if (uniqueBooks.Count == 7)
            {
                return BookPrice * 7 * 0.70;
            }

            return 0;
        }

        public List<string> GetAllBooksInBasket()
        {
            foreach (var basket in Baskets) 
            {
                foreach (var book in basket)
                {
                    MasterBasket.Add(book);
                }
            }
            return MasterBasket;
        }

    }
}
