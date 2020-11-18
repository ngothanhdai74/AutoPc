namespace AutoPc
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.trucX = new System.Windows.Forms.NumericUpDown();
            this.trucY = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rightMouse = new System.Windows.Forms.RadioButton();
            this.leftMouse = new System.Windows.Forms.RadioButton();
            this.cbDoubleClick = new System.Windows.Forms.CheckBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trucX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trucY)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Mở Notepad";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(105, 23);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Mở file";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(204, 23);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(106, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Chạy lệnh cmd";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(24, 53);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(109, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "Chạy cmd ngầm";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // trucX
            // 
            this.trucX.Location = new System.Drawing.Point(48, 85);
            this.trucX.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.trucX.Minimum = new decimal(new int[] {
            3000,
            0,
            0,
            -2147483648});
            this.trucX.Name = "trucX";
            this.trucX.Size = new System.Drawing.Size(120, 20);
            this.trucX.TabIndex = 4;
            // 
            // trucY
            // 
            this.trucY.Location = new System.Drawing.Point(48, 131);
            this.trucY.Name = "trucY";
            this.trucY.Size = new System.Drawing.Size(120, 20);
            this.trucY.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Trục X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Trục Y";
            // 
            // rightMouse
            // 
            this.rightMouse.AutoSize = true;
            this.rightMouse.Location = new System.Drawing.Point(13, 166);
            this.rightMouse.Name = "rightMouse";
            this.rightMouse.Size = new System.Drawing.Size(76, 17);
            this.rightMouse.TabIndex = 8;
            this.rightMouse.TabStop = true;
            this.rightMouse.Text = "Chuột phải";
            this.rightMouse.UseVisualStyleBackColor = true;
            // 
            // leftMouse
            // 
            this.leftMouse.AutoSize = true;
            this.leftMouse.Location = new System.Drawing.Point(105, 166);
            this.leftMouse.Name = "leftMouse";
            this.leftMouse.Size = new System.Drawing.Size(70, 17);
            this.leftMouse.TabIndex = 9;
            this.leftMouse.TabStop = true;
            this.leftMouse.Text = "Chuột trái";
            this.leftMouse.UseVisualStyleBackColor = true;
            // 
            // cbDoubleClick
            // 
            this.cbDoubleClick.AutoSize = true;
            this.cbDoubleClick.Location = new System.Drawing.Point(48, 200);
            this.cbDoubleClick.Name = "cbDoubleClick";
            this.cbDoubleClick.Size = new System.Drawing.Size(86, 17);
            this.cbDoubleClick.TabIndex = 10;
            this.cbDoubleClick.Text = "Double Click";
            this.cbDoubleClick.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(13, 226);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(155, 49);
            this.button5.TabIndex = 11;
            this.button5.Text = "Click vào màn hình";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(13, 281);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(154, 50);
            this.button6.TabIndex = 12;
            this.button6.Text = "Click vào ứng dụng";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.cbDoubleClick);
            this.Controls.Add(this.leftMouse);
            this.Controls.Add(this.rightMouse);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trucY);
            this.Controls.Add(this.trucX);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = " ";
            ((System.ComponentModel.ISupportInitialize)(this.trucX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trucY)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.NumericUpDown trucX;
        private System.Windows.Forms.NumericUpDown trucY;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rightMouse;
        private System.Windows.Forms.RadioButton leftMouse;
        private System.Windows.Forms.CheckBox cbDoubleClick;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}

