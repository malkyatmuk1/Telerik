namespace Defining_Classes___Part_2
{
    using System;
    using System.Text;

    class GenericList<T> where T : IComparable, IEquatable<T>
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
            if (count == capas) Resize();
            elements[count] = element;            
        }
        public void Remove(int index)
        {
            for(int i = index; i < elements.Length-1; i++)
            {
                this.elements[i] = this.elements[i + 1];
            }
            this.count--;
        }
        public void Insert(T element,int position)
        {
            T el=element;
            T el2 = elements[position];
            if (this.count+2 == elements.Length ) Resize();
            for(int i = position ; i <elements.Length-1;)
            {
                
                elements[i] = el;
                el = el2;
                i++;
                el2 = elements[i];
                         
                
                
            }
            this.count++;
        }
        private void Resize()
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
                if ((min.CompareTo(elements[i])) > 0 &&  (object)elements[i]!=null) min = elements[i];

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

               if (!Equals(elements[i], default(T))) stroitel.Append(this.elements[i]);
               if (i != elements.Length - 1) { if (!Equals(elements[i], default(T)) && !Equals(elements[i + 1], default(T))) stroitel.AppendLine(); }
            }
            return stroitel.ToString();

        }

        
    }
}
