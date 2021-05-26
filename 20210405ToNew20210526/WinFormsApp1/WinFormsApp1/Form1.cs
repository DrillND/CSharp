using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            
            if (textBox1.Text != "" && textBox4.Text != "시" && textBox5.Text != "분" && comboBox1.Text != "")
            {
                //차량 번호가 중복되지 않으면 1 중복되면 2
                int flag = 1;
                foreach (var sam in dataGridView1.Rows) //foreach 문과 DataGridView 복습
                {
                    DataGridViewRow dataGridViewRow = sam as DataGridViewRow;
                    if (dataGridViewRow.Cells[0].Value.ToString() == textBox1.Text)
                    {
                        flag = 2;
                        MessageBox.Show("중복되는 차량 번호 입니다.");
                        break;
                    }

                }
                if (flag == 1)
                {
                    if (checkBox1.Checked)
                    {
                        {
                            dataGridView1.Rows.Add(textBox1.Text, comboBox1.Text, comboBox2.Text + " " + textBox4.Text + " : " + textBox5.Text, "10% 할인");
                        }
                    }
                    else
                    {
                        dataGridView1.Rows.Add(textBox1.Text, comboBox1.Text, comboBox2.Text + " " + textBox4.Text + " : " + textBox5.Text, "할인 없음");
                    }
                }
            }

            if (textBox1.Text == "")
            {
                MessageBox.Show("차 번호를 입력해 주세요!");
            }
            if (textBox4.Text == "시")
            {
                MessageBox.Show("입차 시간을 입력해 주세요!");
            }
            if (textBox5.Text == "분")
            {
                MessageBox.Show("입차 시간의 분을 입력해 주세요!");
            }
            if (comboBox1.Text == "")
            {
                MessageBox.Show("차 종을 선택해 주세요!");
            }

            
            

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }





        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string outtimeampm = DateTime.Now.ToString("tt");
            string outtime1 = DateTime.Now.ToString("h ");
            string outtime2 = DateTime.Now.ToString(" mm");

            //int c = dataGridView1.ce
            //if (textBox6.Text = dataGridView1.Rows[rowindeCells[0].value)
            //dataGridView1.Rows.Remove();
            //dataGridView3.Rows.Add();



            //총 비용
            //var item2 ;
            //DataGridViewRow dataGridView2 = item2 as DataGridViewRow;
            if (textBox6.Text != "" && textBox8.Text != "시" && textBox7.Text != "분")
            {

                if (checkBox2.Checked)
                {
                    foreach (var item in dataGridView1.Rows) //교수님 코드, 
                    {
                        DataGridViewRow dataGridViewRow = item as DataGridViewRow;

                        if (dataGridViewRow.Cells[0].Value.ToString() == textBox6.Text)
                        {
                            dataGridView1.Rows.Remove(dataGridViewRow);
                            dataGridView3.Rows.Add(dataGridViewRow.Cells[0].Value, dataGridViewRow.Cells[1].Value, dataGridViewRow.Cells[2].Value, outtimeampm + " " + outtime1 + ":" + outtime2, dataGridViewRow.Cells[3].Value);

                        }

                    }

                }
                else
                {
                    var a = int.Parse(textBox4.Text);
                    var b = int.Parse(textBox8.Text);
                    if (comboBox2.Text == "오후")
                    {
                        a = (a + 12) * 60;
                    }
                    else
                    {
                        a = a * 60;
                    }
                    if (comboBox3.Text == "오후")
                    {
                        b = (b + 12) * 60;
                    }
                    else
                    {
                        b = b * 60;
                    }
                    int x = int.Parse(textBox5.Text);
                    int y = int.Parse(textBox7.Text);
                    int outcome = (b + y) - (a + x);
                    if (outcome <0)
                    {
                        MessageBox.Show("출차 시간을 확인하세요!");
                    }
                    else
                    {
                        foreach (var item in dataGridView1.Rows)
                        {
                            DataGridViewRow dataGridViewRow = item as DataGridViewRow;

                            if (dataGridViewRow.Cells[0].Value.ToString() == textBox6.Text)
                            {
                                {
                                    if (dataGridViewRow.Cells[1].Value.ToString() == "경차(분당300원)" && dataGridViewRow.Cells[3].Value.ToString() == "10% 할인")
                                    {
                                        dataGridView1.Rows.Remove(dataGridViewRow);
                                        dataGridView3.Rows.Add(dataGridViewRow.Cells[0].Value, dataGridViewRow.Cells[1].Value, dataGridViewRow.Cells[2].Value, comboBox3.Text + " " + textBox8.Text + " : " + textBox7.Text, outcome + " 분", dataGridViewRow.Cells[3].Value, outcome * 300 * 0.9 + "원");
                                    }
                                    if (dataGridViewRow.Cells[1].Value.ToString() == "경차(분당300원)" && dataGridViewRow.Cells[3].Value.ToString() == "할인 없음")
                                    {
                                        dataGridView1.Rows.Remove(dataGridViewRow);
                                        dataGridView3.Rows.Add(dataGridViewRow.Cells[0].Value, dataGridViewRow.Cells[1].Value, dataGridViewRow.Cells[2].Value, comboBox3.Text + " " + textBox8.Text + " : " + textBox7.Text, outcome + " 분", dataGridViewRow.Cells[3].Value, outcome * 300 + "원");
                                    }
                                }
                                {
                                    if (dataGridViewRow.Cells[1].Value.ToString() == "일반(분당500원)" && dataGridViewRow.Cells[3].Value.ToString() == "10% 할인")
                                    {
                                        dataGridView1.Rows.Remove(dataGridViewRow);
                                        dataGridView3.Rows.Add(dataGridViewRow.Cells[0].Value, dataGridViewRow.Cells[1].Value, dataGridViewRow.Cells[2].Value, comboBox3.Text + " " + textBox8.Text + " : " + textBox7.Text, outcome + " 분", dataGridViewRow.Cells[3].Value, outcome * 500 * 0.9 + "원");
                                    }
                                    if (dataGridViewRow.Cells[1].Value.ToString() == "일반(분당500원)" && dataGridViewRow.Cells[3].Value.ToString() == "할인 없음")
                                    {
                                        dataGridView1.Rows.Remove(dataGridViewRow);
                                        dataGridView3.Rows.Add(dataGridViewRow.Cells[0].Value, dataGridViewRow.Cells[1].Value, dataGridViewRow.Cells[2].Value, comboBox3.Text + " " + textBox8.Text + " : " + textBox7.Text, outcome + " 분", dataGridViewRow.Cells[3].Value, outcome * 500 + "원");
                                    }
                                }
                                {
                                    if (dataGridViewRow.Cells[1].Value.ToString() == "슈퍼카(분당1만원)" && dataGridViewRow.Cells[3].Value.ToString() == "10% 할인")
                                    {
                                        dataGridView1.Rows.Remove(dataGridViewRow);
                                        dataGridView3.Rows.Add(dataGridViewRow.Cells[0].Value, dataGridViewRow.Cells[1].Value, dataGridViewRow.Cells[2].Value, comboBox3.Text + " " + textBox8.Text + " : " + textBox7.Text, outcome + " 분", dataGridViewRow.Cells[3].Value, outcome * 10000 * 0.9 + "원");
                                    }
                                    if (dataGridViewRow.Cells[1].Value.ToString() == "슈퍼카(분당1만원)" && dataGridViewRow.Cells[3].Value.ToString() == "할인 없음")
                                    {
                                        dataGridView1.Rows.Remove(dataGridViewRow);
                                        dataGridView3.Rows.Add(dataGridViewRow.Cells[0].Value, dataGridViewRow.Cells[1].Value, dataGridViewRow.Cells[2].Value, comboBox3.Text + " " + textBox8.Text + " : " + textBox7.Text, outcome + " 분", dataGridViewRow.Cells[3].Value, outcome * 10000 + "원");
                                    }
                                }
                            }

                        }
                    }
                }
            }
            if (textBox6.Text == "")
            {
                MessageBox.Show("출 차 번호를 입력해 주세요!");
            }
            if (textBox8.Text == "시")
            {
                MessageBox.Show("출차 시간을 입력해 주세요!");
            }
            if (textBox7.Text == "분")
            {
                MessageBox.Show("출차 시간의 분을 입력해 주세요!");
            }



        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            //if (checkBox2.Checked)
            //{
            //    textBox8.Text = string.Empty;
            //    textBox7.Text = string.Empty;
            //}
            //else
            //{
            //    textBox8.Text = "시";
            //    textBox7.Text = "분";
            //}
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (var item in dataGridView1.Rows)
            {
                DataGridViewRow dataGridViewRow = item as DataGridViewRow;

                if (dataGridViewRow.Cells[0].Value.ToString() == textBox1.Text)
                {
                    dataGridView1.Rows.Remove(dataGridViewRow);
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            foreach (var item in dataGridView3.Rows)
            {
                DataGridViewRow dataGridViewRow3 = item as DataGridViewRow;

                if (dataGridViewRow3.Cells[0].Value.ToString() == textBox6.Text)
                {
                    dataGridView3.Rows.Remove(dataGridViewRow3);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {


            ////foreach (var item in dataGridView3.Rows)
            ////{
            //    for (i = 1; i <100;i++)
            //    {
            //        string a = dataGridView3.Rows[0].Cells[6].Value.ToString();
            //        string b = dataGridView3.Rows[i].Cells[6].ToString();
            //        string c = a + b;
            //    string c = c + b;
            //    }
            ////}
            ///
            int sum = 0;
            for (int i = 0; i < dataGridView3.Rows.Count; i++)
            {
                //string a = dataGridView3.Rows[i].Cells[6].Value.ToString();
                int le = dataGridView3.Rows[i].Cells[6].Value.ToString().IndexOf('원');
                sum += int.Parse(dataGridView3.Rows[i].Cells[6].Value.ToString().Substring(0,le));
                
            }
            textBox3.Text = sum.ToString()+"원";

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
