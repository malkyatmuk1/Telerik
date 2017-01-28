function mmsa(args)
{   var a=+args[0],min,max,sum=0,avrg,b,count=0;
min=a;
max=a;
sum=sum+a;
	for(var i=1;i<args.length;i++)
	{
		b=+args[i];
		if(b>max) max=b;
		if(min>b) min=b;
		sum=sum+b;
		count=i;

	}
	
	avrg=sum/(count+1);
	console.log("min="+min.toFixed(2));
	console.log("max="+max.toFixed(2));
	console.log("sum="+sum.toFixed(2));
	console.log("avg="+avrg.toFixed(2));
}