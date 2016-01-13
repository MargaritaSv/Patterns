namespace Composite
{
    class Program
    {
        static void Main()
        {
            var god = new GreekGod("Zeus is god of the sky and thunder.");

            var brought = new GreekGod("Hades is his brought(the god of underworld)");
            god.Add(brought);
            brought.Add(new Generation("Hades's child is Furies"));
            brought.Add(new Generation("Hades's child is Dionysus"));
            brought.Add(new Generation("Hades's child is Dionysus"));

            var secondbrought = new GreekGod("Hades is his brought(the god of underworld)");
            god.Add(brought);
            secondbrought.Add(new Generation("Hades's child is Aethusa"));
            secondbrought.Add(new Generation("Hades's child is Triton"));
            secondbrought.Add(new Generation("Hades's child is Mideia"));

            var zeusWive = new GreekGod("Metis - zeus's wive");
            god.Add(zeusWive);
            var firstChils = new GreekGod(" Altena - zeus's child from Metris");
            zeusWive.Add(new Generation("Altena"));

            firstChils.Add(new Generation("Altena child is Erikthonius."));

            var secondZeusWife = new GreekGod("Dione secon wive of Zeus");
            god.Add(secondZeusWife);
            secondZeusWife.Add(new Generation("Aphrodita"));

            god.Display(1);
        }
    }
}
