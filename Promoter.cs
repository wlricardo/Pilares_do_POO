using System;

public abstract class Promoter
{
    private string _firstName;
    private string _lastaName;
    private int _cellPhone;

    public string MyBusinessCard
    {
        get
        {
            return String.Format("My name is {0} {1} - Phone no. {2}.", this._firstName, this._lastaName, this._cellPhone);
        }
    }

    public Promoter(){}

    public Promoter(string firstName, string lastName, int cellPhone)
    {
        this._firstName = firstName;
        this._lastaName = lastName;
        this._cellPhone = cellPhone;
    }

    public void Promote()
    {
        this.ShareWithInnerCircle();
        this.UsePaidAds();
    }

    protected abstract void ShareWithInnerCircle();
    protected abstract void UsePaidAds();

    // Como temos as classes protected, elas devem ser implementadas pelas classes que necessitam delas.
}