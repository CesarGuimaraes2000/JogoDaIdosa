namespace Velha
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
            button00 = new Button();
            button01 = new Button();
            button02 = new Button();
            button10 = new Button();
            button11 = new Button();
            button12 = new Button();
            button20 = new Button();
            button21 = new Button();
            button22 = new Button();
            buttonOp = new Button();
            label1 = new Label();
            buttonFake = new Button();
            textBox1 = new TextBox();
            buttondeb = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(1, 335);
            button1.Name = "button1";
            button1.Size = new Size(429, 95);
            button1.TabIndex = 0;
            button1.Text = "Reiniciar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button00
            // 
            button00.Font = new Font("Segoe UI", 36F);
            button00.Location = new Point(1, 12);
            button00.Name = "button00";
            button00.Size = new Size(139, 86);
            button00.TabIndex = 1;
            button00.UseVisualStyleBackColor = true;
            button00.Click += btn_Click;
            // 
            // button01
            // 
            button01.Font = new Font("Segoe UI", 36F);
            button01.Location = new Point(146, 12);
            button01.Name = "button01";
            button01.Size = new Size(139, 86);
            button01.TabIndex = 2;
            button01.UseVisualStyleBackColor = true;
            button01.Click += btn_Click;
            // 
            // button02
            // 
            button02.Font = new Font("Segoe UI", 36F);
            button02.Location = new Point(291, 12);
            button02.Name = "button02";
            button02.Size = new Size(139, 86);
            button02.TabIndex = 3;
            button02.UseVisualStyleBackColor = true;
            button02.Click += btn_Click;
            // 
            // button10
            // 
            button10.Font = new Font("Segoe UI", 36F);
            button10.Location = new Point(1, 104);
            button10.Name = "button10";
            button10.Size = new Size(139, 84);
            button10.TabIndex = 4;
            button10.UseVisualStyleBackColor = true;
            button10.Click += btn_Click;
            // 
            // button11
            // 
            button11.Font = new Font("Segoe UI", 36F);
            button11.Location = new Point(146, 104);
            button11.Name = "button11";
            button11.Size = new Size(139, 84);
            button11.TabIndex = 5;
            button11.UseVisualStyleBackColor = true;
            button11.Click += btn_Click;
            // 
            // button12
            // 
            button12.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button12.Location = new Point(291, 104);
            button12.Name = "button12";
            button12.Size = new Size(139, 84);
            button12.TabIndex = 6;
            button12.UseVisualStyleBackColor = true;
            button12.Click += btn_Click;
            // 
            // button20
            // 
            button20.Font = new Font("Segoe UI", 36F);
            button20.Location = new Point(1, 194);
            button20.Name = "button20";
            button20.Size = new Size(139, 84);
            button20.TabIndex = 7;
            button20.UseVisualStyleBackColor = true;
            button20.Click += btn_Click;
            // 
            // button21
            // 
            button21.Font = new Font("Segoe UI", 36F);
            button21.Location = new Point(146, 194);
            button21.Name = "button21";
            button21.Size = new Size(139, 84);
            button21.TabIndex = 8;
            button21.UseVisualStyleBackColor = true;
            button21.Click += btn_Click;
            // 
            // button22
            // 
            button22.Font = new Font("Segoe UI", 36F);
            button22.Location = new Point(291, 194);
            button22.Name = "button22";
            button22.Size = new Size(139, 84);
            button22.TabIndex = 9;
            button22.UseVisualStyleBackColor = true;
            button22.Click += btn_Click;
            // 
            // buttonOp
            // 
            buttonOp.ImageAlign = ContentAlignment.MiddleLeft;
            buttonOp.Location = new Point(436, 12);
            buttonOp.Name = "buttonOp";
            buttonOp.Size = new Size(176, 65);
            buttonOp.TabIndex = 10;
            buttonOp.Text = "Ativar Oponente";
            buttonOp.UseVisualStyleBackColor = true;
            buttonOp.Click += buttonOp_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(636, 37);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 11;
            // 
            // buttonFake
            // 
            buttonFake.Enabled = false;
            buttonFake.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonFake.ForeColor = SystemColors.Highlight;
            buttonFake.Location = new Point(436, 93);
            buttonFake.Name = "buttonFake";
            buttonFake.Size = new Size(176, 108);
            buttonFake.TabIndex = 12;
            buttonFake.UseVisualStyleBackColor = true;
            buttonFake.Click += buttonFake_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(436, 407);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(137, 23);
            textBox1.TabIndex = 13;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // buttondeb
            // 
            buttondeb.Location = new Point(668, 398);
            buttondeb.Name = "buttondeb";
            buttondeb.Size = new Size(75, 23);
            buttondeb.TabIndex = 14;
            buttondeb.Text = "button2";
            buttondeb.UseVisualStyleBackColor = true;
            buttondeb.Click += debug_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(773, 442);
            Controls.Add(buttondeb);
            Controls.Add(textBox1);
            Controls.Add(buttonFake);
            Controls.Add(label1);
            Controls.Add(buttonOp);
            Controls.Add(button22);
            Controls.Add(button21);
            Controls.Add(button20);
            Controls.Add(button12);
            Controls.Add(button11);
            Controls.Add(button10);
            Controls.Add(button02);
            Controls.Add(button01);
            Controls.Add(button00);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Jogo da Idosa";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button00;
        private Button button01;
        private Button button02;
        private Button button10;
        private Button button11;
        private Button button12;
        private Button button20;
        private Button button21;
        private Button button22;
        private Button buttonOp;
        private Label label1;
        private Button buttonFake;
        private TextBox textBox1;
        private Button buttondeb;
    }
}
