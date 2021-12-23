using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc {
    public partial class MainForm : Form {
        MainNum mainNum = new MainNum();

        public MainForm() {
            InitializeComponent();
            this.Text = "계산기";
            mainNum.Num = 0; // 초기값 0
            txtMainNum.Text = "0";
        }

        
        // start of added method line
        public int txtMainNumGet() {
            return int.Parse(txtMainNum.Text);
        }

        public void txtMainNumSet(int num) { // mainNum 부분에 입력 반영
            mainNum.Num = num;
            txtMainNum.Text = String.Format("{0:#,###0}", num);
        }

        private int addMainNum(int num, string str) {
            try {
                return int.Parse(num.ToString() + str);
            }
            catch(OverflowException) { // Mainnum 오버플로우 처리
                return int.Parse(num.ToString());
            }
        }
        // end of added method line

        
        // start of Number btn
        private void btnZero_Click(object sender, EventArgs e) { // 0 btn
            if(mainNum.Num == 0) { // 메인 숫자 값이 0일 경우
                mainNum.Num = 0;
                txtMainNumSet(mainNum.Num);
            } else {
                mainNum.Num = addMainNum(mainNum.Num, "0");
                txtMainNumSet(mainNum.Num);
            }
        }

        private void btnOne_Click(object sender, EventArgs e) { // 1 btn
            mainNum.Num = addMainNum(mainNum.Num, "1");
            txtMainNumSet(mainNum.Num);
        }

        private void btnTwo_Click(object sender, EventArgs e) { // 2 btn
            mainNum.Num = addMainNum(mainNum.Num, "2");
            txtMainNumSet(mainNum.Num);
        }

        private void btnThree_Click(object sender, EventArgs e) { // 3 btn

        }

        private void btnFour_Click(object sender, EventArgs e) { // 4 btn

        }

        private void btnFive_Click(object sender, EventArgs e) { // 5 btn

        }

        private void btnSix_Click(object sender, EventArgs e) { // 6 btn

        }

        private void btnSeven_Click(object sender, EventArgs e) { // 7 btn

        }

        private void btnEight_Click(object sender, EventArgs e) { // 8 btn

        }

        private void btnNine_Click(object sender, EventArgs e) { // 9 btn

        }
        // end of Number btn

        private void btnBack_Click(object sender, EventArgs e) { // back btn
            if(mainNum.Num > 0) { // mainNum 이 0보다 클 경우
                string backNum = mainNum.Num.ToString();
                int mainNumLength = backNum.Length;
                backNum = backNum.Substring(0, mainNumLength - 1);

                txtMainNumSet(int.Parse(backNum));
            }
        }
    }
}
