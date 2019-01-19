using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pizzaDukkani
{
    public abstract class Pizza
    {
        protected string isim = "isimsiz";
        protected double fiyat = 0;
        public virtual string getIsim()
        {
            return isim;
        }

        public virtual double getFiyat()
        {
            return fiyat;
        }

        public virtual void hazirla()
        {
            Console.WriteLine("Pizza hazırlanıyor.");
            Console.ForegroundColor = ConsoleColor.Green;
            ConsoleProgress progress = new ConsoleProgress();
            progress.ProgressBar(60);
            for (int i = 0; i < 101; i++)
            {
                progress.Update(i);
                System.Threading.Thread.Sleep(50);
            }
        }

        public virtual void pisir()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nPizza pisiriliyor.");
            Console.ForegroundColor = ConsoleColor.Green;
            ConsoleProgress progress = new ConsoleProgress();
            progress.ProgressBar(60);
            for (int i = 0; i < 101; i++)
            {
                progress.Update(i);
                System.Threading.Thread.Sleep(50);
            }
        }

        public virtual void kes()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nPizza kesiliyor.");
            Console.ForegroundColor = ConsoleColor.Green;
            ConsoleProgress progress = new ConsoleProgress();
            progress.ProgressBar(60);
            for (int i = 0; i < 101; i++)
            {
                progress.Update(i);
                System.Threading.Thread.Sleep(50);
            }
        }

        public virtual void paketle()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nPizza paketleniyor.");
            Console.ForegroundColor = ConsoleColor.Green;
            ConsoleProgress progress = new ConsoleProgress();
            progress.ProgressBar(60);
            for (int i = 0; i < 101; i++)
            {
                progress.Update(i);
                System.Threading.Thread.Sleep(50);
            }
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nPizza hazır. Afiyet olsun.");

        }
    }

    public class bolmalzemosPizza : Pizza
    {
        public override void hazirla()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Bolmalzemos pizza hazırlanıyor.");
        }

        public bolmalzemosPizza()
        {
            isim = "Bolmalzemos Pizza";
            fiyat = 15;
        }
       
    }

    public class sosyalPizza : Pizza
    {
        public override void hazirla()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Sosyal pizza hazırlanıyor.");
        }

        public sosyalPizza()
        {
            isim = "Sosyal Pizza";
            fiyat = 13;
        }

    }
    public class veganPizza : Pizza
    {
        public override void hazirla()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Vegan pizza hazırlanıyor.");
        }

        public veganPizza()
        {
            isim = "Vegan Pizza";
            fiyat = 10;
        }

    }

}

