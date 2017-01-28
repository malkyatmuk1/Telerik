function roots(args) {

var a=+args[0],b=+args[1],c=+args[2],d,x;
d=b*b-4*a*c;
if(d<0) console.log("no real roots");
else{
	var x1,x2;
	if(d==0) {x1=(b*(-1))/(2*a);console.log("x1=x2="+x1.toFixed(2));}
	else {
			d=Math.sqrt(d);
			x1=((b*(-1))+d)/(2*a);
			x2=((b*(-1))-d)/(2*a);
	        if(x1>x2){x=x2;x2=x1;x1=x;}
	        console.log("x1="+x1.toFixed(2)+"; "+"x2="+x2.toFixed(2));
		}
			

	}		
}