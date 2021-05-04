using System.Collections;

namespace Iterator_Pattern
{
    class MyIntCollectionReverseEnumerator : IEnumerator
    {
        public object Current { get; set; }
        private int position;
        private readonly int[] array;

        public MyIntCollectionReverseEnumerator(int[] array)
        {
            this.array = array;
            position = array.Length;
        }

        public bool MoveNext()
        {
            position--;
            if (position >= 0)
            {
                Current = array[position];
                return true;
            }
            return false;
        }

        public void Reset()
        {
            position = array.Length;
        }
    }
}
