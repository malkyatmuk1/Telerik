namespace StringBuilderExpresion
{
    using System.Text;
 
    public static class StringBuilderExtensions
    {
       public static  StringBuilder Substring(this StringBuilder str , int startIndex, int length)
        {
           var theOutput = new StringBuilder();

            if (startIndex < 0) startIndex = 0;
            if (length > str.Length || length + startIndex  > str.Length)
            {
                length = str.Length - startIndex;
            }
           for (int i = startIndex; i < length; i++)
			{
                theOutput = theOutput.Append(str[i]);
			 
			}
           

            return theOutput.AppendLine();

        }



    }
}
