namespace Facada
{
    public class InterControler
    {
        public void DimLights(int amount)
        {
            int desiredAmount = amount;
            if (desiredAmount < 0)
            {
                desiredAmount = 0;
            }

            if (desiredAmount > 100)
            {
                desiredAmount = 100;
            }

            System.Console.WriteLine($"Dimming lights to {desiredAmount} ...");
        }

        public void MoveCurtains(int amount)
        {
            int desiredAmount = amount;
            if (desiredAmount < 0)
            {
                desiredAmount = 0;
            }

            if (desiredAmount > 100)
            {
                desiredAmount = 100;
            }

            System.Console.WriteLine($"Moving curtains lights to {desiredAmount} ...");
        }

        public void HideTable()
        {
            System.Console.WriteLine("Hiding the table...");
        }
    }
}