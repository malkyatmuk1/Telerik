function third(args)
{
	var n=args[0];
if(n.length<3) console.log("false 0");
else{
	if(n[n.length-3]=="7") console.log("true");
	else console.log("false "+ n[n.length-3]);
}
}