namespace TemplateMethod
{
    using System;

    /// <summary>
    /// The abstract class.
    /// </summary>
    public abstract class AbstractClass
    {
        /// <summary>
        /// The primitive operation 1.
        /// </summary>
        public abstract void PrimitiveOperation1();

        /// <summary>
        /// Primitives the operation2.
        /// </summary>
        public abstract void PrimitiveOperation2();

        /// <summary>
        /// Templates the method.
        /// </summary>
        public void TemplateMethod()
        {
            this.PrimitiveOperation1();
            this.PrimitiveOperation2();
            Console.WriteLine("");
        }
    }
}