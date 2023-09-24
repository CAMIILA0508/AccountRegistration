namespace Account_Registration {
    public partial class FrmRegistration : Form {
        public FrmRegistration() {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e) {
            StudentInfoClass.StudentNo = long.Parse(tbstnum.Text);
            StudentInfoClass.Program = cbprogram.Text;
            StudentInfoClass.LastName = tblname.Text;
            StudentInfoClass.FirstName = tbfname.Text;
            StudentInfoClass.MiddleName = tbmname.Text;
            StudentInfoClass.Age = long.Parse(tbage.Text);
            StudentInfoClass.ContactNo = long.Parse(tbcontact.Text);
            StudentInfoClass.Address = rtbaddress.Text;
            FrmConfirm frc = new FrmConfirm();


            DialogResult res = new DialogResult();
            res = frc.ShowDialog();
            if (res == DialogResult.OK) {
                cbprogram.SelectedIndex = -1;
                tbfname.Text = "";
                tblname.Text = "";
                tbmname.Text = "";
                rtbaddress.Text = "";
                tbage.Text = "";
                tbstnum.Text = "";
                tbcontact.Text = "";
            }
        }
    }
}