namespace XOXOyunu
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            label1 = new Label();
            lblXOX = new Label();
            SuspendLayout();
            // 
            // btn1
            // 
            btn1.Location = new Point(81, 155);
            btn1.Name = "btn1";
            btn1.Size = new Size(87, 75);
            btn1.TabIndex = 0;
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += XOXClickGame;
            // 
            // btn2
            // 
            btn2.Location = new Point(174, 155);
            btn2.Name = "btn2";
            btn2.Size = new Size(87, 75);
            btn2.TabIndex = 1;
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += XOXClickGame;
            // 
            // btn3
            // 
            btn3.Location = new Point(267, 155);
            btn3.Name = "btn3";
            btn3.Size = new Size(87, 75);
            btn3.TabIndex = 2;
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += XOXClickGame;
            // 
            // btn4
            // 
            btn4.Location = new Point(81, 236);
            btn4.Name = "btn4";
            btn4.Size = new Size(87, 75);
            btn4.TabIndex = 3;
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += XOXClickGame;
            // 
            // btn5
            // 
            btn5.Location = new Point(174, 236);
            btn5.Name = "btn5";
            btn5.Size = new Size(87, 75);
            btn5.TabIndex = 4;
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += XOXClickGame;
            // 
            // btn6
            // 
            btn6.Location = new Point(267, 236);
            btn6.Name = "btn6";
            btn6.Size = new Size(87, 75);
            btn6.TabIndex = 5;
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += XOXClickGame;
            // 
            // btn7
            // 
            btn7.Location = new Point(81, 317);
            btn7.Name = "btn7";
            btn7.Size = new Size(87, 75);
            btn7.TabIndex = 6;
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += XOXClickGame;
            // 
            // btn8
            // 
            btn8.Location = new Point(174, 317);
            btn8.Name = "btn8";
            btn8.Size = new Size(87, 75);
            btn8.TabIndex = 7;
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += XOXClickGame;
            // 
            // btn9
            // 
            btn9.Location = new Point(267, 317);
            btn9.Name = "btn9";
            btn9.Size = new Size(87, 75);
            btn9.TabIndex = 8;
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += XOXClickGame;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(126, 95);
            label1.Name = "label1";
            label1.Size = new Size(124, 20);
            label1.TabIndex = 9;
            label1.Text = "Sıradaki Karakter:";
            // 
            // lblXOX
            // 
            lblXOX.Anchor = AnchorStyles.None;
            lblXOX.Font = new Font("Times New Roman", 20F, FontStyle.Bold);
            lblXOX.Location = new Point(256, 81);
            lblXOX.Name = "lblXOX";
            lblXOX.Size = new Size(47, 43);
            lblXOX.TabIndex = 10;
            lblXOX.Text = "X";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(440, 496);
            Controls.Add(lblXOX);
            Controls.Add(label1);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Label label1;
        private Label lblXOX;
    }
}
