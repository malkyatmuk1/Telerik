function Count(args)
 {
	 var n=+args[0];
	 var numbers=args[1].split(" ");
	 var x=+args[2];
	 var count=0;
	 for (var i = 0; i < n; i++)
	 {
	 	if(+numbers[i]==x) count++;
	 }
	 return count;


}