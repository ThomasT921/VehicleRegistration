namespace TT_Final_Project
{
    partial class SuvForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSuvMake = new System.Windows.Forms.TextBox();
            this.txtSuvModel = new System.Windows.Forms.TextBox();
            this.txtSuvDrive = new System.Windows.Forms.TextBox();
            this.txtSuvEngine = new System.Windows.Forms.TextBox();
            this.txtSuvStyle = new System.Windows.Forms.TextBox();
            this.txtSuvSeats = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSuvAdd = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtSuvSeats);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtSuvMake);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtSuvStyle);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtSuvModel);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtSuvEngine);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtSuvDrive);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(272, 205);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Suv Properties";
            // 
            // txtSuvMake
            // 
            this.txtSuvMake.Location = new System.Drawing.Point(146, 28);
            this.txtSuvMake.Name = "txtSuvMake";
            this.txtSuvMake.Size = new System.Drawing.Size(120, 20);
            this.txtSuvMake.TabIndex = 1;
            // 
            // txtSuvModel
            // 
            this.txtSuvModel.Location = new System.Drawing.Point(146, 54);
            this.txtSuvModel.Name = "txtSuvModel";
            this.txtSuvModel.Size = new System.Drawing.Size(120, 20);
            this.txtSuvModel.TabIndex = 2;
            // 
            // txtSuvDrive
            // 
            this.txtSuvDrive.Location = new System.Drawing.Point(146, 80);
            this.txtSuvDrive.Name = "txtSuvDrive";
            this.txtSuvDrive.Size = new System.Drawing.Size(120, 20);
            this.txtSuvDrive.TabIndex = 3;
            // 
            // txtSuvEngine
            // 
            this.txtSuvEngine.Location = new System.Drawing.Point(146, 106);
            this.txtSuvEngine.Name = "txtSuvEngine";
            this.txtSuvEngine.Size = new System.Drawing.Size(120, 20);
            this.txtSuvEngine.TabIndex = 4;
            // 
            // txtSuvStyle
            // 
            this.txtSuvStyle.Location = new System.Drawing.Point(146, 132);
            this.txtSuvStyle.Name = "txtSuvStyle";
            this.txtSuvStyle.Size = new System.Drawing.Size(120, 20);
            this.txtSuvStyle.TabIndex = 5;
            // 
            // txtSuvSeats
            // 
            this.txtSuvSeats.Location = new System.Drawing.Point(146, 158);
            this.txtSuvSeats.Name = "txtSuvSeats";
            this.txtSuvSeats.Size = new System.Drawing.Size(120, 20);
            this.txtSuvSeats.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Make:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Model:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Drivetrain:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Engine:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Style:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Amount of Seats:";
            // 
            // btnSuvAdd
            // 
            this.btnSuvAdd.Location = new System.Drawing.Point(62, 223);
            this.btnSuvAdd.Name = "btnSuvAdd";
            this.btnSuvAdd.Size = new System.Drawing.Size(177, 23);
            this.btnSuvAdd.TabIndex = 1;
            this.btnSuvAdd.Text = "Add";
            this.btnSuvAdd.UseVisualStyleBackColor = true;
            this.btnSuvAdd.Click += new System.EventHandler(this.btnSuvAdd_Click);
            // 
            // SuvForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 256);
            this.Controls.Add(this.btnSuvAdd);
            this.Controls.Add(this.groupBox1);
            this.Name = "SuvForm";
            this.Text = "Add Suv";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSuvAdd;
        public System.Windows.Forms.TextBox txtSuvMake;
        public System.Windows.Forms.TextBox txtSuvModel;
        public System.Windows.Forms.TextBox txtSuvDrive;
        public System.Windows.Forms.TextBox txtSuvEngine;
        public System.Windows.Forms.TextBox txtSuvStyle;
        public System.Windows.Forms.TextBox txtSuvSeats;
    }
}