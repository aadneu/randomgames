
using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main()
    {
        /*
       Console.WriteLine("RANDOM NUMBER GAME");
       int inputNumber;
       var rand = new Random();
       var randomNumber = rand.Next(0,5);
      
       playGame(); 
       void playGame()
        
        {
             do
                    {
                        Console.WriteLine("Skriv inn ett tall mellom 0 og 5: ");
                        var input = Console.ReadLine();
                        inputNumber = int.Parse(input);
                        
                        if (inputNumber < randomNumber) 
                        {
                            Console.WriteLine("HØYERE ");
                        }
                        else if (inputNumber > randomNumber) 
                        {
                            Console.WriteLine("LAVERE ");
                        }
                        else
                         {
                            Console.WriteLine("Gratulerer, du vant!");
                            Console.WriteLine("Skriv ja hvis du vil spille igjen ");
                            var spillIgjen = Console.ReadLine();
                            if (spillIgjen == "ja")
                                {
                                    randomNumber = rand.Next(0, 5);
                                    playGame();
                                }
                            else
                            {
                                Console.WriteLine("Takk for i dag!");
                            
                            }
                }
            }   while (inputNumber != randomNumber);
        }
        */
       
        
        





        /* RANDOM HOBBY GENERATOR
        var inputString1 = Console.ReadLine();
        var rand = new Random();
        var randomNumber = rand.Next(0,4); 
        string[] hobbies = { "fluffer", "skomaker", "idiot", "cock", "sjåfør" };
        string output;
        for(int i = 0; i < hobbies.Length; i++)
        {
            output = $"{inputString1} har nå blitt en {hobbies[randomNumber]}";
            
            Console.WriteLine(output);
            break;
        }
       */

        


        /* BASIC RANDOM FUNKSJON
        var rand = new Random();
        var randomNumber = rand.Next(0,5);
        if (randomNumber == 0)
        {
            Console.WriteLine("Tallet er 0");
        } else {  
            Console.WriteLine("Større enn 1");
        }
        */

        /*
        Console.WriteLine("Hello World!");

  

        string input1 = Console.ReadLine();
        string input2 = Console.ReadLine();

        double inputNumber1 = Convert.ToDouble(input1);
        double inputNumber2 = Convert.ToDouble(input2);

        Console.WriteLine(retunerEtTall(inputNumber1, inputNumber2));
        ingenVerdi();
            
    }
    public static void ingenVerdi()
    {
       Console.WriteLine("Ingen verdi her");
    }
    public static double retunerEtTall(double x, double y)
        {
            return x+y;
        */
    }
        
}

