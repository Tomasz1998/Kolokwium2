using System;
using System.Collections.Generic;
using System.Text;

namespace Kolos2
{
    public class Pomiar
    {
        private int _temperatura;
        private int _wilgotnosc;
        private int _prWiatru;
        private int _cisnienie;
        private int _idPracownika;

        public Pomiar()
        {
            _temperatura = Program.random.Next(-20, 20);
            _wilgotnosc = Program.random.Next(1, 40);
            _prWiatru = Program.random.Next(3, 50);
            _cisnienie = Program.random.Next(970, 1020);
            _idPracownika = Program.random.Next(0, 2);
        }
        public int Temperatura
        {
            get
            {
                return _temperatura;
            }
            set
            {
                _temperatura = value;
            }
        }
        public int Wilgotnosc
        {
            get
            {
                return _wilgotnosc;
            }
            set
            {
                _wilgotnosc = value;
            }
        }
        public int PrWiatru
        {
            get
            {
                return _prWiatru;
            }
            set
            {
                _prWiatru = value;
            }
        }
        public int Cisnienie
        {
            get
            {
                return _cisnienie;
            }
            set
            {
                _cisnienie = value;
            }
        }
        public int IdPracownika { get; set; }

        public void OpiszPomiar()
        {
            Console.WriteLine($"Pomiar temp: {_temperatura}stopni, Wilgotność: {_wilgotnosc}%, prędkośc wiatru: {_prWiatru}m/s, Cisnienie: {_cisnienie}hPa, IDPracownika: {_idPracownika}");
        }
    }
}
