using System.Collections.Generic;
using System.Linq;
using System;

namespace Scrabble.Models
{
  public class ScrabbleScore
  {
    public string UserWord { get; set; }
    public int WordScore { get; set; }
    public char[] SplitArray = { };

    public ScrabbleScore(string userInput)
    {
      UserWord = userInput.ToLower();
      WordScore = 0;
      SplitArray = userInput.ToCharArray();
    }
    private static Dictionary<char, int> _scrabbleDictionary = new Dictionary<char, int>() { { 'a', 1 }, { 'b', 3 }, { 'c', 3 }, { 'd', 2 }, { 'e', 1 }, { 'f', 4 }, { 'g', 2 }, { 'h', 4 }, { 'i', 1 }, { 'j', 8 }, { 'k', 5 }, { 'l', 1 }, { 'm', 3 }, { 'n', 1 }, { 'o', 1 }, { 'p', 3 }, { 'q', 10 }, { 'r', 1 }, { 's', 1 }, { 't', 1 }, { 'u', 1 }, { 'v', 4 }, { 'w', 4 }, { 'x', 8 }, { 'y', 4 }, { 'z', 10 } };

    // for each index in SplitArray, compare index against _scrabbleDictionary. If index matches a key in _scrabbleDictionary, then add the corresponding value to WordScore

    public void GetScore()
    {
      foreach (char index in SplitArray)
      {
        if (_scrabbleDictionary.ContainsKey(index))
        {
          int value = _scrabbleDictionary[index];
          Console.WriteLine(value);
          WordScore += value;
          Console.WriteLine(WordScore);
        }
        else
        {
          WordScore = 100;
        }
      }
    }



  }
}



// ["a" "x" "e"]
// scrabbleDictionary[i] 1 4 1
// score = +scrabbleDictionary[i]
