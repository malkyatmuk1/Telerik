function prime(args)
{
	var n=+args[0];
	var max=1;
	if(n==1){max=1;return max;}
	if(n==2){max=2;return max;}
	max=3;
	var br=0;
	
		for (var j = n; j >=7; j--) 
		{	
		
		for (var i = 2; i <=  Math.ceil(Math.sqrt(j)); i++)
                {
                    if (j % i == 0) br++;
                }
                if(br==0) {max=j;return max;}
                br=0;
         }

                
}