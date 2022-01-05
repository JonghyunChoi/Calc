using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Calc.Controllers;
using Calc.Models;

namespace Calc {
    public partial class MainForm : Form {
        Controller controller = new Controller();

        public MainForm() {
            InitializeComponent();
            //this.Text = "계산기";
            InputNumberTXT.Text = controller.InputNumber().ToString();
        }

        private void btnClickProcess(int value) {
            if(controller.InputNumber() > 0) {
                try {
                    controller.InputNumber(int.Parse(controller.InputNumber().ToString() + value.ToString()));
                }
                catch(OverflowException) { }

                InputNumberTXT.Text = controller.InputStrNumber();
            }
            else if(controller.InputNumber() <= 0) {
                controller.InputNumber(value);
                InputNumberTXT.Text = controller.InputStrNumber();
            }
        }
        
        // start of Number btn
        private void btnZero_Click(object sender, EventArgs e) { // 0 btn
            btnClickProcess(0);
        }

        private void btnOne_Click(object sender, EventArgs e) { // 1 btn
            btnClickProcess(1);
        }

        private void btnTwo_Click(object sender, EventArgs e) { // 2 btn
            btnClickProcess(2);
        }

        private void btnThree_Click(object sender, EventArgs e) { // 3 btn
            btnClickProcess(3);
        }

        private void btnFour_Click(object sender, EventArgs e) { // 4 btn
            btnClickProcess(4);
        }

        private void btnFive_Click(object sender, EventArgs e) { // 5 btn
            btnClickProcess(5);
        }

        private void btnSix_Click(object sender, EventArgs e) { // 6 btn
            btnClickProcess(6);
        }

        private void btnSeven_Click(object sender, EventArgs e) { // 7 btn
            btnClickProcess(7);
        }

        private void btnEight_Click(object sender, EventArgs e) { // 8 btn
            btnClickProcess(8);
        }

        private void btnNine_Click(object sender, EventArgs e) { // 9 btn
            btnClickProcess(9);
        }
        // end of Number btn

        private void btnBack_Click(object sender, EventArgs e) { // back btn

        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e) {

        }
    }
}
