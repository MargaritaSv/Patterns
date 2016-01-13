namespace Facada
{
    class Program
    {
        static void Main(string[] args)
        {
            var homeThreatePro = HomeTheater.CreateInstance();
            homeThreatePro.InitHomeSystem();
            homeThreatePro.DisplayAvailableMedia();
            homeThreatePro.Next();
            homeThreatePro.Next();
            homeThreatePro.Previous();
            homeThreatePro.Stop();
        }
    }
}
