using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitapOrnek
{
    internal class Kitap
    {
        private string _kitapAdi;
        public string kitapAdi
        {
            get
            {
                return _kitapAdi;
            }
            set
            {
                if (value == null)
                {
                    Console.WriteLine("tanimsiz");
                }
                else
                {
                    _kitapAdi = value;
                }
            }
        }

        private string _yazarAdi;
        public string yazarAdi
        {
            get
            {
                return _yazarAdi;
            }
            set
            {
                if (value == null)
                {
                    Console.WriteLine("tanimsiz");
                }
                else
                {
                    _yazarAdi = value;
                }
            }
        }
        private int _yil;
        public int yil
        {
            get
            {
                return _yil;
            }
            set
            {
                if (value < 1900)
                {
                    value = 1900;
                    _yil = value;
                }
                else if (value > 2100)
                {
                    value = 2100;
                    _yil = value;
                }
                else
                {
                    _yil = value;
                }


            }
        }
        private int _fiyat;
        public int fiyat
        {
            get
            {
                return _fiyat;
            }
            set
            {
                if (value < 0)
                {
                    value = 0;
                    _fiyat = value;
                }
                else
                {
                    _fiyat = value;
                }
            }

        }
    }
}
