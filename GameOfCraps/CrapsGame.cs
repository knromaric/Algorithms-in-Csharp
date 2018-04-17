using System;

namespace GameOfCraps
{
    public partial class CrapsGame
    {
        private RollDice _roll;
        private GameStatus _gameStatus;
        private DiceSum _diceSum;
        private int _numRolls;
        private int _sum;
        private int _point;
        public const int numGames = 5;
        private Statistics _statistics;


        public CrapsGame()
        {
            _roll = new RollDice();
            _statistics = new Statistics();
        }
        private void EvaluateRoll()
        {
            switch (_sum)
            {
                case 7:
                    _diceSum = DiceSum.Seven;
                    _gameStatus = GameStatus.Win;
                    _point = 0;
                    _statistics.SetStats(_numRolls, _gameStatus);
                    break;
                case 11:
                    _diceSum = DiceSum.YoLeven;
                    _gameStatus = GameStatus.Win;
                    _point = 0;
                    _statistics.SetStats(_numRolls, _gameStatus);
                    break;
                case 2:
                    _diceSum = DiceSum.SnakeEyes;
                    _gameStatus = GameStatus.Lose;
                    _point = 0;
                    _statistics.SetStats(_numRolls, _gameStatus);
                    break;
                case 3:
                    _diceSum = DiceSum.Trey;
                    _gameStatus = GameStatus.Lose;
                    _point = 0;
                    _statistics.SetStats(_numRolls, _gameStatus);
                    break;
                case 12:
                    _diceSum = DiceSum.BoxCars;
                    _gameStatus = GameStatus.Lose;
                    _point = 0;
                    _statistics.SetStats(_numRolls, _gameStatus);
                    break;
                default:
                    _gameStatus = GameStatus.Continue;
                    _point = _sum;
                    _statistics.SetStats(_numRolls, _gameStatus);
                    break;

            }
        }

        private void DisplayMessage()
        {
            switch (_gameStatus)
            {
                case GameStatus.Win:
                    Console.WriteLine(_numRolls == 1 
                        ? $"Congratulations, you rolled {_diceSum}. YOU WIN !!!"
                        : $"Congratualtions, your rolled {_sum}. YOU WIN !!!");
                    break;
                case GameStatus.Lose:
                    Console.WriteLine(_numRolls == 1
                        ? $"SORRY, you rolled {_diceSum}. YOU LOSE !!!"
                        : $"SORRY, your rolled {_sum}. YOU lOSE !!!");
                    break;
                default:
                    Console.WriteLine($"You rolled {_sum}. Your point is {_point}. Keep rolling !!!");
                    break;
            }
        }

        public void Play()
        {
            for (int i = 0; i < numGames; i++)
            {
                Console.WriteLine($"************************** game # {i + 1}");
                _gameStatus = GameStatus.Continue;
                _numRolls = 0;

                _sum = _roll.DiceRoll();
                _numRolls++;
                EvaluateRoll();
                DisplayMessage();
                while (_gameStatus == GameStatus.Continue)
                {
                    KeepPlaying();
                    DisplayMessage();
                }
            }

            _statistics.DisplayStatistics();
            
        }

        private void KeepPlaying()
        {
            _sum = _roll.DiceRoll();
            _numRolls++; 

            if(_sum == _point)
            {
                _gameStatus = GameStatus.Win;
                _statistics.SetStats(_numRolls, _gameStatus);
            }
            else if(_sum == 7)
            {
                _gameStatus = GameStatus.Lose;
                _statistics.SetStats(_numRolls, _gameStatus);
            }
            else
            {
                _gameStatus = GameStatus.Continue;
            }
        }
    }
}
