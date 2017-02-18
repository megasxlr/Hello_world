using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdBragd
{
   
    /*
    public class ord
    {
        public string Stafur { get; set; }
        public string ord (string stafur)
        {
            Stafur = stafur;
        }
    }
    */
    public class stike
    {
        public static string stafrof = "aábcdðeéfghiíjklmnoópqrstuúvwxyýzþæö";
        public static List<string> stafir = new List<string>();
        public static string ord = "";
        public static List<string> total = new List<string>();
        public static int stafSize = 0;
        public static int size = 0;
        public static bool x = false;
        public static bool y = false;

        public static void begin()
        {
            while (x == false)
            {
                stike.change();
            }
        }
        public static void aLetter(string ord)
        {

            total.Add(ord);
        }
        public static void change()
        {
            while(y == false)
            {
                string lol = "";
                stafir.Add(stike.addword(lol));
            }
        }
        public static string addword(string a)
        {
            return "";
        }
        /*  public static void addword2()
         *  {
         *      for(int i = 0; i < strike.stafrof.length; i++)
         *      {
         *          strike.stafir.add(stafrof[i]);
         *          strike.do1();
         *      }
         *  }
         *  public static void do1()
         *  {
         *      if(stafir[0] == "a")
         *      {
         *          s
         *      }
         *  }
         *
         * 
         */
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("íslenzka: ");
            string svar = Console.ReadLine();
            if (svar == "yes")
            {
                stike.begin();
                for (int i = 0; i < stike.size; i++)
                {
                    Console.WriteLine(stike.total[i]);
                }
                Console.ReadLine();
            }
            else { }

        }
        public void aLetter(char letter)
        {

        }
        public List<string> allwords()
        {
            List<string> ord1 = new List<string>();

            return ord1;

        }
    }
}
