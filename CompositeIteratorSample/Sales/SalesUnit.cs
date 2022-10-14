using System.Collections;

namespace CompositeIteratorSample.Sales
{
    public abstract class SalesUnit: IEnumerable<SalesUnit>
    {
        protected SalesUnit(string name)
        {
            Name = name;
            Units = new List<SalesUnit>();
        }

        public string Name { get; private set; }
        public abstract void PayCommission(long amount);
        public abstract long GetCredits();
        public IList<SalesUnit> Units { get; protected set; }
        public abstract IEnumerator<SalesUnit> GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
