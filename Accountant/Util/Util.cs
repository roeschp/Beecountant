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

        public static string PathExecutable = Path.GetDirectoryName(Application.ExecutablePath);


        public enum Product
        {
            Tannehonig,
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

        public struct HoneyCapacity
        {
            public int HoneyBig = 500;
            public int HoneySmall = 250;
        }
    }
}
