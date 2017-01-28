function max(args) {
	var broi=1,max=1; 
	for (var i = 0; i <args.length-1 ; i++) {
		if(args[i]==args[i+1]) {broi++;}
		else {
			broi=1;
		}
		if(max<broi) max=broi;

	}
	console.log(max);


}