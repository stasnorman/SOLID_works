using SOLID_works.SCR;
using SOLID_works.SCR.DIP;
using SOLID_works.SCR.Liskov;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_works
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region S
            OrderNotification orderNotification = new OrderNotification();
            OrderValidator orderValidator = new OrderValidator();
            #endregion

            #region O
            DbOrderSaver dbOrderSaver = new DbOrderSaver();
            //dbOrderSaver.Save("Hello world");
            CacheOrderSaver cacheOrderSaver = new CacheOrderSaver();
            //cacheOrderSaver.Save("to all");
            IOrderSaver[] orderSaver = { dbOrderSaver, cacheOrderSaver };
            #endregion

            #region L
            Bird bird = new Bird("Lol");
            Pegeot pegeot = new Pegeot("Lol", "Быстрая");
            #endregion

            #region I
            //Разделение по интерфейсам и действиям в них
            #endregion

            #region D     
            Book book = new Book(new HtmlPrinter());
            book.Text = "МНОГА БУКАВ";
            book.Print();

            #endregion

            OrderProcessor orderProcessor = new OrderProcessor(orderSaver, orderNotification, orderValidator);

            Console.ReadKey();
        }
    }
}
