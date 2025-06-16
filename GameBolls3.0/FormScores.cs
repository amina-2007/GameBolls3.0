using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameBolls3._0
{
    public partial class FormScores : Form
    {
       //public int length;
        public FormScores()
        {
            InitializeComponent();
        }

       /* static string result (int rightSteps, int currentSteps)
        {
            if (Convert.ToInt32(currentSteps) >  rightSteps) return "Mожно лучше";
            else
            {
                if (Convert.ToInt32(currentSteps) == rightSteps) return "Хороший результат";
                else return "Переиграл и уничтожил";
            }
        }*/
        private void FormScores_Load(object sender, EventArgs e)
        {
            const string resultsFilePath = "GameResults.txt";

            // Проверка существования файла
            if (!File.Exists(resultsFilePath))
            {
                MessageBox.Show("Сегодня не поиграем", "Ошибка",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Чтение и обработка файла
                using (var sr = new StreamReader(resultsFilePath))
                {
                    int counter = 0;//максимум нас столько
                    while (!sr.EndOfStream && counter < 20)
                    {
                        string line = sr.ReadLine();
                        if (string.IsNullOrWhiteSpace(line)) continue;

                        
                        string[] data = line.Split('#');
                        if (data.Length < 3) continue;

                       
                        string level = data[0];
                        string playerName = data[1];
                        if (!int.TryParse(data[2], out int steps)) continue;

                        // Определение результата
                        string result;
                        if (level == "1")
                        {
                            result = steps <= 6 ? "СУПЕР" : "НОРМА";
                        }
                        else if (level == "2")
                        {
                            result = steps <= 9 ? "ОТЛИЧНО" : "НОРМАС";
                        }
                        else if (level == "3")
                        {
                            result = steps <= 16 ? "ПЕРЕИГРАЛ И УНИЧТОЖИЛ" : "НОРМАЛЬНО";
                        }
                        else
                        {
                            result = "МИНУС СТИПЕНДИЯ";
                        }

                        
                        listViewScores.Items.Add(new ListViewItem(new[]
                        {
                    level,
                    playerName,
                    steps.ToString(),
                    result
                }));

                        counter++;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"УРА! ВСЕ ПОЛЕТЕЛО {ex.Message}",
                              "Ошибка",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Error);
            }
        }
    }
}
