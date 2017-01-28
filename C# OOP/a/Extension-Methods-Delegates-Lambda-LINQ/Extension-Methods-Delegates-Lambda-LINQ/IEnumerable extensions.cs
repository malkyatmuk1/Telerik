namespace Extension_Methods_Delegates_Lambda_LINQ
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public static class IEnumerable_extensions
    {

        public static T Sum<T>(this IEnumerable<T> items) 
        {

            T sum = (dynamic)0;
            foreach (var item in items)
            {
                sum = (dynamic)sum + item;
            }

            return sum;
        }
        public static T Max<T>(this IEnumerable<T> items) {
            T max = items.First();
            foreach (var item in items)
	        {
		        if((dynamic)max<item) max=item;
	        }
            return max;
        }

        public static T Minus<T>(this IEnumerable<T> items) 
        {
            T min = items.First();
            foreach (var item in items)
	        {
		        if((dynamic)min>item) min=item;
	        }
            return min;
        }
        public static T Product<T>(this IEnumerable<T> items) 
        {
            T product=(dynamic) 1;
            foreach (var item in items)
            {
                product=(dynamic)product*item;
            }
	       return product;    
        }

        public static T Avarage<T>(this IEnumerable<T> items) 
        {
            T sum = items.Sum();
            T av = (dynamic)sum / items.Count();
            return av;
        }
}
    }
