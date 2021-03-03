namespace NumberPair
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.Easy = new System.Windows.Forms.RadioButton();
            this.normal = new System.Windows.Forms.RadioButton();
            this.God = new System.Windows.Forms.RadioButton();
            this.Start = new System.Windows.Forms.Button();
            this.hard = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("splitContainer1.Panel1.BackgroundImage")));
            this.splitContainer1.Panel1.Controls.Add(this.God);
            this.splitContainer1.Panel1.Controls.Add(this.Start);
            this.splitContainer1.Panel1.Controls.Add(this.hard);
            this.splitContainer1.Panel1.Controls.Add(this.normal);
            this.splitContainer1.Panel1.Controls.Add(this.Easy);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("splitContainer1.Panel2.BackgroundImage")));
            this.splitContainer1.Size = new System.Drawing.Size(784, 561);
            this.splitContainer1.SplitterDistance = 170;
            this.splitContainer1.TabIndex = 0;
            // 
            // Easy
            // 
            this.Easy.AutoSize = true;
            this.Easy.Checked = true;
            this.Easy.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Easy.Location = new System.Drawing.Point(30, 24);
            this.Easy.Margin = new System.Windows.Forms.Padding(2);
            this.Easy.Name = "Easy";
            this.Easy.Size = new System.Drawing.Size(104, 28);
            this.Easy.TabIndex = 1;
            this.Easy.TabStop = true;
            this.Easy.Text = "菜雞難度";
            this.Easy.UseVisualStyleBackColor = true;
            // 
            // normal
            // 
            this.normal.AutoSize = true;
            this.normal.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.normal.Location = new System.Drawing.Point(30, 56);
            this.normal.Margin = new System.Windows.Forms.Padding(2);
            this.normal.Name = "normal";
            this.normal.Size = new System.Drawing.Size(104, 28);
            this.normal.TabIndex = 2;
            this.normal.Text = "中級難度";
            this.normal.UseVisualStyleBackColor = true;
            // 
            // God
            // 
            this.God.AutoSize = true;
            this.God.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.God.Location = new System.Drawing.Point(30, 120);
            this.God.Margin = new System.Windows.Forms.Padding(2);
            this.God.Name = "God";
            this.God.Size = new System.Drawing.Size(104, 28);
            this.God.TabIndex = 7;
            this.God.Text = "上帝模式";
            this.God.UseVisualStyleBackColor = true;
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(30, 152);
            this.Start.Margin = new System.Windows.Forms.Padding(2);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(104, 58);
            this.Start.TabIndex = 6;
            this.Start.Text = "開始遊戲";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // hard
            // 
            this.hard.AutoSize = true;
            this.hard.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.hard.Location = new System.Drawing.Point(30, 88);
            this.hard.Margin = new System.Windows.Forms.Padding(2);
            this.hard.Name = "hard";
            this.hard.Size = new System.Drawing.Size(104, 28);
            this.hard.TabIndex = 5;
            this.hard.Text = "高級難度";
            this.hard.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.RadioButton God;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.RadioButton hard;
        private System.Windows.Forms.RadioButton normal;
        private System.Windows.Forms.RadioButton Easy;
    }
}

