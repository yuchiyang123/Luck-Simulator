namespace Luck_Simulator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            listView1 = new ListView();
            button2 = new Button();
            dataGridView1 = new DataGridView();
            label3 = new Label();
            button3 = new Button();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(103, 40);
            button1.Name = "button1";
            button1.Size = new Size(90, 48);
            button1.TabIndex = 0;
            button1.Text = "抽";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 25F, FontStyle.Bold);
            label1.Location = new Point(109, 134);
            label1.Name = "label1";
            label1.Size = new Size(121, 43);
            label1.TabIndex = 1;
            label1.Text = "內容物";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft JhengHei UI", 25F, FontStyle.Bold);
            label2.Location = new Point(316, 134);
            label2.Name = "label2";
            label2.Size = new Size(87, 43);
            label2.TabIndex = 2;
            label2.Text = "抽數";
            // 
            // listView1
            // 
            listView1.Location = new Point(32, 210);
            listView1.Name = "listView1";
            listView1.Size = new Size(224, 253);
            listView1.TabIndex = 3;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // button2
            // 
            button2.Location = new Point(244, 40);
            button2.Name = "button2";
            button2.Size = new Size(104, 48);
            button2.TabIndex = 4;
            button2.Text = "十連抽";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(316, 210);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(213, 154);
            dataGridView1.TabIndex = 5;
            dataGridView1.Resize += dataGridView1_Resize;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Bold);
            label3.Location = new Point(334, 386);
            label3.Name = "label3";
            label3.Size = new Size(149, 120);
            label3.TabIndex = 6;
            label3.Text = "\"大吉\": 機率 = 5%\r\n\"中吉\": 機率 = 15%\r\n\"小吉\": 機率 = 19%\r\n\"普\": 機率 = 30%\r\n\"兇\": 機率 = 25%\r\n\"大兇\": 機率 = 6%";
            // 
            // button3
            // 
            button3.Location = new Point(379, 40);
            button3.Name = "button3";
            button3.Size = new Size(104, 48);
            button3.TabIndex = 7;
            button3.Text = "百連抽";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft JhengHei UI", 10F, FontStyle.Bold);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(376, 105);
            label4.Name = "label4";
            label4.Size = new Size(113, 18);
            label4.TabIndex = 8;
            label4.Text = "*百連抽會卡一下";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(553, 547);
            Controls.Add(label4);
            Controls.Add(button3);
            Controls.Add(label3);
            Controls.Add(dataGridView1);
            Controls.Add(button2);
            Controls.Add(listView1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "抽卡模擬器";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private ListView listView1;
        private Button button2;
        private DataGridView dataGridView1;
        private Label label3;
        private Button button3;
        private Label label4;
    }
}
