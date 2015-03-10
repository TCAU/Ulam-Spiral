using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Ulam_Spiral
{
    class UlamGrid
    {
        public Bitmap GetBitmap(bool[] list)
        {
            int length = Convert.ToInt32(Math.Floor(Math.Sqrt(list.Length)));
            Bitmap bmp = new Bitmap(length, length);

            int x, y, listIndex = 2, iterationIndex = 1, spacesFilled = 2;

            x = length / 2 - 1;

            y = length / 2;

            while (spacesFilled < list.Length)
            {
                int right, down, left, up;

                right = up = iterationIndex * 2 - 1;
                left = down = iterationIndex * 2;

                while (right > 0 && spacesFilled < list.Length)
                {
                    x++;
                    if (list[listIndex])
                    {
                        bmp.SetPixel(x, y, Color.Black);
                    }
                    listIndex++;
                    right--;
                    spacesFilled++;
                }

                while (up > 0 && spacesFilled < list.Length)
                {
                    y--;
                    if (list[listIndex])
                    {
                        bmp.SetPixel(x, y, Color.Black);
                    }
                    listIndex++;
                    up--;
                    spacesFilled++;
                }

                while (left > 0 && spacesFilled < list.Length)
                {
                    x--;
                    if (list[listIndex])
                    {
                        bmp.SetPixel(x, y, Color.Black);
                    }
                    listIndex++;
                    left--;
                    spacesFilled++;
                }

                while (down > 0 && spacesFilled < list.Length)
                {
                    y++;
                    if (list[listIndex])
                    {
                        bmp.SetPixel(x, y, Color.Black);
                    }
                    listIndex++;
                    down--;
                    spacesFilled++;
                }

                iterationIndex++;
            }

            return bmp;
        }
    }
}
