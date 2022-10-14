using CompositeIteratorSample.Sales;

namespace CompositeIteratorUnitTest
{
    public class UnitTest1
    {
        [Fact]
        public void SalesUnit_Test()
        {
            var unit =
                new SalesUnitBuilder()
                    .WithGroup(g => g.GroupNamed("g1")
                        .WithMember(m => m.MemberNamed("m1"))
                        .WithMember(m => m.MemberNamed("m2")))
                    .Build();

            unit.PayCommission(5000);

            foreach (var member in unit)
            {
                var name = member.Name;
                var credits = member.GetCredits();
            }
        }
    }
}