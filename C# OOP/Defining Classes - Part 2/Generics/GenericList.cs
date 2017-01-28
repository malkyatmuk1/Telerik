namespace Defining_Classes___Part_2
{
    using System;
    using System.Text;

    class GenericList<T> where T: IComparable
    {
        private T[] elements;
        private int count = -1;
        public int capas;
        public GenericList(int capacity)
        {            
            elements = new T[capacity];
            capas = capacity;
        }
        public T this[int index]
        {
            get
            {
                return elements[index];
            }

            set
            {
                if(index < 0 || index >= elements.Length) throw new IndexOutOfRangeException();
                else elements[index] = value;
            }
         }
        public void Add(T element)
        {
            this.count++;
            elements[count] = element;            
        }
        public void Remove(int index)
        {
            for(int i = index; i < elements.Length; i++)
            {
                this.elements[i] = this.elements[i + 1];
            }
            this.count--;
        }
        public void Insert(T element,int position)
        {
            T el=elements[position];
            T el2 = elements[position + 1];
            if (this.count == elements.Length - 1) Resize();
            for(int i = position ; i < elements.Length; i++)
            {

                elements[i] = el;
                el = el2;
                el2 = elements[i + 1];
                
                
            }
        }
        public void Resize()
        {
            T[] newEelements = new T[elements.Length* 2];
            for(int i=0;i<elements.Length;i++)
            {
                newEelements[i] = elements[i];
            }

            this.elements = newEelements;
        }
        public void Clear()
        { 
            for(int i=0;i<elements.Length;i++)
            {
                elements[i]=default(T);
            }
        }
        public int Find(T value)
        {
            int index=-1;
            for(int i=0;i<elements.Length;i++)
            {
                if ((value.CompareTo(elements[i])) == 0) { index = i; break; }

            }
            return index;
        }
        public T Min()
        {
            T min = elements[0];
            for(int i=0;i<elements.Length;i++)
            {
                if ((min.CompareTo(elements[i])) > 0) min = elements[i];

            }
            return min;   
        }
        public T Max()
        {
            T max = elements[0];
            for (int i = 0; i < elements.Length; i++)
            {
                if ((max.CompareTo(elements[i])) < 0) max = elements[i];

            }
            return max;   
        }
        public override string ToString()
        {
            StringBuilder stroitel = new StringBuilder();
            for (int i = 0; i < elements.Length; i++ )
            {
                stroitel.Append(this.elements[i]).Append(" ");
            }
            return stroitel.ToString();

        }

        
    }
}
