function bits(args)
{
	var number= +args;
	var mask1=1<<3;

var um=mask1&number;
    if(um>0) console.log("1");
    else console.log("0");
}