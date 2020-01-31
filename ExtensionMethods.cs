using System;
using System.Collections.Generic;
using System.Text;
//Zadanie 2C
namespace Kolos2
{
    public static class ExtensionMethods
    {
        public static string Cenowka(this double liczba, float liczba1 )
        {
            return Math.Round(liczba, 2).ToString() + Math.Round(liczba1, 2).ToString();
        }
    }
}
