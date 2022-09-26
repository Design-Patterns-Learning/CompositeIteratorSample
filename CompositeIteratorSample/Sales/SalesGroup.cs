using System.Collections;

namespace CompositeIteratorSample.Sales
{
    public class SalesGroup : SalesUnit, IEnumerable<SalesUnit>
    {
        public SalesGroup
            (string name, IList<SalesUnit> units) : base(name)
        {
            Units = units;
        }

        public IList<SalesUnit> Units { set; private get; }

        public override long GetCredits() =>
            Units.Sum(c => c.GetCredits());

        public IEnumerator<SalesUnit> GetEnumerator() =>
            new SalesUnitEnumerator(Units.ToArray());

        public override void PayCommission(long amount)
        {
            var shareAmount = amount / Units.Count;

            foreach (var salesUnit in Units)
            {
                salesUnit.PayCommission(shareAmount);
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
