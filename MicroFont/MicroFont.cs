using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroFont
{
    public class MicroFont
    {
        private FontDefinition font = new FontDefinition();

        public MicroFont()
        {

        }

        public Bitmap Generate(string text, int width, int height, int xPadding, int yPadding)
        {
            Bitmap image = new Bitmap(width, height);
            Graphics g = Graphics.FromImage(image);
            g.FillRectangle(new SolidBrush(Color.Black), 0, 0, width, height);

            int curX = xPadding;
            int curY = yPadding;

            foreach(char character in text.ToUpper())
            {
                if (character == '\n')
                {
                    curY += 6;
                    curX = xPadding;
                    continue;
                }
                if (font.Characters.ContainsKey(character)) {
                    int[,] fontChar = font.Characters[character];
                    for(int i = 0; i < 5; i++)
                    {
                        image.SetPixel(curX, curY + i, Color.FromArgb(255 * fontChar[i, 0], 255 * fontChar[i, 1], 255 * fontChar[i, 2]));
                    }
                    curX += 2;
                }

            }
            return image;
        }
    }
}
