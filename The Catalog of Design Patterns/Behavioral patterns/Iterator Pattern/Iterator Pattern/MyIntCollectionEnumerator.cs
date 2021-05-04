using System.Collections;

namespace Iterator_Pattern
{
    class MyIntCollectionEnumerator : IEnumerator
    {
        public object Current { get; set; }
        private int position = -1;
        private readonly int[] array;

        public MyIntCollectionEnumerator(int[] array)
        {
            this.array = array;
        }

        public bool MoveNext()
        {
            position++;
            if (position < array.Length)
            {
                Current = array[position];
                return true;
            }
            return false;
        }

        public void Reset()
        {
            position = -1;
        }
    }
}
