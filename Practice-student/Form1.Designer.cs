namespace Practice_student
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
            lblstudentinfo = new Label();
            button1 = new Button();
            txtenrollment = new TextBox();
            label7 = new Label();
            numericUpDown1 = new NumericUpDown();
            dtBirthdate = new DateTimePicker();
            txtPaternlastname = new TextBox();
            txtmotherlastname = new TextBox();
            textBox3 = new TextBox();
            txtcarrer = new TextBox();
            txtName = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // lblstudentinfo
            // 
            lblstudentinfo.AutoSize = true;
            lblstudentinfo.Location = new Point(503, 253);
            lblstudentinfo.Margin = new Padding(3, 0, 3, 9);
            lblstudentinfo.Name = "lblstudentinfo";
            lblstudentinfo.Size = new Size(50, 20);
            lblstudentinfo.TabIndex = 67;
            lblstudentinfo.Text = "label8";
            // 
            // button1
            // 
            button1.Location = new Point(633, 223);
            button1.Name = "button1";
            button1.Size = new Size(107, 29);
            button1.TabIndex = 66;
            button1.Text = "create";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtenrollment
            // 
            txtenrollment.Location = new Point(186, 183);
            txtenrollment.Name = "txtenrollment";
            txtenrollment.Size = new Size(162, 27);
            txtenrollment.TabIndex = 65;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(225, 142);
            label7.Name = "label7";
            label7.Size = new Size(81, 20);
            label7.TabIndex = 64;
            label7.Text = "Enrollment";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(402, 183);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(117, 27);
            numericUpDown1.TabIndex = 63;
            // 
            // dtBirthdate
            // 
            dtBirthdate.Format = DateTimePickerFormat.Short;
            dtBirthdate.Location = new Point(621, 70);
            dtBirthdate.Name = "dtBirthdate";
            dtBirthdate.Size = new Size(100, 27);
            dtBirthdate.TabIndex = 62;
            // 
            // txtPaternlastname
            // 
            txtPaternlastname.Location = new Point(199, 71);
            txtPaternlastname.Name = "txtPaternlastname";
            txtPaternlastname.Size = new Size(162, 27);
            txtPaternlastname.TabIndex = 60;
            // 
            // txtmotherlastname
            // 
            txtmotherlastname.Location = new Point(393, 71);
            txtmotherlastname.Name = "txtmotherlastname";
            txtmotherlastname.Size = new Size(175, 27);
            txtmotherlastname.TabIndex = 61;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(633, 70);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(84, 27);
            textBox3.TabIndex = 59;
            // 
            // txtcarrer
            // 
            txtcarrer.Location = new Point(37, 183);
            txtcarrer.Name = "txtcarrer";
            txtcarrer.Size = new Size(125, 27);
            txtcarrer.TabIndex = 58;
            // 
            // txtName
            // 
            txtName.Location = new Point(37, 71);
            txtName.Name = "txtName";
            txtName.Size = new Size(125, 27);
            txtName.TabIndex = 57;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(225, 49);
            label6.Name = "label6";
            label6.Size = new Size(110, 20);
            label6.TabIndex = 56;
            label6.Text = "Paternlastname";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(422, 49);
            label5.Name = "label5";
            label5.Size = new Size(117, 20);
            label5.TabIndex = 55;
            label5.Text = "motherlastname";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(621, 49);
            label4.Name = "label4";
            label4.Size = new Size(96, 20);
            label4.TabIndex = 54;
            label4.Text = "DateBirthday";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(62, 142);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 53;
            label3.Text = "Carrer";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(422, 142);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 52;
            label2.Text = "Average";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(62, 49);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 51;
            label1.Text = "Name";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblstudentinfo);
            Controls.Add(button1);
            Controls.Add(txtenrollment);
            Controls.Add(label7);
            Controls.Add(numericUpDown1);
            Controls.Add(dtBirthdate);
            Controls.Add(txtPaternlastname);
            Controls.Add(txtmotherlastname);
            Controls.Add(textBox3);
            Controls.Add(txtcarrer);
            Controls.Add(txtName);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblstudentinfo;
        private Button button1;
        private TextBox txtenrollment;
        private Label label7;
        private NumericUpDown numericUpDown1;
        private DateTimePicker dtBirthdate;
        private TextBox txtPaternlastname;
        private TextBox txtmotherlastname;
        private TextBox textBox3;
        private TextBox txtcarrer;
        private TextBox txtName;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}