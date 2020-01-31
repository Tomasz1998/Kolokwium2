using System;
using System.Collections.Generic;
using System.Text;

namespace Kolos2
{
    public enum Uprawnienia
    {
        Brak = 0,
        KatNaAuta,
        KatNaMotocykle,
        KatNaCiezarowki,
        KatNaTiry
    }
    public class Kierowca
    {
        private Uprawnienia _uprawnienia;
        private string _nazwisko;
        private DateTime _dataWaznosci;

        public Kierowca(string nazwisko, DateTime dataWaznosci)
        {
            _uprawnienia = (Uprawnienia)Program.random.Next(5);
            _nazwisko = nazwisko;
            _dataWaznosci = dataWaznosci;
        }
        public void OpiszKierowce()
        {
            Console.WriteLine($"Nazwisko {_nazwisko}, Data ważnosci OC {_dataWaznosci}, Kategoria {_uprawnienia}");
        }
    }
}
