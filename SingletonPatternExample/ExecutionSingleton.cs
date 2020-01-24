using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonPatternExample
{
    public class ExecutionSingleton
    {
        public static void Execute()
        {
            var c1 = ManagementInstance.GetManagementInstance();
            var c2 = ManagementInstance.GetManagementInstance();
            var c3 = ManagementInstance.GetManagementInstance();
            var c4 = ManagementInstance.GetManagementInstance();

            if(c1 == c2 && c2 == c3 && c3 ==c4)
            {
                Console.WriteLine("This is the same instance");
            }

            var management = ManagementInstance.GetManagementInstance();

            for(var i = 0; i < 15; i ++)
            {
                var cart = management.NextCart;
                Console.WriteLine("Cart of: " + cart.OwnerName + " --- ID Cart: " + cart.Id);
            }
        }
    }
}
