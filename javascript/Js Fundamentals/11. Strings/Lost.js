function fun(args) {
	let a=args[0];
	var rc=a.split(' ');
	let row=+rc[0];
	let col=+rc[1];
	let b=args[1];
	var vurvi;
	var numbers=b.split(' ');
	var bit0,bit1,bit2,bit3;
	var s;
	
	var matrix=[];
	for (var i = 0; i < row; i++) {
		
		var mej=args[i+1];
		s=mej.split(' ');
		matrix.push([]);
		for (var j = 0; j < col; j++) {
			
			matrix[i][j]=s[j];
			//return matrix[i][j];
		
		}
	
	}
	
	var startr=row>>1;
	var startc=col>>1;
	
	var bit;
	var k=0;
	while(k!=5)
	{
		bit0=(+matrix[startr][startc])&1;
	
		bit1=(+matrix[startr][startc])&2;
		
		bit2=(+matrix[startr][startc])&4;

		bit3=(+matrix[startr][startc])&8;

		if(bit0!=0)vurvi=1;
		else if(bit1!=0)vurvi=2;
		else if(bit2!=0)vurvi=4;
		else if(bit3!=0)vurvi=3;
		//console.log(matrix[startr][startc]+vurvi);
		if(matrix[startr][startc]!='0')
		{
			console.log(startr+" "+startc);
			if(vurvi==1 ) {matrix[startr][startc]=='0';startr--;}
			else if(vurvi==2) {matrix[startr][startc]=='0';startc++;}
			else if(vurvi==3) {matrix[startr][startc]=='0';startc--;}
			else  {matrix[startr][startc]=='0';startr++;}
			
		}
		
	if(startc==0 || startr==0) return `No rakiya, only JavaScript ${startr} ${startc}`;
	k++;
		}
		
	
}