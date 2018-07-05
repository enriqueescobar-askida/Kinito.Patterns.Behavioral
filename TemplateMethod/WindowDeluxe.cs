namespace TemplateMethod
{
    using System;

    /// <summary>
    /// The window deluxe.
    /// </summary>
    public sealed class WindowDeluxe : AbstractWindow
    {
        /// <summary>
        /// The position label.
        /// </summary>
        public override void PositionLabel()
        {
            Console.WriteLine("center.");
        }
    }
}
