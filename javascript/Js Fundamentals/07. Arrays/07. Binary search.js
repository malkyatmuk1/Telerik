function binar(args) {
	 var n=+args[0];

	 var x=+args[args.length-1];

	 var numbers=[n];
	 var br=0;
	for (var i = 0; i < n; i++) {
		numbers[i]=+args[i+1];
	}
	numbers=numbers.sort(function(a, b) {
  return a - b;
});
	var left=0;
	var right=n-1;
	var middle;
	while(left<=right)
	{
		 middle=left+right;
		middle=middle>>1;
			
		if(numbers[middle]===x){console.log(middle);br++;break;}
		else if(numbers[middle]>x) right=middle-1;
		else left=middle+1;

	}
	if(br==0) console.log("-1");


}