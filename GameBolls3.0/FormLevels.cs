using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameBolls3._0
{
    public partial class FormLevels : Form
    {
        int steps = 0;
        public string claslevel;
        string[,] GameField = new string[6, 16]; // Изменил размерность на [6,16] для соответствия новым классам

        // Заменяем CreateField на два новых класса
        RenderField renderer = new RenderField();
        FieldsState fieldState = new FieldsState();

        GameProcess process = new GameProcess();

        public FormLevels()
        {
            InitializeComponent();
            // Инициализация изображений теперь в FieldRenderer
            renderer.ImgEmpty = Bitmap.FromFile("Images/Empty.png");
            renderer.ImgRedBall = Bitmap.FromFile("Images/RedBaloon_100.png");
            renderer.ImgOrangeBall = Bitmap.FromFile("Images/OrangeBaloon_100.png");
            renderer.ImgColumn = Bitmap.FromFile("Images/Column.png");
            renderer.ImgBottom = Bitmap.FromFile("Images/Bottom.png");
            renderer.ImgBlueBall = Bitmap.FromFile("Images/BlueBallon_100.png");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int CurrentColumn = e.ColumnIndex;
            int CurrentRow = e.RowIndex;
            bool RightColumn = process.IsColumnRight(CurrentColumn, claslevel);
            bool RighRow = process.IsRowRight(CurrentRow, claslevel);

            if (RightColumn && RighRow)
            {
                if (process.IsNoCurrentBall(GameField, claslevel))
                {
                    bool RightPos = process.IsPositionRight(GameField, claslevel, CurrentRow, CurrentColumn);
                    if (RightPos)
                    {
                        process.ChooseBall(claslevel, dataGridView1, GameField, CurrentRow, CurrentColumn);
                    }
                    else MessageBox.Show("Нельзя так ходить!");
                }
                else
                {
                    while (CurrentRow + 1 < GameField.GetLength(0) &&
                           GameField[CurrentRow + 1, CurrentColumn] == "N")
                    {
                        CurrentRow += 1;
                    }

                    if (GameField[CurrentRow, CurrentColumn] == "N")
                    {
                        bool IsBallPlaced = process.PlaceBall(claslevel, dataGridView1, GameField, CurrentRow, CurrentColumn);
                        if (IsBallPlaced) steps++;
                    }
                    else MessageBox.Show("Нельзя так ходить");
                }
            }

            if (process.IsFieldReady(GameField, claslevel))
            {
                FormUserName formUserName = new FormUserName();
                formUserName.steps = steps;
                formUserName.level = claslevel;
                formUserName.ShowDialog();

                DialogResult result = MessageBox.Show("Обновить поле?", "Вы победили!", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    steps = 0;
                    // Заменяем вызовы методов CreateField на новые классы
                    fieldState.InitializeField(GameField, claslevel);
                    renderer.DrawField(dataGridView1, GameField, claslevel);
                }
                if (result == DialogResult.No)
                {
                   // Form.Close();
                }
            }
        }

        private void FormLevel1_Load(object sender, EventArgs e)
        {
            dataGridView1.GridColor = Color.White;
            dataGridView1.Rows.Add(5);

            // Инициализация поля с помощью новых классов
            fieldState.InitializeField(GameField, claslevel);
            renderer.DrawField(dataGridView1, GameField, claslevel);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
