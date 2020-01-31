using System;
using System.Collections.Generic;
using System.Text;

namespace Kolos2
{
    public class Sok : Product
    {
        public Sok(string Nazwa, double Cena, string Producent)
        {
            _nazwa = Nazwa;
            _cena = Cena;
            _producent = Producent;
        }
        public string Nazwa { get; set; }
        public double Cena { get; set; }
        public string Producent { get; set; }
        
    }
}
