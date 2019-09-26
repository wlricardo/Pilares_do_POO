using System;

public class XSClubPromoter : Promoter, IBodyBuilder, IVlogger
{
    public XSClubPromoter()
    {
    }

    public XSClubPromoter(string firstName, string lastName, int cellPhone) : base(firstName, lastName, cellPhone)
    {
    }

    public void Vlog()
    {
        Console.WriteLine(" I use DSLA to vlog.");
    }

    public void Workout()
    {
        Console.WriteLine(" I workout at home.");
    }

    protected override void ShareWithInnerCircle()
    {
        Console.WriteLine(" I share it in Linked In.");
    }

    protected override void UsePaidAds()
    {
        Console.WriteLine(" I use Facebook Ads.");
    }
}