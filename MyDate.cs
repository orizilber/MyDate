using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyDate
{
    class MyDate
    {
        private int day;
        private int month;
        private int year;



        public MyDate()
        {
            this.day = 1;
            this.month = 1;
            this.year = 1;
        }

        public MyDate(int day, int month, int year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }



        public int getDay()
        {
            return this.day;
        }

        public int getMonth()
        {
            return this.month;
        }

        public int getYear()
        {
            return this.year;
        }



        public void setDay(int day)
        {
            this.day = day;
        }

        public void setMonth(int month)
        {
            this.month = month;
        }

        public void setYear(int year)
        {
            this.year = year;
        }



        public override string ToString()
        {
            return this.day + "/" + this.month + "/" + this.year;
        }


        public MyDate nextDate()
        {
            if (this.day >= 30)
            {
                if (this.month >= 12)
                {
                    return new MyDate(1, 1, this.year + 1);
                }
                else
                {
                    return new MyDate(1, this.month+1, this.year);
                }
            }
            else
            {
                return new MyDate(this.day + 1, this.month, this.year);
            }
        }

        public MyDate prevDate()
        {
            if (this.day <= 1)
            {
                if (this.month <= 1)
                {
                    return new MyDate(30, 12, this.year - 1);
                }
                else
                {
                    return new MyDate(30, this.month-1, this.year);
                }
            }
            else
            {
                return new MyDate(this.day - 1, this.month, this.year);
            }
        }


        public long DeferenceBetween(MyDate other)
        {
            long thisDate = this.day + this.month * 30 + this.year * 365;
            long otherDate = other.day + other.month * 30 + other.year * 365;

            return thisDate - otherDate;

        }

    }
}