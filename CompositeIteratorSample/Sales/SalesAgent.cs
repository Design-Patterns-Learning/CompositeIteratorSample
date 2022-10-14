using System.Collections;

namespace CompositeIteratorSample.Sales
{
    public class SalesAgent : SalesUnit
    {
        private long _credits;

        public SalesAgent(string agentName) : base(agentName)
        {
        }

        public override long GetCredits() => _credits;

        public override void PayCommission(long amount)
        {
            _credits += amount;
        }

        public override IEnumerator<SalesUnit> GetEnumerator() =>
            new SalesUnitEnumerator(this);
    }
}
