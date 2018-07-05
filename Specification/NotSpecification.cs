namespace Specification
{
    /// <summary>
    /// The not specification.
    /// </summary>
    /// <typeparam name="TEntity">
    /// </typeparam>
    public class NotSpecification<TEntity> : ISpecification<TEntity>
    {
        /// <summary>
        /// Gets the wrapped.
        /// </summary>
        public ISpecification<TEntity> Wrapped { get; internal set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="NotSpecification{TEntity}"/> class.
        /// </summary>
        /// <param name="x">
        /// The x.
        /// </param>
        public NotSpecification(ISpecification<TEntity> x)
        {
            this.Wrapped = x;
        }

        /// <summary>
        /// The is satisfied by.
        /// </summary>
        /// <param name="candidate">
        /// The candidate.
        /// </param>
        /// <returns>
        /// The <see cref="bool"/>.
        /// </returns>
        public bool IsSatisfiedBy(TEntity candidate)
        {
            return !this.Wrapped.IsSatisfiedBy(candidate);
        }
    }
}