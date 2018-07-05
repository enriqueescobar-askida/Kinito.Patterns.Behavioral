namespace Iterator
{
    /// <summary>
    /// The item.
    /// </summary>
    public class Item
    {
        /// <summary>
        /// Gets the name.
        /// </summary>
        public string Name { get; internal set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Item"/> class.
        /// </summary>
        /// <param name="name">
        /// The name.
        /// </param>
        public Item(string name)
        {
            this.Name = name;
        }
    }
}