﻿namespace OXGame
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
            button1 = new Button();
            label1 = new Label();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(108, 72);
            button1.Name = "button1";
            button1.Size = new Size(109, 101);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("ROG Fonts", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(470, 72);
            label1.Name = "label1";
            label1.Size = new Size(156, 32);
            label1.TabIndex = 1;
            label1.Text = "Player";
            label1.Click += label1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(108, 171);
            button2.Name = "button2";
            button2.Size = new Size(109, 101);
            button2.TabIndex = 2;
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(108, 270);
            button3.Name = "button3";
            button3.Size = new Size(109, 101);
            button3.TabIndex = 3;
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(215, 270);
            button4.Name = "button4";
            button4.Size = new Size(109, 101);
            button4.TabIndex = 4;
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(215, 171);
            button5.Name = "button5";
            button5.Size = new Size(109, 101);
            button5.TabIndex = 5;
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(215, 72);
            button6.Name = "button6";
            button6.Size = new Size(109, 101);
            button6.TabIndex = 6;
            button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new Point(322, 269);
            button7.Name = "button7";
            button7.Size = new Size(109, 101);
            button7.TabIndex = 7;
            button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Location = new Point(322, 171);
            button8.Name = "button8";
            button8.Size = new Size(109, 101);
            button8.TabIndex = 8;
            button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            button9.Location = new Point(322, 72);
            button9.Name = "button9";
            button9.Size = new Size(109, 101);
            button9.TabIndex = 9;
            button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            button10.Font = new Font("ROG Fonts", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button10.Location = new Point(485, 107);
            button10.Name = "button10";
            button10.Size = new Size(123, 113);
            button10.TabIndex = 10;
            button10.Text = "x";
            button10.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "OXGAME";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
    }
}
