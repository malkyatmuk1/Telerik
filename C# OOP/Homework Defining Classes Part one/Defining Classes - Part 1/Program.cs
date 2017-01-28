using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Defining_Classes___Part_1
{

    public class Call
    {
        public static DateTime date;
        static GSM Phone;
        public static int duration;
        static string phonenumber;
        public Call(GSM phone,DateTime date, int duration,string phonenumb)
        {
            Call.date = date;
            Call.Phone = phone;
            Call.duration = duration;
            Call.phonenumber = phonenumb;
                
        }
        public GSM Phone1 { get; set; }
        public int duration1 { get; set; }
        public string phonenumber1 { get; set; }
        public DateTime date1 { get; set; }

        public static string WriteCall()
        {
            StringBuilder builderer = new StringBuilder();

            builderer.Append("Model: ").Append(Call.Phone.Model).Append("\r\n");
            builderer.Append("Manufacturer: ").Append(Call.Phone.Manufacturer).Append("\r\n");
            builderer.Append("Date: ").Append(Call.date).Append("\r\n");
            builderer.Append("Dialled Phone Number: ").Append(Call.phonenumber).Append("\r\n");
            builderer.Append("Duration: ").Append(Call.duration).Append("\r\n");

            return builderer.ToString();
        }
    }
    public class GSMCallHistoryTest
    {
        public static void test()
        {
            GSM telephone = new GSM("S4", "Samsung");
            Call numberone= new Call( telephone,DateTime.Now,300 ,"0898855825");
            telephone.AddCall(numberone);
            Call numbertwo = new Call(telephone, DateTime.Now, 350, "0898855925");
            telephone.AddCall(numbertwo);
            Call numberthree = new Call(telephone, DateTime.Now, 300, "0898854825");
            telephone.AddCall(numberthree);

             telephone.PrintCall();
            Console.WriteLine("///////////////////");
            telephone.PriceCall();
            Console.WriteLine("///////////////////");

            telephone.DeleteCall(2);
            telephone.PrintCall();
            Console.WriteLine("//////////////////");
            telephone.PriceCall();
            Console.WriteLine("//////////////////");

            telephone.ClearCall();
            telephone.PrintCall();      

        }

    }
        public class GSMTest
        { 
           
            public void Print()
            {
                GSM[] mobilePhones = this.Create();
                foreach(var item in mobilePhones)
                {
                    Console.WriteLine(item.WriteEverything());
                    Console.WriteLine("///////////////////");
                }
                
            }
            public GSM[] Create(){
             GSM[] mobilePhones =
            {
                new GSM("GALAXY S7 Edge", "SAMSUNG", new Battery(BatteryType.LiIon), new Display()),
                new GSM("G5", "LG", "Ivanka Petrova", 500,new Battery(BatteryType.NiCd), new Display(5.2, 1000)),
                new GSM("M2", "Sony", "Ivanka petrova",100, new Battery("HS4-555" ,  80, 20,BatteryType.LiIon), new Display(5, 1000)),
                new GSM("P9", "Huawei")
            };
                return mobilePhones;
            }
            public void DisplayInfoIphone4S()
            {
               Console.WriteLine(GSM.IPhone4S.WriteEverything());
            }

        }
        
        public class GSM
        {
            public static readonly GSM IPhone4S = new GSM("Iphone 4S", "Apple", new Battery(BatteryType.NiCd), new Display(100));
            public string model, manufacturer, owner;
            private int? price;
            public Battery batteryInfo;
            public Display displayInfo;
            public List<Call> historyCall;
            

            //constructors
            public GSM(string model, string manufacturer)
            {
                this.Model = model;
                this.Manufacturer = manufacturer;
                this.historyCall = new List<Call>();
            }

            public GSM(string model, string manufacturer, Battery batteryInfo, Display displayInfo)
                : this(model, manufacturer)
            {
                this.BatteryInfo = batteryInfo;
                this.DisplayInfo = displayInfo;
            }

            public GSM(string model, string manufacturer, string owner, int? price, Battery batteryInfo, Display displayInfo)
                : this(model, manufacturer, batteryInfo, displayInfo)
            {
                this.price = price;
                this.owner = owner;
            }
            //

            //proparty
            public List<Call> HistoryCall { get; set; }
            public string Model
            {
                get
                {
                    return this.model;
                }
                set
                {
                    this.model = value;
                }
            }
            public string Manufacturer
            {
                get
                {
                    return this.manufacturer;
                }
                set
                {
                    this.manufacturer = value;
                }
            }
            public string Owner
            {

                get
                {
                    return this.owner;
                }
            }
            public int? Price
            {
                get
                {
                    return this.price;
                }
                set
                {
                    this.price = value;
                }
            }
            public Battery BatteryInfo
            {
                get
                {
                    return this.batteryInfo;
                }

                set
                {
                    this.batteryInfo = value;
                }
            }

            public Display DisplayInfo
            {
                get
                {
                    return this.displayInfo;
                }

                set
                {
                    this.displayInfo = value;
                }
            }
            //
            public string WriteEverything()
            {
                StringBuilder stroitel = new StringBuilder();
                stroitel.Append("The model is: ").Append(this.model).Append("\n");
                stroitel.Append("The manufacturer is: ").Append(this.manufacturer).Append("\n");
                if (this.price != null) { stroitel.Append("The price is: ").Append(this.price).Append("\n"); }
                if (this.owner != null) { stroitel.Append("The owner is: ").Append(this.owner).Append("\n"); }
                if (this.BatteryInfo != null)
                    {
                        stroitel.Append(Battery.WriteEverythingBattery());
                    }
          
            if (this.DisplayInfo != null)
            {
                stroitel.Append(Display.WriteEverythingDisplay());
            }
            
            return stroitel.ToString();
        }
            public void AddCall(Call call)
            {
                this.historyCall.Add(call);
            }

            public void DeleteCall(int index)
            {
                this.historyCall.Remove(this.historyCall[index]);
            }

            public void ClearCall()
            {
                this.historyCall.Clear();
            }
            public void PriceCall()
            {
                double sum = 0;

                for (int i = 0; i < this.historyCall.Count; i++)
                {
                    sum=sum + (this.historyCall[i].duration1 / 60) * 0.37;
                }

                Console.WriteLine("The price is {0} lv", sum);
            }
            public void PrintCall()
            {
                foreach (var item in this.historyCall)
                {
                    Console.WriteLine(item);
                }
            }

        }
        public class Battery
        {
            static string Model;
            static int? HoursIdle, HoursTalk;
            static BatteryType? type;
            //ctor
            public Battery(string model, int hoursIdle, int hoursTalk, BatteryType type)
            {
                Battery.Model = model;
                Battery.HoursIdle = hoursIdle;
                Battery.HoursTalk = hoursTalk;
                Battery.type = type;
            }
            public Battery(string model, int hoursIdle, int hoursTalk)
            {
                Battery.Model = model;
                Battery.HoursIdle = hoursIdle;
                Battery.HoursTalk = hoursTalk;

            }
            public Battery(string model, int hoursIdle)
            {
                Battery.Model = model;
                Battery.HoursIdle = hoursIdle;

            }
            public Battery(BatteryType type)
            {
                Battery.type = type;

            }

            //
            //property
            public string Model1
            {
                get
                {
                    return Battery.Model;
                }
                set
                {
                    if (value == null) throw new ArgumentNullException("Enter valid value!");
                    else Battery.Model = value;

                }

            }
            public int? HoursIdle1
            {
                get
                {
                    return Battery.HoursIdle;
                }
                set
                {

                    Battery.HoursIdle = value;

                }
            }
            public int? HoursTalk1 { get; set; }
            public BatteryType? Type1
            {
                
                set
                {
                    if (type != BatteryType.LiIon || type != BatteryType.NiCd || type != BatteryType.NiMH) throw new ArgumentNullException("Enter valid value!");
                    else Battery.type = value;

                }
            }
            //
            public static string WriteEverythingBattery()
            {
               StringBuilder  stroitel1 = new StringBuilder();
                if(Model!=null)stroitel1.Append("The model of Battery is: ").Append(Battery.Model).Append("\n");
               if(Battery.HoursIdle!=null) stroitel1.Append("The hoursIdle of Battery is: ").Append(Battery.HoursIdle).Append("\n");
               if (Battery.HoursTalk != null) stroitel1.Append("The hoursTalk of Battery is: ").Append(Battery.HoursTalk).Append("\n");
               if (Battery.type != null) stroitel1.Append("The type of Battery is: ").Append(Battery.type).Append("\n");
               Battery.HoursIdle = null;
               Battery.HoursTalk = null;
               Battery.Model = null;
               Battery.type = null;
                return stroitel1.ToString();
            }
        }
        public class Display
        {
            static double? Size, NumberOfColors;
            //ctor
            public Display(){}
            public Display(double size,double numberOfColors)
            {
               Display.Size = size;
                Display.NumberOfColors = numberOfColors;
            }
            public Display(double size)
            {
                Display.Size = size;
               
            }
            //
            //prop
            public int Size1 { get; set; }
            public int NumberofColors1 { get; set; }
            //
            public static string WriteEverythingDisplay()
            {
                StringBuilder stroiteldisplay = new StringBuilder();
                if (Display.Size != null)  stroiteldisplay.Append("The Size of Display is: ").Append(Display.Size).Append("\n");
                if (Display.NumberOfColors != null) stroiteldisplay.Append("The Number of Colors in the display are: ").Append(Display.NumberOfColors);
                Display.NumberOfColors = null;
                Display.Size = null;
                return stroiteldisplay.ToString();
            }
        }
       public enum BatteryType
        {
            LiIon,
            NiMH,
            NiCd
        }
   
    class Program
    {
        static void Main(string[] args)
        {
          
           GSMTest printting = new GSMTest();
           GSM telefon1 = new GSM("Nokia", "tanq");
            printting.DisplayInfoIphone4S();
            Console.WriteLine("/////////////////////////");
            printting.Print();
            GSMCallHistoryTest.test();
           Console.WriteLine(telefon1.WriteEverything());
            
        }

    }
}
