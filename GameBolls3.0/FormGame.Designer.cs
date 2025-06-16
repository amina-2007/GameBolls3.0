
namespace GameBolls3._0
{
    partial class FormGame
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonShowScores = new System.Windows.Forms.Button();
            this.labelChooseLevel = new System.Windows.Forms.Label();
            this.buttonLevel1 = new System.Windows.Forms.Button();
            this.buttonLevel2 = new System.Windows.Forms.Button();
            this.buttonLevel3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonShowScores
            // 
            this.buttonShowScores.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonShowScores.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonShowScores.ForeColor = System.Drawing.Color.MidnightBlue;
            this.buttonShowScores.Location = new System.Drawing.Point(92, 267);
            this.buttonShowScores.Name = "buttonShowScores";
            this.buttonShowScores.Size = new System.Drawing.Size(692, 101);
            this.buttonShowScores.TabIndex = 0;
            this.buttonShowScores.Text = "ПОСМОТРЕТЬ РЕЙТИНГ";
            this.buttonShowScores.UseVisualStyleBackColor = false;
            this.buttonShowScores.Click += new System.EventHandler(this.buttonShowScores_Click);
            // 
            // labelChooseLevel
            // 
            this.labelChooseLevel.AutoSize = true;
            this.labelChooseLevel.Font = new System.Drawing.Font("Impact", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelChooseLevel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelChooseLevel.Location = new System.Drawing.Point(87, 36);
            this.labelChooseLevel.Name = "labelChooseLevel";
            this.labelChooseLevel.Size = new System.Drawing.Size(714, 98);
            this.labelChooseLevel.TabIndex = 1;
            this.labelChooseLevel.Text = "КАКАЯ СЛОЖНОСТЬ?";
            this.labelChooseLevel.Click += new System.EventHandler(this.labelChooseLevel_Click);
            // 
            // buttonLevel1
            // 
            this.buttonLevel1.BackColor = System.Drawing.Color.LightGreen;
            this.buttonLevel1.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonLevel1.ForeColor = System.Drawing.Color.DarkGreen;
            this.buttonLevel1.Location = new System.Drawing.Point(92, 137);
            this.buttonLevel1.Name = "buttonLevel1";
            this.buttonLevel1.Size = new System.Drawing.Size(221, 107);
            this.buttonLevel1.TabIndex = 2;
            this.buttonLevel1.Text = "ЛЕГКАЯ!";
            this.buttonLevel1.UseVisualStyleBackColor = false;
            this.buttonLevel1.Click += new System.EventHandler(this.buttonLevel1_Click);
            // 
            // buttonLevel2
            // 
            this.buttonLevel2.BackColor = System.Drawing.Color.BurlyWood;
            this.buttonLevel2.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonLevel2.ForeColor = System.Drawing.Color.SaddleBrown;
            this.buttonLevel2.Location = new System.Drawing.Point(319, 137);
            this.buttonLevel2.Name = "buttonLevel2";
            this.buttonLevel2.Size = new System.Drawing.Size(234, 107);
            this.buttonLevel2.TabIndex = 3;
            this.buttonLevel2.Text = "СРЕДНЯЯ!";
            this.buttonLevel2.UseVisualStyleBackColor = false;
            this.buttonLevel2.Click += new System.EventHandler(this.buttonLevel2_Click);
            // 
            // buttonLevel3
            // 
            this.buttonLevel3.BackColor = System.Drawing.Color.LightCoral;
            this.buttonLevel3.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonLevel3.ForeColor = System.Drawing.Color.Maroon;
            this.buttonLevel3.Location = new System.Drawing.Point(559, 137);
            this.buttonLevel3.Name = "buttonLevel3";
            this.buttonLevel3.Size = new System.Drawing.Size(225, 107);
            this.buttonLevel3.TabIndex = 4;
            this.buttonLevel3.Text = "ТЯЖЕЛАЯ!";
            this.buttonLevel3.UseVisualStyleBackColor = false;
            this.buttonLevel3.Click += new System.EventHandler(this.buttonLevel3_Click);
            // 
            // FormGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(917, 506);
            this.Controls.Add(this.buttonLevel3);
            this.Controls.Add(this.buttonLevel2);
            this.Controls.Add(this.buttonLevel1);
            this.Controls.Add(this.labelChooseLevel);
            this.Controls.Add(this.buttonShowScores);
            this.Name = "FormGame";
            this.Text = "Игра КОЛБОЧКИ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonShowScores;
        private System.Windows.Forms.Label labelChooseLevel;
        private System.Windows.Forms.Button buttonLevel1;
        private System.Windows.Forms.Button buttonLevel2;
        private System.Windows.Forms.Button buttonLevel3;
    }
}

