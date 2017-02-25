using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheAionProject
{
    /// <summary>
    /// the character class the player uses in the game
    /// </summary>
    public class Traveler : Character
    {
        #region ENUMERABLES


        #endregion

        #region FIELDS

        private int _score;
        private int _health;
        private int _lives;

        #endregion


        #region PROPERTIES

        public int Lives
        {
            get { return _lives; }
            set { _lives = value; }
        }

        public int Health
        {
            get { return _health; }
            set { _health = value; }
        }

        public int Score
        {
            get { return _score; }
            set { _score = value; }
        }

        #endregion


        #region CONSTRUCTORS

        public Traveler()
        {

        }

        public Traveler(string name, RaceType race, int spaceTimeLocationID) : base(name, race, spaceTimeLocationID)
        {

        }

        #endregion


        #region METHODS
        

        #endregion
    }
}
