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


