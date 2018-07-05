namespace TemplateMethod
{
    using System;

    /// <summary>
    /// The class one.
    /// </summary>
    public sealed class ClassOne : AbstractClass
    {
        /// <summary>
        /// The primitive operation 1.
        /// </summary>
        public override void PrimitiveOperation1()
        {
            Console.WriteLine("ClassOne.PrimitiveOperation1()");
        }

        /// <summary>
        /// The primitive operation 2.
        /// </summary>
        public override void PrimitiveOperation2()
        {
            Console.WriteLine("ClassOne.PrimitiveOperation2()");
        }
    }
}