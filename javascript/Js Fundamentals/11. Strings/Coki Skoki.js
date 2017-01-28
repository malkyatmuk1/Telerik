function fun(args) {
	var sum=0;
	var n=+args[0];
	var number;
	for (var i = 1; i<n+1; i++) 
	{

		 number=+args[i];
	
		if (number%2==0) {
			sum=sum+number;
				sum=sum%1024;
			i++;
		}
		else {
			if(i==1) sum=1;
			sum=sum*number;
			sum=sum%1024;
			
		}
			
	}
	console.log(sum);
}