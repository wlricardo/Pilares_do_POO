using System;
using System.Collections.Generic;

namespace App_Udemy
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Promoter> promoters = new List<Promoter>() {new XSClubPromoter("Jim", "Jamesson", 22266677)}; // Posso declarar aqui
            promoters.Add(new XSClubPromoter("John", "Jones", 55544488)); // Ou da forma tradicional
            promoters.Add(new OmniaClubPromoter("James", "Jackson", 11155566));   

            foreach(var promoter in promoters)
            {
                promoter.Promote();
            }

            List<Writer> writers = new List<Writer>() {new BookWriter("Jesse", "Jordan"), new BookWriter("Jefrey", "Jock")};
            writers.Add(new BlogWriter("James", "Jeckins"));

            foreach(var writer in writers)
            {
                writer.Write();
            }

            List<IBodyBuilder> bodyBuilders = new List<IBodyBuilder>() {new XSClubPromoter("John", "Jones", 55544488), new XSClubPromoter("James", "Jackson", 11155566)};

            foreach(var builder in bodyBuilders)
            {
                builder.Workout();
            }

            List<IVlogger> vloggers = new List<IVlogger>();
            vloggers.Add(new BookWriter("John", "Jones"));
            vloggers.Add(new XSClubPromoter("James", "Jackson", 11155566));     

            foreach(var vlogger in vloggers)
            {
                vlogger.Vlog();
            }       
        }
    }
}
