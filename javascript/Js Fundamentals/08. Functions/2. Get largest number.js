function MaxNumber(args1) 
{
    var args=args1[0].split(" ");
    var max=+args[0];
    var i;
	for( i=1;i<args.length;i++)
	{
	
		if(+args[i]>max)max=+args[i];
	}
    return max;
}