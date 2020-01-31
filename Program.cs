using System;
using System.Collections.Generic;
using System.Linq;

namespace Kolos2
{
    class Program
    {
        
        public static Random random;
        static void Main(string[] args)
        {
            //Zadanie1C
            random = new Random();
            List<Pomiar> lista = new List<Pomiar>();
            for (int i = 0; i < 150; i++)
            {
                lista.Add(new Pomiar());
            }
            foreach (var item in lista)
            {
                item.OpiszPomiar();
            }
            var Srednia = lista.Select(x => x.Cisnienie).Average();
            var Min = lista.Select(x => x.Cisnienie).Min();
            var Max = lista.Select(x => x.Cisnienie).Max();

            var Srednia1 = lista.Select(x => x.PrWiatru).Average();
            var Min1 = lista.Select(x => x.PrWiatru).Min();
            var Max1 = lista.Select(x => x.PrWiatru).Max();

            var Srednia2 = lista.Select(x => x.Wilgotnosc).Average();
            var Min2 = lista.Select(x => x.Wilgotnosc).Min();
            var Max2 = lista.Select(x => x.Wilgotnosc).Max();

            var Srednia3 = lista.Select(x => x.Temperatura).Average();
            var Min3 = lista.Select(x => x.Temperatura).Min();
            var Max3 = lista.Select(x => x.Temperatura).Max();

            Console.WriteLine("Parametry Cisnienia");
            Console.WriteLine("Srednia " + Srednia + " Min " + Min + " Max " + Max);

            Console.WriteLine("Parametry Prędkości wiatru");
            Console.WriteLine("Srednia " + Srednia1 + " Min " + Min1 + " Max " + Max1);

            Console.WriteLine("Parametry Wilgotności");
            Console.WriteLine("Srednia " + Srednia2 + " Min " + Min2 + " Max " + Max2);

            Console.WriteLine("Parametry Temperatury");
            Console.WriteLine("Srednia " + Srednia3 + " Min " + Min3 + " Max " + Max3);
            Console.WriteLine();

            
            //Zadanie 3C
            List<Product> listaProduktow = new List<Product>();
            listaProduktow.Add(new Chleb("Polski", 3.99, "Polska"));
            listaProduktow.Add(new Sok("Sosnowski", 15.45, "NaPewnoNiePolska"));
            listaProduktow.Add(new Chleb("Radomski", 10, "Niemcy"));
            foreach (var item in listaProduktow)
            {
                Console.WriteLine($"Nazwa: {item._nazwa}, Cena: {item._cena}zł, Producent {item._producent}");
            }
            var sumaKoszyka = listaProduktow.Select(x => x._cena).Sum();
            Console.WriteLine("suma koszyka = " + sumaKoszyka);
            Console.WriteLine();
            //Zadanie 4C
            Kierowca kierowca = new Kierowca("Nowak", new DateTime(2020, 12, 30));
            Kierowca kierowca1 = new Kierowca("Kowalski", new DateTime(2019, 12, 30));
            Kierowca kierowca2 = new Kierowca("Biegun", new DateTime(2021, 12, 30));

            kierowca.OpiszKierowce();
            kierowca1.OpiszKierowce();
            kierowca2.OpiszKierowce();
        }
    }
}
