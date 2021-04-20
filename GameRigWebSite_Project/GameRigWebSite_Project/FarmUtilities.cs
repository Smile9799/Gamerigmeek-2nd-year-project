using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameRigWebSite_Project
{
    public  class FarmUtilities
    {
        private static double vat;
        public static double total;
        private static double subtotal;
        private static int deliveryfee;
      public FarmUtilities()
        {
            vat = 0.15;
            deliveryfee = 50;
    
        }
        public static double getVat()
        {
            return vat;
        }
        public static int getDeliveryFee()
        {
            return deliveryfee;
        }

        public static void setSubtotal(double tot)
        {
            subtotal = tot;

        }
        public static void setTotal(double tot)
        {
            total = tot;
        }
        public static void setDeliveryFee(int fee)
        {
            deliveryfee = fee;
        }
    }
}