using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İkiliAgac
{
    public class İkiliAgac
    {
        private İkiliAgacDugumu kok;
        private string dugumler;
        
        public İkiliAgac(İkiliAgacDugumu kok)
        {
            this.kok = kok;
        }
        //Kok private olduğu için overloaded DugumSayisi fonksiyonu
        public int DugumSayisi()
        {
            return DugumSayisi(kok);
        }
        public int DugumSayisi (İkiliAgacDugumu dugum)
        {
            /* tüm bunları yapmak yerine 3 satır ilede bu işlemi yapabiliriz aslında
               fonskiyonların dışına bir tane sayac isminde bir değişken tanımlayıp
               ziyaret methodu içinde sayacı artırabiliriz ve burada çağırırız veya liste oluşturup listeye atarız
               ama o zaman başka bir methodu amacı dışında kullanacaktım o yüzden bu şekilde yaptım*/ 
               
            
            if (dugum == null)
            {
                return 0;
            }
            else
            {
                Queue<İkiliAgacDugumu> queue = new Queue<İkiliAgacDugumu>();


                queue.Enqueue(dugum);

                int count = 1;
                while (queue.Count != 0)
                {

                    İkiliAgacDugumu degisken = queue.Dequeue();



                    if (degisken.sol != null)
                    {
                        queue.Enqueue(degisken.sol);
                        count++;
                    }


                    if (degisken.sag != null)
                    {
                        queue.Enqueue(degisken.sag);
                        count++;
                    }
                }
                return count;
            }
            
        }
        public int YaprakSayisi()
        {
            return YaprakSayisi(kok);
        }
        public int YaprakSayisi(İkiliAgacDugumu dugum)
        {
            int yaprak_sayisi = 0;
            if (dugum == null)
            {
                return 0;
            }
            if (dugum.sol == null && dugum.sag == null)
            {
                yaprak_sayisi++;
                return yaprak_sayisi;
            }
            else
            {
                return YaprakSayisi(dugum.sol) + YaprakSayisi(dugum.sag);
            }
        }
        public string DugumleriYazdir()
        {
            return dugumler;
        }
        //Gezinme İşlemleri
        public void PreOrder()
        {
            dugumler = "";
            PreOrderInt(kok);
        }
        private void PreOrderInt(İkiliAgacDugumu dugum)
        {
            if (dugum == null)
                return;
            Ziyaret(dugum);
            PreOrderInt(dugum.sol);
            PreOrderInt(dugum.sag);
        }
        public void InOrder()
        {
            dugumler = "";
            InOrderInt(kok);
        }
        private void InOrderInt(İkiliAgacDugumu dugum)
        {
            if (dugum == null)
                return;
            InOrderInt(dugum.sol);
            Ziyaret(dugum);
            InOrderInt(dugum.sag);
        }
        private void Ziyaret(İkiliAgacDugumu dugum)
        {
            dugumler += dugum.veri + " ";
        }
        public void PostOrder()
        {
            dugumler = "";
            PostOrderInt(kok);
        }
        private void PostOrderInt(İkiliAgacDugumu dugum)
        {
            if (dugum == null)
                return;
            PostOrderInt(dugum.sol);
            PostOrderInt(dugum.sag);
            Ziyaret(dugum);
        }
    }
}
