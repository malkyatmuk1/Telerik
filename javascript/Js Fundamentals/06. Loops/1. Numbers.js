function present(args) {

    var number=+args[0],text="";

    for (var i =1; i <=number; i++) {

text=text+i;

if(i<number) text=text+" ";

    }

console.log(text);

}
