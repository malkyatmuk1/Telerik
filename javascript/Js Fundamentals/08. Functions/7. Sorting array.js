function largest(args) {
	var n=+args[0];
	var numbers=args[1].split(' ');
	numbers=numbers.sort(function(a, b) {
  return a - b;
});
	var sort="";
	for (var i = 0; i < n; i++) {

			sort=sort+numbers[i];
			if(i!=n-1) sort=sort+" ";
		}
		return sort;
		
}