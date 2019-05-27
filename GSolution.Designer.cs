namespace Assignment1LRP281
{
    partial class GSolution
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.btnPath = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.chLine = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chLine)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(128, 12);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(432, 20);
            this.txtPath.TabIndex = 0;
            // 
            // btnPath
            // 
            this.btnPath.Location = new System.Drawing.Point(589, 12);
            this.btnPath.Name = "btnPath";
            this.btnPath.Size = new System.Drawing.Size(101, 23);
            this.btnPath.TabIndex = 1;
            this.btnPath.Text = "Calculate";
            this.btnPath.UseVisualStyleBackColor = true;
            this.btnPath.Click += new System.EventHandler(this.btnPath_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Path Name";
            // 
            // chLine
            // 
            chartArea2.Name = "ChartArea1";
            this.chLine.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chLine.Legends.Add(legend2);
            this.chLine.Location = new System.Drawing.Point(12, 69);
            this.chLine.Name = "chLine";
            this.chLine.Size = new System.Drawing.Size(744, 369);
            this.chLine.TabIndex = 3;
            this.chLine.Text = "chart1";
            // 
            // GSolution
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chLine);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPath);
            this.Controls.Add(this.txtPath);
            this.Name = "GSolution";
            this.Text = "GSolution";
            ((System.ComponentModel.ISupportInitialize)(this.chLine)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Button btnPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chLine;
    }
}