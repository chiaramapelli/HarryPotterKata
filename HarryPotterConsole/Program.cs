using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace HarryPotter.Logic
{
    class Program
    {
        static void Main(string[] args)
        {
            var harryPotterLogic = new HarryPotterLogic();                  //initiated instance of a class

            Console.WriteLine("What books would you like? Please select from the following list: ");            //displaying book options

            Dictionary<string, string> bookRepo = new Dictionary<string, string>();

            bookRepo.Add("1", "Harry Potter and The Philosopher's Stone");
            bookRepo.Add("2", "Harry Potter and The Chamber of Secrets");
            bookRepo.Add("3", "Harry Potter and The Prisoner of Azkaban");
            bookRepo.Add("4", "Harry Potter and The Goblet of Fire");
            bookRepo.Add("5", "Harry Potter and The Order of the Phoenix");
            bookRepo.Add("6", "Harry Potter and The Half-Blood Prince");
            bookRepo.Add("7", "Harry Potter and The Deathly Hallows");
            var answer = "";

            foreach (KeyValuePair<string, string> bookPair in bookRepo)
            {
                Console.WriteLine("{0}, {1} ", bookPair.Key, bookPair.Value);
            }
            Console.WriteLine();

            do
            {

                var bookID = Console.ReadLine();
                var bookName = bookRepo[bookID];
                harryPotterLogic.Add(bookName);
                Console.WriteLine(bookName);
                Console.WriteLine("Do you want another book? y/n");
                answer = Console.ReadLine();
              

            } while (answer != "n");

            var total = harryPotterLogic.GetTotal();
            var allBooks = harryPotterLogic.GetAllBooksInBasket();

            Console.WriteLine("Your overall total is " + total + ", and your books are: ");

            foreach (var book in allBooks)
            {
                Console.WriteLine(book);
            }

            Console.ReadLine();

        }
    }
}



