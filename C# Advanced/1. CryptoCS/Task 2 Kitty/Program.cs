using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2_Kitty
{
    class Program
    {
             static void Main(string[] args)
        {
            string text1 = Console.ReadLine();
            string moving = Console.ReadLine();
            int ded = 0;
            string[] arr = moving.Split(' ');
            string ret = "";
            int index = 0;
            int soul = 0, food = 0;
            int br = 0;
                 int i=0;
                 while(i!=arr.Length+1)
                 {
                     if (i == arr.Length)
                     {
                         if (text1[index] == '@') { 
                         soul++;
                        text1= text1.Remove(index, 1);
                         text1 = text1.Insert(index, "0");
                            }
                         else if (text1[index] == '*')
                         {
                             food++;
                           text1=  text1.Remove(index, 1);
                             text1 = text1.Insert(index, "0");
                         }
                         else if(text1[index]=='x')
                         {
                             if (index % 2 == 0)
                             {
                                 soul--;
                                 
                                 if (soul < 0)
                                 {
                                     Console.WriteLine("You are deadlocked, you greedy kitty!");
                                     Console.WriteLine("Jumps before deadlock: " + i);
                                     br = 1;
                                     break;
                                 }
                                 ded++;
                             }
                             else
                             {
                                 food--;
                                 if (food < 0)
                                 {
                                     Console.WriteLine("You are deadlocked, you greedy kitty!");
                                     Console.WriteLine("Jumps before deadlock: " + i);
                                     br = 1;
                                     break;
                                 }
                                 ded++;
                             }

                            }
                         break;  
                     }
                     else
                     {
                         string move;
                         move = arr[i];
                         int choslo;
                         if (move[0] != '-')
                         {
                             choslo = Convert.ToInt32(arr[i]);
                             if (text1[index] == '@')
                             {
                                 soul++; 
                             text1=    text1.Remove(index, 1);
                                 text1 = text1.Insert(index, "0");
                             }
                             else if (text1[index] == '*')
                             {
                                 food++; 
                                text1= text1.Remove(index, 1);
                                 text1 = text1.Insert(index, "0");
                             }
                             else if(text1[index]=='x')
                             {
                                 if (index % 2 == 0)
                                 {
                                     soul--;
                                    if (soul < 0)
                                     {
                                         Console.WriteLine("You are deadlocked, you greedy kitty!");
                                         Console.WriteLine("Jumps before deadlock: " + i);
                                         br = 1;
                                         break;
                                     }
                                     ded++;
                                 }
                                 else
                                 {
                                     food--;
                                     if (food < 0)
                                     {
                                         Console.WriteLine("You are deadlocked, you greedy kitty!");
                                         Console.WriteLine("Jumps before deadlock: " + i);
                                         br = 1;
                                         break;
                                     }
                                     ded++;
                                 }
                             }
                             index = index + choslo;
                             if (index > text1.Length) index = index % (text1.Length-1)-1 ;
                      

                         }

                         else
                         {
                             move = move.Remove(0, 1);
                             choslo = Convert.ToInt32(move);


                             if (text1[index] == '@')
                             {
                                 soul++; 
                                 text1=text1.Remove(index, 1);
                                 text1 = text1.Insert(index, "0");
                             }
                             else if (text1[index] == '*')
                             {
                                 food++;
                                text1= text1.Remove(index, 1);
                                 text1 = text1.Insert(index, "0");
                             }
                             else if(text1[index]=='x')
                             {
                                 if (index % 2 == 0)
                                 {
                                     soul--;
                                    
                                     if (soul < 0)
                                     {
                                         Console.WriteLine("You are deadlocked, you greedy kitty!");
                                         Console.WriteLine("Jumps before deadlock: " + i);
                                         br = 1;
                                         break;
                                     }
                                     ded++;
                                 }
                                 else
                                 {
                                     food--;
                                     
                                     if (food < 0)
                                     {
                                         Console.WriteLine("You are deadlocked, you greedy kitty!");
                                         Console.WriteLine("Jumps before deadlock: " + i);
                                         br = 1;
                                         break;
                                     }
                                     ded++;
                                 }
                             }
                             index = index - choslo;
                             if (index < 0) index = (text1.Length-choslo)%(text1.Length-1);
                    


                         }

                         i++;
                     }
                 }
                

            if (br != 1)
            {
                Console.WriteLine("Coder souls collected: " + soul);
                Console.WriteLine("Food collected: "+food);
                Console.WriteLine("Deadlocks: " + ded);

            }
        }
    }
}
