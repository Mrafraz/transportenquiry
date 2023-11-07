using TrainReservationSystem;

namespace transportenquiry
{
    public partial class admin_login : Form
    {
        public admin_login()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void login_Click(object sender, EventArgs e)
        {
            /*u_main mn=new u_main();
            mn.Show(); */
            Trains tr = new Trains();
            tr.Show();
            this.Hide();
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
           Login_Options lo=new Login_Options();
            lo.Show();
            this.Hide();
        }
    }
}