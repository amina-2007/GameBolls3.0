using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameBolls3._0
{
    public class GameProcess
    {
        public const string Level1 = "1";
        public const string Level2 = "2";
        public const string Level3 = "3";

        public const string Empty = "N";
        public const string RedBall = "R";
        public const string OrangeBall = "O";
        public const string BlueBall = "B";

        private static readonly int[] ColumnsLevel1 = { 2, 6, 10 };
        private static readonly int[] ColumnsLevel2And3 = { 2, 6, 10, 14 };
        private static readonly int[] RowsLevel1And2 = { 2, 3, 4 };
        private static readonly int[] RowsLevel3 = { 1, 2, 3, 4 };

        private const int SelectedBallRow = 0;
        private int SelectedBallColumn(string level) => level == Level1 ? 6 : 8;

        private readonly Dictionary<string, Image> _ballImages = new Dictionary<string, Image>(); //Vmecto otdelnix peremennix 

        public GameProcess()
        {
            _ballImages[Empty] = Bitmap.FromFile("Images/Empty.png");
            _ballImages[RedBall] = Bitmap.FromFile("Images/RedBaloon_100.png");
            _ballImages[OrangeBall] = Bitmap.FromFile("Images/OrangeBaloon_100.png");
            _ballImages[BlueBall] = Bitmap.FromFile("Images/BlueBallon_100.png");
        }

        public bool IsColumnRight(int column, string level) =>
            (level == Level1 ? ColumnsLevel1 : ColumnsLevel2And3).Contains(column);

        public bool IsRowRight(int row, string level) =>
            (level == Level3 ? RowsLevel3 : RowsLevel1And2).Contains(row);

        public bool IsNoCurrentBall(string[,] gameField, string level) =>
            gameField[SelectedBallRow, SelectedBallColumn(level)] == Empty;

        public bool IsPositionRight(string[,] gameField, string level, int row, int column) =>
            gameField[row - 1, column] == Empty || row == (level == Level3 ? 1 : 2);

        public void ChooseBall(string level, DataGridView grid, string[,] gameField, int row, int column)
        {
            int selectedColumn = SelectedBallColumn(level);
            string ballType = gameField[row, column];

            gameField[SelectedBallRow, selectedColumn] = ballType;
            gameField[row, column] = Empty;

            grid.Rows[row].Cells[column].Value = _ballImages[Empty];
            grid.Rows[SelectedBallRow].Cells[selectedColumn].Value = _ballImages[ballType];
        }

        public bool PlaceBall(string level, DataGridView grid, string[,] gameField, int row, int column)
        {
            int selectedColumn = SelectedBallColumn(level);
            string ballType = gameField[SelectedBallRow, selectedColumn];

            gameField[row, column] = ballType;
            gameField[SelectedBallRow, selectedColumn] = Empty;

            grid.Rows[row].Cells[column].Value = _ballImages[ballType];
            grid.Rows[SelectedBallRow].Cells[selectedColumn].Value = _ballImages[Empty];

            return true;
        }

        public bool IsFieldReady(string[,] gameField, string level)
        {
            int requiredMatches = level == Level1 ? 2 : 3;
            var columnsToCheck = level == Level1 ? ColumnsLevel1 : ColumnsLevel2And3;
            var rowsToCheck = level == Level3 ? RowsLevel3 : RowsLevel1And2;

            int matchedColumns = 0;

            foreach (int col in columnsToCheck)
            {
                bool isColumnValid = true;
                string firstBall = gameField[rowsToCheck[0], col];

                if (firstBall == Empty) continue;

                for (int i = 1; i < rowsToCheck.Length; i++)
                {
                    if (gameField[rowsToCheck[i], col] != firstBall)
                    {
                        isColumnValid = false;
                        break;
                    }
                }

                if (isColumnValid && ++matchedColumns >= requiredMatches)
                    return true;
            }

            return false;
        }
    }
}
