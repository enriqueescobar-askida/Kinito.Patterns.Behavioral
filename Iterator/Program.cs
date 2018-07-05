namespace Iterator
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
            // Build a collection
            Collection collection = new Collection();
            collection[0] = new Item("Item 0");
            collection[1] = new Item("Item 1");
            collection[2] = new Item("Item 2");
            collection[3] = new Item("Item 3");
            collection[4] = new Item("Item 4");
            collection[5] = new Item("Item 5");
            collection[6] = new Item("Item 6");
            collection[7] = new Item("Item 7");
            collection[8] = new Item("Item 8");

            // Create iterator
            Iterator iterator = new Iterator(collection);

            // Skip every other item
            iterator.Step = 2;
            Console.WriteLine("Iterating over collection:");

            for (Item item = iterator.First(); !iterator.IsDone; item = iterator.Next())
                Console.WriteLine(item.Name);

            // Wait for user
            Console.ReadKey();
        }

        /// <summary>
        /// The test first.
        /// </summary>
        private static void TestFirst()
        {
            ConcreteAggregate concreteAggregate = new ConcreteAggregate();
            concreteAggregate[0] = "Item A";
            concreteAggregate[1] = "Item B";
            concreteAggregate[2] = "Item C";
            concreteAggregate[3] = "Item D";

            // Create Iterator and provide aggregate
            ConcreteIterator concreteIterator = new ConcreteIterator(concreteAggregate);
            Console.WriteLine("Iterating over collection:");
            object item = concreteIterator.First();
            while (item != null)
            {
                Console.WriteLine(item);
                item = concreteIterator.Next();
            }

            // Wait for user
            Console.ReadKey();
        }
    }
}