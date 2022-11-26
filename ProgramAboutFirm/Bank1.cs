using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramAboutFirm
{
    class Bank1 : Firm
    {
        private String chieAccountantName;
        private String chiefAccountanLastName;
        private double count;
        public int month = 12;

        public double moneyOnTheCard = Console.Read();
        public void setName(String chiefAccountantName)
        {
            this.chieAccountantName = chieAccountantName;
        }
        public void setLastName(String ciefAccountantLastName)
        {
            this.chiefAccountanLastName = chiefAccountanLastName;
        }
        public String getName()
        {
            return chieAccountantName;
        }
        public String getLastName()
        {
            return chiefAccountanLastName;
        }
        public void setCount(double count)
        {
            this.count = count;
        }
        public double getCount()
        {
            return count;
        }
        public void takeOffMoney()
        {
            if (moneyOnTheCard < getCount())
            {
                Console.WriteLine("You took off your money" + moneyOnTheCard);
            }
            else
            {
                Console.WriteLine(moneyOnTheCard == getCount());
            }
           
        }
       
           public void increasePerMonth()
        {
            switch (month)
            {
                case 1: Console.WriteLine("You many for a month");
                    break;
                case 2: Console.WriteLine("Your money for a month");
                    break;
                case 3:
                    Console.WriteLine("Your money for a month");
                    break;

                case 4:
                    Console.WriteLine("Your money for a month");
                    break;
                case 5:
                    Console.WriteLine("Your money for a month");
                    break;

                case 6:
                    Console.WriteLine("Your money for a month");
                    break;

                case 7:
                    Console.WriteLine("Your money for a month");
                    break;
                case 8:
                    Console.WriteLine("Your money for a month");
                    break;
                case 9:
                    Console.WriteLine("Your money for a month");
                    break;
                case 10:
                    Console.WriteLine("Your money for a month");
                    break;
                case 11:
                    Console.WriteLine("Your money for a month");
                    break;
                case 12:
                    Console.WriteLine("Your money for a month");
                    break;

            }

        }

        }
    



}


