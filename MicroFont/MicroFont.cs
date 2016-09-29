using System;
using System.Drawing;

namespace MicroFont
{
    public class MicroFont
    {
        private FontDefinition font = new FontDefinition();

        public MicroFont()
        {

        }

		public Size MeasaureText(string text, int xPadding, int yPadding)
		{
			Size size = new Size(xPadding, yPadding);

			int sizeX = xPadding;

			foreach (char character in text.ToUpper())
			{
				if (character == '\n')
				{
					size.Height += 6;
					size.Width = Math.Max(size.Width, sizeX);
					sizeX = xPadding;
					continue;
				}
				if (font.Characters.ContainsKey(character))
				{
					int[,] fontChar = font.Characters[character];
					sizeX += 2;
				}

			}
			size.Width = Math.Max(size.Width, sizeX) + xPadding - 1;
			size.Height += 5 + yPadding;

			return size;
		}

		public Bitmap Generate(string text, int xPadding, int yPadding, bool invertColours)
		{
			Size size = MeasaureText(text, xPadding, yPadding);
			return Generate(text, size.Width, size.Height, xPadding, yPadding, invertColours);
		}

		public Bitmap Generate(string text, int width, int height, int xPadding, int yPadding, bool invertColours)
        {
            Bitmap image = new Bitmap(width, height);
            Graphics g = Graphics.FromImage(image);
            g.FillRectangle(new SolidBrush(invertColours ? Color.White : Color.Black), 0, 0, width, height);

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
						if (invertColours)
							image.SetPixel(curX, curY + i, Color.FromArgb(255 * (1 - fontChar[i, 0]), 255 * (1 - fontChar[i, 1]), 255 * (1 - fontChar[i, 2])));
						else
							image.SetPixel(curX, curY + i, Color.FromArgb(255 * fontChar[i, 0], 255 * fontChar[i, 1], 255 * fontChar[i, 2]));
					}
					curX += 2;
                }

            }
            return image;
        }
    }
}
