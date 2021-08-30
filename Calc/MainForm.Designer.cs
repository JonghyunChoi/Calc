
namespace Calc {
    partial class MainForm {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent() {
            this.btnPercent = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btnMultiple = new System.Windows.Forms.Button();
            this.btnNine = new System.Windows.Forms.Button();
            this.btnEight = new System.Windows.Forms.Button();
            this.btnSeven = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnSix = new System.Windows.Forms.Button();
            this.btnFive = new System.Windows.Forms.Button();
            this.btnFour = new System.Windows.Forms.Button();
            this.btnEquals = new System.Windows.Forms.Button();
            this.btnDot = new System.Windows.Forms.Button();
            this.btnZero = new System.Windows.Forms.Button();
            this.btnReverse = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnThree = new System.Windows.Forms.Button();
            this.btnTwo = new System.Windows.Forms.Button();
            this.btnOne = new System.Windows.Forms.Button();
            this.txtMainNum = new System.Windows.Forms.RichTextBox();
            this.txtSubNum = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnPercent
            // 
            this.btnPercent.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.btnPercent.Location = new System.Drawing.Point(216, 189);
            this.btnPercent.Name = "btnPercent";
            this.btnPercent.Size = new System.Drawing.Size(96, 60);
            this.btnPercent.TabIndex = 0;
            this.btnPercent.Text = "%";
            this.btnPercent.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.btnClear.Location = new System.Drawing.Point(114, 189);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(96, 60);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "C";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.btnBack.Location = new System.Drawing.Point(12, 189);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(96, 60);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnDivide
            // 
            this.btnDivide.Font = new System.Drawing.Font("맑은 고딕", 18F);
            this.btnDivide.Location = new System.Drawing.Point(318, 189);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(96, 60);
            this.btnDivide.TabIndex = 7;
            this.btnDivide.Text = "÷";
            this.btnDivide.UseVisualStyleBackColor = true;
            // 
            // btnMultiple
            // 
            this.btnMultiple.Font = new System.Drawing.Font("맑은 고딕", 18F);
            this.btnMultiple.Location = new System.Drawing.Point(318, 255);
            this.btnMultiple.Name = "btnMultiple";
            this.btnMultiple.Size = new System.Drawing.Size(96, 60);
            this.btnMultiple.TabIndex = 11;
            this.btnMultiple.Text = "×";
            this.btnMultiple.UseVisualStyleBackColor = true;
            // 
            // btnNine
            // 
            this.btnNine.Font = new System.Drawing.Font("맑은 고딕", 14F, System.Drawing.FontStyle.Bold);
            this.btnNine.Location = new System.Drawing.Point(216, 255);
            this.btnNine.Name = "btnNine";
            this.btnNine.Size = new System.Drawing.Size(96, 60);
            this.btnNine.TabIndex = 10;
            this.btnNine.Text = "9";
            this.btnNine.UseVisualStyleBackColor = true;
            this.btnNine.Click += new System.EventHandler(this.btnNine_Click);
            // 
            // btnEight
            // 
            this.btnEight.Font = new System.Drawing.Font("맑은 고딕", 14F, System.Drawing.FontStyle.Bold);
            this.btnEight.Location = new System.Drawing.Point(114, 255);
            this.btnEight.Name = "btnEight";
            this.btnEight.Size = new System.Drawing.Size(96, 60);
            this.btnEight.TabIndex = 9;
            this.btnEight.Text = "8";
            this.btnEight.UseVisualStyleBackColor = true;
            this.btnEight.Click += new System.EventHandler(this.btnEight_Click);
            // 
            // btnSeven
            // 
            this.btnSeven.Font = new System.Drawing.Font("맑은 고딕", 14F, System.Drawing.FontStyle.Bold);
            this.btnSeven.Location = new System.Drawing.Point(12, 255);
            this.btnSeven.Name = "btnSeven";
            this.btnSeven.Size = new System.Drawing.Size(96, 60);
            this.btnSeven.TabIndex = 8;
            this.btnSeven.Text = "7";
            this.btnSeven.UseVisualStyleBackColor = true;
            this.btnSeven.Click += new System.EventHandler(this.btnSeven_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.Font = new System.Drawing.Font("맑은 고딕", 18F);
            this.btnMinus.Location = new System.Drawing.Point(318, 321);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(96, 60);
            this.btnMinus.TabIndex = 15;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            // 
            // btnSix
            // 
            this.btnSix.Font = new System.Drawing.Font("맑은 고딕", 14F, System.Drawing.FontStyle.Bold);
            this.btnSix.Location = new System.Drawing.Point(216, 321);
            this.btnSix.Name = "btnSix";
            this.btnSix.Size = new System.Drawing.Size(96, 60);
            this.btnSix.TabIndex = 14;
            this.btnSix.Text = "6";
            this.btnSix.UseVisualStyleBackColor = true;
            this.btnSix.Click += new System.EventHandler(this.btnSix_Click);
            // 
            // btnFive
            // 
            this.btnFive.Font = new System.Drawing.Font("맑은 고딕", 14F, System.Drawing.FontStyle.Bold);
            this.btnFive.Location = new System.Drawing.Point(114, 321);
            this.btnFive.Name = "btnFive";
            this.btnFive.Size = new System.Drawing.Size(96, 60);
            this.btnFive.TabIndex = 13;
            this.btnFive.Text = "5";
            this.btnFive.UseVisualStyleBackColor = true;
            this.btnFive.Click += new System.EventHandler(this.btnFive_Click);
            // 
            // btnFour
            // 
            this.btnFour.Font = new System.Drawing.Font("맑은 고딕", 14F, System.Drawing.FontStyle.Bold);
            this.btnFour.Location = new System.Drawing.Point(12, 321);
            this.btnFour.Name = "btnFour";
            this.btnFour.Size = new System.Drawing.Size(96, 60);
            this.btnFour.TabIndex = 12;
            this.btnFour.Text = "4";
            this.btnFour.UseVisualStyleBackColor = true;
            this.btnFour.Click += new System.EventHandler(this.btnFour_Click);
            // 
            // btnEquals
            // 
            this.btnEquals.Font = new System.Drawing.Font("맑은 고딕", 18F);
            this.btnEquals.Location = new System.Drawing.Point(318, 453);
            this.btnEquals.Name = "btnEquals";
            this.btnEquals.Size = new System.Drawing.Size(96, 60);
            this.btnEquals.TabIndex = 23;
            this.btnEquals.Text = "=";
            this.btnEquals.UseVisualStyleBackColor = true;
            // 
            // btnDot
            // 
            this.btnDot.Font = new System.Drawing.Font("맑은 고딕", 14F, System.Drawing.FontStyle.Bold);
            this.btnDot.Location = new System.Drawing.Point(216, 453);
            this.btnDot.Name = "btnDot";
            this.btnDot.Size = new System.Drawing.Size(96, 60);
            this.btnDot.TabIndex = 22;
            this.btnDot.Text = ".";
            this.btnDot.UseVisualStyleBackColor = true;
            // 
            // btnZero
            // 
            this.btnZero.Font = new System.Drawing.Font("맑은 고딕", 14F, System.Drawing.FontStyle.Bold);
            this.btnZero.Location = new System.Drawing.Point(114, 453);
            this.btnZero.Name = "btnZero";
            this.btnZero.Size = new System.Drawing.Size(96, 60);
            this.btnZero.TabIndex = 21;
            this.btnZero.Text = "0";
            this.btnZero.UseVisualStyleBackColor = true;
            this.btnZero.Click += new System.EventHandler(this.btnZero_Click);
            // 
            // btnReverse
            // 
            this.btnReverse.Font = new System.Drawing.Font("맑은 고딕", 14F, System.Drawing.FontStyle.Bold);
            this.btnReverse.Location = new System.Drawing.Point(12, 453);
            this.btnReverse.Name = "btnReverse";
            this.btnReverse.Size = new System.Drawing.Size(96, 60);
            this.btnReverse.TabIndex = 20;
            this.btnReverse.Text = "+/-";
            this.btnReverse.UseVisualStyleBackColor = true;
            // 
            // btnPlus
            // 
            this.btnPlus.Font = new System.Drawing.Font("맑은 고딕", 18F);
            this.btnPlus.Location = new System.Drawing.Point(318, 387);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(96, 60);
            this.btnPlus.TabIndex = 19;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            // 
            // btnThree
            // 
            this.btnThree.Font = new System.Drawing.Font("맑은 고딕", 14F, System.Drawing.FontStyle.Bold);
            this.btnThree.Location = new System.Drawing.Point(216, 387);
            this.btnThree.Name = "btnThree";
            this.btnThree.Size = new System.Drawing.Size(96, 60);
            this.btnThree.TabIndex = 18;
            this.btnThree.Text = "3";
            this.btnThree.UseVisualStyleBackColor = true;
            this.btnThree.Click += new System.EventHandler(this.btnThree_Click);
            // 
            // btnTwo
            // 
            this.btnTwo.Font = new System.Drawing.Font("맑은 고딕", 14F, System.Drawing.FontStyle.Bold);
            this.btnTwo.Location = new System.Drawing.Point(114, 387);
            this.btnTwo.Name = "btnTwo";
            this.btnTwo.Size = new System.Drawing.Size(96, 60);
            this.btnTwo.TabIndex = 17;
            this.btnTwo.Text = "2";
            this.btnTwo.UseVisualStyleBackColor = true;
            this.btnTwo.Click += new System.EventHandler(this.btnTwo_Click);
            // 
            // btnOne
            // 
            this.btnOne.Font = new System.Drawing.Font("맑은 고딕", 14F, System.Drawing.FontStyle.Bold);
            this.btnOne.Location = new System.Drawing.Point(12, 387);
            this.btnOne.Name = "btnOne";
            this.btnOne.Size = new System.Drawing.Size(96, 60);
            this.btnOne.TabIndex = 16;
            this.btnOne.Text = "1";
            this.btnOne.UseVisualStyleBackColor = true;
            this.btnOne.Click += new System.EventHandler(this.btnOne_Click);
            // 
            // txtMainNum
            // 
            this.txtMainNum.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtMainNum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMainNum.Font = new System.Drawing.Font("맑은 고딕", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtMainNum.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtMainNum.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtMainNum.Location = new System.Drawing.Point(12, 115);
            this.txtMainNum.Multiline = false;
            this.txtMainNum.Name = "txtMainNum";
            this.txtMainNum.ReadOnly = true;
            this.txtMainNum.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtMainNum.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.txtMainNum.Size = new System.Drawing.Size(402, 63);
            this.txtMainNum.TabIndex = 25;
            this.txtMainNum.Text = "";
            // 
            // txtSubNum
            // 
            this.txtSubNum.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtSubNum.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtSubNum.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtSubNum.Location = new System.Drawing.Point(12, 68);
            this.txtSubNum.Multiline = false;
            this.txtSubNum.Name = "txtSubNum";
            this.txtSubNum.ReadOnly = true;
            this.txtSubNum.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtSubNum.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.txtSubNum.Size = new System.Drawing.Size(402, 41);
            this.txtSubNum.TabIndex = 26;
            this.txtSubNum.Text = "";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 527);
            this.Controls.Add(this.txtSubNum);
            this.Controls.Add(this.txtMainNum);
            this.Controls.Add(this.btnEquals);
            this.Controls.Add(this.btnDot);
            this.Controls.Add(this.btnZero);
            this.Controls.Add(this.btnReverse);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.btnThree);
            this.Controls.Add(this.btnTwo);
            this.Controls.Add(this.btnOne);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnSix);
            this.Controls.Add(this.btnFive);
            this.Controls.Add(this.btnFour);
            this.Controls.Add(this.btnMultiple);
            this.Controls.Add(this.btnNine);
            this.Controls.Add(this.btnEight);
            this.Controls.Add(this.btnSeven);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnPercent);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPercent;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btnMultiple;
        private System.Windows.Forms.Button btnNine;
        private System.Windows.Forms.Button btnEight;
        private System.Windows.Forms.Button btnSeven;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnSix;
        private System.Windows.Forms.Button btnFive;
        private System.Windows.Forms.Button btnFour;
        private System.Windows.Forms.Button btnEquals;
        private System.Windows.Forms.Button btnDot;
        private System.Windows.Forms.Button btnZero;
        private System.Windows.Forms.Button btnReverse;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnThree;
        private System.Windows.Forms.Button btnTwo;
        private System.Windows.Forms.Button btnOne;
        private System.Windows.Forms.RichTextBox txtMainNum;
        private System.Windows.Forms.RichTextBox txtSubNum;
    }
}

