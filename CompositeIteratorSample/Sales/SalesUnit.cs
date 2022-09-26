using System.Collections;

namespace CompositeIteratorSample.Sales
{
    public abstract class SalesUnit
    {
        protected SalesUnit(string name)
        {
            Name = name;
        }

        public string Name { get; private set; }
        public abstract void PayCommission(long amount);
        public abstract long GetCredits();
    }
}
