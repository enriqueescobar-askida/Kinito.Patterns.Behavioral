namespace TemplateMethod
{
    using System;

    /// <summary>
    /// The class two.
    /// </summary>
    public sealed class ClassTwo : AbstractClass
    {
        /// <summary>
        /// The primitive operation 1.
        /// </summary>
        public override void PrimitiveOperation1()
        {
            Console.WriteLine("ClassTwo.PrimitiveOperation1()");
        }

        /// <summary>
        /// The primitive operation 2.
        /// </summary>
        public override void PrimitiveOperation2()
        {
            Console.WriteLine("ClassTwo.PrimitiveOperation2()");
        }
    }
}