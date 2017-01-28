function biggest(args)
{
	var a=+args[0],b=+args[1],c=+args[2],max=a;
	if(max<b) max=b;
	if(max<c)max=c;
	console.log(max);
}