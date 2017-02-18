using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheAionProject
{
    /// <summary>
    /// controller for the MVC pattern in the application
    /// </summary>
    public class Controller
    {
        #region FIELDS

        private ConsoleView _gameConsoleView;
        private Traveler _gameTraveler;
        private Universe _gameUniverse;
        private SpaceTimeLocation _currentLocation;
        private bool _playingGame;

        #endregion

        #region PROPERTIES


        #endregion

        #region CONSTRUCTORS

        public Controller()
        {
            //
            // setup all of the objects in the game
            //
            InitializeGame();

            //
            // begins running the application UI
            //
            ManageGameLoop();
        }

        #endregion

        #region METHODS

        /// <summary>
        /// initialize the major game objects
        /// </summary>
        private void InitializeGame()
        {
            _gameTraveler = new Traveler();
            _gameUniverse = new Universe();
            _gameConsoleView = new ConsoleView(_gameTraveler, _gameUniverse);
            _playingGame = true;

            Console.CursorVisible = false;
        }

        /// <summary>
        /// method to manage the application setup and game loop
        /// </summary>
        private void ManageGameLoop()
        {
            TravelerAction travelerActionChoice = TravelerAction.None;

            //
            // display splash screen
            //
            _playingGame = _gameConsoleView.DisplaySpashScreen();

            //
            // player chooses to quit
            //
            if (!_playingGame)
            {
                Environment.Exit(1);
            }

            //
            // display introductory message
            //
            _gameConsoleView.DisplayGamePlayScreen("Mission Intro", Text.MissionIntro(), ActionMenu.MissionIntro, "");
            _gameConsoleView.GetContinueKey();

            //
            // initialize the mission traveler
            // 
            InitializeMission();

            //
            // prepare game play screen
            //
            _currentLocation = _gameUniverse.GetSpaceTimeLocationByID(_gameTraveler.SpaceTimeLocationID);
            _gameConsoleView.DisplayGamePlayScreen("Current Location", Text.CurrentLocationInfo(_currentLocation), ActionMenu.MainMenu, "");

            //
            // game loop
            //
            while (_playingGame)
            {
                travelerActionChoice = _gameConsoleView.GetActionMenuChoice(ActionMenu.MainMenu);

                //
                // choose an action based on the user's menu choice
                //
                switch (travelerActionChoice)
                {
                    case TravelerAction.None:
                        break;

                    case TravelerAction.LookAround:
                        _gameConsoleView.DisplayLookAround();
                        break;

                    case TravelerAction.Travel:
                        _gameConsoleView.DisplayTravel();
                        //_gameTraveler.SpaceTimeLocationID = _gameConsoleView.GetNewLocationChoice();
                        break;

                    case TravelerAction.TravelerInfo:
                        _gameConsoleView.DisplayTravelerInfo();
                        break;

                    case TravelerAction.Exit:
                        _playingGame = false;
                        break;

                    default:
                        break;
                }
            }

            //
            // close the application
            //
            Environment.Exit(1);
        }

        private void InitializeMission()
        {
            //
            // intro
            //
            _gameConsoleView.DisplayGamePlayScreen("Mission Initialization", Text.InitializeMissionIntro(), ActionMenu.MissionIntro, "");
            _gameConsoleView.GetContinueKey();

            //
            // get traveler's name
            //
            _gameConsoleView.DisplayGamePlayScreen("Mission Initialization - Name", Text.InitializeMissionGetTravelerName(), ActionMenu.MissionIntro, "");
            _gameConsoleView.DisplayInputBoxPrompt("Enter your name: ");
            _gameTraveler.Name = _gameConsoleView.GetString();

            //
            // get traveler's age
            //
            _gameConsoleView.DisplayGamePlayScreen("Mission Initialization - Age", Text.InitializeMissionGetTravelerAge(_gameTraveler), ActionMenu.MissionIntro, "");
            int gameTravelerAge;

            _gameConsoleView.GetInteger($"Enter your age {_gameTraveler.Name}: ", 0, 1000000, out gameTravelerAge);
            _gameTraveler.Age = gameTravelerAge;

            //
            // get traveler's race
            //
            _gameConsoleView.DisplayGamePlayScreen("Mission Initialization - Race", Text.InitializeMissionGetTravelerRace(_gameTraveler), ActionMenu.MissionIntro, "");
            _gameConsoleView.DisplayInputBoxPrompt($"Enter your race {_gameTraveler.Name}: ");
            _gameTraveler.Race = _gameConsoleView.GetRace();

            //
            // echo the traveler's info
            //
            _gameConsoleView.DisplayGamePlayScreen("Mission Initialization - Complete", Text.InitializeMissionEchoTravelerInfo(_gameTraveler), ActionMenu.MissionIntro, "");
            _gameConsoleView.GetContinueKey();

            //
            // set traveler's initial location
            //
            _gameTraveler.SpaceTimeLocationID = 1;
        }

        #endregion
    }
}
