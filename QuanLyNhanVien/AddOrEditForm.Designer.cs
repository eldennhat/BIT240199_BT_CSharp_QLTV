using System.ComponentModel;

namespace QuanLyNhanVien;

partial class AddOrEditForm
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

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
    private void InitializeComponent() {
        label1 = new System.Windows.Forms.Label();
        idBox = new System.Windows.Forms.TextBox();
        nameBox = new System.Windows.Forms.TextBox();
        label2 = new System.Windows.Forms.Label();
        label3 = new System.Windows.Forms.Label();
        dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
        label4 = new System.Windows.Forms.Label();
        genderBox = new System.Windows.Forms.ComboBox();
        label5 = new System.Windows.Forms.Label();
        label6 = new System.Windows.Forms.Label();
        label7 = new System.Windows.Forms.Label();
        label8 = new System.Windows.Forms.Label();
        label9 = new System.Windows.Forms.Label();
        label10 = new System.Windows.Forms.Label();
        backgroundDescBox = new System.Windows.Forms.TextBox();
        phoneBox = new System.Windows.Forms.TextBox();
        statusCheckbox = new System.Windows.Forms.CheckBox();
        salaryBox = new System.Windows.Forms.NumericUpDown();
        Save = new System.Windows.Forms.Button();
        button2 = new System.Windows.Forms.Button();
        posBox = new System.Windows.Forms.ComboBox();
        specialBox = new System.Windows.Forms.TextBox();
        ((System.ComponentModel.ISupportInitialize)salaryBox).BeginInit();
        SuspendLayout();
        // 
        // label1
        // 
        label1.Location = new System.Drawing.Point(27, 25);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(100, 40);
        label1.TabIndex = 0;
        label1.Text = "ID";
        label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // idBox
        // 
        idBox.Location = new System.Drawing.Point(166, 25);
        idBox.Name = "idBox";
        idBox.Size = new System.Drawing.Size(430, 39);
        idBox.TabIndex = 1;
        // 
        // nameBox
        // 
        nameBox.Location = new System.Drawing.Point(166, 80);
        nameBox.Name = "nameBox";
        nameBox.Size = new System.Drawing.Size(430, 39);
        nameBox.TabIndex = 3;
        // 
        // label2
        // 
        label2.Location = new System.Drawing.Point(27, 80);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(133, 40);
        label2.TabIndex = 2;
        label2.Text = "Full name";
        label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // label3
        // 
        label3.Location = new System.Drawing.Point(27, 135);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(106, 40);
        label3.TabIndex = 4;
        label3.Text = "Birthday";
        label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // dateTimePicker1
        // 
        dateTimePicker1.Location = new System.Drawing.Point(166, 134);
        dateTimePicker1.Name = "dateTimePicker1";
        dateTimePicker1.Size = new System.Drawing.Size(430, 39);
        dateTimePicker1.TabIndex = 5;
        // 
        // label4
        // 
        label4.Location = new System.Drawing.Point(27, 191);
        label4.Name = "label4";
        label4.Size = new System.Drawing.Size(100, 40);
        label4.TabIndex = 6;
        label4.Text = "Gender";
        label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // genderBox
        // 
        genderBox.FormattingEnabled = true;
        genderBox.Location = new System.Drawing.Point(166, 191);
        genderBox.Name = "genderBox";
        genderBox.Size = new System.Drawing.Size(430, 40);
        genderBox.TabIndex = 7;
        // 
        // label5
        // 
        label5.Location = new System.Drawing.Point(27, 246);
        label5.Name = "label5";
        label5.Size = new System.Drawing.Size(100, 40);
        label5.TabIndex = 8;
        label5.Text = "Phone";
        label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // label6
        // 
        label6.Location = new System.Drawing.Point(27, 300);
        label6.Name = "label6";
        label6.Size = new System.Drawing.Size(141, 40);
        label6.TabIndex = 9;
        label6.Text = "Description";
        label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // label7
        // 
        label7.Location = new System.Drawing.Point(27, 356);
        label7.Name = "label7";
        label7.Size = new System.Drawing.Size(100, 40);
        label7.TabIndex = 10;
        label7.Text = "Position";
        label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // label8
        // 
        label8.Location = new System.Drawing.Point(27, 410);
        label8.Name = "label8";
        label8.Size = new System.Drawing.Size(133, 40);
        label8.TabIndex = 11;
        label8.Text = "Special in";
        label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // label9
        // 
        label9.Location = new System.Drawing.Point(27, 465);
        label9.Name = "label9";
        label9.Size = new System.Drawing.Size(100, 40);
        label9.TabIndex = 12;
        label9.Text = "Status";
        label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // label10
        // 
        label10.Location = new System.Drawing.Point(27, 520);
        label10.Name = "label10";
        label10.Size = new System.Drawing.Size(100, 40);
        label10.TabIndex = 13;
        label10.Text = "Salary";
        label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // backgroundDescBox
        // 
        backgroundDescBox.Location = new System.Drawing.Point(166, 246);
        backgroundDescBox.Name = "backgroundDescBox";
        backgroundDescBox.Size = new System.Drawing.Size(430, 39);
        backgroundDescBox.TabIndex = 14;
        // 
        // phoneBox
        // 
        phoneBox.Location = new System.Drawing.Point(166, 300);
        phoneBox.Name = "phoneBox";
        phoneBox.Size = new System.Drawing.Size(430, 39);
        phoneBox.TabIndex = 15;
        // 
        // posBox
        // 
        specialBox.Location = new System.Drawing.Point(166, 411);
        specialBox.Name = "posBox";
        specialBox.Size = new System.Drawing.Size(430, 39);
        specialBox.TabIndex = 17;
        // 
        // statusCheckbox
        // 
        statusCheckbox.Location = new System.Drawing.Point(166, 463);
        statusCheckbox.Name = "statusCheckbox";
        statusCheckbox.Size = new System.Drawing.Size(32, 42);
        statusCheckbox.TabIndex = 18;
        statusCheckbox.Text = "statusCheckbox";
        statusCheckbox.UseVisualStyleBackColor = true;
        // 
        // salaryBox
        // 
        salaryBox.Location = new System.Drawing.Point(166, 522);
        salaryBox.Name = "salaryBox";
        salaryBox.Size = new System.Drawing.Size(430, 39);
        salaryBox.TabIndex = 19;
        // 
        // Save
        // 
        Save.Location = new System.Drawing.Point(83, 610);
        Save.Name = "Save";
        Save.Size = new System.Drawing.Size(164, 47);
        Save.TabIndex = 20;
        Save.Text = "Save";
        Save.UseVisualStyleBackColor = true;
        Save.Click += Save_Click;
        // 
        // button2
        // 
        button2.Location = new System.Drawing.Point(350, 610);
        button2.Name = "button2";
        button2.Size = new System.Drawing.Size(164, 47);
        button2.TabIndex = 21;
        button2.Text = "Cancel";
        button2.UseVisualStyleBackColor = true;
        button2.Click += button2_Click_1;
        // 
        // posBox
        // 
        posBox.FormattingEnabled = true;
        posBox.Location = new System.Drawing.Point(166, 357);
        posBox.Name = "posBox";
        posBox.Size = new System.Drawing.Size(430, 40);
        posBox.TabIndex = 22;
        posBox.DataSource = Enum.GetValues(typeof(ChucVu));
        // 
        // AddOrEditForm
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(618, 694);
        Controls.Add(button2);
        Controls.Add(Save);
        Controls.Add(salaryBox);
        Controls.Add(statusCheckbox);
        Controls.Add(posBox);
        Controls.Add(phoneBox);
        Controls.Add(genderBox);
        Controls.Add(label10);
        Controls.Add(label9);
        Controls.Add(label8);
        Controls.Add(label7);
        Controls.Add(label6);
        Controls.Add(label5);
        Controls.Add(backgroundDescBox);
        Controls.Add(label4);
        Controls.Add(dateTimePicker1);
        Controls.Add(label3);
        Controls.Add(nameBox);
        Controls.Add(label2);
        Controls.Add(idBox);
        Controls.Add(label1);
        Controls.Add(specialBox);
        Text = "AddOrEditForm";
        Load += AddOrEditForm_Load;
        ((System.ComponentModel.ISupportInitialize)salaryBox).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.ComboBox posBox;

    public System.Windows.Forms.Button Save;
    public System.Windows.Forms.Button button2;

    public System.Windows.Forms.NumericUpDown salaryBox;

    public System.Windows.Forms.CheckBox statusCheckbox;

    public System.Windows.Forms.TextBox specialBox;

    public System.Windows.Forms.TextBox backgroundDescBox;
    public System.Windows.Forms.TextBox phoneBox;

    public System.Windows.Forms.Label label10;

    public System.Windows.Forms.Label label6;
    public System.Windows.Forms.Label label7;
    public System.Windows.Forms.Label label8;
    public System.Windows.Forms.Label label9;

    public System.Windows.Forms.Label label5;

    public System.Windows.Forms.Label label4;

    public System.Windows.Forms.ComboBox genderBox;

    public System.Windows.Forms.DateTimePicker dateTimePicker1;

    public System.Windows.Forms.Label label3;

    public System.Windows.Forms.TextBox idBox;
    public System.Windows.Forms.TextBox nameBox;
    public System.Windows.Forms.Label label2;

    public System.Windows.Forms.Label label1;

    #endregion
}