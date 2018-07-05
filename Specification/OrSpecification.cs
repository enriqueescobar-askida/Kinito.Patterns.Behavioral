namespace Specification
{
    public class OrSpecification<TEntity> : ISpecification<TEntity>
    {
        public ISpecification<TEntity> Spec1 { get; internal set; }
        public ISpecification<TEntity> Spec2 { get; internal set; }

        public OrSpecification(ISpecification<TEntity> s1, ISpecification<TEntity> s2)
        {
            this.Spec1 = s1;
            this.Spec2 = s2;
        }

        public bool IsSatisfiedBy(TEntity candidate)
        {
            return this.Spec1.IsSatisfiedBy(candidate) || this.Spec2.IsSatisfiedBy(candidate);
        }
    }
}