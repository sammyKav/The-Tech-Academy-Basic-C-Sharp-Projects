using System;
using System.Collections.Generic;




    class Program
    {
        static void Main()
        {

        string[] strArray = { "Good", "Bad", "Happy", "Sad" }; //create an array

        Console.WriteLine("pick in index from 0 to 3");
        int index = Convert.ToInt32(Console.ReadLine()); //save user resonse. 
        if (index >= 0 && index < 4)
        {
            Console.WriteLine(strArray[index]); //displays the users requested index

           
        }
        else {
            Console.WriteLine("This index doesn't exist follow basic directions or go back to preschool.");
            Console.ReadLine();
                }


        int[] intArray = { 1, 4, 121, 95 };
        Console.WriteLine("pick in index from 0 to 3");
        int index1 = Convert.ToInt32(Console.ReadLine()); //save user resonse. 

        if (index1 >= 0 && index1 < 4)
        {
            Console.WriteLine(intArray[index1]); //displays the users requested index


        }
        else
        {
            Console.WriteLine("This index doesn't exist! Follow basic directions or go back to preschool.");
           
        }


        Console.WriteLine("Pick an index for a list. Pick 0 to 3");

        List<string> strList = new List<string>();

        strList.Add("Fish");
        strList.Add("Random Word");
        strList.Add("Monk Fish");
        strList.Add("Stable Fish");

        int lsIndex = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(strList[lsIndex]);


        Console.ReadLine();



        //int[] numArray = new int[5]; //must instantiate it
        //numArray[0] = 5;
        //numArray[1] = 2;
        //numArray[2] = 100;
        //numArray[3] = 599;
        //numArray[4] = 50;

        //int[] numArray1 = new int[] { 5, 2, 10, 200, 5000 }; //another way of doing the above. 

        //int[] numArray2 = { 5, 2, 10, 200, 6500, 600, 2300 }; //fastest way. 

        //numArray2[5] = 650; //change an element of the array. 



        //Console.WriteLine(numArray[3]);
        //Console.ReadLine();

        //list

        //List<int> intList = new List<int>();
        //intList.Add(4);
        //intList.Add(10);
        //intList.Remove(10);
        //Console.WriteLine(intList[0]);

        //List<string> strList = new List<string>();
        //strList.Add("add");
        //strList.Add("my ass");
        //strList.Remove("add");
        //Console.WriteLine(intList[0]);

        // byte[] byteArray = new byte[5000] use this array for a large quantity.


    }
    }

