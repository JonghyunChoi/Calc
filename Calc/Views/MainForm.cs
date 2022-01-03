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
        
        // start of Number btn
        private void btnZero_Click(object sender, EventArgs e) { // 0 btn
            if(controller.InputNumber() > 0) {
                try {
                    controller.InputNumber(int.Parse(controller.InputNumber().ToString() + "0"));
                }
                catch(OverflowException) { }

                InputNumberTXT.Text = controller.InputStrNumber();
            }
        }

        private void btnOne_Click(object sender, EventArgs e) { // 1 btn
            if(controller.InputNumber() > 0) {
                try {
                    controller.InputNumber(int.Parse(controller.InputNumber().ToString() + "1"));
                }
                catch(OverflowException) { }
                
                InputNumberTXT.Text = controller.InputStrNumber();
            } 
            else if(controller.InputNumber() <= 0) {
                controller.InputNumber(1);
                InputNumberTXT.Text = controller.InputStrNumber();
            }
        }

        private void btnTwo_Click(object sender, EventArgs e) { // 2 btn
            if(controller.InputNumber() > 0) {
                try {
                    controller.InputNumber(int.Parse(controller.InputNumber().ToString() + "2"));
                }
                catch(OverflowException) { }

                InputNumberTXT.Text = controller.InputStrNumber();
            }
            else if(controller.InputNumber() <= 0) {
                controller.InputNumber(2);
                InputNumberTXT.Text = controller.InputStrNumber();
            }
        }

        private void btnThree_Click(object sender, EventArgs e) { // 3 btn
            if(controller.InputNumber() > 0) {
                try {
                    controller.InputNumber(int.Parse(controller.InputNumber().ToString() + "3"));
                }
                catch(OverflowException) { }

                InputNumberTXT.Text = controller.InputStrNumber();
            }
            else if(controller.InputNumber() <= 0) {
                controller.InputNumber(3);
                InputNumberTXT.Text = controller.InputStrNumber();
            }
        }

        private void btnFour_Click(object sender, EventArgs e) { // 4 btn
            if(controller.InputNumber() > 0) {
                try {
                    controller.InputNumber(int.Parse(controller.InputNumber().ToString() + "4"));
                }
                catch(OverflowException) { }

                InputNumberTXT.Text = controller.InputStrNumber();
            }
            else if(controller.InputNumber() <= 0) {
                controller.InputNumber(4);
                InputNumberTXT.Text = controller.InputStrNumber();
            }
        }

        private void btnFive_Click(object sender, EventArgs e) { // 5 btn
            if(controller.InputNumber() > 0) {
                try {
                    controller.InputNumber(int.Parse(controller.InputNumber().ToString() + "5"));
                }
                catch(OverflowException) { }

                InputNumberTXT.Text = controller.InputStrNumber();
            }
            else if(controller.InputNumber() <= 0) {
                controller.InputNumber(5);
                InputNumberTXT.Text = controller.InputStrNumber();
            }
        }

        private void btnSix_Click(object sender, EventArgs e) { // 6 btn
            if(controller.InputNumber() > 0) {
                try {
                    controller.InputNumber(int.Parse(controller.InputNumber().ToString() + "6"));
                }
                catch(OverflowException) { }

                InputNumberTXT.Text = controller.InputStrNumber();
            }
            else if(controller.InputNumber() <= 0) {
                controller.InputNumber(6);
                InputNumberTXT.Text = controller.InputStrNumber();
            }
        }

        private void btnSeven_Click(object sender, EventArgs e) { // 7 btn
            if(controller.InputNumber() > 0) {
                try {
                    controller.InputNumber(int.Parse(controller.InputNumber().ToString() + "7"));
                }
                catch(OverflowException) { }

                InputNumberTXT.Text = controller.InputStrNumber();
            }
            else if(controller.InputNumber() <= 0) {
                controller.InputNumber(7);
                InputNumberTXT.Text = controller.InputStrNumber();
            }
        }

        private void btnEight_Click(object sender, EventArgs e) { // 8 btn
            if(controller.InputNumber() > 0) {
                try {
                    controller.InputNumber(int.Parse(controller.InputNumber().ToString() + "8"));
                }
                catch(OverflowException) { }

                InputNumberTXT.Text = controller.InputStrNumber();
            }
            else if(controller.InputNumber() <= 0) {
                controller.InputNumber(8);
                InputNumberTXT.Text = controller.InputStrNumber();
            }
        }

        private void btnNine_Click(object sender, EventArgs e) { // 9 btn
            if(controller.InputNumber() > 0) {
                try {
                    controller.InputNumber(int.Parse(controller.InputNumber().ToString() + "9"));
                }
                catch(OverflowException) { }

                InputNumberTXT.Text = controller.InputStrNumber();
            }
            else if(controller.InputNumber() <= 0) {
                controller.InputNumber(9);
                InputNumberTXT.Text = controller.InputStrNumber();
            }
        }
        // end of Number btn

        private void btnBack_Click(object sender, EventArgs e) { // back btn

        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e) {

        }
    }
}
