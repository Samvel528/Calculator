
namespace Calculator
{
    partial class Frm_Calculator
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
            this.tb_Result = new System.Windows.Forms.TextBox();
            this.bt_Reset = new System.Windows.Forms.Button();
            this.bt_ResetAll = new System.Windows.Forms.Button();
            this.bt_Delete = new System.Windows.Forms.Button();
            this.bt_Divide = new System.Windows.Forms.Button();
            this.bt_Seven = new System.Windows.Forms.Button();
            this.bt_Eight = new System.Windows.Forms.Button();
            this.bt_Nine = new System.Windows.Forms.Button();
            this.bt_Multiple = new System.Windows.Forms.Button();
            this.bt_Sum = new System.Windows.Forms.Button();
            this.bt_Three = new System.Windows.Forms.Button();
            this.bt_Two = new System.Windows.Forms.Button();
            this.bt_One = new System.Windows.Forms.Button();
            this.bt_Subtract = new System.Windows.Forms.Button();
            this.bt_Six = new System.Windows.Forms.Button();
            this.bt_Five = new System.Windows.Forms.Button();
            this.bt_Four = new System.Windows.Forms.Button();
            this.bt_Equal = new System.Windows.Forms.Button();
            this.bt_DecimalPoint = new System.Windows.Forms.Button();
            this.bt_Zero = new System.Windows.Forms.Button();
            this.bt_PlusMinus = new System.Windows.Forms.Button();
            this.lb_Temp = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_Result
            // 
            this.tb_Result.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_Result.Location = new System.Drawing.Point(12, 42);
            this.tb_Result.Multiline = true;
            this.tb_Result.Name = "tb_Result";
            this.tb_Result.ReadOnly = true;
            this.tb_Result.Size = new System.Drawing.Size(354, 66);
            this.tb_Result.TabIndex = 0;
            this.tb_Result.Text = "0";
            this.tb_Result.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // bt_Reset
            // 
            this.bt_Reset.Location = new System.Drawing.Point(12, 114);
            this.bt_Reset.Name = "bt_Reset";
            this.bt_Reset.Size = new System.Drawing.Size(84, 82);
            this.bt_Reset.TabIndex = 1;
            this.bt_Reset.Text = "CE";
            this.bt_Reset.UseVisualStyleBackColor = true;
            this.bt_Reset.Click += new System.EventHandler(this.bt_Reset_Click);
            // 
            // bt_ResetAll
            // 
            this.bt_ResetAll.Location = new System.Drawing.Point(102, 114);
            this.bt_ResetAll.Name = "bt_ResetAll";
            this.bt_ResetAll.Size = new System.Drawing.Size(84, 82);
            this.bt_ResetAll.TabIndex = 2;
            this.bt_ResetAll.Text = "C";
            this.bt_ResetAll.UseVisualStyleBackColor = true;
            this.bt_ResetAll.Click += new System.EventHandler(this.bt_ResetAll_Click);
            // 
            // bt_Delete
            // 
            this.bt_Delete.Location = new System.Drawing.Point(192, 114);
            this.bt_Delete.Name = "bt_Delete";
            this.bt_Delete.Size = new System.Drawing.Size(84, 82);
            this.bt_Delete.TabIndex = 3;
            this.bt_Delete.Text = "<";
            this.bt_Delete.UseVisualStyleBackColor = true;
            this.bt_Delete.Click += new System.EventHandler(this.bt_Delete_Click);
            // 
            // bt_Divide
            // 
            this.bt_Divide.Location = new System.Drawing.Point(282, 114);
            this.bt_Divide.Name = "bt_Divide";
            this.bt_Divide.Size = new System.Drawing.Size(84, 82);
            this.bt_Divide.TabIndex = 4;
            this.bt_Divide.Text = "/";
            this.bt_Divide.UseVisualStyleBackColor = true;
            this.bt_Divide.Click += new System.EventHandler(this.operator_Click);
            // 
            // bt_Seven
            // 
            this.bt_Seven.Location = new System.Drawing.Point(12, 202);
            this.bt_Seven.Name = "bt_Seven";
            this.bt_Seven.Size = new System.Drawing.Size(84, 82);
            this.bt_Seven.TabIndex = 5;
            this.bt_Seven.Text = "7";
            this.bt_Seven.UseVisualStyleBackColor = true;
            this.bt_Seven.Click += new System.EventHandler(this.button_Click);
            // 
            // bt_Eight
            // 
            this.bt_Eight.Location = new System.Drawing.Point(102, 202);
            this.bt_Eight.Name = "bt_Eight";
            this.bt_Eight.Size = new System.Drawing.Size(84, 82);
            this.bt_Eight.TabIndex = 6;
            this.bt_Eight.Text = "8";
            this.bt_Eight.UseVisualStyleBackColor = true;
            this.bt_Eight.Click += new System.EventHandler(this.button_Click);
            // 
            // bt_Nine
            // 
            this.bt_Nine.Location = new System.Drawing.Point(192, 202);
            this.bt_Nine.Name = "bt_Nine";
            this.bt_Nine.Size = new System.Drawing.Size(84, 82);
            this.bt_Nine.TabIndex = 7;
            this.bt_Nine.Text = "9";
            this.bt_Nine.UseVisualStyleBackColor = true;
            this.bt_Nine.Click += new System.EventHandler(this.button_Click);
            // 
            // bt_Multiple
            // 
            this.bt_Multiple.Location = new System.Drawing.Point(282, 202);
            this.bt_Multiple.Name = "bt_Multiple";
            this.bt_Multiple.Size = new System.Drawing.Size(84, 82);
            this.bt_Multiple.TabIndex = 8;
            this.bt_Multiple.Text = "*";
            this.bt_Multiple.UseVisualStyleBackColor = true;
            this.bt_Multiple.Click += new System.EventHandler(this.operator_Click);
            // 
            // bt_Sum
            // 
            this.bt_Sum.Location = new System.Drawing.Point(282, 379);
            this.bt_Sum.Name = "bt_Sum";
            this.bt_Sum.Size = new System.Drawing.Size(84, 82);
            this.bt_Sum.TabIndex = 16;
            this.bt_Sum.Text = "+";
            this.bt_Sum.UseVisualStyleBackColor = true;
            this.bt_Sum.Click += new System.EventHandler(this.operator_Click);
            // 
            // bt_Three
            // 
            this.bt_Three.Location = new System.Drawing.Point(192, 379);
            this.bt_Three.Name = "bt_Three";
            this.bt_Three.Size = new System.Drawing.Size(84, 82);
            this.bt_Three.TabIndex = 15;
            this.bt_Three.Text = "3";
            this.bt_Three.UseVisualStyleBackColor = true;
            this.bt_Three.Click += new System.EventHandler(this.button_Click);
            // 
            // bt_Two
            // 
            this.bt_Two.Location = new System.Drawing.Point(102, 379);
            this.bt_Two.Name = "bt_Two";
            this.bt_Two.Size = new System.Drawing.Size(84, 82);
            this.bt_Two.TabIndex = 14;
            this.bt_Two.Text = "2";
            this.bt_Two.UseVisualStyleBackColor = true;
            this.bt_Two.Click += new System.EventHandler(this.button_Click);
            // 
            // bt_One
            // 
            this.bt_One.Location = new System.Drawing.Point(12, 379);
            this.bt_One.Name = "bt_One";
            this.bt_One.Size = new System.Drawing.Size(84, 82);
            this.bt_One.TabIndex = 13;
            this.bt_One.Text = "1";
            this.bt_One.UseVisualStyleBackColor = true;
            this.bt_One.Click += new System.EventHandler(this.button_Click);
            // 
            // bt_Subtract
            // 
            this.bt_Subtract.Location = new System.Drawing.Point(282, 291);
            this.bt_Subtract.Name = "bt_Subtract";
            this.bt_Subtract.Size = new System.Drawing.Size(84, 82);
            this.bt_Subtract.TabIndex = 12;
            this.bt_Subtract.Text = "-";
            this.bt_Subtract.UseVisualStyleBackColor = true;
            this.bt_Subtract.Click += new System.EventHandler(this.operator_Click);
            // 
            // bt_Six
            // 
            this.bt_Six.Location = new System.Drawing.Point(192, 291);
            this.bt_Six.Name = "bt_Six";
            this.bt_Six.Size = new System.Drawing.Size(84, 82);
            this.bt_Six.TabIndex = 11;
            this.bt_Six.Text = "6";
            this.bt_Six.UseVisualStyleBackColor = true;
            this.bt_Six.Click += new System.EventHandler(this.button_Click);
            // 
            // bt_Five
            // 
            this.bt_Five.Location = new System.Drawing.Point(102, 291);
            this.bt_Five.Name = "bt_Five";
            this.bt_Five.Size = new System.Drawing.Size(84, 82);
            this.bt_Five.TabIndex = 10;
            this.bt_Five.Text = "5";
            this.bt_Five.UseVisualStyleBackColor = true;
            this.bt_Five.Click += new System.EventHandler(this.button_Click);
            // 
            // bt_Four
            // 
            this.bt_Four.Location = new System.Drawing.Point(12, 291);
            this.bt_Four.Name = "bt_Four";
            this.bt_Four.Size = new System.Drawing.Size(84, 82);
            this.bt_Four.TabIndex = 9;
            this.bt_Four.Text = "4";
            this.bt_Four.UseVisualStyleBackColor = true;
            this.bt_Four.Click += new System.EventHandler(this.button_Click);
            // 
            // bt_Equal
            // 
            this.bt_Equal.Location = new System.Drawing.Point(282, 467);
            this.bt_Equal.Name = "bt_Equal";
            this.bt_Equal.Size = new System.Drawing.Size(84, 82);
            this.bt_Equal.TabIndex = 20;
            this.bt_Equal.Text = "=";
            this.bt_Equal.UseVisualStyleBackColor = true;
            this.bt_Equal.Click += new System.EventHandler(this.bt_Equal_Click);
            // 
            // bt_DecimalPoint
            // 
            this.bt_DecimalPoint.Location = new System.Drawing.Point(192, 467);
            this.bt_DecimalPoint.Name = "bt_DecimalPoint";
            this.bt_DecimalPoint.Size = new System.Drawing.Size(84, 82);
            this.bt_DecimalPoint.TabIndex = 19;
            this.bt_DecimalPoint.Text = ",";
            this.bt_DecimalPoint.UseVisualStyleBackColor = true;
            this.bt_DecimalPoint.Click += new System.EventHandler(this.button_Click);
            // 
            // bt_Zero
            // 
            this.bt_Zero.Location = new System.Drawing.Point(102, 467);
            this.bt_Zero.Name = "bt_Zero";
            this.bt_Zero.Size = new System.Drawing.Size(84, 82);
            this.bt_Zero.TabIndex = 18;
            this.bt_Zero.Text = "0";
            this.bt_Zero.UseVisualStyleBackColor = true;
            this.bt_Zero.Click += new System.EventHandler(this.button_Click);
            // 
            // bt_PlusMinus
            // 
            this.bt_PlusMinus.Location = new System.Drawing.Point(12, 467);
            this.bt_PlusMinus.Name = "bt_PlusMinus";
            this.bt_PlusMinus.Size = new System.Drawing.Size(84, 82);
            this.bt_PlusMinus.TabIndex = 17;
            this.bt_PlusMinus.Text = "+/-";
            this.bt_PlusMinus.UseVisualStyleBackColor = true;
            this.bt_PlusMinus.Click += new System.EventHandler(this.bt_PlusMinus_Click);
            // 
            // lb_Temp
            // 
            this.lb_Temp.AutoSize = true;
            this.lb_Temp.Location = new System.Drawing.Point(12, 9);
            this.lb_Temp.Name = "lb_Temp";
            this.lb_Temp.Size = new System.Drawing.Size(0, 20);
            this.lb_Temp.TabIndex = 21;
            // 
            // Frm_Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 557);
            this.Controls.Add(this.lb_Temp);
            this.Controls.Add(this.bt_Equal);
            this.Controls.Add(this.bt_DecimalPoint);
            this.Controls.Add(this.bt_Zero);
            this.Controls.Add(this.bt_PlusMinus);
            this.Controls.Add(this.bt_Sum);
            this.Controls.Add(this.bt_Three);
            this.Controls.Add(this.bt_Two);
            this.Controls.Add(this.bt_One);
            this.Controls.Add(this.bt_Subtract);
            this.Controls.Add(this.bt_Six);
            this.Controls.Add(this.bt_Five);
            this.Controls.Add(this.bt_Four);
            this.Controls.Add(this.bt_Multiple);
            this.Controls.Add(this.bt_Nine);
            this.Controls.Add(this.bt_Eight);
            this.Controls.Add(this.bt_Seven);
            this.Controls.Add(this.bt_Divide);
            this.Controls.Add(this.bt_Delete);
            this.Controls.Add(this.bt_ResetAll);
            this.Controls.Add(this.bt_Reset);
            this.Controls.Add(this.tb_Result);
            this.Name = "Frm_Calculator";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_Result;
        private System.Windows.Forms.Button bt_Reset;
        private System.Windows.Forms.Button bt_ResetAll;
        private System.Windows.Forms.Button bt_Delete;
        private System.Windows.Forms.Button bt_Divide;
        private System.Windows.Forms.Button bt_Seven;
        private System.Windows.Forms.Button bt_Eight;
        private System.Windows.Forms.Button bt_Nine;
        private System.Windows.Forms.Button bt_Multiple;
        private System.Windows.Forms.Button bt_Sum;
        private System.Windows.Forms.Button bt_Three;
        private System.Windows.Forms.Button bt_Two;
        private System.Windows.Forms.Button bt_One;
        private System.Windows.Forms.Button bt_Subtract;
        private System.Windows.Forms.Button bt_Six;
        private System.Windows.Forms.Button bt_Five;
        private System.Windows.Forms.Button bt_Four;
        private System.Windows.Forms.Button bt_Equal;
        private System.Windows.Forms.Button bt_DecimalPoint;
        private System.Windows.Forms.Button bt_Zero;
        private System.Windows.Forms.Button bt_PlusMinus;
        private System.Windows.Forms.Label lb_Temp;
    }
}

