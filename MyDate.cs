class MyDate    <3
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

    public MyDate(int day, int month , int year)
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
        return "The current date is: " + this.day + "/" + this.month + "/" + this.year + " <3"
    }

    public string nextDate()
    {
        if(this.day >= 30)
        {
            return "The next date is: " + "1" + "/" + this.month+1 + "/" + this.year + " <3"
        }
        else
        {
            return "The next date is: " + this.day+1 + "/" + this.month + "/" + this.year + " <3"
        }
    }
}