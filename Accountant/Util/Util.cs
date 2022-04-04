using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accountant.Util
{
    public static class Util
    {
        public static string PriceListFolder = "PriceList";
        public static string PriceListName = "PriceList.json";
        public static string CustomerListFolder = "CustomerList";
        public static string CustomerListName = "CustomerList.json";

        public static double TaxesFactor = 1.095;

        public static string PathExecutable = Path.GetDirectoryName(Application.ExecutablePath);


        public enum Product
        {
            Tannenhonig,
            Waldhonig,
            Kastanienhonig,
            Lindenhonig,
            BlütenhonigCremig,
            BlütenhonigFluessig,
            Met,
            Propolistinktur,
            Honigseife
        }

        public enum Selection
        {
            Multi,
            Single
        }

        public struct Capacity
        {
            public int big;
            public int small;

            public Capacity()
            {
                big = 500;
                small = 250;
            }
        }
    }
}
