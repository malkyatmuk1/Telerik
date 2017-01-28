namespace Problem_3.Range_Exceptions
{   using System;
    using System.Text;
    class InvalidRangeException<T> : ApplicationException
    {
        public T Start { get; private set; }
        public T End { get; private set; }
        public InvalidRangeException(T start,T end)
        {
            this.Start = start;
            this.End = end;
        }
    public override string Message
    {
        get { return string.Format("Out of the  range [{0} - {1}]", this.Start, this.End); }
    }


    }
}
