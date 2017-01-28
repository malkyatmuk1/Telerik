function frec(args) {

var time=0,max=0,chislo,minchislo;
for(var i=1;i<args.length;i++)
{
	for (var j = 1; j < args.length ;j++) {

		if(args[j]==args[i]) time++;

		if(max<time){minchislo=args[i];max=time;}

	}
	time=0;

}
console.log(minchislo+ " ("+max+" times)");
}