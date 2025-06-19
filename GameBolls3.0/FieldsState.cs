using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameBolls3._0
{
    class FieldsState
    {
        public void InitializeField(string[,] gameField, string level)
        {
            // Инициализация пустого поля
            for (int i = 4; i > 0; i--)
            {
                for (int j = 2; j < 15; j += 4)
                {
                    gameField[i, j] = "N";
                }
            }

            Random rnd = new Random();

            if (level == "1")
            {
                InitializeLevel1(gameField, rnd);
            }
            else if (level == "2")
            {
                InitializeLevel2(gameField, rnd);
            }
            else
            {
                InitializeLevel3(gameField, rnd);
            }
        }

        private void InitializeLevel1(string[,] gameField, Random rnd)
        {
            List<string> list = new List<string> { "R", "R", "R", "O", "O", "O", "N", "N", "N" };

            for (int i = 4; i > 1; i--)
            {
                for (int j = 2; j < 11; j += 4)
                {
                    ProcessCell(gameField, i, j, list, rnd);
                }
            }

            FinalizeField(gameField, 2, 11);
            gameField[0, 6] = "N";
        }

        private void InitializeLevel2(string[,] gameField, Random rnd)
        {
            List<string> list = new List<string> { "R", "R", "R", "O", "O", "O", "N", "N", "N", "B", "B", "B" };

            for (int i = 4; i > 1; i--)
            {
                for (int j = 2; j < 15; j += 4)
                {
                    ProcessCell(gameField, i, j, list, rnd);
                }
            }

            FinalizeField(gameField, 2, 15);
            gameField[0, 8] = "N";
        }

        private void InitializeLevel3(string[,] gameField, Random rnd)
        {
            List<string> list = new List<string> { "R", "R", "R", "R", "O", "O", "O", "O", "N", "N", "N", "N", "B", "B", "B", "B" };

            for (int i = 4; i > 0; i--)
            {
                for (int j = 2; j < 15; j += 4)
                {
                    ProcessCell(gameField, i, j, list, rnd);
                }
            }

            FinalizeField(gameField, 1, 15);
            gameField[0, 8] = "N";
        }

        private void ProcessCell(string[,] gameField, int i, int j, List<string> list, Random rnd)
        {
            if (list.Count == 0) return;

            int n = rnd.Next(list.Count);
            gameField[i, j] = list[n];
            list.RemoveAt(n);

            ApplyPhysics(gameField, i, j);
        }

        private void ApplyPhysics(string[,] gameField, int i, int j)
        {
            bool moved;
            do
            {
                moved = false;

                // Проверка падения сверху
                if ((gameField[i - 1, j] == "R" || gameField[i - 1, j] == "O" || gameField[i - 1, j] == "B")
                    && gameField[i, j] == "N")
                {
                    gameField[i, j] = gameField[i - 1, j];
                    gameField[i - 1, j] = "N";
                    moved = true;
                }

                // Проверка падения вниз
                if (i <= 3 && (gameField[i, j] == "R" || gameField[i, j] == "O" || gameField[i, j] == "B")
                    && gameField[i + 1, j] == "N")
                {
                    gameField[i + 1, j] = gameField[i, j];
                    gameField[i, j] = "N";
                    moved = true;
                }
            } while (moved);
        }

        private void FinalizeField(string[,] gameField, int startRow, int maxColumn)
        {
            for (int j = 2; j < maxColumn; j += 4)
            {
                for (int i = startRow; i < 4; i++)
                {
                    if ((gameField[i, j] == "R" || gameField[i, j] == "O" || gameField[i, j] == "B")
                        && gameField[i + 1, j] == "N" && gameField[i - 1, j] == "N")
                    {
                        gameField[i + 1, j] = gameField[i, j];
                        gameField[i, j] = "N";
                    }
                }
            }
        }
    }
}
