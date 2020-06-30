using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Dark_Labyrinth_Game
{
    public class Levels
    {
        public static Level level1()
        {
            Field [,] fields = new Field[8,8];
            for (int i = 0; i < 8; i++)
            {
                fields[0, i] = new Wall(0, i);
                fields[7, i] = new Wall(7, i);
                fields[i, 0] = new Wall(i, 0);
                fields[i, 7] = new Wall(i, 7);
            }

            fields[1, 1] = new Path(1, 1);
            fields[1, 2] = new Path(1, 2);
            fields[1, 3] = new Path(1, 3);
            fields[1, 4] = new Path(1, 4);
            fields[1, 5] = new Path(1, 5);
            fields[1, 6] = new Path(1, 6);

            fields[2, 1] = new Path(2, 1);
            fields[2, 2] = new Wall(2, 2);
            fields[2, 3] = new Wall(2, 3);
            fields[2, 4] = new Wall(2, 4);
            fields[2, 5] = new Wall(2, 5);
            fields[2, 6] = new Wall(2, 6);

            fields[3, 1] = new Path(3, 1);
            fields[3, 2] = new Path(3, 2);
            fields[3, 3] = new Path(3, 3);
            fields[3, 4] = new Path(3, 4);
            fields[3, 5] = new Path(3, 5);
            fields[3, 6] = new Path(3, 6);

            // 1/2

            fields[4, 1] = new Wall(4, 1);
            fields[4, 2] = new Wall(4, 2);
            fields[4, 3] = new Wall(4, 3);
            fields[4, 4] = new Path(4, 4);
            fields[4, 5] = new Wall(4, 5);
            fields[4, 6] = new Wall(4, 6);

            fields[5, 1] = new Path(5, 1);
            fields[5, 2] = new Path(5, 2);
            fields[5, 3] = new Path(5, 3);
            fields[5, 4] = new Path(5, 4);
            fields[5, 5] = new Wall(5, 5);
            fields[5, 6] = new Wall(5, 6);

            fields[6, 1] = new Goal(6, 1);
            fields[6, 2] = new Wall(6, 2);
            fields[6, 3] = new Wall(6, 3);
            fields[6, 4] = new Path(6, 4);
            fields[6, 5] = new Wall(6, 5);
            fields[6, 6] = new Wall(6, 6);

            Player player = new Player(fields, 1, 6);
            Level level = new Level(fields, player);
            return level;
        }

        public static Level level2()
        {
            Field[,] fields = new Field[8, 8];
            for (int i = 0; i < 8; i++)
            {
                fields[0, i] = new Wall(0, i);
                fields[7, i] = new Wall(7, i);
                fields[i, 0] = new Wall(i, 0);
                fields[i, 7] = new Wall(i, 7);
            }

            fields[1, 1] = new Wall(1, 1);
            fields[1, 2] = new Wall(1, 2);
            fields[1, 3] = new Wall(1, 3);
            fields[1, 4] = new Wall(1, 4);
            fields[1, 5] = new Path(1, 5);
            fields[1, 6] = new Path(1, 6);

            fields[2, 1] = new Wall(2, 1);
            fields[2, 2] = new Wall(2, 2);
            fields[2, 3] = new Path(2, 3);
            fields[2, 4] = new Path(2, 4);
            fields[2, 5] = new Path(2, 5);
            fields[2, 6] = new Wall(2, 6);

            fields[3, 1] = new Portal(3, 1, 4, 5);
            fields[3, 2] = new Wall(3, 2);
            fields[3, 3] = new Path(3, 3);
            fields[3, 4] = new Wall(3, 4);
            fields[3, 5] = new Wall(3, 5);
            fields[3, 6] = new Wall(3, 6);

            // 1/2

            fields[4, 1] = new Path(4, 1);
            fields[4, 2] = new Wall(4, 2);
            fields[4, 3] = new Path(4, 3);
            fields[4, 4] = new Wall(4, 4);
            fields[4, 5] = new Portal(4, 5, 3, 1);
            fields[4, 6] = new Wall(4, 6);

            fields[5, 1] = new Path(5, 1);
            fields[5, 2] = new Wall(5, 2);
            fields[5, 3] = new Path(5, 3);
            fields[5, 4] = new Wall(5, 4);
            fields[5, 5] = new Path(5, 5);
            fields[5, 6] = new Wall(5, 6);

            fields[6, 1] = new Path(6, 1);
            fields[6, 2] = new Path(6, 2);
            fields[6, 3] = new Path(6, 3);
            fields[6, 4] = new Wall(6, 4);
            fields[6, 5] = new Goal(6, 5);
            fields[6, 6] = new Wall(6, 6);

            Player player = new Player(fields, 1, 6);
            Level level = new Level(fields, player);
            return level;
        }

        public static Level level3()
        {
            Field[,] fields = new Field[10, 10];
            for (int i = 0; i < 10; i++)
            {
                fields[0, i] = new Wall(0, i);
                fields[9, i] = new Wall(9, i);
                fields[i, 0] = new Wall(i, 0);
                fields[i, 9] = new Wall(i, 9);
            }

            fields[1, 1] = new Wall(1, 1);
            fields[1, 2] = new Wall(1, 2);
            fields[1, 3] = new Wall(1, 3);
            fields[1, 4] = new Path(1, 4);
            fields[1, 5] = new Path(1, 5);
            fields[1, 6] = new Path(1, 6);
            fields[1, 7] = new Path(1, 7);
            fields[1, 8] = new Path(1, 8);

            fields[2, 1] = new Path(2, 1);
            fields[2, 2] = new Path(2, 2);
            fields[2, 3] = new Path(2, 3);
            fields[2, 4] = new Path(2, 4);
            fields[2, 5] = new Wall(2, 5);
            fields[2, 6] = new Path(2, 6);
            fields[2, 7] = new Wall(2, 7);
            fields[2, 8] = new Wall(2, 8);

            fields[3, 1] = new Path(3, 1);
            fields[3, 2] = new Wall(3, 2);
            fields[3, 3] = new Wall(3, 3);
            fields[3, 4] = new Path(3, 4);
            fields[3, 5] = new Wall(3, 5);
            fields[3, 6] = new Path(3, 6);
            fields[3, 7] = new Path(3, 7);
            fields[3, 8] = new Wall(3, 8);

            fields[4, 1] = new Path(4, 1);
            fields[4, 2] = new Path(4, 2);
            fields[4, 3] = new Wall(4, 3);
            fields[4, 4] = new Path(4, 4);
            fields[4, 5] = new Path(4, 5);
            fields[4, 6] = new Wall(4, 6);
            fields[4, 7] = new Path(4, 7);
            fields[4, 8] = new Path(4, 8);

            // 1/2

            fields[5, 1] = new Wall(5, 1);
            fields[5, 2] = new Path(5, 2);
            fields[5, 3] = new Wall(5, 3);
            fields[5, 4] = new Wall(5, 4);
            fields[5, 5] = new Path(5, 5);
            fields[5, 6] = new Path(5, 6);
            fields[5, 7] = new Wall(5, 7);
            fields[5, 8] = new Path(5, 8);

            fields[6, 1] = new Path(6, 1);
            fields[6, 2] = new Path(6, 2);
            fields[6, 3] = new Wall(6, 3);
            fields[6, 4] = new Wall(6, 4);
            fields[6, 5] = new Wall(6, 5);
            fields[6, 6] = new Path(6, 6);
            fields[6, 7] = new Path(6, 7);
            fields[6, 8] = new Path(6, 8);

            fields[7, 1] = new Path(7, 1);
            fields[7, 2] = new Wall(7, 2);
            fields[7, 3] = new Wall(7, 3);
            fields[7, 4] = new Wall(7, 4);
            fields[7, 5] = new Wall(7, 5);
            fields[7, 6] = new Path(7, 6);
            fields[7, 7] = new Wall(7, 7);
            fields[7, 8] = new Wall(7, 8);

            fields[8, 1] = new Path(8, 1);
            fields[8, 2] = new Path(8, 2);
            fields[8, 3] = new Path(8, 3);
            fields[8, 4] = new Goal(8, 4);
            fields[8, 5] = new Wall(8, 5);
            fields[8, 6] = new Path(8, 6);
            fields[8, 7] = new Wall(8, 7);
            fields[8, 8] = new Wall(8, 8);

            Player player = new Player(fields, 1, 8);
            Level level = new Level(fields, player);
            return level;
        }

        public static Level level4()
        {
            Field[,] fields = new Field[12, 12];
            for (int i = 0; i < 12; i++)
            {
                fields[0, i] = new Wall(0, i);
                fields[11, i] = new Wall(11, i);
                fields[i, 0] = new Wall(i, 0);
                fields[i, 11] = new Wall(i, 11);
            }

            fields[1, 1] = new Path(1, 1);
            fields[1, 2] = new Path(1, 2);
            fields[1, 3] = new Path(1, 3);
            fields[1, 4] = new Wall(1, 4);
            fields[1, 5] = new Path(1, 5);
            fields[1, 6] = new Path(1, 6);
            fields[1, 7] = new Path(1, 7);
            fields[1, 8] = new Wall(1, 8);
            fields[1, 9] = new Path(1, 9);
            fields[1, 10] = new Wall(1, 10);

            fields[2, 1] = new Path(2, 1);
            fields[2, 2] = new Wall(2, 2);
            fields[2, 3] = new Path(2, 3);
            fields[2, 4] = new Wall(2, 4);
            fields[2, 5] = new Wall(2, 5);
            fields[2, 6] = new Wall(2, 6);
            fields[2, 7] = new Path(2, 7);
            fields[2, 8] = new Wall(2, 8);
            fields[2, 9] = new Path(2, 9);
            fields[2, 10] = new Wall(2, 10);

            fields[3, 1] = new Wall(3, 1);
            fields[3, 2] = new Wall(3, 2);
            fields[3, 3] = new Path(3, 3);
            fields[3, 4] = new Path(3, 4);
            fields[3, 5] = new Path(3, 5);
            fields[3, 6] = new Wall(3, 6);
            fields[3, 7] = new Path(3, 7);
            fields[3, 8] = new Path(3, 8);
            fields[3, 9] = new Path(3, 9);
            fields[3, 10] = new Path(3, 10);

            fields[4, 1] = new Portal(4, 1, 9, 6);
            fields[4, 2] = new Wall(4, 2);
            fields[4, 3] = new Wall(4, 3);
            fields[4, 4] = new Wall(4, 4);
            fields[4, 5] = new Path(4, 5);
            fields[4, 6] = new Wall(4, 6);
            fields[4, 7] = new Wall(4, 7);
            fields[4, 8] = new Wall(4, 8);
            fields[4, 9] = new Wall(4, 9);
            fields[4, 10] = new Path(4, 10);

            fields[5, 1] = new Path(5, 1);
            fields[5, 2] = new Wall(5, 2);
            fields[5, 3] = new Wall(5, 3);
            fields[5, 4] = new Wall(5, 4);
            fields[5, 5] = new Path(5, 5);
            fields[5, 6] = new Path(5, 6);
            fields[5, 7] = new Path(5, 7);
            fields[5, 8] = new Path(5, 8);
            fields[5, 9] = new Path(5, 9);
            fields[5, 10] = new Path(5, 10);

            // 1/2

            fields[6, 1] = new Path(6, 1);
            fields[6, 2] = new Path(6, 2);
            fields[6, 3] = new Path(6, 3);
            fields[6, 4] = new Path(6, 4);
            fields[6, 5] = new Path(6, 5);
            fields[6, 6] = new Wall(6, 6);
            fields[6, 7] = new Wall(6, 7);
            fields[6, 8] = new Path(6, 8);
            fields[6, 9] = new Wall(6, 9);
            fields[6, 10] = new Wall(6, 10);

            fields[7, 1] = new Wall(7, 1);
            fields[7, 2] = new Wall(7, 2);
            fields[7, 3] = new Wall(7, 3);
            fields[7, 4] = new Wall(7, 4);
            fields[7, 5] = new Wall(7, 5);
            fields[7, 6] = new Wall(7, 6);
            fields[7, 7] = new Wall(7, 7);
            fields[7, 8] = new Path(7, 8);
            fields[7, 9] = new Wall(7, 9);
            fields[7, 10] = new Path(7, 10);

            fields[8, 1] = new Path(8, 1);
            fields[8, 2] = new Path(8, 2);
            fields[8, 3] = new Path(8, 3);
            fields[8, 4] = new Path(8, 4);
            fields[8, 5] = new Path(8, 5);
            fields[8, 6] = new Wall(8, 6);
            fields[8, 7] = new Wall(8, 7);
            fields[8, 8] = new Path(8, 8);
            fields[8, 9] = new Wall(8, 9);
            fields[8, 10] = new Path(8, 10);

            fields[9, 1] = new Path(9, 1);
            fields[9, 2] = new Wall(9, 2);
            fields[9, 3] = new Wall(9, 3);
            fields[9, 4] = new Wall(9, 4);
            fields[9, 5] = new Path(9, 5);
            fields[9, 6] = new Portal(9, 6, 4, 1);
            fields[9, 7] = new Wall(9, 7);
            fields[9, 8] = new Path(9, 8);
            fields[9, 9] = new Path(9, 9);
            fields[9, 10] = new Path(9, 10);

            fields[10, 1] = new Goal(10, 1);
            fields[10, 2] = new Wall(10, 2);
            fields[10, 3] = new Path(10, 3);
            fields[10, 4] = new Path(10, 4);
            fields[10, 5] = new Path(10, 5);
            fields[10, 6] = new Wall(10, 6);
            fields[10, 7] = new Wall(10, 7);
            fields[10, 8] = new Wall(10, 8);
            fields[10, 9] = new Wall(10, 9);
            fields[10, 10] = new Wall(10, 10);

            Player player = new Player(fields, 1, 5);
            Level level = new Level(fields, player);
            return level;
        }

        public static Level level5()
        {
            Field[,] fields = new Field[14, 14];
            for (int i = 0; i < 14; i++)
            {
                fields[0, i] = new Wall(0, i);
                fields[13, i] = new Wall(13, i);
                fields[i, 0] = new Wall(i, 0);
                fields[i, 13] = new Wall(i, 13);
            }

            fields[1, 1] = new Wall(1, 1);
            fields[1, 2] = new Wall(1, 2);
            fields[1, 3] = new Path(1, 3);
            fields[1, 4] = new Path(1, 4);
            fields[1, 5] = new Path(1, 5);
            fields[1, 6] = new Path(1, 6);
            fields[1, 7] = new Path(1, 7);
            fields[1, 8] = new Path(1, 8);
            fields[1, 9] = new Wall(1, 9);
            fields[1, 10] = new Path(1, 10);
            fields[1, 11] = new Path(1, 11);
            fields[1, 12] = new Path(1, 12);

            fields[2, 1] = new Path(2, 1);
            fields[2, 2] = new Path(2, 2);
            fields[2, 3] = new Path(2, 3);
            fields[2, 4] = new Wall(2, 4);
            fields[2, 5] = new Wall(2, 5);
            fields[2, 6] = new Wall(2, 6);
            fields[2, 7] = new Wall(2, 7);
            fields[2, 8] = new Path(2, 8);
            fields[2, 9] = new Wall(2, 9);
            fields[2, 10] = new Path(2, 10);
            fields[2, 11] = new Wall(2, 11);
            fields[2, 12] = new Path(2, 12);

            fields[3, 1] = new Path(3, 1);
            fields[3, 2] = new Wall(3, 2);
            fields[3, 3] = new Wall(3, 3);
            fields[3, 4] = new Path(3, 4);
            fields[3, 5] = new Path(3, 5);
            fields[3, 6] = new Path(3, 6);
            fields[3, 7] = new Path(3, 7);
            fields[3, 8] = new Path(3, 8);
            fields[3, 9] = new Path(3, 9);
            fields[3, 10] = new Path(3, 10);
            fields[3, 11] = new Wall(3, 11);
            fields[3, 12] = new Path(3, 12);

            fields[4, 1] = new Path(4, 1);
            fields[4, 2] = new Path(4, 2);
            fields[4, 3] = new Path(4, 3);
            fields[4, 4] = new Wall(4, 4);
            fields[4, 5] = new Wall(4, 5);
            fields[4, 6] = new Wall(4, 6);
            fields[4, 7] = new Wall(4, 7);
            fields[4, 8] = new Wall(4, 8);
            fields[4, 9] = new Wall(4, 9);
            fields[4, 10] = new Path(4, 10);
            fields[4, 11] = new Wall(4, 11);
            fields[4, 12] = new Path(4, 12);

            // 1/3

            fields[5, 1] = new Wall(5, 1);
            fields[5, 2] = new Wall(5, 2);
            fields[5, 3] = new Path(5, 3);
            fields[5, 4] = new Wall(5, 4);
            fields[5, 5] = new Path(5, 5);
            fields[5, 6] = new Path(5, 6);
            fields[5, 7] = new Path(5, 7);
            fields[5, 8] = new Path(5, 8);
            fields[5, 9] = new Path(5, 9);
            fields[5, 10] = new Path(5, 10);
            fields[5, 11] = new Wall(5, 11);
            fields[5, 12] = new Path(5, 12);

            fields[6, 1] = new Path(6, 1);
            fields[6, 2] = new Path(6, 2);
            fields[6, 3] = new Path(6, 3);
            fields[6, 4] = new Wall(6, 4);
            fields[6, 5] = new Path(6, 5);
            fields[6, 6] = new Wall(6, 6);
            fields[6, 7] = new Wall(6, 7);
            fields[6, 8] = new Path(6, 8);
            fields[6, 9] = new Wall(6, 9);
            fields[6, 10] = new Wall(6, 10);
            fields[6, 11] = new Wall(6, 11);
            fields[6, 12] = new Path(6, 12);

            fields[7, 1] = new Path(7, 1);
            fields[7, 2] = new Wall(7, 2);
            fields[7, 3] = new Wall(7, 3);
            fields[7, 4] = new Wall(7, 4);
            fields[7, 5] = new Path(7, 5);
            fields[7, 6] = new Wall(7, 6);
            fields[7, 7] = new Wall(7, 7);
            fields[7, 8] = new Path(7, 8);
            fields[7, 9] = new Wall(7, 9);
            fields[7, 10] = new Path(7, 10);
            fields[7, 11] = new Path(7, 11);
            fields[7, 12] = new Path(7, 12);

            fields[8, 1] = new Path(8, 1);
            fields[8, 2] = new Wall(8, 2);
            fields[8, 3] = new Path(8, 3);
            fields[8, 4] = new Wall(8, 4);
            fields[8, 5] = new Path(8, 5);
            fields[8, 6] = new Wall(8, 6);
            fields[8, 7] = new Wall(8, 7);
            fields[8, 8] = new Path(8, 8);
            fields[8, 9] = new Wall(8, 9);
            fields[8, 10] = new Path(8, 10);
            fields[8, 11] = new Wall(8, 11);
            fields[8, 12] = new Wall(8, 12);

            // 2/3

            fields[9, 1] = new Path(9, 1);
            fields[9, 2] = new Wall(9, 2);
            fields[9, 3] = new Path(9, 3);
            fields[9, 4] = new Wall(9, 4);
            fields[9, 5] = new Wall(9, 5);
            fields[9, 6] = new Wall(9, 6);
            fields[9, 7] = new Wall(9, 7);
            fields[9, 8] = new Portal(9, 8, 10, 12);
            fields[9, 9] = new Wall(9, 9);
            fields[9, 10] = new Path(9, 10);
            fields[9, 11] = new Wall(9, 11);
            fields[9, 12] = new Wall(9, 12);

            fields[10, 1] = new Path(10, 1);
            fields[10, 2] = new Wall(10, 2);
            fields[10, 3] = new Path(10, 3);
            fields[10, 4] = new Path(10, 4);
            fields[10, 5] = new Path(10, 5);
            fields[10, 6] = new Path(10, 6);
            fields[10, 7] = new Wall(10, 7);
            fields[10, 8] = new Wall(10, 8);
            fields[10, 9] = new Wall(10, 9);
            fields[10, 10] = new Path(10, 10);
            fields[10, 11] = new Wall(10, 11);
            fields[10, 12] = new Portal(10, 12, 9, 8);

            fields[11, 1] = new Path(11, 1);
            fields[11, 2] = new Wall(11, 2);
            fields[11, 3] = new Path(11, 3);
            fields[11, 4] = new Wall(11, 4);
            fields[11, 5] = new Wall(11, 5);
            fields[11, 6] = new Wall(11, 6);
            fields[11, 7] = new Path(11, 7);
            fields[11, 8] = new Wall(11, 8);
            fields[11, 9] = new Wall(11, 9);
            fields[11, 10] = new Path(11, 10);
            fields[11, 11] = new Wall(11, 11);
            fields[11, 12] = new Path(11, 12);

            fields[12, 1] = new Path(12, 1);
            fields[12, 2] = new Path(12, 2);
            fields[12, 3] = new Path(12, 3);
            fields[12, 4] = new Path(12, 4);
            fields[12, 5] = new Path(12, 5);
            fields[12, 6] = new Path(12, 6);
            fields[12, 7] = new Path(12, 7);
            fields[12, 8] = new Path(12, 8);
            fields[12, 9] = new Path(12, 9);
            fields[12, 10] = new Path(12, 10);
            fields[12, 11] = new Wall(12, 11);
            fields[12, 12] = new Goal(12, 12);

            Player player = new Player(fields, 3, 4);
            Level level = new Level(fields, player);
            return level;
        }

        public static Level level6()
        {
            Field[,] fields = new Field[16, 16];
            for (int i = 0; i < 16; i++)
            {
                fields[0, i] = new Wall(0, i);
                fields[15, i] = new Wall(15, i);
                fields[i, 0] = new Wall(i, 0);
                fields[i, 15] = new Wall(i, 15);
            }

            fields[1, 1] = new Portal(1, 1, 9, 8);
            fields[1, 2] = new Path(1, 2);
            fields[1, 3] = new Path(1, 3);
            fields[1, 4] = new Wall(1, 4);
            fields[1, 5] = new Path(1, 5);
            fields[1, 6] = new Path(1, 6);
            fields[1, 7] = new Path(1, 7);
            fields[1, 8] = new Path(1, 8);
            fields[1, 9] = new Path(1, 9);
            fields[1, 10] = new Path(1, 10);
            fields[1, 11] = new Path(1, 11);
            fields[1, 12] = new Wall(1, 12);
            fields[1, 13] = new Wall(1, 13);
            fields[1, 14] = new Wall(1, 14);

            fields[2, 1] = new Path(2, 1);
            fields[2, 2] = new Wall(2, 2);
            fields[2, 3] = new Path(2, 3);
            fields[2, 4] = new Path(2, 4);
            fields[2, 5] = new Path(2, 5);
            fields[2, 6] = new Wall(2, 6);
            fields[2, 7] = new Wall(2, 7);
            fields[2, 8] = new Wall(2, 8);
            fields[2, 9] = new Path(2, 9);
            fields[2, 10] = new Wall(2, 10);
            fields[2, 11] = new Path(2, 11);
            fields[2, 12] = new Wall(2, 12);
            fields[2, 13] = new Wall(2, 13);
            fields[2, 14] = new Wall(2, 14);

            // 1/7

            fields[3, 1] = new Path(3, 1);
            fields[3, 2] = new Wall(3, 2);
            fields[3, 3] = new Wall(3, 3);
            fields[3, 4] = new Wall(3, 4);
            fields[3, 5] = new Wall(3, 5);
            fields[3, 6] = new Wall(3, 6);
            fields[3, 7] = new Wall(3, 7);
            fields[3, 8] = new Path(3, 8);
            fields[3, 9] = new Path(3, 9);
            fields[3, 10] = new Wall(3, 10);
            fields[3, 11] = new Path(3, 11);
            fields[3, 12] = new Path(3, 12);
            fields[3, 13] = new Path(3, 13);
            fields[3, 14] = new Path(3, 14);

            fields[4, 1] = new Path(4, 1);
            fields[4, 2] = new Path(4, 2);
            fields[4, 3] = new Path(4, 3);
            fields[4, 4] = new Path(4, 4);
            fields[4, 5] = new Path(4, 5);
            fields[4, 6] = new Path(4, 6);
            fields[4, 7] = new Wall(4, 7);
            fields[4, 8] = new Path(4, 8);
            fields[4, 9] = new Wall(4, 9);
            fields[4, 10] = new Wall(4, 10);
            fields[4, 11] = new Path(4, 11);
            fields[4, 12] = new Wall(4, 12);
            fields[4, 13] = new Wall(4, 13);
            fields[4, 14] = new Path(4, 14);

            // 2/7

            fields[5, 1] = new Wall(5, 1);
            fields[5, 2] = new Wall(5, 2);
            fields[5, 3] = new Wall(5, 3);
            fields[5, 4] = new Wall(5, 4);
            fields[5, 5] = new Wall(5, 5);
            fields[5, 6] = new Path(5, 6);
            fields[5, 7] = new Wall(5, 7);
            fields[5, 8] = new Path(5, 8);
            fields[5, 9] = new Wall(5, 9);
            fields[5, 10] = new Wall(5, 10);
            fields[5, 11] = new Path(5, 11);
            fields[5, 12] = new Path(5, 12);
            fields[5, 13] = new Wall(5, 13);
            fields[5, 14] = new Path(5, 14);

            fields[6, 1] = new Portal(6, 1, 13, 6);
            fields[6, 2] = new Path(6, 2);
            fields[6, 3] = new Path(6, 3);
            fields[6, 4] = new Path(6, 4);
            fields[6, 5] = new Wall(6, 5);
            fields[6, 6] = new Path(6, 6);
            fields[6, 7] = new Wall(6, 7);
            fields[6, 8] = new Wall(6, 8);
            fields[6, 9] = new Wall(6, 9);
            fields[6, 10] = new Wall(6, 10);
            fields[6, 11] = new Wall(6, 11);
            fields[6, 12] = new Path(6, 12);
            fields[6, 13] = new Wall(6, 13);
            fields[6, 14] = new Path(6, 14);

            // 3/7

            fields[7, 1] = new Path(7, 1);
            fields[7, 2] = new Wall(7, 2);
            fields[7, 3] = new Wall(7, 3);
            fields[7, 4] = new Path(7, 4);
            fields[7, 5] = new Wall(7, 5);
            fields[7, 6] = new Path(7, 6);
            fields[7, 7] = new Path(7, 7);
            fields[7, 8] = new Path(7, 8);
            fields[7, 9] = new Path(7, 9);
            fields[7, 10] = new Path(7, 10);
            fields[7, 11] = new Path(7, 11);
            fields[7, 12] = new Path(7, 12);
            fields[7, 13] = new Wall(7, 13);
            fields[7, 14] = new Wall(7, 14);

            fields[8, 1] = new Path(8, 1);
            fields[8, 2] = new Path(8, 2);
            fields[8, 3] = new Wall(8, 3);
            fields[8, 4] = new Path(8, 4);
            fields[8, 5] = new Wall(8, 5);
            fields[8, 6] = new Wall(8, 6);
            fields[8, 7] = new Wall(8, 7);
            fields[8, 8] = new Wall(8, 8);
            fields[8, 9] = new Wall(8, 9);
            fields[8, 10] = new Wall(8, 10);
            fields[8, 11] = new Wall(8, 11);
            fields[8, 12] = new Path(8, 12);
            fields[8, 13] = new Path(8, 13);
            fields[8, 14] = new Path(8, 14);

            // 4/7

            fields[9, 1] = new Wall(9, 1);
            fields[9, 2] = new Path(9, 2);
            fields[9, 3] = new Wall(9, 3);
            fields[9, 4] = new Wall(9, 4);
            fields[9, 5] = new Wall(9, 5);
            fields[9, 6] = new Path(9, 6);
            fields[9, 7] = new Path(9, 7);
            fields[9, 8] = new Portal(9, 8, 1, 1);
            fields[9, 9] = new Wall(9, 9);
            fields[9, 10] = new Goal(9, 10);
            fields[9, 11] = new Wall(9, 11);
            fields[9, 12] = new Wall(9, 12);
            fields[9, 13] = new Wall(9, 13);
            fields[9, 14] = new Path(9, 14);

            fields[10, 1] = new Path(10, 1);
            fields[10, 2] = new Path(10, 2);
            fields[10, 3] = new Wall(10, 3);
            fields[10, 4] = new Path(10, 4);
            fields[10, 5] = new Wall(10, 5);
            fields[10, 6] = new Wall(10, 6);
            fields[10, 7] = new Wall(10, 7);
            fields[10, 8] = new Wall(10, 8);
            fields[10, 9] = new Wall(10, 9);
            fields[10, 10] = new Path(10, 10);
            fields[10, 11] = new Wall(10, 11);
            fields[10, 12] = new Path(10, 12);
            fields[10, 13] = new Path(10, 13);
            fields[10, 14] = new Path(10, 14);

            // 5/7

            fields[11, 1] = new Path(11, 1);
            fields[11, 2] = new Wall(11, 2);
            fields[11, 3] = new Wall(11, 3);
            fields[11, 4] = new Path(11, 4);
            fields[11, 5] = new Path(11, 5);
            fields[11, 6] = new Path(11, 6);
            fields[11, 7] = new Path(11, 7);
            fields[11, 8] = new Path(11, 8);
            fields[11, 9] = new Path(11, 9);
            fields[11, 10] = new Path(11, 10);
            fields[11, 11] = new Wall(11, 11);
            fields[11, 12] = new Path(11, 12);
            fields[11, 13] = new Wall(11, 13);
            fields[11, 14] = new Path(11, 14);

            fields[12, 1] = new Path(12, 1);
            fields[12, 2] = new Wall(12, 2);
            fields[12, 3] = new Wall(12, 3);
            fields[12, 4] = new Path(12, 4);
            fields[12, 5] = new Wall(12, 5);
            fields[12, 6] = new Wall(12, 6);
            fields[12, 7] = new Wall(12, 7);
            fields[12, 8] = new Wall(12, 8);
            fields[12, 9] = new Wall(12, 9);
            fields[12, 10] = new Wall(12, 10);
            fields[12, 11] = new Wall(12, 11);
            fields[12, 12] = new Path(12, 12);
            fields[12, 13] = new Wall(12, 13);
            fields[12, 14] = new Path(12, 14);

            // 6/7

            fields[13, 1] = new Path(13, 1);
            fields[13, 2] = new Wall(13, 2);
            fields[13, 3] = new Wall(13, 3);
            fields[13, 4] = new Path(13, 4);
            fields[13, 5] = new Wall(13, 5);
            fields[13, 6] = new Portal(13, 6, 6, 1);
            fields[13, 7] = new Path(13, 7);
            fields[13, 8] = new Wall(13, 8);
            fields[13, 9] = new Wall(13, 9);
            fields[13, 10] = new Path(13, 10);
            fields[13, 11] = new Path(13, 11);
            fields[13, 12] = new Path(13, 12);
            fields[13, 13] = new Wall(13, 13);
            fields[13, 14] = new Path(13, 14);

            fields[14, 1] = new Path(14, 1);
            fields[14, 2] = new Path(14, 2);
            fields[14, 3] = new Path(14, 3);
            fields[14, 4] = new Path(14, 4);
            fields[14, 5] = new Wall(14, 5);
            fields[14, 6] = new Wall(14, 6);
            fields[14, 7] = new Path(14, 7);
            fields[14, 8] = new Path(14, 8);
            fields[14, 9] = new Path(14, 9);
            fields[14, 10] = new Path(14, 10);
            fields[14, 11] = new Wall(14, 11);
            fields[14, 12] = new Wall(14, 12);
            fields[14, 13] = new Wall(14, 13);
            fields[14, 14] = new Wall(14, 14);

            Player player = new Player(fields, 9, 6);
            Level level = new Level(fields, player);
            return level;
        }

        // UNFINISHED no walls

        public static Level level7()
        {
            Field[,] fields = new Field[18, 18];
            for (int i = 0; i < 18; i++)
            {
                fields[0, i] = new Wall(0, i);
                fields[17, i] = new Wall(17, i);
                fields[i, 0] = new Wall(i, 0);
                fields[i, 17] = new Wall(i, 17);
            }

            fields[1, 1] = new Path(1, 1);
            fields[1, 2] = new Path(1, 2);
            fields[1, 3] = new Path(1, 3);
            fields[1, 4] = new Path(1, 4);
            fields[1, 5] = new Path(1, 5);
            fields[1, 6] = new Wall(1, 6);
            fields[1, 7] = new Wall(1, 7);
            fields[1, 8] = new Wall(1, 8);
            fields[1, 9] = new Wall(1, 9);
            fields[1, 10] = new Wall(1, 10);
            fields[1, 11] = new Wall(1, 11);
            fields[1, 12] = new Wall(1, 12);
            fields[1, 13] = new Wall(1, 13);
            fields[1, 14] = new Wall(1, 14);
            fields[1, 15] = new Wall(1, 15);
            fields[1, 16] = new Wall(1, 16);

            fields[2, 1] = new Path(2, 1);
            fields[2, 2] = new Wall(2, 2);
            fields[2, 3] = new Wall(2, 3);
            fields[2, 4] = new Wall(2, 4);
            fields[2, 5] = new Path(2, 5);
            fields[2, 6] = new Path(2, 6);
            fields[2, 7] = new Path(2, 7);
            fields[2, 8] = new Path(2, 8);
            fields[2, 9] = new Path(2, 9);
            fields[2, 10] = new Path(2, 10);
            fields[2, 11] = new Path(2, 11);
            fields[2, 12] = new Path(2, 12);
            fields[2, 13] = new Path(2, 13);
            fields[2, 14] = new Wall(2, 14);
            fields[2, 15] = new Path(2, 15);
            fields[2, 16] = new Wall(2, 16);

            fields[3, 1] = new Path(3, 1);
            fields[3, 2] = new Wall(3, 2);
            fields[3, 3] = new Wall(3, 3);
            fields[3, 4] = new Wall(3, 4);
            fields[3, 5] = new Path(3, 5);
            fields[3, 6] = new Wall(3, 6);
            fields[3, 7] = new Wall(3, 7);
            fields[3, 8] = new Wall(3, 8);
            fields[3, 9] = new Wall(3, 9);
            fields[3, 10] = new Wall(3, 10);
            fields[3, 11] = new Wall(3, 11);
            fields[3, 12] = new Wall(3, 12);
            fields[3, 13] = new Path(3, 13);
            fields[3, 14] = new Wall(3, 14);
            fields[3, 15] = new Path(3, 15);
            fields[3, 16] = new Wall(3, 16);

            fields[4, 1] = new Path(4, 1);
            fields[4, 2] = new Path(4, 2);
            fields[4, 3] = new Path(4, 3);
            fields[4, 4] = new Wall(4, 4);
            fields[4, 5] = new Path(4, 5);
            fields[4, 6] = new Wall(4, 6);
            fields[4, 7] = new Path(4, 7);
            fields[4, 8] = new Path(4, 8);
            fields[4, 9] = new Path(4, 9);
            fields[4, 10] = new Path(4, 10);
            fields[4, 11] = new Path(4, 11);
            fields[4, 12] = new Wall(4, 12);
            fields[4, 13] = new Path(4, 13);
            fields[4, 14] = new Wall(4, 14);
            fields[4, 15] = new Path(4, 15);
            fields[4, 16] = new Wall(4, 16);

            // 1/4

            fields[5, 1] = new Path(5, 1);
            fields[5, 2] = new Wall(5, 2);
            fields[5, 3] = new Wall(5, 3);
            fields[5, 4] = new Wall(5, 4);
            fields[5, 5] = new Path(5, 5);
            fields[5, 6] = new Wall(5, 6);
            fields[5, 7] = new Path(5, 7);
            fields[5, 8] = new Wall(5, 8);
            fields[5, 9] = new Wall(5, 9);
            fields[5, 10] = new Wall(5, 10);
            fields[5, 11] = new Path(5, 11);
            fields[5, 12] = new Path(5, 12);
            fields[5, 13] = new Path(5, 13);
            fields[5, 14] = new Wall(5, 14);
            fields[5, 15] = new Path(5, 15);
            fields[5, 16] = new Wall(5, 16);

            fields[6, 1] = new Path(6, 1);
            fields[6, 2] = new Path(6, 2);
            fields[6, 3] = new Path(6, 3);
            fields[6, 4] = new Wall(6, 4);
            fields[6, 5] = new Path(6, 5);
            fields[6, 6] = new Wall(6, 6);
            fields[6, 7] = new Path(6, 7);
            fields[6, 8] = new Wall(6, 8);
            fields[6, 9] = new Path(6, 9);
            fields[6, 10] = new Wall(6, 10);
            fields[6, 11] = new Path(6, 11);
            fields[6, 12] = new Wall(6, 12);
            fields[6, 13] = new Wall(6, 13);
            fields[6, 14] = new Wall(6, 14);
            fields[6, 15] = new Path(6, 15);
            fields[6, 16] = new Wall(6, 16);

            fields[7, 1] = new Path(7, 1);
            fields[7, 2] = new Wall(7, 2);
            fields[7, 3] = new Path(7, 3);
            fields[7, 4] = new Wall(7, 4);
            fields[7, 5] = new Path(7, 5);
            fields[7, 6] = new Wall(7, 6);
            fields[7, 7] = new Wall(7, 7);
            fields[7, 8] = new Wall(7, 8);
            fields[7, 9] = new Path(7, 9);
            fields[7, 10] = new Wall(7, 10);
            fields[7, 11] = new Path(7, 11);
            fields[7, 12] = new Wall(7, 12);
            fields[7, 13] = new Wall(7, 13);
            fields[7, 14] = new Wall(7, 14);
            fields[7, 15] = new Path(7, 15);
            fields[7, 16] = new Wall(7, 16);

            fields[8, 1] = new Path(8, 1);
            fields[8, 2] = new Wall(8, 2);
            fields[8, 3] = new Path(8, 3);
            fields[8, 4] = new Wall(8, 4);
            fields[8, 5] = new Path(8, 5);
            fields[8, 6] = new Path(8, 6);
            fields[8, 7] = new Path(8, 7);
            fields[8, 8] = new Path(8, 8);
            fields[8, 9] = new Path(8, 9);
            fields[8, 10] = new Wall(8, 10);
            fields[8, 11] = new Portal(8, 11, 16, 7);
            fields[8, 12] = new Wall(8, 12);
            fields[8, 13] = new Path(8, 13);
            fields[8, 14] = new Path(8, 14);
            fields[8, 15] = new Path(8, 15);
            fields[8, 16] = new Path(8, 16);

            // 2/4

            fields[9, 1] = new Path(9, 1);
            fields[9, 2] = new Wall(9, 2);
            fields[9, 3] = new Path(9, 3);
            fields[9, 4] = new Wall(9, 4);
            fields[9, 5] = new Wall(9, 5);
            fields[9, 6] = new Wall(9, 6);
            fields[9, 7] = new Wall(9, 7);
            fields[9, 8] = new Wall(9, 8);
            fields[9, 9] = new Wall(9, 9);
            fields[9, 10] = new Wall(9, 10);
            fields[9, 11] = new Wall(9, 11);
            fields[9, 12] = new Wall(9, 12);
            fields[9, 13] = new Path(9, 13);
            fields[9, 14] = new Wall(9, 14);
            fields[9, 15] = new Wall(9, 15);
            fields[9, 16] = new Wall(9, 16);
            
            fields[10, 1] = new Wall(10, 1);
            fields[10, 2] = new Wall(10, 2);
            fields[10, 3] = new Path(10, 3);
            fields[10, 4] = new Path(10, 4);
            fields[10, 5] = new Path(10, 5);
            fields[10, 6] = new Path(10, 6);
            fields[10, 7] = new Path(10, 7);
            fields[10, 8] = new Wall(10, 8);
            fields[10, 9] = new Wall(10, 9);
            fields[10, 10] = new Wall(10, 10);
            fields[10, 11] = new Path(10, 11);
            fields[10, 12] = new Wall(10, 12);
            fields[10, 13] = new Path(10, 13);
            fields[10, 14] = new Path(10, 14);
            fields[10, 15] = new Path(10, 15);
            fields[10, 16] = new Wall(10, 16);

            fields[11, 1] = new Path(11, 1);
            fields[11, 2] = new Wall(11, 2);
            fields[11, 3] = new Wall(11, 3);
            fields[11, 4] = new Wall(11, 4);
            fields[11, 5] = new Path(11, 5);
            fields[11, 6] = new Wall(11, 6);
            fields[11, 7] = new Wall(11, 7);
            fields[11, 8] = new Wall(11, 8);
            fields[11, 9] = new Path(11, 9);
            fields[11, 10] = new Wall(11, 10);
            fields[11, 11] = new Path(11, 11);
            fields[11, 12] = new Wall(11, 12);
            fields[11, 13] = new Wall(11, 13);
            fields[11, 14] = new Wall(11, 14);
            fields[11, 15] = new Path(11, 15);
            fields[11, 16] = new Wall(11, 16);

            fields[12, 1] = new Path(12, 1);
            fields[12, 2] = new Path(12, 2);
            fields[12, 3] = new Path(12, 3);
            fields[12, 4] = new Wall(12, 4);
            fields[12, 5] = new Portal(12, 5, 16, 2);
            fields[12, 6] = new Wall(12, 6);
            fields[12, 7] = new Path(12, 7);
            fields[12, 8] = new Path(12, 8);
            fields[12, 9] = new Path(12, 9);
            fields[12, 10] = new Wall(12, 10);
            fields[12, 11] = new Path(12, 11);
            fields[12, 12] = new Path(12, 12);
            fields[12, 13] = new Path(12, 13);
            fields[12, 14] = new Wall(12, 14);
            fields[12, 15] = new Path(12, 15);
            fields[12, 16] = new Path(12, 16);

            // 3/4

            fields[13, 1] = new Wall(13, 1);
            fields[13, 2] = new Wall(13, 2);
            fields[13, 3] = new Path(13, 3);
            fields[13, 4] = new Wall(13, 4);
            fields[13, 5] = new Wall(13, 5);
            fields[13, 6] = new Wall(13, 6);
            fields[13, 7] = new Path(13, 7);
            fields[13, 8] = new Wall(13, 8);
            fields[13, 9] = new Path(13, 9);
            fields[13, 10] = new Wall(13, 10);
            fields[13, 11] = new Wall(13, 11);
            fields[13, 12] = new Wall(13, 12);
            fields[13, 13] = new Path(13, 13);
            fields[13, 14] = new Wall(13, 14);
            fields[13, 15] = new Wall(13, 15);
            fields[13, 16] = new Path(13, 16);

            fields[14, 1] = new Wall(14, 1);
            fields[14, 2] = new Wall(14, 2);
            fields[14, 3] = new Path(14, 3);
            fields[14, 4] = new Path(14, 4);
            fields[14, 5] = new Path(14, 5);
            fields[14, 6] = new Path(14, 6);
            fields[14, 7] = new Path(14, 7);
            fields[14, 8] = new Wall(14, 8);
            fields[14, 9] = new Path(14, 9);
            fields[14, 10] = new Path(14, 10);
            fields[14, 11] = new Path(14, 11);
            fields[14, 12] = new Wall(14, 12);
            fields[14, 13] = new Path(14, 13);
            fields[14, 14] = new Path(14, 14);
            fields[14, 15] = new Path(14, 15);
            fields[14, 16] = new Path(14, 16);

            fields[15, 1] = new Goal(15, 1);
            fields[15, 2] = new Wall(15, 2);
            fields[15, 3] = new Wall(15, 3);
            fields[15, 4] = new Path(15, 4);
            fields[15, 5] = new Wall(15, 5);
            fields[15, 6] = new Wall(15, 6);
            fields[15, 7] = new Wall(15, 7);
            fields[15, 8] = new Wall(15, 8);
            fields[15, 9] = new Wall(15, 9);
            fields[15, 10] = new Wall(15, 10);
            fields[15, 11] = new Path(15, 11);
            fields[15, 12] = new Wall(15, 12);
            fields[15, 13] = new Wall(15, 13);
            fields[15, 14] = new Wall(15, 14);
            fields[15, 15] = new Wall(15, 15);
            fields[15, 16] = new Path(15, 16);

            fields[16, 1] = new Path(16, 1);
            fields[16, 2] = new Portal(16, 2, 12, 5);
            fields[16, 3] = new Wall(16, 3);
            fields[16, 4] = new Path(16, 4);
            fields[16, 5] = new Path(16, 5);
            fields[16, 6] = new Path(16, 6);
            fields[16, 7] = new Portal(16, 7, 8, 11);
            fields[16, 8] = new Wall(16, 8);
            fields[16, 9] = new Path(16, 9);
            fields[16, 10] = new Path(16, 10);
            fields[16, 11] = new Path(16, 11);
            fields[16, 12] = new Path(16, 12);
            fields[16, 13] = new Path(16, 13);
            fields[16, 14] = new Path(16, 14);
            fields[16, 15] = new Path(16, 15);
            fields[16, 16] = new Path(16, 16);

            Player player = new Player(fields, 8, 16);
            Level level = new Level(fields, player);
            return level;
        }
    }
}
