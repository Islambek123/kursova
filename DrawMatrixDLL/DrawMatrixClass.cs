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
        static RectangleGame obj;
        static List<RectangleGame> matrix;

        public DrawMatrixClass()
        {
            obj = new RectangleGame();
            matrix = new List<RectangleGame>();
        }


        public List<RectangleGame> DrawRectangles(Graphics g)
        {
            for (int i = 1; i <= obj.Length; i++)
            {
                for (int j = 1; j <= obj.Width; j++)
                {
                    RectangleGame item = new RectangleGame
                    {
                        Begin = new Point(10 * i, 10 * j),
                        End = new Point(10 * i + 20, 10 * j + 20)
                    };

                    InitializeMatrix(item, i, j);
                    matrix.Add(item);

                    switch (item.Type)
                    {
                        case 0:
                            Fill(Color.Gray, g, i, j); // 0 - земля
                            break;
                        case 1:
                            Fill(Color.Blue, g, i, j); // 1 - місця для будівлі веж
                            break;
                        case 2:
                            Fill(Color.Green, g, i, j); // 2 - точка спавна
                            break;
                        case 3:
                            Fill(Color.Red, g, i, j); // 3 - фініш
                            break;
                        case 4:
                            Fill(Color.Brown, g, i, j); // 4 - клітина ходьби юніта
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
            if (i % 2 == 0 && j % 3 == 0)
            {
                rectangleGame.Type = 1;
            }
            else if (i == 0 && j == 0)
            {
                rectangleGame.Type = 2;
            }
            else if (i == obj.Width && j == obj.Length)
            {
                rectangleGame.Type = 3;
            }
            else if (i == j)
            {
                rectangleGame.Type = 4;
            }
            else
            {
                rectangleGame.Type = 0;
            }
        }

        private static void Fill(Color color, Graphics g, int i, int j)
        {
            Brush b = new SolidBrush(color); // ініцалізація кісті
            g.DrawRectangle(new Pen(new SolidBrush(color)),
                            new Rectangle(new Point(40 * i, 40 * j), new Size(30, 30))); // малювання "кордонів" елемента матриці

            g.FillRectangle(b, 40 * i, 40 * j, 30, 30); // заповнення кольорем елеметна матриці
        }
    }
}
