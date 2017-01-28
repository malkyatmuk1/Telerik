function Breakets(args) {
	var str=args[0];
	var br=0;
	if(str.split("(").length-1>str.split(")").length-1 || str.split("(").length-1<str.split(")").length-1)return "Incorect";
	else
	{
		if(str.indexOf(")")==0 || str.indexOf("(")==0) return "Incorect";
		else return "Corect";
	}

}