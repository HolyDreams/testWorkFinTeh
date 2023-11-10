namespace testWorkFinTeh
{
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }

        private void butFirst_Click(object sender, EventArgs e)
        {
            var print = new pPrint();
            print.Dock = DockStyle.Fill;
            panel1.Controls.Add(print);
        }
    }
}