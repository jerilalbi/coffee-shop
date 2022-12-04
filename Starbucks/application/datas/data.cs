using Starbucks.domain.admin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starbucks.application.datas
{
    public class data
    {
        public static int totalPrice;
        public static String emailId;
        public static int cartProducts = 0;

        public void clearData()
        {
            AdminDbOP dbOP  = new AdminDbOP();
            dbOP.adminQuery("delete from cart");
        }
    }
}
