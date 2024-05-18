namespace Bruch_Rechner
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
            tB_Bruch1 = new TextBox();
            tB_Bruch2 = new TextBox();
            btn_plus = new Button();
            tB_Oper = new TextBox();
            btn_minus = new Button();
            btn_mult = new Button();
            btn_div = new Button();
            btn_equals = new Button();
            tB_Result = new TextBox();
            btn_power = new Button();
            btn_sqrt = new Button();
            SuspendLayout();
            // 
            // tB_Bruch1
            // 
            tB_Bruch1.Location = new Point(95, 83);
            tB_Bruch1.Name = "tB_Bruch1";
            tB_Bruch1.Size = new Size(57, 23);
            tB_Bruch1.TabIndex = 0;
            tB_Bruch1.TextAlign = HorizontalAlignment.Center;
            // 
            // tB_Bruch2
            // 
            tB_Bruch2.Location = new Point(189, 83);
            tB_Bruch2.Name = "tB_Bruch2";
            tB_Bruch2.Size = new Size(57, 23);
            tB_Bruch2.TabIndex = 1;
            tB_Bruch2.TextAlign = HorizontalAlignment.Center;
            // 
            // btn_plus
            // 
            btn_plus.Font = new Font("Segoe UI", 14F);
            btn_plus.Location = new Point(98, 165);
            btn_plus.Name = "btn_plus";
            btn_plus.Size = new Size(54, 54);
            btn_plus.TabIndex = 2;
            btn_plus.Text = "+";
            btn_plus.UseVisualStyleBackColor = true;
            btn_plus.Click += btn_plus_Click;
            // 
            // tB_Oper
            // 
            tB_Oper.Location = new Point(158, 83);
            tB_Oper.Name = "tB_Oper";
            tB_Oper.Size = new Size(25, 23);
            tB_Oper.TabIndex = 3;
            tB_Oper.TextAlign = HorizontalAlignment.Center;
            // 
            // btn_minus
            // 
            btn_minus.Font = new Font("Segoe UI", 18F);
            btn_minus.Location = new Point(98, 225);
            btn_minus.Name = "btn_minus";
            btn_minus.Size = new Size(54, 54);
            btn_minus.TabIndex = 4;
            btn_minus.Text = "-";
            btn_minus.UseVisualStyleBackColor = true;
            btn_minus.Click += btn_minus_Click;
            // 
            // btn_mult
            // 
            btn_mult.Font = new Font("Segoe UI", 14F);
            btn_mult.Location = new Point(160, 165);
            btn_mult.Name = "btn_mult";
            btn_mult.Size = new Size(54, 54);
            btn_mult.TabIndex = 5;
            btn_mult.Text = "*";
            btn_mult.UseVisualStyleBackColor = true;
            btn_mult.Click += btn_mult_Click;
            // 
            // btn_div
            // 
            btn_div.Font = new Font("Segoe UI", 14F);
            btn_div.Location = new Point(160, 225);
            btn_div.Name = "btn_div";
            btn_div.Size = new Size(54, 54);
            btn_div.TabIndex = 7;
            btn_div.Text = "/";
            btn_div.UseVisualStyleBackColor = true;
            btn_div.Click += btn_div_Click;
            // 
            // btn_equals
            // 
            btn_equals.Font = new Font("Segoe UI", 14F);
            btn_equals.Location = new Point(252, 70);
            btn_equals.Name = "btn_equals";
            btn_equals.Size = new Size(51, 41);
            btn_equals.TabIndex = 8;
            btn_equals.Text = "=";
            btn_equals.UseVisualStyleBackColor = true;
            btn_equals.Click += btn_equals_Click;
            // 
            // tB_Result
            // 
            tB_Result.Location = new Point(309, 83);
            tB_Result.Name = "tB_Result";
            tB_Result.Size = new Size(57, 23);
            tB_Result.TabIndex = 9;
            tB_Result.TextAlign = HorizontalAlignment.Center;
            // 
            // btn_power
            // 
            btn_power.Font = new Font("Segoe UI", 14F);
            btn_power.Location = new Point(220, 165);
            btn_power.Name = "btn_power";
            btn_power.Size = new Size(54, 54);
            btn_power.TabIndex = 10;
            btn_power.Text = "^";
            btn_power.UseVisualStyleBackColor = true;
            btn_power.Click += btn_power_Click;
            // 
            // btn_sqrt
            // 
            btn_sqrt.Font = new Font("Segoe UI", 14F);
            btn_sqrt.Location = new Point(220, 225);
            btn_sqrt.Name = "btn_sqrt";
            btn_sqrt.Size = new Size(54, 54);
            btn_sqrt.TabIndex = 11;
            btn_sqrt.Text = "√ ";
            btn_sqrt.UseVisualStyleBackColor = true;
            btn_sqrt.Click += btn_sqrt_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(544, 381);
            Controls.Add(btn_sqrt);
            Controls.Add(btn_power);
            Controls.Add(tB_Result);
            Controls.Add(btn_equals);
            Controls.Add(btn_div);
            Controls.Add(btn_mult);
            Controls.Add(btn_minus);
            Controls.Add(tB_Oper);
            Controls.Add(btn_plus);
            Controls.Add(tB_Bruch2);
            Controls.Add(tB_Bruch1);
            Name = "Form1";
            Text = "  ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tB_Bruch1;
        private TextBox tB_Bruch2;
        private Button btn_plus;
        private TextBox tB_Oper;
        private Button btn_minus;
        private Button btn_mult;
        private Button btn_div;
        private Button btn_equals;
        private TextBox tB_Result;
        private Button btn_power;
        private Button btn_sqrt;
    }
}
