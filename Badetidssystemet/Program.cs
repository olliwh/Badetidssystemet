using System;

namespace Badetidssystemet
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Opret Kreds objecter
            Console.WriteLine("-------------------------------------------------------opret kreds objekter----------------------------------------");
            Kreds k1 = new Kreds("k1", "Roskilde Kreds", "Roskilde nr 1", 0);
            Kreds k2 = new Kreds("k2", "Ringsted Kreds", "Ringsted nr 1", 45);
            Kreds k3 = new Kreds("k2", "Randers", "Randers nr 1", 45);
            Kreds k4 = new Kreds("k4", "Rungsted Kreds", "Rungsted nr 1", 45);
            Kreds k5 = new Kreds("k5", "Ribe Kreds", "Ribe nr 1", 45);
            Kreds k6 = new Kreds("k6", "Ranum Kreds", "Ranum nr 1", 0);



            Console.WriteLine(k1);
            Console.WriteLine(k2);
            Console.WriteLine(k3);
            Console.WriteLine(k4);
            Console.WriteLine(k5);
            Console.WriteLine(k6);

            #endregion



            #region Opret BadetidsPeriode objecter
            Console.WriteLine("-------------------------------------------------------opret badetidsPeriode objekter----------------------------------------");

            BadetidsPeriode bp1 = new BadetidsPeriode("Aften badning", DayOfWeek.Saturday, new DateTime(2022, 10, 12).AddHours(18).AddMinutes(30), new DateTime(2022, 10, 12).AddHours(20));
            BadetidsPeriode bp2 = new BadetidsPeriode("Morgen badning", DayOfWeek.Wednesday, new DateTime(2022, 10, 11).AddHours(6).AddMinutes(30), new DateTime(2022, 10, 11).AddHours(7).AddMinutes(30));

            Console.WriteLine(bp1);
            Console.WriteLine(bp2);
            #endregion
            #region Test af Add og Slet
            Console.WriteLine("--------------------------------------------------Add of Slet metoder----------------------------------------");

            bp1.AdderKreds(k1);
            bp1.AdderKreds(k2);
            bp1.AdderKreds(k3);
            bp1.AdderKreds(k4);
            bp1.AdderKreds(k5);
            Console.WriteLine("Alle Tilføjet:\n" + bp1);


            bp1.SletKreds("k4");
            bp1.SletKreds("k5");

            Console.WriteLine("Slettet to:\n" + bp1);


            bp2.AdderKreds(k1);
            bp2.AdderKreds(k2);
            bp2.AdderKreds(k3);
            bp2.AdderKreds(k4);
            bp2.AdderKreds(k5);
            Console.WriteLine("Alle Tilføjet:\n" + bp2);
            #endregion

            #region Test af exceptions
            Console.WriteLine("--------------------------------------------------Exceptions----------------------------------------");

            k4.AntalDeltagere = 0;
            k5.AntalDeltagere = 100;

            bp2.Type = "bad";
            bp2.Type = "Badning";
            bp2.StartTidspunkt = new DateTime().AddHours(21);
            bp2.StartTidspunkt = new DateTime().AddHours(17);
            bp2.SlutTidspunkt = new DateTime().AddHours(21);
            bp2.StartTidspunkt = new DateTime().AddHours(16);
            bp2.StartTidspunkt = new DateTime().AddHours(18);

            Console.WriteLine(bp2);

            Console.WriteLine(k6);
            BadetidsPeriode bp3 = new BadetidsPeriode("bad", DayOfWeek.Friday, new DateTime(2022, 10, 10).AddHours(12), new DateTime(2022, 10, 10).AddHours(11));
            Console.WriteLine(bp3);
            #endregion

            #region BadetidPeriodeForLoop

            Console.WriteLine("---------------------------------------------------BadetidsPeriodeForLoopAndList--------------------------------------");
            BadetidsPeriodeForLoopAndList bpf = new BadetidsPeriodeForLoopAndList("Middags badning", DayOfWeek.Monday, new DateTime(2022, 08, 10).AddHours(12), new DateTime(2022, 08, 10).AddHours(13).AddMinutes(30));
            Console.WriteLine(bpf);
            bpf.AdderKreds(k1);
            bpf.AdderKreds(k2);
            bpf.AdderKreds(k3);
            bpf.AdderKreds(k4);
            bpf.AdderKreds(k5);
            Console.WriteLine(bpf);
            #endregion

            #region Test af user stories
            Console.WriteLine("--------------------------------------------------test af user stories----------------------------------------");

            Kreds k7 = new Kreds("k7", "Ringkøbing Kreds", "Ringkøbing nr 1", 45);
            Kreds k8 = new Kreds("k8", "Risskov", "Risskov nr 1", 45);
            Kreds k9 = new Kreds("k9", "Rude Kreds", "Rude nr 1", 45);
            Kreds k10 = new Kreds("k10", "Rødby Kreds", "Rødby nr 1", 45);
            Kreds k11 = new Kreds("k11", "Rødding Kreds", "Rødding nr 1", 45);
            Kreds k12 = new Kreds("k12", "Ry Kreds", "Ry nr 1", 45);
            Kreds k13 = new Kreds("k13", "Ringe kreds", "Ringe nr 1", 0);

            k1.EditKreds("ka", "nw", "s", 4);
            Console.WriteLine(k1);
            bp2.AdderKreds(k6);
            bp2.AdderKreds(k7);
            bp2.AdderKreds(k8);
            bp2.AdderKreds(k9);
            bp2.AdderKreds(k10); 
            bp2.AdderKreds(k11);
            bp2.AdderKreds(k12);
            bp2.AdderKreds(k13);
            Console.WriteLine(bp2);
            bp2.SletKreds("k8");
            Console.WriteLine(bp2);
            bp2.AdderKreds(k13);
            Console.WriteLine(bp2);

            #endregion



        }
    }
}
