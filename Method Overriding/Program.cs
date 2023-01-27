using System;

namespace Method_Overriding
{
    class Program
    {
        static void Main(string[] args)
        {
            //Kalıtımda base class da yer alan fonksiyonlara başka işlemler yaptırmak için kullanılır
            //bunun içinde override ve virtual kullanılır
            Kedi siyam = new Kedi();
            siyam.ses();
            Kopek kangal = new Kopek();
            kangal.ses();
            //Base class da yer alan aynı isimdeki fonksiyon ile türetilmiş class larda ki aynı isimli fonsiyonlarda
            // oluşan hatayı pas geçmesi için new kullanırdık
            //Şimdi base class da ki fonsiyona virtual yazalım
            //Türetilmiş class daki fonksiyonlara new yerine override yazalım
            //Bu şekilde hata oluşmadan fonksiyon çalışır
            Kopekx no=new Kopekx();
            no.ses();
        }
    }
    class Canli
    {
        public virtual void ses()
        {
            Console.WriteLine("------------");
        }
    }
    class Kedi : Canli
    {
        public override void ses()
        {
            Console.WriteLine("Bir kedi mıyav dedi!");
        }
    }
    class Kopek : Canli
    {
        public override void ses()
        {
            Console.WriteLine("Bir köpek hav hav dedi!");
        }
    }
    class Kopekx : Kopek
    {
       
    }
}
