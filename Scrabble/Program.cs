using System;
using Scrabble.Models;

namespace Scrabble.Soultion
{
  class Program
  {
    static void Main()
    {
      string userWord = "test";
      ScrabbleScore newScore = new ScrabbleScore(userWord);
      newScore.GetScore();
    }
  }
}
