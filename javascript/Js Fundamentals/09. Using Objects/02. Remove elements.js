function yongestPerson(args) {
    var first=args[0];
    for (var i = 0; i < args.length; i++) {
       if(args[i]==first) {args.splice( i, 1 );i--;}

    }
    
    for (var i = 0; i < args.length; i++) {
        console.log(args[i]);
    }
}