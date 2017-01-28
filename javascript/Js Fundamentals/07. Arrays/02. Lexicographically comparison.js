function lexico(args) {
	var first=args[0];
	var second=args[1];
	var br=0;

	var min=first.length;
	var se=second.length;
	if(se<min)min=se;
		for(var i=0;i<min; i++)
	{
		if(first[i].charCodeAt()!=second[i].charCodeAt())
		{
			if(first[i].charCodeAt()<second[i].charCodeAt()){br++;console.log("<");break;}
			else {br++;console.log(">");break;}
		}
		
	}
	if(br==0) {
		if(first.length==second.length) console.log("=");
		if(first.length<second.length) console.log("<");
		if(first.length>second.length) console.log(">");
	}
           