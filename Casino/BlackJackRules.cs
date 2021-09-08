using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino.BlackJack
{
    class BlackJackRules
    {
        private static Dictionary<Face, int> _cardValues = new Dictionary<Face, int>() //add a int value to cards, so that they can be operated on. 
        {
            [Face.Two] = 2,
            [Face.Three] = 3,
            [Face.Four] = 4,
            [Face.Five] = 5,
            [Face.Six] = 6,
            [Face.Seven] = 7,
            [Face.Eight] = 8,
            [Face.Nine] = 9,
            [Face.Ten] = 10,
            [Face.Jack] = 10,
            [Face.Queen] = 10,
            [Face.King] = 10,
            [Face.Ace] = 1 //will add logic later to add 10. 
        };

        private static int[] GetAllPossibleHandValues(List<Card> Hand) //this used to account for value of Ace, which can be one or eleven. 
        {
            int aceCount = Hand.Count(x => x.Face == Face.Ace); //lambda function that counts number of aces.
            int[] result = new int[aceCount + 1];  //creates an array of length acecount + 1
            int value = Hand.Sum(x => _cardValues[x.Face]); //calculates sum of the hand. 
            result[0] = value; //stores the value of the hand in first element of arry
            if (result.Length == 1) return result; //if there aren't any aces than return result
            for (int i = 1; i < result.Length; i++) //accounts for the value of the. Starts on second element of array. Since two aces won't be both 11 only need to account for the case where one ace equals 10. 
            {
                value += (i * 10); //adds 10 to the to the second Ace.  
                result[i] = value;
            }
            return result;
        }

        public static bool CheckForBlackJack(List<Card> Hand)  //checks to see if value of hand is a winner. 
        {
            int[] possibleValues = GetAllPossibleHandValues(Hand); 
            int value = possibleValues.Max();
            if (value == 21) return true;
            else return false;
        }
        public static bool IsBusted(List<Card> Hand)
        {
            int value = GetAllPossibleHandValues(Hand).Min();
            if (value > 21) return true;
            else return false;

        }

        public static bool ShouldDealerStay(List<Card> Hand) //if the value of the hand is between 17 and 21 dealer won't hit. 
        {
            int[] possibleHandValues = GetAllPossibleHandValues(Hand);
            foreach (int value in possibleHandValues)
            {
                if (value > 16 && value < 22)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool? CompareHands(List<Card> PlayerHand, List<Card> DealerHand)
        {
            int[] playerResults = GetAllPossibleHandValues(PlayerHand);
            int[] dealerResults = GetAllPossibleHandValues(DealerHand);
            int playerScore = playerResults.Where(x => x < 22).Max();
            int dealerScore = dealerResults.Where(x => x < 22).Max();

            if (playerScore > dealerScore) return true;
            else if (playerScore < dealerScore) return false;
            else return null;
        }  
    }
}
