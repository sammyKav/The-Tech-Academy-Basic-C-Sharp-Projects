using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Program
    {
        static void Main(string[] args)
        {

            string[] strArray = { "Pig", "Milk Man", "Happy Feet", "Bird Bath", "Lion Humor" };
            string[] strArray1 = { "Run", "Sing", "Steal", "Help", "Inject", "Calculate" };
            List<string> talkingTacoNames = new List<string>() { "BeefyBill", "TacoTimeTuesday", "AlphaMan", "HorseMeetMistress", "AlanGreenspan", "JPowell","JanetYellen" };
            List<string> weeklyArrests = new List<string>() { "Cat Women", "Alfred", "Marc Anthony", "Julius Caesar", "Marc Anthony", "Jimbo Fisher", "Alfred", "Jimbo Fisher" };
        while (strArray[0].Length < 10) { 
                Console.WriteLine("Hey don't just sit there! Write something?");
                string str = Console.ReadLine();

                for (int i=0; i<strArray.Length; i++)
                {
                    strArray[i] = strArray[i] + str;
                }

                //strArray[0] = strArray[0] + "Feet";
                //Console.WriteLine(strArray[0]);
                }
            
            
                foreach (string addStr in strArray) 
                {
                    Console.WriteLine(addStr);
                }
       
        //second while loop
        
        while (strArray1[0].Length <= 10)
        {
            Console.WriteLine("Write something. A verb, perhaps?");
            string str1 = Console.ReadLine();

            for (int i = 0; i < strArray1.Length; i++)
            {
                strArray1[i] = strArray1[i] + str1;//concats same string to each element in the array. 
            }

            //strArray[0] = strArray[0] + "Feet";
            //Console.WriteLine(strArray[0]);
        }


        foreach (string addStr1 in strArray1)
        {
            Console.WriteLine(addStr1);
        }

     

            //part #4
        Console.WriteLine("Hey, there's a list of talking taco. Enter a name and I'll tell you the order!");
        string name = Console.ReadLine();
        
        foreach( string taco in talkingTacoNames)
        {
            if(name == taco) //if the user input equals the value in the list. 
            {
                int Index = talkingTacoNames.IndexOf(taco);
                Console.WriteLine(Index + " " + taco); 
                break;
            }
            if(!talkingTacoNames.Contains(name))
            {
                Console.WriteLine("Are you crazy? Of course theren't isn't any talking tacos by the name of" + name);
                break;
            }
            
        }
           

        

        
        
            //"Cat Women", "Alfred", "Marc Anthony", "Julius Caesar", "Marc Anthony", "Jimbo Fisher", "Alfred", "Jimbo Fisher" 

            Console.WriteLine("Write a name and see if they've been arrested this week.");
            string criminal = Console.ReadLine();
        foreach(string arrest in weeklyArrests)
        {
            if(arrest == criminal)
            {
                Console.WriteLine("First Arrest id#" + weeklyArrests.IndexOf(arrest) + " Second Arrest id# " + weeklyArrests.LastIndexOf(arrest));
                break;
            }
            if(!weeklyArrests.Contains(criminal))
            {
                Console.WriteLine("This person hasn't been arrested yet. We'll be sure to arrest them at your earliest convenience.");
                break;
            }
        }    
           

        List<string> customerComplaints = new List<string> { "Too loud", "Too quite", "Rude", "Poor smell", "Too loud", "Too loud", "Too quite", "Rude", "Poor smell" };

        int counter = 0;//use this to see compare first index
        foreach(string complaint in customerComplaints)
        {
            
            int firstIndex = customerComplaints.IndexOf(complaint);//find index of first instance

            if (firstIndex == counter) //if the counter is equal to first instance than display a message. 
            {
                Console.WriteLine(complaint + "First instance of complaint " + firstIndex + " "+ counter); 
            }
            else { Console.WriteLine(complaint + " Heard this one before. " + firstIndex + " " + counter); }

            counter++;
         }

        Console.ReadLine();
        }
    }

