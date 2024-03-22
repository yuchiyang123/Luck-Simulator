using System;
using System.Data;

namespace Luck_Simulator
{
    public partial class Form1 : Form
    {
        private int count = 0;
        public int i = 0;
        private System.Data.DataTable dt = new System.Data.DataTable();
        public Form1()
        {
            InitializeComponent();
            //listView格式 預設是le
            listView1.View = View.Details;
            //增加欄位 數字是該欄位得像素大小
            listView1.Columns.Add("次數", 50);
            listView1.Columns.Add("結果", 100);
            DGV();
            //this.Resize += dataGridView1_Resize;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells; // 自動調整列寬
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells; // 自動調整行高


        }
        public void DGV()
        {
            //DGVsetting
            dataGridView1.Dock = DockStyle.None;
            dataGridView1.AutoGenerateColumns = true; //自動換行
            dataGridView1.ReadOnly = true; //唯讀
            dataGridView1.AllowUserToAddRows = false; //限制使用者添加

            //添加=>表單
            this.Controls.Add(dataGridView1);

            //dataTable

            dt.Columns.Add("結果", typeof(string));
            dt.Columns.Add("次數", typeof(int));
            dt.Columns.Add("機率", typeof(double));

            //數據顯示
            dt.Rows.Add("大吉", 0, 0);
            dt.Rows.Add("中吉", 0, 0);
            dt.Rows.Add("小吉", 0, 0);
            dt.Rows.Add("普", 0, 0);
            dt.Rows.Add("兇", 0, 0);
            dt.Rows.Add("大兇", 0, 0);

            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            i++;
            count++;
            label1.Visible = true;
            label2.Visible = true;
            label2.Text = (count).ToString();

            string[] arr = new string[count];
            main();
            //1
            ListViewItem item1 = new ListViewItem((count).ToString());
            //2
            item1.SubItems.Add(label1.Text);
            //1+2 view
            listView1.Items.Add(item1);


        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            label2.Visible = true;

            count += 10;

            label2.Text = ((count).ToString());
            while (i < count)
            {
                main();
                i++;
                ListViewItem itme1 = new ListViewItem((i).ToString());
                itme1.SubItems.Add(label1.Text);
                listView1.Items.Add(itme1);

            }
        }
        //happen
        int countDaJi = 0;
        int countZhongJi = 0;
        int countXiaoJi = 0;
        int countPu = 0;
        int countXiong = 0;
        int countDaXiong = 0;
        double countDaJiP = 0;
        double countZhongJiP = 0;
        double countXiaoJiP = 0;
        double countPuP = 0;
        double countXiongP = 0;
        double countDaXiongP = 0;
        DataRow[] foundR = new DataRow[0];


        public void main()
        {
            Random random = new Random();
            int randN = random.Next(1, 101);

            if (randN <= 5)
            {
                label1.Text = "大吉";
                countDaJi++;
            }
            else if (randN <= 20)
            {
                label1.Text = "中吉";
                countZhongJi++;
            }
            else if (randN <= 39)
            {
                label1.Text = "小吉";
                countXiaoJi++;
            }
            else if (randN <= 69)
            {
                label1.Text = "普";
                countPu++;
            }
            else if (randN <= 94)
            {
                label1.Text = "兇";
                countXiong++;
            }
            else
            {
                label1.Text = "大兇";
                countDaXiong++;
            }

            // 更新每種結果的機率
            countDaJiP = (double)countDaJi / count * 100;
            countZhongJiP = (double)countZhongJi / count * 100;
            countXiaoJiP = (double)countXiaoJi / count * 100;
            countPuP = (double)countPu / count * 100;
            countXiongP = (double)countXiong / count * 100;
            countDaXiongP = (double)countDaXiong / count * 100;

            // 保留兩位小數
            countDaJiP = Math.Round(countDaJiP, 2);
            countZhongJiP = Math.Round(countZhongJiP, 2);
            countXiaoJiP = Math.Round(countXiaoJiP, 2);
            countPuP = Math.Round(countPuP, 2);
            countXiongP = Math.Round(countXiongP, 2);
            countDaXiongP = Math.Round(countDaXiongP, 2);

            // 更新 DataGridView
            dt.Rows.Clear(); // 清除舊資料
            dt.Rows.Add("大吉", countDaJi, countDaJiP);
            dt.Rows.Add("中吉", countZhongJi, countZhongJiP);
            dt.Rows.Add("小吉", countXiaoJi, countXiaoJiP);
            dt.Rows.Add("普", countPu, countPuP);
            dt.Rows.Add("兇", countXiong, countXiongP);
            dt.Rows.Add("大兇", countDaXiong, countDaXiongP);
        }


        private void dataGridView1_Resize(object sender, EventArgs e)
        {
            dataGridView1.Width = this.ClientSize.Width;
            dataGridView1.Height = this.ClientSize.Height;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            label2.Visible = true;

            count += 100;

            label2.Text = ((count).ToString());
            while (i < count)
            {
                main();
                i++;
                ListViewItem itme1 = new ListViewItem((i).ToString());
                itme1.SubItems.Add(label1.Text);
                listView1.Items.Add(itme1);

            }
        }
    }
}
