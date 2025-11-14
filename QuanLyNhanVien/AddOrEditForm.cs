namespace QuanLyNhanVien;

public partial class AddOrEditForm : Form {
    private bool isEdit;
    private MainQuanLy mainForm;

    public AddOrEditForm(bool isEdit, MainQuanLy mainForm) {
        this.isEdit = isEdit;
        this.mainForm = mainForm;
        InitializeComponent();
    }

    private void AddOrEditForm_Load(object sender, EventArgs e) {
        if (isEdit && mainForm.staffGrid.SelectedRows.Count == 1) {
            Text = "Edit Staff";
            DataGridViewRow selectedRow = mainForm.staffGrid.SelectedRows[0];
            NhanVien nv = selectedRow.DataBoundItem as NhanVien;
            dateTimePicker1.Value = nv.Birthday;
            specialBox.Text = nv.ChuyenMon;
            nameBox.Text = nv.FullName;
            genderBox.Text = nv.Gender;
            idBox.Text = nv.ID;
            backgroundDescBox.Text = nv.Motahoancanh;
            salaryBox.Maximum = decimal.MaxValue;
            salaryBox.Value = nv.Salary;
            phoneBox.Text = nv.SDT;
            statusCheckbox.Checked = nv.Status;
            mainForm.ReloadStaff();
        } else Text = "Add Staff";
    }

    private void button2_Click_1(object sender, EventArgs e) {
        Close();
    }

    private void Save_Click(object sender, EventArgs e) {
        if (!isEdit) {
            NhanVien nv = new NhanVien();
            nv.Birthday = dateTimePicker1.Value;
            nv.ChucVu = (ChucVu)posBox.SelectedItem;
            nv.ChuyenMon = specialBox.Text;
            nv.FullName = nameBox.Text;
            nv.Gender = genderBox.Text;
            nv.ID = idBox.Text;
            nv.Motahoancanh = backgroundDescBox.Text;
            nv.Salary = salaryBox.Value;
            nv.SDT = phoneBox.Text;
            nv.Status = statusCheckbox.Checked;
            Database.DanhsachNhanVien.Add(nv);
            mainForm.ReloadStaff();
            Close();
        } else {
            if (mainForm.staffGrid.SelectedRows.Count == 1) {
                DataGridViewRow selectedRow = mainForm.staffGrid.SelectedRows[0];
                NhanVien nv = selectedRow.DataBoundItem as NhanVien;
                nv.Birthday = dateTimePicker1.Value;
                nv.ChucVu = (ChucVu)posBox.SelectedItem;
                nv.ChuyenMon = specialBox.Text;
                nv.FullName = nameBox.Text;
                nv.Gender = genderBox.Text;
                nv.ID = idBox.Text;
                nv.Motahoancanh = backgroundDescBox.Text;
                nv.Salary = salaryBox.Value;
                nv.SDT = phoneBox.Text;
                nv.Status = statusCheckbox.Checked;
                mainForm.ReloadStaff();
                Close();
            }
        }
    }
}