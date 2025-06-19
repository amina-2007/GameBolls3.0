using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing;

namespace GameBolls3._0
{
    class RenderField
    {
        public Image ImgRedBall, ImgOrangeBall, ImgColumn, ImgBottom, ImgEmpty, ImgBlueBall;

        public void DrawColumn(int i, DataGridView grid, string level)
        {
            grid.Rows[2].Cells[i].Value = ImgColumn;
            grid.Rows[3].Cells[i].Value = ImgColumn;
            grid.Rows[4].Cells[i].Value = ImgColumn;
            grid.Rows[5].Cells[i].Value = ImgColumn;
            if (level == "3") grid.Rows[1].Cells[i].Value = ImgColumn;
        }

        public void DrawBoll(int i, string[,] gameField, DataGridView grid, string level)
        {
            int min = 2;
            if (level == "3") min = 1;
            for (int j = min; j < 5; j++)
            {
                switch (gameField[j, i])
                {
                    case "N": grid.Rows[j].Cells[i].Value = ImgEmpty; break;
                    case "R": grid.Rows[j].Cells[i].Value = ImgRedBall; break;
                    case "O": grid.Rows[j].Cells[i].Value = ImgOrangeBall; break;
                    case "B": grid.Rows[j].Cells[i].Value = ImgBlueBall; break;
                }
            }
        }

        public void DrawField(DataGridView grid, string[,] gameField, string level)
        {
            // Очистка поля
            for (int j = 0; j < 6; j++)
            {
                for (int i = 0; i < 16; i++)
                {
                    grid.Rows[j].Cells[i].Value = ImgEmpty;
                }
            }

            // Отрисовка элементов
            int n = level == "1" ? 12 : 16;
            for (int i = 0; i < n; i++)
            {
                switch (i)
                {
                    case 1:
                    case 3:
                    case 5:
                    case 7:
                    case 9:
                    case 11:
                    case 13:
                    case 15:
                        DrawColumn(i, grid, level);
                        break;

                    case 2:
                    case 6:
                    case 10:
                    case 14:
                        grid.Rows[5].Cells[i].Value = ImgBottom;
                        DrawBoll(i, gameField, grid, level);
                        break;
                }
            }
        }
    }
}
