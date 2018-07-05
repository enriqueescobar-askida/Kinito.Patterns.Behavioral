namespace Memento
{
    using System;

    /// <summary>
    /// The program.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// The main.
        /// </summary>
        /// <param name="args">
        /// The args.
        /// </param>
        public static void Main(string[] args)
        {
            TestFirst();
            TestSecond();
        }

        /// <summary>
        /// The test second.
        /// </summary>
        private static void TestSecond()
        {
            Originator originator = new Originator { State = "On" };

            // Store internal state
            Caretaker caretaker =
                new Caretaker { AnotherMemento = originator.CreateAnotherMemento() };

            // Continue changing originator
            originator.State = "Off";

            // Restore saved state
            originator.SetAnotherMemento(caretaker.AnotherMemento);

            // Wait for user
            Console.ReadKey();
        }

        /// <summary>
        /// The test first.
        /// </summary>
        private static void TestFirst()
        {
            SalesProspect salesProspect = new SalesProspect
                {
                    Name = "Noel van Halen",
                    Phone = "(412) 256-0990",
                    Budget = 25000.0
                };

            // Store internal state
            ProspectMemory prospectMemory =
                new ProspectMemory { Memento = salesProspect.SaveMemento() };

            // Continue changing originator
            salesProspect.Name = "Leo Welch";
            salesProspect.Phone = "(310) 209-7111";
            salesProspect.Budget = 1000000.0;

            // Restore saved state
            salesProspect.RestoreMemento(prospectMemory.Memento);

            // Wait for user
            Console.ReadKey();
        }
    }
}