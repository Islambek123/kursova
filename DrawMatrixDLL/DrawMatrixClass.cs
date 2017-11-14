﻿using System;
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

        private static void Fill(Color color, Graphics graphics, int i, int j)
        {
            Brush brush = new SolidBrush(color); // ініцалізація кісті
            graphics.DrawRectangle(new Pen(new SolidBrush(color)),
                            new Rectangle(new Point(40 * i, 40 * j), new Size(30, 30))); // малювання "кордонів" елемента матриці

            graphics.FillRectangle(brush, 40 * i, 40 * j, 30, 30); // заповнення кольорем елеметна матриці
        }
    }
}
