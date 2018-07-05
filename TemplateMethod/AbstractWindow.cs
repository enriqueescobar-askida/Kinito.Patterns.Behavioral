namespace TemplateMethod
{
    /// <summary>
    /// The abstract window.
    /// </summary>
    public abstract class AbstractWindow
    {
        /// <summary>
        /// The position label.
        /// </summary>
        public abstract void PositionLabel();

        /// <summary>
        /// Setups the window face.
        /// </summary>
        public void SetupWindowFace()
        {
            this.PositionLabel();
        }
    }
}
