using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment24
{
    class BookStore5
    {
        public int bookno;
        public string bookName;
        public string bookTitle;
        public string bookAuthor;
        public int bookQuantity;
        public double bookPrice;
        public void Details()
        {
            Console.WriteLine("BookNumber: " + bookno);
            Console.WriteLine("Bookname: " + bookName);
            Console.WriteLine("Book Title: " + bookTitle);
            Console.WriteLine("BookAuthor: " + bookAuthor);
            Console.WriteLine("BookQuantity: " + bookQuantity);
            Console.WriteLine("Book Price: " + bookPrice);
        }

        public double amountPayable(int qty, double price)
        {
            double totalprice = qty * price;
            return totalprice;

        }
    }

    class Test_Book
    {
        static void Main()
        {
            BookStore5 bs = new BookStore5();
            bs.bookno = 10;
            bs.bookName = "C#.Net";
            bs.bookTitle = "Programming";
            bs.bookAuthor = "Einstein";
            bs.bookQuantity = 5;
            bs.bookPrice = 500;
            bs.Details();
            Console.WriteLine("Total price is to be paid is " + bs.amountPayable(bs.bookQuantity, bs.bookPrice));
            Console.ReadKey();
        }
    }
}
