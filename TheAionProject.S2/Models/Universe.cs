using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheAionProject.Assets;

namespace TheAionProject
{
    public class Universe
    {
        #region ***** define all lists to be maintained by the Universe object *****

        //
        // list of all space-time locations
        //
        private List<SpaceTimeLocation> _spaceTimeLocations;

        public List<SpaceTimeLocation> SpaceTimeLocations
        {
            get { return _spaceTimeLocations; }
            set { _spaceTimeLocations = value; }
        }

        #endregion

        #region ***** constructor *****

        //
        // default Universe constructor
        //
        public Universe()
        {
            //
            // add all of the universe objects to the game
            // 
            IntializeUniverse();
        }

        #endregion

        #region ***** define methods to initialize all game elements *****

        /// <summary>
        /// initialize the universe with all of the space-time locations
        /// </summary>
        private void IntializeUniverse()
        {
            _spaceTimeLocations = UniverseObjects.SpaceTimeLocations as List<SpaceTimeLocation>;
        }

        #endregion

        #region ***** define methods to return game element objects *****

        /// <summary>
        /// get a SpaceTimeLocation object using an ID
        /// </summary>
        /// <param name="ID">space-time location ID</param>
        /// <returns>requested space-time location</returns>
        public SpaceTimeLocation GetSpaceTimeLocationByID(int ID)
        {
            SpaceTimeLocation spaceTimeLocation = null;

            //
            // run through the space-time location list and grab the correct one
            //
            foreach (SpaceTimeLocation location in _spaceTimeLocations)
            {
                if (location.SpaceTimeLocationID == ID)
                {
                    spaceTimeLocation = location;
                }
            }

            //
            // the specified ID was not found in the universe
            // throw and exception
            //
            if (spaceTimeLocation == null)
            {
                string feedbackMessage = $"The Space-Time Location ID {ID} does not exist in the current Universe.";
                throw new ArgumentException(ID.ToString(), feedbackMessage);
            }

            return spaceTimeLocation;
        }

        #endregion
    }
}
