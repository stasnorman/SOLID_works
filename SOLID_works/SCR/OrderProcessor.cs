using SOLID_works.SCR.ObjectUser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_works.SCR
{
    public class OrderProcessor
    {
        private IOrderSaver[] orderSaver;
        private OrderNotification orderNotification;
        private OrderValidator orderValidator;

        public OrderProcessor(IOrderSaver[] orderSaver, OrderNotification orderNotification, OrderValidator orderValidator) {
            this.orderSaver = orderSaver;
            this.orderNotification = orderNotification;
            this.orderValidator = orderValidator;
        }

        public void Processor() {
            orderValidator.Validate();
            orderNotification.SendNotification();
            foreach (var item in orderSaver)
            {
                item.Save(null);
            }
        }
    }
}
