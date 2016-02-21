using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Bingol_Jingol
{
    internal class BingoCard
    {
        int[,] numbers;
        GameScreenWithControls window;

        public BingoCard(GameScreenWithControls window)
        {
            this.window = window;

            // get mulitdimensional array
            numbers = GenerateCardNumbers();

            // create labels for UI
            int x;
            int y = 50;
            int loopCount = 1;
            // loop through rows
            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                x = 30;
                y += 80;
                // loop through columns
                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                    // create new label for every number
                    Label label = new Label();
                    label.BackColor = Color.White;
                    label.Font = new Font("Microsoft Sans Serif", 23F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                    label.ForeColor = Color.DarkRed;
                    label.Location = new Point(x, y);
                    label.Name = "box" + loopCount;
                    label.Padding = new Padding(10);
                    label.Size = new Size(75, 75);
                    // dynamic tabindex and text
                    label.TabIndex = loopCount;
                    label.Text = numbers[i, j].ToString();
                    label.TextAlign = ContentAlignment.MiddleCenter;

                    window.Controls.Add(label);

                    x += 80;
                    loopCount++;
                }
            }

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

        public override string ToString()
        {
            return numbers.Cast<int>().Aggregate("", (current, number) => current + ("|" + number + "|"));
        }
    }
}