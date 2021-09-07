using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Casino;
using Casino.BlackJack;
using System.Data.SqlClient;
using System.Data;

namespace BlackJack
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Welcome to Sketchy Ralph's Insane Casion. What's your name?");
            string playerName = Console.ReadLine(); //can implicitly handle when use var. var playername. 
            if(playerName == "admin")
            {
                List<ExceptionEntity> Exceptions = ReadExceptions();
                foreach(var exception in Exceptions)
                {
                    Console.Write(exception.Id + " | ");
                    Console.Write(exception.ExceptionType + " | ");
                    Console.Write(exception.ExceptionMessage + " | ");
                    Console.Write(exception.TimeStamp + " | ");
                }
                Console.Read();
            }

            bool validAnswer = false;
            int bank = 0;
            while (!validAnswer)
            {
                Console.WriteLine("And how much money did you bring today");
                validAnswer = int.TryParse(Console.ReadLine(), out bank);
                if (!validAnswer) Console.WriteLine("Please enter digits only. Only whole numbers."); 
            }
            
            Console.WriteLine("Hello, {0}. Would you like to play Black Jack?", playerName);
            string answer = Console.ReadLine().ToLower();
            if (answer == "yes")
            {
                Player player = new Player(playerName, bank);
                Game game = new BlackJackGame(); //polymorphism.
                game += player; //overloaded operator
                player.isActivelyPlaying = true;
                while (player.isActivelyPlaying && player.Balance > 0)
                {
                    try { 
                    game.Play(); //play the game while player wants to or while they have money. 
                    }
                    catch (FraudException ex) //give it a name so you can pass it in below. 
                    {
                        Console.WriteLine(ex.Message); //start specific. 
                        UpdateDbwithException(ex); //passing in the ex here. 
                        Console.ReadLine();
                    }
                    catch (Exception) //then move to general. 
                    {
                        Console.WriteLine("An error occured. Please contact your system admin, Crazy Ralph");
                        Console.ReadLine();
                        return; //ends the method because this is a void method. 
                    }
                }
                game -= player;
                Console.WriteLine("Thanks for playing.");
            }
            Console.WriteLine("Feel free to take a look around. Come back later alligator.");
            Console.Read();
        }
        private static void UpdateDbwithException(Exception ex) 
        {
            string connectionString = @"Data Source=(localdb)\ProjectsV13;Initial Catalog=BlackJackGame;Integrated Security=True;
                                      Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;
                                      ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            string queryString = @"INSERT INTO EXCEPTIONS (ExceptionType, ExceptionMessage, TimeStamp) VALUES
                                 (@ExceptionType, @ExceptionMessage, @TimeStamp)"; //creating input parameters for sql. 
            using(SqlConnection connection = new SqlConnection(connectionString)) //using statement down here is different than above. For controlling memory. 
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.Add("@ExceptionType", SqlDbType.VarChar);//dealing with external db protects against SQL injection. 
                command.Parameters.Add("@ExceptionMessage", SqlDbType.VarChar);
                command.Parameters.Add("@TimeStamp", SqlDbType.DateTime);
                
                command.Parameters["@ExceptionType"].Value = ex.GetType().ToString();
                command.Parameters["@ExceptionMessage"].Value = ex.Message;
                command.Parameters["@TimeStamp"].Value = DateTime.Now;

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();

            }
        }
        private static List<ExceptionEntity> ReadExceptions()
        {
            string connectionString = @"Data Source=(localdb)\ProjectsV13;Initial Catalog=BlackJackGame;Integrated Security=True;
                                      Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;
                                      ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            string queryString = @"select Id, ExceptionType, ExceptionMessage, TimeStamp from Exceptions";

            List<ExceptionEntity> Exceptions = new List<ExceptionEntity>();
            
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    ExceptionEntity exception = new ExceptionEntity();
                    exception.Id = Convert.ToInt32(reader["Id"]);
                    exception.ExceptionType = reader["ExceptionType"].ToString();
                    exception.ExceptionMessage = reader["ExceptionMessage"].ToString();
                    exception.TimeStamp = Convert.ToDateTime(reader["TimeStamp"]);
                    Exceptions.Add(exception);
                }
                connection.Close();
            }
            return Exceptions;

        }
    }
}
