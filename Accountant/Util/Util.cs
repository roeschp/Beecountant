using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Accountant.Util
{
    public static class Util
    {
        public static string PriceListFolder = "PriceList";
        public static string PriceListB2C = "PriceList_B2C.json";
        public static string PriceListB2B = "PriceList_B2B.json";
        public static string CustomerListFolder = "CustomerList";
        public static string CustomerListName = "CustomerList.json";

        public static double TaxesFactor = 1.107;

        public static string PathExecutable = Path.GetDirectoryName(Application.ExecutablePath);

        public static T DeepCopy<T>(T item)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            MemoryStream stream = new MemoryStream();
            formatter.Serialize(stream, item);
            stream.Seek(0, SeekOrigin.Begin);
            T result = (T)formatter.Deserialize(stream);
            stream.Close();
            return result;
        }

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

        public enum BusinessRelation
        {
            B2B,
            B2C
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
