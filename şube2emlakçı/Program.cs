using System;
using şube2.emlakcılib;
using şube2emlakçı;

namespace şube2emlakçı
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ev evim = new Ev();
            Console.WriteLine("Alan Giriniz: ");
            evim.Alan = double.Parse(Console.ReadLine());
            Console.WriteLine("Kat No Giriniz: ");
            evim.Katno = int.Parse(Console.ReadLine());
            Console.WriteLine("Oda Sayısı Giriniz: ");
            evim.Odasayısı = int.Parse(Console.ReadLine());
            Console.WriteLine("Semt Giriniz: ");
            evim.Semt = Console.ReadLine();
            evim.EvBilgileri();

            Ev evim2 = new Ev();
            evim2.Alan=120;
            evim2.SetKatno(5);
            evim2.SetOdasayısı(3);
            //evim2.odasayısı = 3;
            evim2.SetSemt("Kızılay");
            evim2.EvBilgileri();

            //Ev evim2 = new Ev { katno = 5, alan = 120, odasayısı = 3, semt = "Gazi" }; yukarıdaki ile aynı olayı yapar.

            Bilgisayar pc1 = new Bilgisayar();
            pc1.ssd = 1;
            pc1.ram = 16;
            pc1.marka = "casper";
            pc1.model = "excalıbur";
            pc1.PcBilgileri();

            Console.WriteLine(pc1.PcBilgileri()); 
            Console.WriteLine(evim.EvBilgileri());
            Console.WriteLine(evim2.EvBilgileri());

            Ev evim3 = new Ev(3, 2, 120);
            Console.WriteLine(evim3.EvBilgileri());

            var evim4 = new Ev(3, 1, 120);
            Console.WriteLine(evim4.EvBilgileri());

            Console.WriteLine("Toplam ev sayısı " + Ev.Sayac);

            Console.WriteLine(evim.GetOdasayısı());
            Console.WriteLine(evim.GetKatno());
            Console.WriteLine(evim.GetAlan());
            Console.WriteLine(evim.GetSemt());

            Console.WriteLine(evim2.GetOdasayısı());
            Console.WriteLine(evim2.GetKatno());
            Console.WriteLine(evim2.GetAlan());
            Console.WriteLine(evim2.GetSemt());

            evim.Semt = "sincan";
            Console.WriteLine(evim.Semt);

            evim.Odasayısı = 3;
            Console.WriteLine(evim.Odasayısı);

            

            
            
            
            
        }


    }

    
}
//Ev evim = new Ev(); //Ev classından bir nesne türetildi. 

//evim: nesnenin referansı. nesneye ulasmak için kullanılır. Referanslar nesnelere ulasmak için kullanılır.

//Ev: referansın veri tipi. Her class aynı zamanda bir veri tipidir.

//new: Nesne üretmek için kullanılan anahtar sözcük.Nesneler heap bölgesinde olusturulur. Referanslar da stack bölgesinde olusturulur.

//private: sadece class içinde erişilebilir.

//public: class dışında da erişilebilir.

//bir classdan birden fazla nesne üretilebilir.

//DRY: Don't Repeat Yourself. Kod tekrarından kaçınmak için kullanılan bir prensiptir.

//Bir class içinde static olarak tanımlanan üyelere, class adı ile erişilir. Örneğin Ev.sayac şeklinde.

//Kapsülleme ilkesi(Encapsulation): class içinde yapılan işlerin class dışından erişilememesi ilkesidir.
//Bu ilkeye uygun olarak fieldlar private olarak tanımlanır ve erişim için propertyler kullanılır.
//örneğin: Odasayısı field'ına değer atama işlemi yapmak için öncelikle field private yapıldı.
//sornasında bu fiedle erişebilen public SetOdasayısı(int odasayısı) metodu tanımlandı.
//bu metod içinde gelen değerin mutak değere alınarak odasayısını fieldına aktarıldı ve bu işlemde bu metodu kullananların bilgisi olmadı.
