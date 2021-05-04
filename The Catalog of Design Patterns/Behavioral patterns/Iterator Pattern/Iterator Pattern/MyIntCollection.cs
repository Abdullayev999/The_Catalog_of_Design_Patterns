using System.Collections;

namespace Iterator_Pattern
{
    class MyIntCollection : IEnumerable
    {
        private int[] array;

        public MyIntCollection(params int[] numbers)
        {
            array = numbers;
        }

        public int this[int index]
        {
            get => array[index];
            set => array[index] = value;
        }

        public IEnumerator GetEnumerator()
        {
            return new MyIntCollectionReverseEnumerator(this.array);
        }
    }
}
