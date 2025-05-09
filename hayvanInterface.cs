using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        public interface ISesCikarabilen
        {
            void SesCikar();
        }

        public class Kedi : ISesCikarabilen
        {
            public void SesCikar()
            {
                Console.WriteLine("Miyav miyav!");
            }
        }

        public class Kopek : ISesCikarabilen
        {
            public void SesCikar()
            {
                Console.WriteLine("Hav hav!");
            }
        }

        public class Kus : ISesCikarabilen
        {
            public void SesCikar()
            {
                Console.WriteLine("Cik cik!");
            }
        }

        static void Main(string[] args)
        {
            ISesCikarabilen kedi = new Kedi();
            kedi.SesCikar();

            ISesCikarabilen kopek = new Kopek();
            kopek.SesCikar();

            ISesCikarabilen kus = new Kus();
            kus.SesCikar();
        }
    }
}
