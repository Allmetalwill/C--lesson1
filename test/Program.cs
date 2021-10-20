using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {   // Hello World message 
            Console.WriteLine("Hello World!");
            // Type your name and press enter
      Console.WriteLine("What is your name?");

      // Create a string variable and get user input from the keyboard and store it in the variable
      string userName = Console.ReadLine();

      // Print the value of the variable (userName), which will display the input value
      Console.WriteLine("Hello " + userName);
      
      string Userchoice = "";
      
      Console.Write("Are you having a good day? Yes or No?");
     Userchoice = Console.ReadLine();
      if(Userchoice == "No")
      {
          Console.WriteLine("I wish I could make it better");
      }

       if(Userchoice == "Yes")
      {
          Console.WriteLine("That is good");
      }
 
  
    int previousQuestions = 5;
    

    for (int i = 0; i < 3 ; i++) {
        // find a way to check if the selected number (x) is already in previousQuestions array

        //if it is -> recalculate (x)
        //if it isn't -> writeLine (x)

        // https://stackoverflow.com/questions/7867377/checking-if-a-string-array-contains-a-value-and-if-so-getting-its-position/7867403

    Random question = new Random();
    int x = question.Next(5);
    string[] array = new string[5];
    array[0] = "What is the capital of Germany?";
    array[1] = "Where is Vladmir Putin from?";
    array[2] = "Which political party is Boris Johnson in?";
    array[3] = "What is the capital of Portugal";
    array[4] = "What is the capital of France?";
 
     Console.WriteLine(array[x]);
  
    string[] answer = new string[5];
  
    answer[0] = "Berlin";
    answer[1] = "Russia";
    answer[2] = "Conservative";
    answer[3] = "Lisbon";
    answer[4] = "Paris";
  
    string a = Console.ReadLine();
  
    if (a == answer[x])
    {
        Console.WriteLine("It's True");
    }
    else
    {
        Console.WriteLine("It's False");
    }
    
    }
 
}
        static void Ask(string question)
        {
         Console.WriteLine(question);

         string Hello = Console.ReadLine();

         Console.ReadLine();

        //  for ( number index = 0 ; index < 3 ; i = i + 1 ) {
        //     Console.WriteLine(index);
            
        //  }

        }
        // 1 - declaring the iterator // number index = 0;
        // 2 - declare a condition    // index < array.length
        // 3 - what happens after each iteration
        // random -> randomNum = Math.Random(0, 4);
        //           finalNum = Math.Round(randomNum);

        // return question[finalNum]
    }
}


