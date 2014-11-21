using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyDate
{
    class Soldier
    {
        private int personalNum;
        private string rank;
        private MyDate dateOfBirth;
        private MyDate dateOfEnlistment;
        private MyDate dateOfLiberation;


        public Soldier()
        {
            this.personalNum = 0;
            this.rank = null;
            this.dateOfBirth = null;
            this.dateOfEnlistment = null;
            this.dateOfLiberation = null;
        }

        public Soldier(int pn, string rk, MyDate dob, MyDate doe, MyDate dol)
        {
            this.personalNum = pn;
            this.rank = rk;
            this.dateOfBirth = dob;
            this.dateOfEnlistment = doe;
            this.dateOfLiberation = dol;
        }



        public int GetPersonalNum()
        {
            return this.personalNum;
        }

        public string GetRank()
        {
            return this.rank;
        }

        public MyDate GetDateOfBirth()
    {
        return this.dateOfBirth;
    }

        public MyDate GetDateOfEnlistment()
        {
            return this.dateOfEnlistment;
        }

        public MyDate GetDateOfLiberation()
        {
            return this.dateOfLiberation;
        }



        public void SetPersonalNum(int pn)
        {
            this.personalNum = pn;
        }

        public void SetRank(string rk)
        {
            this.rank = rk;
        }

        public void SetDateOfBirth(MyDate dob)
        {
            this.dateOfBirth = dob;
        }

        public void SetDateOfEnlistment(MyDate doe)
        {
            this.dateOfEnlistment = doe;
        }

        public void SetDateOfLiberation(MyDate dol)
        {
            this.dateOfLiberation = dol;
        }



        public override string ToString()
        {
            return "The soldier's personal number is: " + this.personalNum +
                    ", his rank is: " + this.rank +
                    ", he was born on " + this.dateOfBirth.ToString() +
                    ", he was Liberated on " + this.dateOfLiberation.ToString() +
                    ", and will be enlisted on " + this.dateOfEnlistment.ToString();
        }

        public bool IsLiberated(MyDate today)
        {
            if ((today.DeferenceBetween(this.dateOfBirth) / 365) >= 40)
            {
                return true;
            }
            return false;
        }


    }
}