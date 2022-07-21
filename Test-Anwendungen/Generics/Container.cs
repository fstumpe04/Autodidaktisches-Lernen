namespace Generics
{
    class Container<T>
    {
        private T[] meinArray;
        public T[] MeinArray 
        {
            get => meinArray; 
            set 
            {
                meinArray = BubbleSort(value); 
            }
        }
        public Container(T[] meinArray)
        {
            MeinArray = meinArray;
        }
        private T[] BubbleSort(T[] elements)
        {
            int n = elements.Length;
            T help;
            bool isSwaped;
            do
            {
                isSwaped = false;
                for (int i = 0; i < n; i++)
                {
                    if (elements[i] > (Integer)elements[i + 1])
                    {
                        help = elements[i];
                        elements[i] = elements[i + 1];
                        elements[i + 1] = help;
                        isSwaped = true;
                    }
                    n--;
                }
            } while (isSwaped && n > 0);
            return elements;
        }
    }
}