class Soldier
{
    private int personalNum;
    private string dateOfBirth;
    private string dateOfEnlistment;
    private string dateOfLiberation;


    public Soldier()
    {
        this.personalNum = null;
        this.dateOfBirth = "";
        this.dateOfEnlistment = "";
        this.dateOfLiberation = "";
    }

    public Soldier(int pn , int dob , int doe , int dol)
    {
        this.personalNum = pn;
        this.dateOfBirth = dob;
        this.dateOfEnlistment = doe;
        this.dateOfLiberation = dol;
    }



    public int getPN()
    {
        return this.personalNum;
    }

    public int getDOB()
    {
        return this.dateOfBirth
    }

    public int getDOE()
    {
        return this.dateOfEnlistment;
    }

    public int getDOL()
    {
        return this.dateOfLiberation;
    }



    public void setPN(int pn)
    {
        this.personalNum = pn;
    }

    public void setDOB(int dob)
    {
        this.dateOfBirth = dob;
    }

    public void setDOB(int doe)
    {
        this.dateOfEnlistment = doe;
    }

    public void setDOB(int dol)
    {
        this.dateOfLiberation = dol;
    }



    public override string ToString()
    {
        return "The soldier's personal number is: " + personalNum +
                ", he was born on " + dateOfBirth +
                ", he was Liberated on " + dateOfLiberation +
                ", and will be elnisted on" + dateOfEnlistment;
    }

    public bool compareDates(int date)
    {
        if(this.dateOfLiberation == date)
        {
            return true;
        }
        return false;
    }


}