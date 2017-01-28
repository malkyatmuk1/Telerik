function function_name(args) {
	var str=args[1].toLowerCase();
	var found=args[0].toLowerCase();
	return str.split(found).length-1;
}