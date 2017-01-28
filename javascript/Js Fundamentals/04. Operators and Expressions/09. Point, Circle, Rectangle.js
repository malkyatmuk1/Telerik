function point(arsg)
{
	var flagcircleout=0,flagrectangleout=0;
	var r=0,x=+arsg[0]-1,y=+arsg[1]-1,x1=+arsg[0],y1=+arsg[1];
	r=Math.sqrt(x*x+y*y);
	if(r>1.5) flagcircleout=1;
	if(x1>6|| x1<-1) flagrectangleout=1;
	else if(y1<-1 || y1>1) flagrectangleout=1;
	if(flagrectangleout==1 && flagcircleout==1) console.log("outside circle outside rectangle");
	else if(flagrectangleout==0 && flagcircleout==0 ) console.log("inside circle inside rectangle");
	else if(flagrectangleout==1 && flagcircleout==0) console.log("inside circle outside rectangle");
	else console.log("outside circle inside rectangle")
}