function maxinc(args) {


var broi=1,max=1;
	for (var i = 0; i < args.length; i++) {
		var numeber1=+args[i];
		var numeber2=+args[i+1];
		if(numeber1<numeber2) broi++;
		else broi=1;
		if(broi>max) max=broi;

	}
console.log(max);
}