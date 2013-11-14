using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication5;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cmdCheck_Click(object sender, EventArgs e)
        {
            //string str = "แบบประเมินประสิทธิภาพการจัดทำโพลด์ของศูนย์วิจัยมหาลีย :" + Environment.NewLine;

            string op1, op2, op3, op4;

            //str = str + "1.เพศ ===";
            if (apt1.Checked == true)
            {
                op1= "ชาย"  ;


            }
            else 
            {
                op1= "หญิง" ;

            }

            //str = str + "2.อายุ ===";
            if (bpt1.Checked == true)
            {
                op2= "20-30 ปี"  ;
            }
            else  if (bpt2.Checked == true)
            {
                op2= "31-40 ปี";
            }
            else if (radioButton1.Checked == true)
            {
                op2= "41-50 ปี"  ;

            }
            else 
            {
                op2="51 ปีขึ้นไป"  ;

            }
           // str = str + "3.วุฒิการศึกษาสูงสุด ===";
            if (cpt1.Checked == true)
            {
               op3= "ต่ำกว่าปริญญาตรี"  ;
            }
            else   if (cpt2.Checked == true)
            {
                op3= "ปริญญาตรี"  ;
            }
            else  if (cpt3.Checked == true)
            {
                op3= "ปริญญาโท"  ;
            }
            else 
            {
                op3= "ปริญญาเอก"  ;


            }
           // str = str + "4.ประเภทผู้รับบริการ ===";
            if (dpt1.Checked == true)
            {
               op4= "ผู้บริหาร"  ;
            }
          else   if (dpt2.Checked == true)
            {
                op4= "อาจารย์"  ;
            }
            else if (dpt3.Checked == true)
            {
                op4="เจ้าหน้าที่"  ;
            }
            else if (radioButton5.Checked == true)
            {
                op4= "นักศักษาปัจจุบัน"  ;
            }
            else if (radioButton6.Checked == true)
            {
                op4= "ศิษย์เก่า"  ;
            }
            else 
            {
                op4= "ประชาชนทั่วไป"  ;









            }
            Form2 frm = new Form2 (op1,op2,op3,op4 );
            frm.Show();
            
        }

        private void optMale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void apt2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}

