function bzk(args) {
	var a=args[0];
	var text="";
	var flag=0;
	if(a.length==1)
	{
		switch (a[0]){
		case '1': text=text+"One";break;
		case '0': text=text+"Zero";break;
		case '2': text=text+"Two";break;
		case '3': text=text+"Three";break;
		case '4': text=text+"Four";break;
		case '5': text=text+"Five";break;
		case '7': text=text+"Seven";break;
		case '6': text=text+"Six";break;
		case '8': text=text+"Eight";break;
		case '9': text=text+"Nine";break;
'	'	}
	}

	 if(a.length==2)

	{	
		if(a[0]=='1') {
		switch (a[1]){
		case '1': text=text+"Eleven";break;
		case '2': text=text+"Twelve";break;
		case '3': text=text+"Thirteen";break;
		case '4': text=text+"Fourteen";break;
		case '5': text=text+"Fifteen";break;
		case '6': text=text+"Sixteen";break;
		case '7': text=text+"Seventeen";break;
		case '8': text=text+"Eighteen";break;
		case '9': text=text+"Nineteen";break;
		case '0': text=text+"Ten";break;
		
			}
		}
		else if (a[0]!='1')
		{	

			switch (a[0]){
		case '2': text=text+"Twenty";break;
		case '3': text=text+"Thirty";break;
		case '4': text=text+"Forty";break;
		case '5': text=text+"Fifty";break;
		case '6': text=text+"Sixty";break;
		case '7': text=text+"Seventy";break;
		case '8': text=text+"Eighty";break;
		case '9': text=text+"Ninety";break;
					}
		 switch (a[1]){
		case '1': text=text+" one";break;
		case '2': text=text+" two";break;
		case '3': text=text+" three";break;
		case '4': text=text+" four";break;
		case '5': text=text+" five";break;
		case '6': text=text+" six";break;
		case '7': text=text+" seven";break;
		case '8': text=text+" eight";break;
		case '9': text=text+" nine";break;
		
			}
		}
	}



		else if(a.length==3) {
			
					switch (a[0]){
		case '1': text=text+"One hundred";break;
		case '2': text=text+"Two hundred";break;
		case '3': text=text+"Three hundred";break;
		case '4': text=text+"Four hundred";break;
		case '5': text=text+"Five hundred";break;
		case '6': text=text+"Six hundred";break;
		case '7': text=text+"Seven hundred";break;
		case '8': text=text+"Eight hundred";break;
		case '9': text=text+"Nine hundred";break;
		}
			if(a[1]!=0) {text=text+" ";

				switch (a[1]){
		case '1':{
			switch (a[2]){
			case '1': text=text+"and eleven";break;
		case '2': text=text+"and twelve";break;
		case '3': text=text+"and thirteen";break;
		case '4': text=text+"and fourteen";break;
		case '5': text=text+"and fifteen";break;
		case '6': text=text+"and sixteen";break;
		case '7': text=text+"and seventeen";break;
		case '8': text=text+"and eighteen";break;
		case '9': text=text+"and nineteen";break;
		case '0': text=text+"and ten";break;
		
			}
			flag=1;
			break;
		}
		case '2': text=text+"and twenty";break;
		case '3': text=text+"and thirty";break;
		case '4': text=text+"and forty";break;
		case '5': text=text+"and fifty";break;
		case '6': text=text+"and sixty";break;
		case '7': text=text+"and seventy";break;
		case '8': text=text+"and eighty";break;
		case '9': text=text+"and ninety";break;
					}

		if(flag!=1){
		
			switch (a[2]){
		case '1': text=text+" one";break;
		case '2': text=text+" two";break;
		case '3': text=text+" three";break;
		case '4': text=text+" four";break;
		case '5': text=text+" five";break;
		case '6': text=text+" six";break;
		case '7': text=text+" seven";break;
		case '8': text=text+" eight";break;
		case '9': text=text+" nine";break;
		
			}}}
			else{
				switch (a[2]){
		case '1': text=text+" and one";break;
		case '2': text=text+" and two";break;
		case '3': text=text+" and three";break;
		case '4': text=text+" and four";break;
		case '5': text=text+" and five";break;
		case '6': text=text+" and six";break;
		case '7': text=text+" and seven";break;
		case '8': text=text+" and eight";break;
		case '9': text=text+" and nine";break;
			}
		}
		
		

			
	
	}
	if(text=="") console.log("not a digit");
	else console.log(text);




}
	