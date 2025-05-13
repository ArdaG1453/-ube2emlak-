using System;
using System.Runtime.CompilerServices;

namespace Kütüphanelib
{
    public class Kitap
    {
        private string kitapAdi;
        private string yazar;



        public string Yazar { get => yazar; set => yazar = value.ToUpper(); }
        public string KitapAdi { get => kitapAdi; set => kitapAdi = value.ToUpper(); }
    }
}
