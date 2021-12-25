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
            // 초기값 0
            controller.InputNumber(0);
            InputNumberTXT.Text = "0";
        }
        
        // start of Number btn
        private void btnZero_Click(object sender, EventArgs e) { // 0 btn

        }

        private void btnOne_Click(object sender, EventArgs e) { // 1 btn

        }

        private void btnTwo_Click(object sender, EventArgs e) { // 2 btn

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

        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e) {

        }
    }
}
