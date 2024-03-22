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
            //listView�榡 �w�]�Ole
            listView1.View = View.Details;
            //�W�[��� �Ʀr�O�����o�����j�p
            listView1.Columns.Add("����", 50);
            listView1.Columns.Add("���G", 100);
            DGV();
            //this.Resize += dataGridView1_Resize;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells; // �۰ʽվ�C�e
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells; // �۰ʽվ�氪


        }
        public void DGV()
        {
            //DGVsetting
            dataGridView1.Dock = DockStyle.None;
            dataGridView1.AutoGenerateColumns = true; //�۰ʴ���
            dataGridView1.ReadOnly = true; //��Ū
            dataGridView1.AllowUserToAddRows = false; //����ϥΪ̲K�[

            //�K�[=>���
            this.Controls.Add(dataGridView1);

            //dataTable

            dt.Columns.Add("���G", typeof(string));
            dt.Columns.Add("����", typeof(int));
            dt.Columns.Add("���v", typeof(double));

            //�ƾ����
            dt.Rows.Add("�j�N", 0, 0);
            dt.Rows.Add("���N", 0, 0);
            dt.Rows.Add("�p�N", 0, 0);
            dt.Rows.Add("��", 0, 0);
            dt.Rows.Add("��", 0, 0);
            dt.Rows.Add("�j��", 0, 0);

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
                label1.Text = "�j�N";
                countDaJi++;
            }
            else if (randN <= 20)
            {
                label1.Text = "���N";
                countZhongJi++;
            }
            else if (randN <= 39)
            {
                label1.Text = "�p�N";
                countXiaoJi++;
            }
            else if (randN <= 69)
            {
                label1.Text = "��";
                countPu++;
            }
            else if (randN <= 94)
            {
                label1.Text = "��";
                countXiong++;
            }
            else
            {
                label1.Text = "�j��";
                countDaXiong++;
            }

            // ��s�C�ص��G�����v
            countDaJiP = (double)countDaJi / count * 100;
            countZhongJiP = (double)countZhongJi / count * 100;
            countXiaoJiP = (double)countXiaoJi / count * 100;
            countPuP = (double)countPu / count * 100;
            countXiongP = (double)countXiong / count * 100;
            countDaXiongP = (double)countDaXiong / count * 100;

            // �O�d���p��
            countDaJiP = Math.Round(countDaJiP, 2);
            countZhongJiP = Math.Round(countZhongJiP, 2);
            countXiaoJiP = Math.Round(countXiaoJiP, 2);
            countPuP = Math.Round(countPuP, 2);
            countXiongP = Math.Round(countXiongP, 2);
            countDaXiongP = Math.Round(countDaXiongP, 2);

            // ��s DataGridView
            dt.Rows.Clear(); // �M���¸��
            dt.Rows.Add("�j�N", countDaJi, countDaJiP);
            dt.Rows.Add("���N", countZhongJi, countZhongJiP);
            dt.Rows.Add("�p�N", countXiaoJi, countXiaoJiP);
            dt.Rows.Add("��", countPu, countPuP);
            dt.Rows.Add("��", countXiong, countXiongP);
            dt.Rows.Add("�j��", countDaXiong, countDaXiongP);
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
