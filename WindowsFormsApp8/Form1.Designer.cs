namespace WindowsFormsApp8
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label2 = new System.Windows.Forms.Label();
            this.step = new System.Windows.Forms.TextBox();
            this.b = new System.Windows.Forms.TextBox();
            this.a = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(162, 330);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(401, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "График функции y=cosx^2+tgx";
            // 
            // step
            // 
            this.step.Location = new System.Drawing.Point(551, 371);
            this.step.Name = "step";
            this.step.Size = new System.Drawing.Size(100, 20);
            this.step.TabIndex = 3;
            // 
            // b
            // 
            this.b.Location = new System.Drawing.Point(237, 409);
            this.b.Name = "b";
            this.b.Size = new System.Drawing.Size(100, 20);
            this.b.TabIndex = 4;
            // 
            // a
            // 
            this.a.Location = new System.Drawing.Point(237, 375);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(100, 20);
            this.a.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(37, 373);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Координата начала";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(37, 407);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Координата конца";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(476, 371);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Шаг";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(480, 398);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 31);
            this.button1.TabIndex = 9;
            this.button1.Text = "Построить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(0, -1);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "y=cosx^2+tgx";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(688, 328);
            this.chart1.TabIndex = 10;
            this.chart1.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(689, 441);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.a);
            this.Controls.Add(this.b);
            this.Controls.Add(this.step);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox step;
        private System.Windows.Forms.TextBox b;
        private System.Windows.Forms.TextBox a;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}

