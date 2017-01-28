function sign(args)
{
	var a=+args[0],b=+args[1],c=+args[2],br=0;
	if(a<0 && a!=0) br++;
	if(b<0 && b!=0) br++;
	if(c<0 && c!=0) br++;
	if(a==0 || b==0 || c==0) console.log("0");
	else{
	if(br%2==0) console.log("+");
	if(br%2!=0)console.log("-");
}}