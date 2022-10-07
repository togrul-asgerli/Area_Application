namespace Area_Application
{
    partial class Rectangle
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
            this.txt_width = new System.Windows.Forms.TextBox();
            this.txt_Length = new System.Windows.Forms.TextBox();
            this.lbl_1 = new System.Windows.Forms.Button();
            this.lbl_2 = new System.Windows.Forms.Button();
            this.btn_calc = new System.Windows.Forms.Button();
            this.txt_area = new System.Windows.Forms.TextBox();
            this.txt_perm = new System.Windows.Forms.TextBox();
            this.btn_back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_width
            // 
            this.txt_width.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_width.Location = new System.Drawing.Point(145, 111);
            this.txt_width.Multiline = true;
            this.txt_width.Name = "txt_width";
            this.txt_width.Size = new System.Drawing.Size(178, 69);
            this.txt_width.TabIndex = 0;
            this.txt_width.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_Length
            // 
            this.txt_Length.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Length.Location = new System.Drawing.Point(145, 227);
            this.txt_Length.Multiline = true;
            this.txt_Length.Name = "txt_Length";
            this.txt_Length.Size = new System.Drawing.Size(178, 69);
            this.txt_Length.TabIndex = 1;
            this.txt_Length.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_1
            // 
            this.lbl_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_1.Location = new System.Drawing.Point(53, 121);
            this.lbl_1.Name = "lbl_1";
            this.lbl_1.Size = new System.Drawing.Size(86, 44);
            this.lbl_1.TabIndex = 2;
            this.lbl_1.Text = "Width";
            this.lbl_1.UseVisualStyleBackColor = true;
            // 
            // lbl_2
            // 
            this.lbl_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_2.Location = new System.Drawing.Point(53, 236);
            this.lbl_2.Name = "lbl_2";
            this.lbl_2.Size = new System.Drawing.Size(86, 44);
            this.lbl_2.TabIndex = 3;
            this.lbl_2.Text = "Length";
            this.lbl_2.UseVisualStyleBackColor = true;
            // 
            // btn_calc
            // 
            this.btn_calc.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_calc.Location = new System.Drawing.Point(372, 175);
            this.btn_calc.Name = "btn_calc";
            this.btn_calc.Size = new System.Drawing.Size(145, 72);
            this.btn_calc.TabIndex = 4;
            this.btn_calc.Text = "Calculate";
            this.btn_calc.UseVisualStyleBackColor = true;
            this.btn_calc.Click += new System.EventHandler(this.button3_Click);
            // 
            // txt_area
            // 
            this.txt_area.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_area.Location = new System.Drawing.Point(575, 88);
            this.txt_area.Multiline = true;
            this.txt_area.Name = "txt_area";
            this.txt_area.Size = new System.Drawing.Size(175, 92);
            this.txt_area.TabIndex = 5;
            // 
            // txt_perm
            // 
            this.txt_perm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_perm.Location = new System.Drawing.Point(575, 204);
            this.txt_perm.Multiline = true;
            this.txt_perm.Name = "txt_perm";
            this.txt_perm.Size = new System.Drawing.Size(175, 92);
            this.txt_perm.TabIndex = 6;
            // 
            // btn_back
            // 
            this.btn_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.Location = new System.Drawing.Point(6, 12);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(87, 41);
            this.btn_back.TabIndex = 7;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // Rectangle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Area_Application.Properties.Resources.powerpoint_background_abstract_14;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.txt_perm);
            this.Controls.Add(this.txt_area);
            this.Controls.Add(this.btn_calc);
            this.Controls.Add(this.lbl_2);
            this.Controls.Add(this.lbl_1);
            this.Controls.Add(this.txt_Length);
            this.Controls.Add(this.txt_width);
            this.Name = "Rectangle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rectangle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_width;
        private System.Windows.Forms.TextBox txt_Length;
        private System.Windows.Forms.Button lbl_1;
        private System.Windows.Forms.Button lbl_2;
        private System.Windows.Forms.Button btn_calc;
        private System.Windows.Forms.TextBox txt_area;
        private System.Windows.Forms.TextBox txt_perm;
        private System.Windows.Forms.Button btn_back;
    }
}