function yongestPerson(args) {
    var people= [];

    for (var i = 0; i < args.length; i= i+ 3) {
        people.push({
            firstname: args[i],
            lastname: args[i + 1],
            age: +args[i + 2]
        });
    }
        var youngestman = people[0];
        for (var person in people) {
            if (people[person].age<youngestman.age) {
                youngestman = people[person];
            }
        }

        return youngestman.firstname + " " + youngestman.lastname;
    
    
}