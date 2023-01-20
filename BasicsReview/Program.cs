using Classes;

//ExploreIf();

void ExploreIf(){
    int a = 5;
    int b = 3;
    if (a + b > 10){
        Console.WriteLine("The answer is greater than 10.");
    }    
    else{
        Console.WriteLine("The answer is not greater than 10");
    }

    Console.WriteLine("------------------------------------------------");

    int c = 4;
    if ((a + b + c > 10) && (a == b)){
        Console.WriteLine("The answer is greater than 10.");
        Console.WriteLine("And the first number is greater than the second.");
    }    
    else{
        Console.WriteLine("The answer is not greater than 10");
        Console.WriteLine("Or the first number is not greater than the second.");
    }

    Console.WriteLine("------------------------------------------------");

    if ((a + b + c > 10) || (a == b)){
        Console.WriteLine("The answer is greater than 10.");
        Console.WriteLine("Or the first number is greater than the second.");
    }    
    else{
        Console.WriteLine("The answer is not greater than 10");
        Console.WriteLine("And the first number is not greater than the second.");
    }
}

//ExploreLoops();

void ExploreLoops(){
    int counterOne = 0;
    while(counterOne < 10){
        Console.WriteLine($"Hello World! The counter is {counterOne}");
        counterOne ++;
    }

    Console.WriteLine("-----------------------------------------------");

    int counterTwo = 0;
    do{
        Console.WriteLine($"Hello World! The counter is {counterTwo}");
        counterTwo ++;
    }while(counterTwo < 10);

    Console.WriteLine("-----------------------------------------------");

    for(int index = 0; index < 10; index++){
        Console.WriteLine($"Hello World! The counter is {index}");
    }

    Console.WriteLine("-----------------------------------------------");

    for(int row = 1; row < 11; row++){
        Console.WriteLine($"The row is {row}");
    }

    Console.WriteLine("-----------------------------------------------");

    for (char column = 'a'; column < 'k'; column++){
        Console.WriteLine($"The column is {column}");
    }

    Console.WriteLine("-----------------------------------------------");

    for(int row = 1; row < 11; row++){
        for (char column = 'a'; column < 'k'; column++){
            Console.WriteLine($"The cell is ({row},{column})");
        }
    }
}

//WorkWithStrings();

void WorkWithStrings(){

    Console.WriteLine("-----------------------------------------------");

    var names = new List<string> {"Ryan", "Ana", "Felipe"};
    foreach(var name in names){
        Console.WriteLine($"Hello {name.ToUpper()}!");
    }

    Console.WriteLine("-----------------------------------------------");

    names.Add("Maria");
    names.Add("Bill");
    names.Remove("Ana");

    foreach(var name in names){
        Console.WriteLine($"Hello {name.ToUpper()}!");
    }

    Console.WriteLine("-----------------------------------------------");

    Console.WriteLine($"My name is {names[0]}");
    Console.WriteLine($"I've added {names[2]} and {names[3]} to the list.");
    Console.WriteLine($"This list has {names.Count} people in it.");

    Console.WriteLine("-----------------------------------------------");

    var index = names.IndexOf("Ryan");
    if( index ==-1){
        Console.WriteLine($"When an item is not found, IndexOf returns {index}");
    }
    else{
        Console.WriteLine($"The name {names[index]} is at index: {index}");
    }

    index = names.IndexOf("Not Found");
    if(index == -1){
        Console.WriteLine($"When an item is not found, IndexOf returns {index}");
    }
    else{
        Console.WriteLine($"The name {names[index]} is at index: {index}");
    }

    Console.WriteLine("-----------------------------------------------");

    names.Sort();
    foreach(var name in names){
        Console.WriteLine($"Hello {name.ToUpper()}!");
    }
}

//WorkWithLists();

void WorkWithLists(){

    Console.WriteLine("-----------------------------------------------");

    var fibonacciNumbers = new List<int> {1,1};

    while(fibonacciNumbers.Count < 20){
        var previous = fibonacciNumbers[fibonacciNumbers.Count - 1];
        var previous2 = fibonacciNumbers[fibonacciNumbers.Count - 2];

        fibonacciNumbers.Add(previous + previous2);
    }

    foreach(var item in fibonacciNumbers){
            Console.WriteLine(item);
    }
}

Console.WriteLine("-----------------------------------------------");

var account = new BankAccount("Ryan", 1000);
Console.WriteLine($"Account {account.Number} was created for {account.Owner} with the initial account balance of: ${account.Balance}");

account.MakeWithdrawal(500, DateTime.Now, "rent payment");
Console.WriteLine(account.Balance);
account.MakeDeposit(100, DateTime.Now, "friend paid me back");
Console.WriteLine(account.Balance);

Console.WriteLine(account.GetAccountHistory());

//test for a negative balance
try{
    account.MakeWithdrawal(750, DateTime.Now, "attempt to overdraw");
}
catch(InvalidOperationException e){
    Console.WriteLine("Exception caught trying to overdraw");
    Console.WriteLine(e.ToString());
}

//test that the initial balances must be positive
BankAccount invalivdAccount;
try{
    invalivdAccount = new BankAccount("invalid", -55);
}
catch(ArgumentOutOfRangeException e){
    Console.WriteLine("Exception caught account with negative balance");
    Console.WriteLine(e.ToString());
    return;
}
