using PublicationsLib;
using System;

namespace ConsoleDemo01
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Book myBook = new Book
                {
                    Title = "The Book of Stuff",
                    Author = "Shawn Dholakia",
                    PubDate = DateTime.Now
                };

                PublicationHandler handler1 = new PublicationHandler(myBook);

                Console.WriteLine(handler1.GetPublicationFullName());

                Magazine myMag01 = new Magazine
                {
                    Title = "Stuff Weekly",
                    Author = "Shawn Dholakia",
                    PubDate = DateTime.Now,
                    IssueNum = 10
                };

                PublicationHandler handler3 = new PublicationHandler(myMag01);
                Console.WriteLine(handler3.GetPublicationFullName());

                Magazine myMag02 = new Magazine
                {
                    Title = "Stuff Weeekly",
                    Author = "Shawn Dholakia",
                    PubDate = DateTime.Now,
                    IssueNum = 1
                };
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred! {ex.Message}");
            }

            Console.WriteLine("Hello World!");

            Console.ReadLine();
        }
    }
}
