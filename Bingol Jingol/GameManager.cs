using System;
using System.Collections.Generic;

namespace Bingol_Jingol
{
    internal class GameManager
    {
        int turns = 0;

        // list of cards in the game
        List<BingoCard> cards = new List<BingoCard>();
        List<int> availableNums = new List<int>(100);
        List<int> drawnNums = new List<int>(100);

        Random numberPicker = new Random();

        public GameManager(GameScreenWithControls window)
        {

            // fill available numbers which will be used to pick numbers
            for (int i = 0; i < 100; i++)
            {
                availableNums.Add(i);
            }

            cards.Add(new BingoCard(window));

            Console.WriteLine(cards[0]);
        }

        public int PickNumber()
        {
            // get random index number from available numbers
            int index = numberPicker.Next(availableNums.Count);
            // get the chosen number
            int chosenNum = availableNums[index];
            drawnNums.Add(chosenNum);
            // remove the chosen number so that it cannot be picked again next turn
            availableNums.RemoveAt(index);

            return chosenNum;
        }

        public void nextTurn()
        {

        }
    }
}
