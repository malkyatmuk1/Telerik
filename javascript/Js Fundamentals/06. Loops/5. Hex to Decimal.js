function hex(args) {
		var string=args[0],sum=0,number,stepen=string.length-1;
		for(var i=0;i<string.length;i++)
		{
			
			if(string[i]=='A') sum=sum+10*Math.pow(16,stepen);
			else if(string[i]=='B') sum=sum+11*Math.pow(16,stepen);
			else if(string[i]=='C') sum=sum+12*Math.pow(16,stepen);
			else if(string[i]=='D') sum=sum+13*Math.pow(16,stepen);
			else if(string[i]=='E') sum=sum+14*Math.pow(16,stepen);
			else if(string[i]=='F') sum=sum+15*Math.pow(16,stepen);
			else sum=sum+parseInt(string[i])*Math.pow(16,stepen);
			stepen--;
		}
		console.log(sum);
}