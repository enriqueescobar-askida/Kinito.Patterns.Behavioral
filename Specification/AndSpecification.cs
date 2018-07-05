namespace Specification
{
    /// <summary>
    /// The and specification.
    /// </summary>
    /// <typeparam name="TEntity">
    /// </typeparam>
    public class AndSpecification<TEntity> : ISpecification<TEntity>
    {
        /// <summary>
        /// Gets the spec 1.
        /// </summary>
        public ISpecification<TEntity> Spec1 { get; internal set; }

        /// <summary>
        /// Gets the spec 2.
        /// </summary>
        public ISpecification<TEntity> Spec2 { get; internal set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="AndSpecification{TEntity}"/> class.
        /// </summary>
        /// <param name="s1">
        /// The s 1.
        /// </param>
        /// <param name="s2">
        /// The s 2.
        /// </param>
        public AndSpecification(ISpecification<TEntity> s1, ISpecification<TEntity> s2)
        {
            this.Spec1 = s1;
            this.Spec2 = s2;
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
            return this.Spec1.IsSatisfiedBy(candidate) && this.Spec2.IsSatisfiedBy(candidate);
        }
    }
}