function yongestPerson(args) {
    var lines= [3];
    var x1,x2,y1,y2;
var br=0;
    for (var i = 0; i < args.length;i=i+4) {
       for (var j = 0; j < 4; j++) {
           if(j==0) x1=+args[i+j];
        
           if(j==1) y1=+args[i+j];
           if(j==2) x2=+args[i+j];
           if(j==3) y2=+args[i+j];
       }
    lines[br]=Math.sqrt(Math.pow(Math.abs((x1-x2)),2)+Math.pow(Math.abs((y1-y2)),2));
    ;br++; 
   }
        for (var i = 0; i < 3; i++) {

            console.log(lines[i].toFixed(2));
        }
        if((lines[0]+lines[1])>lines[2]&&(lines[0]+lines[2])>lines[1]&& (lines[1]+lines[2])>lines[0]) console.log("Triangle can be built");
        else console.log("Triangle can not be built");
}