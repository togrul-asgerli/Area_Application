namespace Area_Application
{
    partial class Circle
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
            this.lbl_1 = new System.Windows.Forms.Button();
            this.txt_radius = new System.Windows.Forms.TextBox();
            this.area = new System.Windows.Forms.TextBox();
            this.btn_calc = new System.Windows.Forms.Button();
            this.perimetr = new System.Windows.Forms.TextBox();
            this.btn_back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_1
            // 
            this.lbl_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_1.Location = new System.Drawing.Point(29, 212);
            this.lbl_1.Name = "lbl_1";
            this.lbl_1.Size = new System.Drawing.Size(96, 38);
            this.lbl_1.TabIndex = 0;
            this.lbl_1.Text = "Radius";
            this.lbl_1.UseVisualStyleBackColor = true;
            // 
            // txt_radius
            // 
            this.txt_radius.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_radius.Location = new System.Drawing.Point(146, 201);
            this.txt_radius.Multiline = true;
            this.txt_radius.Name = "txt_radius";
            this.txt_radius.Size = new System.Drawing.Size(123, 60);
            this.txt_radius.TabIndex = 1;
            this.txt_radius.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_radius.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // area
            // 
            this.area.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.area.Location = new System.Drawing.Point(529, 123);
            this.area.Multiline = true;
            this.area.Name = "area";
            this.area.Size = new System.Drawing.Size(123, 89);
            this.area.TabIndex = 2;
            this.area.TextChanged += new System.EventHandler(this.area_TextChanged);
            // 
            // btn_calc
            // 
            this.btn_calc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_calc.Location = new System.Drawing.Point(343, 201);
            this.btn_calc.Name = "btn_calc";
            this.btn_calc.Size = new System.Drawing.Size(105, 60);
            this.btn_calc.TabIndex = 3;
            this.btn_calc.Text = "Calculate";
            this.btn_calc.UseVisualStyleBackColor = true;
            this.btn_calc.Click += new System.EventHandler(this.button2_Click);
            // 
            // perimetr
            // 
            this.perimetr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.perimetr.Location = new System.Drawing.Point(529, 258);
            this.perimetr.Multiline = true;
            this.perimetr.Name = "perimetr";
            this.perimetr.Size = new System.Drawing.Size(123, 89);
            this.perimetr.TabIndex = 4;
            // 
            // btn_back
            // 
            this.btn_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.Location = new System.Drawing.Point(12, 12);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(87, 41);
            this.btn_back.TabIndex = 8;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // Circle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Area_Application.Properties.Resources.istockphoto_1263843726_640x640;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.perimetr);
            this.Controls.Add(this.btn_calc);
            this.Controls.Add(this.area);
            this.Controls.Add(this.txt_radius);
            this.Controls.Add(this.lbl_1);
            this.Name = "Circle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Circle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button lbl_1;
        private System.Windows.Forms.TextBox txt_radius;
        private System.Windows.Forms.TextBox area;
        private System.Windows.Forms.Button btn_calc;
        private System.Windows.Forms.TextBox perimetr;
        private System.Windows.Forms.Button btn_back;
    }
}