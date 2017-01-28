using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;


namespace Task_1Messages
{
    class Program
    {
        static string Chisla(string text)
        {
            string stoinost="";
            for(int i=0;i<text.Length;i=i+3)
            {
                string chislo = text.Substring(i, 3);
                if (chislo == "cad") stoinost = stoinost +"0";
                if (chislo == "xoz") stoinost = stoinost +"1";
                if (chislo == "nop") stoinost = stoinost + "2";
                if (chislo == "cyk") stoinost = stoinost + "3";
                if (chislo == "min") stoinost = stoinost + "4";
                if (chislo == "mar") stoinost = stoinost + "5";
                if (chislo == "kon") stoinost = stoinost + "6";
                if (chislo == "iva") stoinost = stoinost + "7";
                if (chislo == "ogi") stoinost = stoinost + "8";
                if (chislo == "yan") stoinost = stoinost + "9";
            }
            return stoinost;
        }

        static string Krai(BigInteger chislo)
    {
        string bab,krai="";
        bab = chislo.ToString();
        for(int i=0;i<bab.Length;i++)
         {
             if (bab[i] == '0') krai = krai + "cad";
             if (bab[i] == '1') krai = krai + "xoz";
             if (bab[i] == '2') krai = krai + "nop";
             if (bab[i] == '3') krai = krai + "cyk";
             if (bab[i] == '4') krai = krai + "min";
             if (bab[i] == '5') krai = krai + "mar";
             if (bab[i] == '6') krai = krai + "kon";
             if (bab[i] == '7') krai = krai + "iva";
             if (bab[i] == '8') krai = krai + "ogi";
             if (bab[i] == '9') krai = krai + "yan";
           }
        return krai;
    }
        static void Main(string[] args)
        {
            string tex1 = Console.ReadLine();
            string znak = Console.ReadLine();
            string tex2 = Console.ReadLine();
            BigInteger chislo = 0;
           
            if (znak == "-") chislo =BigInteger.Parse(Chisla(tex1))-BigInteger.Parse(Chisla(tex2));
            else chislo = BigInteger.Parse(Chisla(tex1)) + BigInteger.Parse(Chisla(tex2)); ;
            Console.WriteLine(Krai(chislo));
      

        }
    }
}
