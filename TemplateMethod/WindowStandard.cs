namespace TemplateMethod
{
    using System;

    /// <summary>
    /// The window standard.
    /// </summary>
    public sealed class WindowStandard : AbstractWindow
    {
        /// <summary>
        /// The position label.
        /// </summary>
        public override void PositionLabel()
        {
            Console.WriteLine(".");
        }
    }
}
