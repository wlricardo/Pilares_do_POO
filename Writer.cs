using System;
public abstract class Writer : IVlogger
{
    private string _firstName;
    private string _lastaName;

    public string AuthorBio
    {
        get
        {
            return String.Format("My name is {0} {1}.", this._firstName, this._lastaName);
        }
    }

    public Writer(){}

    public Writer(string firstName, string lastName)
    {
        this._firstName = firstName;
        this._lastaName = lastName;
    }
    
    public abstract void Vlog();

    public abstract void Write();
}