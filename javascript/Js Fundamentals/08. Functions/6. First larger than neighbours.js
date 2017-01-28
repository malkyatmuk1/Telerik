function largest(args) {
	var n=+args[0];
	var numbers=args[1].split(' ');
		for (var i = 0; i < n-1; i++) {

		if(+numbers[i+1]>+numbers[i] && +numbers[i+1]>+numbers[i+2]) {return i+1;}
	}
	return -1;
}