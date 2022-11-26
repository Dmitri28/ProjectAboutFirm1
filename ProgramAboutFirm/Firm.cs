using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramAboutFirm
{
    class Firm
    {
        private String nameOfTheFirm;
        private String directorsName;
        private String directorsLastName;
        public const int month = 12;
        public int boodyOfTheCredit = Console.Read();

        public int summ = Console.Read();

        public void setNameOfTheFirm(String nameOfTheFirm)
        {
            this.nameOfTheFirm = nameOfTheFirm;
        }
        public void setDirectorsName(String directorsName)
        {
            this.directorsName = directorsName;
        }
        public void setDirectorsLastName(String directorsLastName)
        {
            this.directorsLastName = directorsLastName;
        }
        public String getNameOfTheFirm()
        {
            return nameOfTheFirm;
        }
        public String getDirectorsName()
        {
            return directorsName;
        }
        public String getDirectorsLastName()
        {
            return directorsLastName;
        }

        public int creditOperation(int summ)
        {
            summ = boodyOfTheCredit / month;
            return summ;

        }
    }

    }
