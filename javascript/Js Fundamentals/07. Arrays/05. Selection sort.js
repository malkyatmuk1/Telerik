function selection(args) {

var min,br=2,b,n=+args[0];
var number1,number2;
 	for(var j=1;j<n;j++)
            {
                for(var i=br;i<n+1;i++)
                {
                	number1=+args[j];
                	number2=+args[i];
                    if (number1 > number2) { b = args[i]; args[i] = args[j]; args[j] = b; }
                }
                br++;
            }
            for (var i = 1;i<args.length; i++) {
            	console.log(args[i]);
        
            }

}
