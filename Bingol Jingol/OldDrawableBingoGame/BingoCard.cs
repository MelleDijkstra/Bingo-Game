using System;
using System.Collections.Generic;
using System.Drawing;

namespace OldDrawableBingoGameGame.Bingol_Jingol
{
    internal class BingoCard
    {

        int[,] numbers;
        int boxSize;
        readonly int margin;
        // margin above all boxes, so that a title can be set above the card
        readonly int topMargin = 40;

        public BingoCard()
        {
            boxSize = 50;
            margin = boxSize / 2;

            // get mulitdimensional array
            numbers = GenerateCardNumbers();

            Console.WriteLine("Bingo card created");
        }

        private int[,] GenerateCardNumbers()
        {
            // create multidimensional array to return
            int[,] returnNums = new int[5, 5];

            // create a list of hundred numbers to choose from
            List<int> tempNums = new List<int>(100);
            for (int i = 0; i < 100; i++)
            {
                tempNums.Add(i);
            }

            Random r = new Random();

            // loop through all the spaces on the card to fill in
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    // get a random position from the tempNums array
                    int a = r.Next(tempNums.Count);
                    // place the number from the random position from the tempNums array to the numbers of the card
                    returnNums[i, j] = tempNums[a];
                    // remove the numbers from the tempNums array so it can't be picked again in the next loop
                    tempNums.RemoveAt(a);
                }
            }

            return returnNums;

        }

        public void Draw(Graphics g)
        {
            // the amount of columns times the box size (width) margin between each column plus the 1 margin on the sides of the card
            int width = numbers.GetLength(1) * boxSize + margin * (numbers.GetLength(1) + 1);
            int height = numbers.GetLength(0) * boxSize + margin * (numbers.GetLength(0) + 2) + topMargin + margin;

            // first draw background
            g.FillRectangle(Brushes.Tomato, new Rectangle(0, 0, width, height));

            // draw all rectangles and numbers on top of background
            // loop through rows
            int x = margin;
            int y = topMargin;
            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                y += boxSize + margin;
                x = margin;
                // loop through columns
                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                    g.DrawRectangle(Pens.Black, new Rectangle(x, y, boxSize, boxSize));
                    x += margin + boxSize;
                }
            }
        }
    }
}
