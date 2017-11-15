using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawMatrixDLL
{
    public class DrawMatrixClass
    {

        public DrawMatrixClass()
        {

        }


        public List<RectangleGame> DrawRectangles(Graphics g, int Width, int Length)
        {
            List<RectangleGame> matrix = new List<RectangleGame>();

            for (int i = 1; i <= Length; i++)
            {
                for (int j = 1; j <= Width; j++)
                {
                    Point beg = new Point(40 * i, 40 * j);
                    RectangleGame item = new RectangleGame
                    {
                        Begin = beg,
                        End = new Point(beg.X+30, beg.Y+30)
                    };

                    InitializeMatrix(item, i, j);
                    matrix.Add(item);

                    switch (item.Type)
                    {
                        case 0:
                            Fill(Color.Gray, g, i, j, @"C:\Users\user.STEP\Desktop\kursova\EditForm\Resources\Screenshot_4.png"); // 0 - земля
                            break;
                        case 1:
                            Fill(Color.Blue, g, i, j, @"C:\Users\user.STEP\Desktop\kursova\EditForm\Resources\Screenshot_7.png"); // 1 - місця для будівлі веж
                            break;
                        case 2:
                            Fill(Color.Green, g, i, j, @"C:\Users\user.STEP\Desktop\kursova\EditForm\Resources\Screenshot_3.png"); // 2 - точка спавна
                            break;
                        case 3:
                            Fill(Color.Red, g, i, j, @"C:\Users\user.STEP\Desktop\kursova\EditForm\Resources\Screenshot_6.png"); // 3 - фініш
                            break;
                        case 4:
                            Fill(Color.Brown, g, i, j, @"C:\Users\user.STEP\Desktop\kursova\EditForm\Resources\images.png"); // 4 - клітина ходьби юніта
                            break;
                        default:
                            break;
                    }

                }
            }
            return matrix;
        }
        private static void  InitializeMatrix(RectangleGame rectangleGame, int i, int j)
        {
            //if (i % 2 == 0 && j % 3 == 0)
            //{
            //    rectangleGame.Type = 1;
            //}
            //else if (i == 0 && j == 0)
            //{
            //    rectangleGame.Type = 2;
            //}
            //else if (i == rectangleGame.Width && j == rectangleGame.Length)
            //{
            //    rectangleGame.Type = 3;
            //}
            //else if (i == j)
            //{
            //    rectangleGame.Type = 4;
            //}
            //else
            //{
                rectangleGame.Type = 0;
            //}
        }

        private static void Fill(Color color, Graphics graphics, int i, int j, string path)
        {
            Brush brush = new SolidBrush(color); // ініцалізація кісті
            graphics.DrawRectangle(new Pen(new SolidBrush(color)),
                            new Rectangle(new Point(40 * i, 40 * j), new Size(30, 30))); // малювання "кордонів" елемента матриці

            graphics.DrawImage(Image.FromFile(path), 40 * i, 40 * j, 30, 30); // заповнення кольорем елеметна матриці
        }
    }
}
