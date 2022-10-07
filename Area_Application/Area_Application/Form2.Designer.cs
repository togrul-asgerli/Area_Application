namespace Area_Application
{
    partial class Triangle
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
            this.f_side = new System.Windows.Forms.TextBox();
            this.s_side = new System.Windows.Forms.TextBox();
            this.th_side = new System.Windows.Forms.TextBox();
            this.lbl_1 = new System.Windows.Forms.TextBox();
            this.lbl_2 = new System.Windows.Forms.TextBox();
            this.lbl_3 = new System.Windows.Forms.TextBox();
            this.txt_area = new System.Windows.Forms.TextBox();
            this.txt_perm = new System.Windows.Forms.TextBox();
            this.btn_calc = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // f_side
            // 
            this.f_side.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.f_side.Location = new System.Drawing.Point(175, 96);
            this.f_side.Multiline = true;
            this.f_side.Name = "f_side";
            this.f_side.Size = new System.Drawing.Size(123, 54);
            this.f_side.TabIndex = 0;
            this.f_side.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // s_side
            // 
            this.s_side.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.s_side.Location = new System.Drawing.Point(175, 174);
            this.s_side.Multiline = true;
            this.s_side.Name = "s_side";
            this.s_side.Size = new System.Drawing.Size(123, 54);
            this.s_side.TabIndex = 1;
            this.s_side.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // th_side
            // 
            this.th_side.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.th_side.Location = new System.Drawing.Point(175, 245);
            this.th_side.Multiline = true;
            this.th_side.Name = "th_side";
            this.th_side.Size = new System.Drawing.Size(123, 54);
            this.th_side.TabIndex = 2;
            this.th_side.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_1
            // 
            this.lbl_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_1.Location = new System.Drawing.Point(28, 105);
            this.lbl_1.Multiline = true;
            this.lbl_1.Name = "lbl_1";
            this.lbl_1.Size = new System.Drawing.Size(123, 35);
            this.lbl_1.TabIndex = 3;
            this.lbl_1.Text = "First Side:";
            this.lbl_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_2
            // 
            this.lbl_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_2.Location = new System.Drawing.Point(28, 184);
            this.lbl_2.Multiline = true;
            this.lbl_2.Name = "lbl_2";
            this.lbl_2.Size = new System.Drawing.Size(123, 33);
            this.lbl_2.TabIndex = 4;
            this.lbl_2.Text = "Second :";
            this.lbl_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_3
            // 
            this.lbl_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_3.Location = new System.Drawing.Point(28, 255);
            this.lbl_3.Multiline = true;
            this.lbl_3.Name = "lbl_3";
            this.lbl_3.Size = new System.Drawing.Size(123, 35);
            this.lbl_3.TabIndex = 5;
            this.lbl_3.Text = "Third:";
            this.lbl_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_area
            // 
            this.txt_area.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_area.Location = new System.Drawing.Point(587, 76);
            this.txt_area.Multiline = true;
            this.txt_area.Name = "txt_area";
            this.txt_area.Size = new System.Drawing.Size(163, 74);
            this.txt_area.TabIndex = 6;
            this.txt_area.TextChanged += new System.EventHandler(this.textBox_Area_TextChanged);
            // 
            // txt_perm
            // 
            this.txt_perm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_perm.Location = new System.Drawing.Point(587, 215);
            this.txt_perm.Multiline = true;
            this.txt_perm.Name = "txt_perm";
            this.txt_perm.Size = new System.Drawing.Size(163, 75);
            this.txt_perm.TabIndex = 7;
            this.txt_perm.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // btn_calc
            // 
            this.btn_calc.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_calc.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_calc.Location = new System.Drawing.Point(372, 162);
            this.btn_calc.Name = "btn_calc";
            this.btn_calc.Size = new System.Drawing.Size(156, 66);
            this.btn_calc.TabIndex = 8;
            this.btn_calc.Text = "Calculate";
            this.btn_calc.UseVisualStyleBackColor = true;
            this.btn_calc.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_back
            // 
            this.btn_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_back.Location = new System.Drawing.Point(3, 12);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(99, 41);
            this.btn_back.TabIndex = 9;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Triangle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Area_Application.Properties.Resources._1169911;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_calc);
            this.Controls.Add(this.txt_perm);
            this.Controls.Add(this.txt_area);
            this.Controls.Add(this.lbl_3);
            this.Controls.Add(this.lbl_2);
            this.Controls.Add(this.lbl_1);
            this.Controls.Add(this.th_side);
            this.Controls.Add(this.s_side);
            this.Controls.Add(this.f_side);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Name = "Triangle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Triangle";
            this.Load += new System.EventHandler(this.Triangle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox f_side;
        private System.Windows.Forms.TextBox s_side;
        private System.Windows.Forms.TextBox th_side;
        private System.Windows.Forms.TextBox lbl_1;
        private System.Windows.Forms.TextBox lbl_2;
        private System.Windows.Forms.TextBox lbl_3;
        private System.Windows.Forms.TextBox txt_area;
        private System.Windows.Forms.TextBox txt_perm;
        private System.Windows.Forms.Button btn_calc;
        private System.Windows.Forms.Button btn_back;
    }
}