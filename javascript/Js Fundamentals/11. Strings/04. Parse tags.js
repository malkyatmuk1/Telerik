function function_name(args) {
	var str=args[0];
	var a=1;
		str=str.replace(/<orgcase>/g,'');
		str=str.replace(/<\/orgcase>/g,'');
		//str=str.replace(/<upcase>/g,"<upcase>".toUpperCase());
	//	str=str.replace(/<\/upcase>/g,"<\/upcase>".toUpperCase());
	//	str=str.replace(/<lowcase>/g,"<lowcase>".toUpperCase());
	//	str=str.replace(/<\/lowcase>/g,"<\/lowcase>".toUpperCase());
	while(a!=-1)
	{
		
		a=str.indexOf("<");
		if(a<0) break;
		if( str.substr(a+1,1)=="U") {
			var b=str.indexOf("</u");
			var strrep=str.substring(a+8,b);
			
			var duma=strrep.toUpperCase();
			duma=duma.replace("<lowcase>",'');
			duma=duma.replace("</lowcase>",'');
			str=str.replace(strrep,duma);
			str=str.replace("<UPCASE>",'');
			str=str.replace("</UPCASE>",'');
			
			
		}
		else {
			var b=str.indexOf("</l");
			var strrep1=str.substring(a+9,b);
			var dumai=strrep1.toLowerCase();
			dumai=dumai.replace("<upcase>",'');
			dumai=dumai.replace("</upcase>",'');
			str=str.replace(strrep1,dumai);
			str=str.replace("<lowcase>",'');
			str=str.replace("</lowcase>",'');
			
		}
	}
	return str;
}
