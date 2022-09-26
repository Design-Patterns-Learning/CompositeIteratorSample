using System.Collections;

namespace CompositeIteratorSample.Sales
{
    public class SalesUnitEnumerator : IEnumerator<SalesUnit>
    {
        private readonly SalesUnit[] _salesUnits;
        private int _index;
        private SalesUnit _current;

        public SalesUnitEnumerator(params SalesUnit[] salesUnits)
        {
            _salesUnits = salesUnits;
        }

        public SalesUnit Current => _current;

        object IEnumerator.Current => Current;

        public void Dispose()
        {
            _current = default;
            _index = 0;
        }

        public bool MoveNext()
        {
            if (_index < _salesUnits.Length)
            {
                _current = _salesUnits[_index];
                _index++;

                return true;
            }

            return false;
        }

        public void Reset()
        {
            _current = default;
            _index = 0;
        }
    }
}
