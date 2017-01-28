function prime(args)
{
	var number= +args;
	var br=0;
	if(number<1) console.log("false");
	else {
		for (var i = 2; i <= number / 2; i++)
                {
                    if (number % i == 0) br++;
                }
                if (br > 0) console.log("false");
                else console.log("true")
	}
}