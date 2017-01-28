function exchange(args)
{
	var a,b,x;
	a=+args[0];
	b=+args[1];
	if(a>b) {x=b;b=a;a=x;}
	console.log(a+" "+b);
}