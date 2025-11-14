namespace QuanLyNhanVien;

public partial class MainQuanLy : Form {
    public MainQuanLy() {
        InitializeComponent();
    }

    public void ReloadStaff() {
        staffGrid.DataSource = typeof(List<NhanVien>);
        staffGrid.DataSource = Database.DanhsachNhanVien;
    }
    
    private void MainQuanLy_Load(object sender, EventArgs e) {
        staffGrid.DataSource = Database.DanhsachNhanVien;
    }

    private void refreshButton_Click(object sender, EventArgs e) {
        ReloadStaff();
    }

    private void addButton_Click(object sender, EventArgs e) {
        AddOrEditForm addForm = new AddOrEditForm(false, this);
        addForm.ShowDialog();
    }

    private void editButton_Click(object sender, EventArgs e) {
        AddOrEditForm editForm = new AddOrEditForm(true, this);
        editForm.ShowDialog();
    }
}