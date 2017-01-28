function matrix(args) {
	var n=+args[0],br=0,result="";
	for(var j=0;j<n;j++)
	{
		br=j+1;
	for(var i=0;i<n;i++)
	{
	
		result=result+br;
		if(i<n-1) result=result+" ";
		br++;

	}
	console.log(result);
	result="";


}



}