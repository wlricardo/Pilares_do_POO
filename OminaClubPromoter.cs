using System;

public class OmniaClubPromoter : Promoter
{
    public OmniaClubPromoter()
    {
    }

    public OmniaClubPromoter(string firstName, string lastName, int cellPhone) : base(firstName, lastName, cellPhone)
    {
    }

    protected override void ShareWithInnerCircle()
    {
        Console.WriteLine(" I share it on Instagram.");
    }

    protected override void UsePaidAds()
    {
        Console.WriteLine(" I use Google Adwords.");
    }
}
