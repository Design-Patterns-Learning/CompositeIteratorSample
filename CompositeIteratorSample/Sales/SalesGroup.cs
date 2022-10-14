using System.Collections;

namespace CompositeIteratorSample.Sales
{
    public class SalesGroup : SalesUnit
    {
        public SalesGroup
            (string name, IList<SalesUnit> units) : base(name)
        {
            Units = units;
        }

        public override long GetCredits() =>
            Units.Sum(c => c.GetCredits());

        public override IEnumerator<SalesUnit> GetEnumerator() =>
            new SalesUnitEnumerator(this);

        public override void PayCommission(long amount)
        {
            var shareAmount = amount / Units.Count;

            foreach (var salesUnit in Units)
            {
                salesUnit.PayCommission(shareAmount);
            }
        }
    }
}
