using testWorkFinTeh.Pages;

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
            panel1.Controls.Clear();
            var print = new pPrint();
            print.Dock = DockStyle.Fill;
            panel1.Controls.Add(print);
        }

        private void butSecond_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            var workers = new pWorkers();
            workers.Dock = DockStyle.Fill;
            panel1.Controls.Add(workers);
        }
    }
}