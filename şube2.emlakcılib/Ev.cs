using System;

namespace şube2.emlakcılib
{
    public class Ev
    {
        public static int Sayac { get; private set; }

        public Ev()//default constructor
        {
            Sayac++;
        }

        public Ev(int odasayisi,int katno,double alan,string semt = "Kızılay")
        {//Optional parametre: En sonda tanımlanmalıdır. Eğer değer verilmezse varsayılan değeri alır.
            this.Odasayısı = odasayisi;
            this.katno = katno;
            this.Semt = semt;
            this.alan = alan;
            Sayac++;
        }
        
        public Ev(int odasayisi,int katno,double alan)
        {
            this.Semt = "kızılay";
            this.Odasayısı = odasayisi;
            this.katno = katno;
            this.alan = alan;
            Sayac++;

        }

        private int odasayısı;//field
        private string semt;
        private double alan;
        private int katno;
        private string buyukluk;

        public int Katno { get; set; }
        //outo Proporty: Get ve set içinde işlem yapılmayacaksa kullanılır.

        public double Alan
        {
            get
            {
                return alan;
            }
            set
            {
                alan = value;

                if(this.alan> 50 && this.alan < 75)
                {
                    this.buyukluk = "küçük ev";
                }
                else if (this.alan > 75 && this.alan<120)
                {
                    this.buyukluk = "orta ev";
                }
                else 
                {
                    this.buyukluk = "büyük ev";
                }
            }
        }
        //Full Proporty = Get ve Set içinde çok satırlı işlemler tanımlanır.
        //Full Proporty kullanmak birden fazla satırda işlem yapmamızı sağlar.

        public string Semt { get => semt; set => semt = value.ToUpper(); }
        public int Odasayısı { get => odasayısı; set => odasayısı = Math.Abs(value); }
        
        

        public void SetOdasayısı(int odasayısı)
        {
             this.Odasayısı = Math.Abs(odasayısı);
        }

        public int GetOdasayısı()
        {
            return this.Odasayısı;
        }
        
        public void SetKatno(int katno)
        {
            this.katno = Math.Abs(katno);
        }

        public int GetKatno()
        {
           return this.katno;
        }

        public void SetAlan(double alan)
        {
            this.alan = Math.Abs(alan);
        }

        public double GetAlan()
        {
            return this.alan;
        }

        public void SetSemt(string semt)
        {
            this.Semt = semt.ToUpper();
        }
        
        public string GetSemt()
        {
            return this.Semt;
        }
        //public void SetSemt(string semt)==>this.semt =semt.ToUpper();
        //public string GetSemt() ==> this.semt;
        //bu ifade yukarıda yaptığımız işlemde aynı görevi görmektedir ve daha kısadır.

        public string EvBilgileri()
        {
            return $"oda sayısı: {this.Odasayısı}\n semt: {this.Semt}\n alan: {this.alan}\n kat no: {this.katno}\n buyukluk :{this.buyukluk} ";

        }
    }
}
//Constructor -yapıcı metod- -kurucu metod-: Class içinde bulunan fieldlara varsayılan değerleri atarlar.

// her classta mutlaka bulunur. bir classdan nesne türetildiğinde ilk çalışan metoddur.

//Constructor tanımlamasında isim verilirken , class adı ile aynı olmalıdır.

//Bu metodlar geriye hiç bir değer döndürmezler. ancak void de değillerdir. geri dönüş tipi yoktur.

// her class da mutlaka olan default constructor, parametre almayan constructor dır.

//Bu constructorları visual studio ile oluşturulurken ctor code snipeti kullanılabilir. ctor+tab.