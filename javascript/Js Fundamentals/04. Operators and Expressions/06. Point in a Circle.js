function circle (args)
{
	var x= +args[0],y= +args[1];
	var r=(x*x+y*y);
	if(Math.sqrt(r)>2) console.log("no "+ Math.sqrt(r).toFixed(2));
	else console.log("yes "+ Math.sqrt(r).toFixed(2));
}