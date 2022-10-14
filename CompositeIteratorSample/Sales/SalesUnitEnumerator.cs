using System.Collections;

namespace CompositeIteratorSample.Sales
{
    public class SalesUnitEnumerator : IEnumerator<SalesUnit>
    {
        private Queue<SalesUnit> _salesUnits = new Queue<SalesUnit>();
        private SalesUnit _current;

        public SalesUnitEnumerator(SalesUnit unit)
        {
            _salesUnits.Enqueue(unit);
        }

        public SalesUnit Current => _current;

        object IEnumerator.Current => Current;

        public void Dispose()
        {
            _current = default;
        }

        public bool MoveNext()
        {
            if (_salesUnits.Any())
            {
                _current = _salesUnits.Dequeue();
                foreach (var item in _current.Units)
                {
                    _salesUnits.Enqueue(item);
                }

                return true;
            }

            return false;
        }

        public void Reset()
        {
            _current = default;
        }
    }
}
