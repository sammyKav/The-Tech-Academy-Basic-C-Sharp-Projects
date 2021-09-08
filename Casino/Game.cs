using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    public abstract class Game
    {
        private List<Player> _players = new List<Player>(); //make sure list of players are never null. 
        private Dictionary<Player, int> _bets = new Dictionary<Player, int>();
        public List<Player> Players { get { return _players; } set { _players = value; } } //sets value of empty list.
        public string Name { get; set; }
        public Dictionary<Player, int> Bets { get {return _bets; } set {_bets = value; } } 

        public abstract void Play();  //abstract method: must implement this method. 
        
        public virtual void ListPlayer() // virtual method: this method get inhertited by inheriting class but can be overwritten.
        {
            foreach( Player player in Players)
            {
                Console.WriteLine(player);
            }
        }
    }
}
