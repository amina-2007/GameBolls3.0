
namespace GameBolls3._0
{
    partial class FormScores
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelResults = new System.Windows.Forms.Label();
            this.listViewScores = new System.Windows.Forms.ListView();
            this.columnHeaderLevel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderScores = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderResult = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // labelResults
            // 
            this.labelResults.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelResults.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelResults.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelResults.ForeColor = System.Drawing.Color.Yellow;
            this.labelResults.Location = new System.Drawing.Point(0, 0);
            this.labelResults.Name = "labelResults";
            this.labelResults.Size = new System.Drawing.Size(1302, 65);
            this.labelResults.TabIndex = 0;
            this.labelResults.Text = "ТАБЛИЦА ЛИДЕРОВ";
            this.labelResults.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listViewScores
            // 
            this.listViewScores.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.listViewScores.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderLevel,
            this.columnHeaderName,
            this.columnHeaderScores,
            this.columnHeaderResult});
            this.listViewScores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewScores.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listViewScores.ForeColor = System.Drawing.Color.Yellow;
            this.listViewScores.HideSelection = false;
            this.listViewScores.Location = new System.Drawing.Point(0, 65);
            this.listViewScores.Name = "listViewScores";
            this.listViewScores.Size = new System.Drawing.Size(1302, 551);
            this.listViewScores.TabIndex = 1;
            this.listViewScores.UseCompatibleStateImageBehavior = false;
            this.listViewScores.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderLevel
            // 
            this.columnHeaderLevel.Text = "УРОВЕНЬ";
            this.columnHeaderLevel.Width = 200;
            // 
            // columnHeaderName
            // 
            this.columnHeaderName.Text = "ИМЯ";
            this.columnHeaderName.Width = 200;
            // 
            // columnHeaderScores
            // 
            this.columnHeaderScores.Text = "ХОДЫ";
            this.columnHeaderScores.Width = 150;
            // 
            // columnHeaderResult
            // 
            this.columnHeaderResult.Text = "ИТОГ";
            this.columnHeaderResult.Width = 350;
            // 
            // FormScores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(1302, 616);
            this.Controls.Add(this.listViewScores);
            this.Controls.Add(this.labelResults);
            this.Name = "FormScores";
            this.Text = "Рейтинг игроков";
            this.Load += new System.EventHandler(this.FormScores_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelResults;
        private System.Windows.Forms.ListView listViewScores;
        private System.Windows.Forms.ColumnHeader columnHeaderLevel;
        private System.Windows.Forms.ColumnHeader columnHeaderName;
        private System.Windows.Forms.ColumnHeader columnHeaderScores;
        private System.Windows.Forms.ColumnHeader columnHeaderResult;
    }
}