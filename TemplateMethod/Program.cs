namespace TemplateMethod
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
            TestThird();
        }

        /// <summary>
        /// The test third.
        /// </summary>
        private static void TestThird()
        {
            AbstractDataAccess daoCategories = new CategoriesDataAccess();
            daoCategories.Run();
            AbstractDataAccess daoProducts = new ProductsDataAccess();
            daoProducts.Run();

            // Wait for user
            Console.ReadKey();
        }

        /// <summary>
        /// The test second.
        /// </summary>
        private static void TestSecond()
        {
            AbstractClass abstractClassOne = new ClassOne();
            abstractClassOne.TemplateMethod();

            AbstractClass abstractClassTwo = new ClassTwo();
            abstractClassTwo.TemplateMethod();

            // Wait for user
            Console.ReadKey();
        }

        /// <summary>
        /// The test first.
        /// </summary>
        private static void TestFirst()
        {
            AbstractWindow windowDeluxe = new WindowDeluxe();
            windowDeluxe.SetupWindowFace();
            AbstractWindow windowStandard = new WindowStandard();
            windowStandard.SetupWindowFace();
        }
    }
}