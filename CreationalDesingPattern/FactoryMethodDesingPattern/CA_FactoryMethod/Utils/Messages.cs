using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_FactoryMethod.Utils
{
    public class Messages
    {
        public static void Dripling(string mevki)
        {
            Console.WriteLine($"{mevki} oyuncusu koşuyor...");
        }
        public static void Sut(string mevki)
        {
            Console.WriteLine($"{mevki} oyuncusu şut çekiyor...");
        }
        public static void Orta(string mevki)
        {
            Console.WriteLine($"{mevki} oyuncusu orta açıyor...");
        }
        public static void Calim(string mevki)
        {
            Console.WriteLine($"{mevki} oyuncusu calim atıyor...");
        }
    }
}
