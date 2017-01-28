function sort(args) {
	var a=+args[0],b=+args[1],c=+args[2],x;

	if(a>b){x=b;b=a;a=x;}
	if(a>c){x=c;c=a;a=x;}
	if(b>c){x=c;c=b;b=x;}
	
	console.log(c+" "+b+" "+a);
}