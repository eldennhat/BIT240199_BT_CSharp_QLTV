namespace QuanLyNhanVien;

partial class MainQuanLy {
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
        if (disposing && (components != null)) {
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
        textBox1 = new System.Windows.Forms.TextBox();
        searchButton = new System.Windows.Forms.Button();
        nameSortButton = new System.Windows.Forms.Button();
        posSortButton = new System.Windows.Forms.Button();
        staffGrid = new System.Windows.Forms.DataGridView();
        addButton = new System.Windows.Forms.Button();
        editButton = new System.Windows.Forms.Button();
        deleteButton = new System.Windows.Forms.Button();
        detailButton = new System.Windows.Forms.Button();
        refreshButton = new System.Windows.Forms.Button();
        ((System.ComponentModel.ISupportInitialize)staffGrid).BeginInit();
        SuspendLayout();
        // 
        // textBox1
        // 
        textBox1.Location = new System.Drawing.Point(12, 34);
        textBox1.Name = "textBox1";
        textBox1.Size = new System.Drawing.Size(495, 39);
        textBox1.TabIndex = 0;
        // 
        // searchButton
        // 
        searchButton.Location = new System.Drawing.Point(538, 29);
        searchButton.Name = "searchButton";
        searchButton.Size = new System.Drawing.Size(203, 49);
        searchButton.TabIndex = 1;
        searchButton.Text = "Search";
        searchButton.UseVisualStyleBackColor = true;
        // 
        // nameSortButton
        // 
        nameSortButton.Location = new System.Drawing.Point(1005, 29);
        nameSortButton.Name = "nameSortButton";
        nameSortButton.Size = new System.Drawing.Size(229, 49);
        nameSortButton.TabIndex = 2;
        nameSortButton.Text = "Sort by Name";
        nameSortButton.UseVisualStyleBackColor = true;
        // 
        // posSortButton
        // 
        posSortButton.Location = new System.Drawing.Point(796, 29);
        posSortButton.Name = "posSortButton";
        posSortButton.Size = new System.Drawing.Size(203, 49);
        posSortButton.TabIndex = 3;
        posSortButton.Text = "Sort by Position";
        posSortButton.UseVisualStyleBackColor = true;
        // 
        // staffGrid
        // 
        staffGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        staffGrid.Location = new System.Drawing.Point(12, 97);
        staffGrid.Name = "staffGrid";
        staffGrid.RowHeadersWidth = 82;
        staffGrid.Size = new System.Drawing.Size(1999, 697);
        staffGrid.TabIndex = 4;
        staffGrid.Text = "staffGrid";
        // 
        // addButton
        // 
        addButton.Location = new System.Drawing.Point(12, 814);
        addButton.Name = "addButton";
        addButton.Size = new System.Drawing.Size(203, 49);
        addButton.TabIndex = 5;
        addButton.Text = "Add";
        addButton.UseVisualStyleBackColor = true;
        addButton.Click += addButton_Click;
        // 
        // editButton
        // 
        editButton.Location = new System.Drawing.Point(221, 814);
        editButton.Name = "editButton";
        editButton.Size = new System.Drawing.Size(203, 49);
        editButton.TabIndex = 6;
        editButton.Text = "Edit";
        editButton.UseVisualStyleBackColor = true;
        editButton.Click += editButton_Click;
        // 
        // deleteButton
        // 
        deleteButton.Location = new System.Drawing.Point(430, 814);
        deleteButton.Name = "deleteButton";
        deleteButton.Size = new System.Drawing.Size(203, 49);
        deleteButton.TabIndex = 7;
        deleteButton.Text = "Delete";
        deleteButton.UseVisualStyleBackColor = true;
        // 
        // detailButton
        // 
        detailButton.Location = new System.Drawing.Point(639, 814);
        detailButton.Name = "detailButton";
        detailButton.Size = new System.Drawing.Size(203, 49);
        detailButton.TabIndex = 8;
        detailButton.Text = "Details";
        detailButton.UseVisualStyleBackColor = true;
        // 
        // refreshButton
        // 
        refreshButton.Location = new System.Drawing.Point(848, 814);
        refreshButton.Name = "refreshButton";
        refreshButton.Size = new System.Drawing.Size(203, 49);
        refreshButton.TabIndex = 9;
        refreshButton.Text = "Refresh";
        refreshButton.UseVisualStyleBackColor = true;
        refreshButton.Click += refreshButton_Click;
        // 
        // MainQuanLy
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(2023, 884);
        Controls.Add(refreshButton);
        Controls.Add(detailButton);
        Controls.Add(deleteButton);
        Controls.Add(editButton);
        Controls.Add(addButton);
        Controls.Add(staffGrid);
        Controls.Add(posSortButton);
        Controls.Add(nameSortButton);
        Controls.Add(searchButton);
        Controls.Add(textBox1);
        Text = "Staff Manager";
        Load += MainQuanLy_Load;
        ((System.ComponentModel.ISupportInitialize)staffGrid).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Button refreshButton;

    private System.Windows.Forms.Button addButton;
    private System.Windows.Forms.Button editButton;
    private System.Windows.Forms.Button deleteButton;
    private System.Windows.Forms.Button detailButton;

    public System.Windows.Forms.DataGridView staffGrid;

    private System.Windows.Forms.Button posSortButton;

    private System.Windows.Forms.Button nameSortButton;

    private System.Windows.Forms.Button searchButton;

    private System.Windows.Forms.TextBox textBox1;

    #endregion
}