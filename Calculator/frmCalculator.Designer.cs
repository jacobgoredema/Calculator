namespace Calculator
{
    partial class frmCalculator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtUserInput = new System.Windows.Forms.TextBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.tlpButtonLayout = new System.Windows.Forms.TableLayoutPanel();
            this.btnCE = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnPercentageSign = new System.Windows.Forms.Button();
            this.btnSeven = new System.Windows.Forms.Button();
            this.btnEight = new System.Windows.Forms.Button();
            this.btnNine = new System.Windows.Forms.Button();
            this.btnMultiplySign = new System.Windows.Forms.Button();
            this.btnFour = new System.Windows.Forms.Button();
            this.btnFive = new System.Windows.Forms.Button();
            this.btnSix = new System.Windows.Forms.Button();
            this.btnSubtractSign = new System.Windows.Forms.Button();
            this.btnOne = new System.Windows.Forms.Button();
            this.btnTwo = new System.Windows.Forms.Button();
            this.btnThree = new System.Windows.Forms.Button();
            this.btnPlusSign = new System.Windows.Forms.Button();
            this.btnZro = new System.Windows.Forms.Button();
            this.btnComa = new System.Windows.Forms.Button();
            this.btnEqualSign = new System.Windows.Forms.Button();
            this.tlpButtonLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtUserInput
            // 
            this.txtUserInput.Location = new System.Drawing.Point(12, 12);
            this.txtUserInput.Name = "txtUserInput";
            this.txtUserInput.Size = new System.Drawing.Size(325, 20);
            this.txtUserInput.TabIndex = 0;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(12, 39);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(280, 13);
            this.lblInfo.TabIndex = 1;
            this.lblInfo.Text = "Please enter an equation and press ENTER or =";
            // 
            // tlpButtonLayout
            // 
            this.tlpButtonLayout.ColumnCount = 4;
            this.tlpButtonLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpButtonLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpButtonLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpButtonLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpButtonLayout.Controls.Add(this.btnCE, 0, 0);
            this.tlpButtonLayout.Controls.Add(this.btnC, 1, 0);
            this.tlpButtonLayout.Controls.Add(this.btnDel, 2, 0);
            this.tlpButtonLayout.Controls.Add(this.btnPercentageSign, 3, 0);
            this.tlpButtonLayout.Controls.Add(this.btnSeven, 0, 1);
            this.tlpButtonLayout.Controls.Add(this.btnEight, 1, 1);
            this.tlpButtonLayout.Controls.Add(this.btnNine, 2, 1);
            this.tlpButtonLayout.Controls.Add(this.btnMultiplySign, 3, 1);
            this.tlpButtonLayout.Controls.Add(this.btnFour, 0, 2);
            this.tlpButtonLayout.Controls.Add(this.btnFive, 1, 2);
            this.tlpButtonLayout.Controls.Add(this.btnSix, 2, 2);
            this.tlpButtonLayout.Controls.Add(this.btnSubtractSign, 3, 2);
            this.tlpButtonLayout.Controls.Add(this.btnOne, 0, 3);
            this.tlpButtonLayout.Controls.Add(this.btnTwo, 1, 3);
            this.tlpButtonLayout.Controls.Add(this.btnThree, 2, 3);
            this.tlpButtonLayout.Controls.Add(this.btnPlusSign, 3, 3);
            this.tlpButtonLayout.Controls.Add(this.btnZro, 1, 4);
            this.tlpButtonLayout.Controls.Add(this.btnComa, 2, 4);
            this.tlpButtonLayout.Controls.Add(this.btnEqualSign, 3, 4);
            this.tlpButtonLayout.Location = new System.Drawing.Point(7, 63);
            this.tlpButtonLayout.Name = "tlpButtonLayout";
            this.tlpButtonLayout.RowCount = 5;
            this.tlpButtonLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpButtonLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpButtonLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpButtonLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpButtonLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpButtonLayout.Size = new System.Drawing.Size(330, 278);
            this.tlpButtonLayout.TabIndex = 7;
            // 
            // btnCE
            // 
            this.btnCE.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCE.Location = new System.Drawing.Point(0, 0);
            this.btnCE.Margin = new System.Windows.Forms.Padding(0);
            this.btnCE.Name = "btnCE";
            this.btnCE.Size = new System.Drawing.Size(82, 55);
            this.btnCE.TabIndex = 0;
            this.btnCE.Text = "CE";
            this.btnCE.UseVisualStyleBackColor = true;
            this.btnCE.Click += new System.EventHandler(this.btnCE_Click);
            // 
            // btnC
            // 
            this.btnC.Location = new System.Drawing.Point(82, 0);
            this.btnC.Margin = new System.Windows.Forms.Padding(0);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(82, 55);
            this.btnC.TabIndex = 1;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = true;
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(164, 0);
            this.btnDel.Margin = new System.Windows.Forms.Padding(0);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(82, 55);
            this.btnDel.TabIndex = 2;
            this.btnDel.Text = "Del";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnPercentageSign
            // 
            this.btnPercentageSign.Location = new System.Drawing.Point(246, 0);
            this.btnPercentageSign.Margin = new System.Windows.Forms.Padding(0);
            this.btnPercentageSign.Name = "btnPercentageSign";
            this.btnPercentageSign.Size = new System.Drawing.Size(82, 55);
            this.btnPercentageSign.TabIndex = 3;
            this.btnPercentageSign.Text = "%";
            this.btnPercentageSign.UseVisualStyleBackColor = true;
            this.btnPercentageSign.Click += new System.EventHandler(this.btnPercentageSign_Click);
            // 
            // btnSeven
            // 
            this.btnSeven.Location = new System.Drawing.Point(0, 55);
            this.btnSeven.Margin = new System.Windows.Forms.Padding(0);
            this.btnSeven.Name = "btnSeven";
            this.btnSeven.Size = new System.Drawing.Size(82, 55);
            this.btnSeven.TabIndex = 9;
            this.btnSeven.Text = "7";
            this.btnSeven.UseVisualStyleBackColor = true;
            this.btnSeven.Click += new System.EventHandler(this.btnSeven_Click);
            // 
            // btnEight
            // 
            this.btnEight.Location = new System.Drawing.Point(82, 55);
            this.btnEight.Margin = new System.Windows.Forms.Padding(0);
            this.btnEight.Name = "btnEight";
            this.btnEight.Size = new System.Drawing.Size(82, 55);
            this.btnEight.TabIndex = 10;
            this.btnEight.Text = "8";
            this.btnEight.UseVisualStyleBackColor = true;
            this.btnEight.Click += new System.EventHandler(this.btnEight_Click);
            // 
            // btnNine
            // 
            this.btnNine.Location = new System.Drawing.Point(164, 55);
            this.btnNine.Margin = new System.Windows.Forms.Padding(0);
            this.btnNine.Name = "btnNine";
            this.btnNine.Size = new System.Drawing.Size(82, 55);
            this.btnNine.TabIndex = 11;
            this.btnNine.Text = "9";
            this.btnNine.UseVisualStyleBackColor = true;
            this.btnNine.Click += new System.EventHandler(this.btnNine_Click);
            // 
            // btnMultiplySign
            // 
            this.btnMultiplySign.Location = new System.Drawing.Point(246, 55);
            this.btnMultiplySign.Margin = new System.Windows.Forms.Padding(0);
            this.btnMultiplySign.Name = "btnMultiplySign";
            this.btnMultiplySign.Size = new System.Drawing.Size(82, 55);
            this.btnMultiplySign.TabIndex = 12;
            this.btnMultiplySign.Text = "*";
            this.btnMultiplySign.UseVisualStyleBackColor = true;
            this.btnMultiplySign.Click += new System.EventHandler(this.btnMultiplySign_Click);
            // 
            // btnFour
            // 
            this.btnFour.Location = new System.Drawing.Point(0, 110);
            this.btnFour.Margin = new System.Windows.Forms.Padding(0);
            this.btnFour.Name = "btnFour";
            this.btnFour.Size = new System.Drawing.Size(82, 55);
            this.btnFour.TabIndex = 17;
            this.btnFour.Text = "4";
            this.btnFour.UseVisualStyleBackColor = true;
            this.btnFour.Click += new System.EventHandler(this.btnFour_Click);
            // 
            // btnFive
            // 
            this.btnFive.Location = new System.Drawing.Point(82, 110);
            this.btnFive.Margin = new System.Windows.Forms.Padding(0);
            this.btnFive.Name = "btnFive";
            this.btnFive.Size = new System.Drawing.Size(82, 55);
            this.btnFive.TabIndex = 18;
            this.btnFive.Text = "5";
            this.btnFive.UseVisualStyleBackColor = true;
            this.btnFive.Click += new System.EventHandler(this.btnFive_Click);
            // 
            // btnSix
            // 
            this.btnSix.Location = new System.Drawing.Point(164, 110);
            this.btnSix.Margin = new System.Windows.Forms.Padding(0);
            this.btnSix.Name = "btnSix";
            this.btnSix.Size = new System.Drawing.Size(82, 55);
            this.btnSix.TabIndex = 19;
            this.btnSix.Text = "6";
            this.btnSix.UseVisualStyleBackColor = true;
            this.btnSix.Click += new System.EventHandler(this.btnSix_Click);
            // 
            // btnSubtractSign
            // 
            this.btnSubtractSign.Location = new System.Drawing.Point(246, 110);
            this.btnSubtractSign.Margin = new System.Windows.Forms.Padding(0);
            this.btnSubtractSign.Name = "btnSubtractSign";
            this.btnSubtractSign.Size = new System.Drawing.Size(82, 55);
            this.btnSubtractSign.TabIndex = 20;
            this.btnSubtractSign.Text = "-";
            this.btnSubtractSign.UseVisualStyleBackColor = true;
            this.btnSubtractSign.Click += new System.EventHandler(this.btnSubtractSign_Click);
            // 
            // btnOne
            // 
            this.btnOne.Location = new System.Drawing.Point(0, 165);
            this.btnOne.Margin = new System.Windows.Forms.Padding(0);
            this.btnOne.Name = "btnOne";
            this.btnOne.Size = new System.Drawing.Size(82, 55);
            this.btnOne.TabIndex = 21;
            this.btnOne.Text = "1";
            this.btnOne.UseVisualStyleBackColor = true;
            this.btnOne.Click += new System.EventHandler(this.btnOne_Click);
            // 
            // btnTwo
            // 
            this.btnTwo.Location = new System.Drawing.Point(82, 165);
            this.btnTwo.Margin = new System.Windows.Forms.Padding(0);
            this.btnTwo.Name = "btnTwo";
            this.btnTwo.Size = new System.Drawing.Size(82, 55);
            this.btnTwo.TabIndex = 22;
            this.btnTwo.Text = "2";
            this.btnTwo.UseVisualStyleBackColor = true;
            this.btnTwo.Click += new System.EventHandler(this.btnTwo_Click);
            // 
            // btnThree
            // 
            this.btnThree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnThree.Location = new System.Drawing.Point(164, 165);
            this.btnThree.Margin = new System.Windows.Forms.Padding(0);
            this.btnThree.Name = "btnThree";
            this.btnThree.Size = new System.Drawing.Size(82, 55);
            this.btnThree.TabIndex = 23;
            this.btnThree.Text = "3";
            this.btnThree.UseVisualStyleBackColor = true;
            this.btnThree.Click += new System.EventHandler(this.btnThree_Click);
            // 
            // btnPlusSign
            // 
            this.btnPlusSign.Location = new System.Drawing.Point(246, 165);
            this.btnPlusSign.Margin = new System.Windows.Forms.Padding(0);
            this.btnPlusSign.Name = "btnPlusSign";
            this.btnPlusSign.Size = new System.Drawing.Size(82, 55);
            this.btnPlusSign.TabIndex = 24;
            this.btnPlusSign.Text = "+";
            this.btnPlusSign.UseVisualStyleBackColor = true;
            this.btnPlusSign.Click += new System.EventHandler(this.btnPlusSign_Click);
            // 
            // btnZro
            // 
            this.btnZro.Location = new System.Drawing.Point(82, 220);
            this.btnZro.Margin = new System.Windows.Forms.Padding(0);
            this.btnZro.Name = "btnZro";
            this.btnZro.Size = new System.Drawing.Size(82, 55);
            this.btnZro.TabIndex = 26;
            this.btnZro.Text = "0";
            this.btnZro.UseVisualStyleBackColor = true;
            this.btnZro.Click += new System.EventHandler(this.btnZro_Click);
            // 
            // btnComa
            // 
            this.btnComa.Location = new System.Drawing.Point(164, 220);
            this.btnComa.Margin = new System.Windows.Forms.Padding(0);
            this.btnComa.Name = "btnComa";
            this.btnComa.Size = new System.Drawing.Size(82, 55);
            this.btnComa.TabIndex = 27;
            this.btnComa.Text = ".";
            this.btnComa.UseVisualStyleBackColor = true;
            this.btnComa.Click += new System.EventHandler(this.btnComa_Click);
            // 
            // btnEqualSign
            // 
            this.btnEqualSign.Location = new System.Drawing.Point(246, 220);
            this.btnEqualSign.Margin = new System.Windows.Forms.Padding(0);
            this.btnEqualSign.Name = "btnEqualSign";
            this.btnEqualSign.Size = new System.Drawing.Size(82, 55);
            this.btnEqualSign.TabIndex = 28;
            this.btnEqualSign.Text = "=";
            this.btnEqualSign.UseVisualStyleBackColor = true;
            this.btnEqualSign.Click += new System.EventHandler(this.btnEqualSign_Click);
            // 
            // frmCalculator
            // 
            this.AcceptButton = this.btnEqualSign;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton = this.btnCE;
            this.ClientSize = new System.Drawing.Size(343, 343);
            this.Controls.Add(this.tlpButtonLayout);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.txtUserInput);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.tlpButtonLayout.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUserInput;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.TableLayoutPanel tlpButtonLayout;
        private System.Windows.Forms.Button btnSeven;
        private System.Windows.Forms.Button btnEight;
        private System.Windows.Forms.Button btnNine;
        private System.Windows.Forms.Button btnMultiplySign;
        private System.Windows.Forms.Button btnFour;
        private System.Windows.Forms.Button btnFive;
        private System.Windows.Forms.Button btnSix;
        private System.Windows.Forms.Button btnSubtractSign;
        private System.Windows.Forms.Button btnOne;
        private System.Windows.Forms.Button btnTwo;
        private System.Windows.Forms.Button btnThree;
        private System.Windows.Forms.Button btnPlusSign;
        private System.Windows.Forms.Button btnZro;
        private System.Windows.Forms.Button btnComa;
        private System.Windows.Forms.Button btnEqualSign;
        private System.Windows.Forms.Button btnCE;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnPercentageSign;
    }
}

