using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using testWorkFinTeh.Methods;
using testWorkFinTeh.Models;
using testWorkFinTeh.Startup;

namespace testWorkFinTeh.Forms
{
    public partial class fAddWorker : Form
    {
        Guid? WorkerID;
        List<IdGuidNameStruct> roleList;
        List<IdGuidNameStruct> departList;
        public fAddWorker(Guid? WorkerID = null)
        {
            InitializeComponent();
            this.WorkerID = WorkerID;

            roleList = StaticParams.getRole();
            comboRole.Items.Clear();
            comboRole.Items.AddRange(roleList.Select(a => a.Name).ToArray());

            departList = StaticParams.getDepart();
            comboDepart.Items.Clear();
            comboDepart.Items.AddRange(departList.Select(a => a.Name).ToArray());
        }

        private void fAddWorker_Load(object sender, EventArgs e)
        {
            if (WorkerID == null)
                return;

            loadTable();
        }

        private void loadTable()
        {
            var loader = new GetData();
            var worker = loader.GetWorker(WorkerID.Value);
            textFirstName.Text = worker.Name;
            textMidName.Text = worker.MiddleName;
            textLastName.Text = worker.LastName;

            comboRole.SelectedItem = roleList.First(a => a.ID == worker.RoleID).Name;
            comboDepart.SelectedItem = departList.First(a => a.ID == worker.DepartID).Name;
        }

        private void butSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textFirstName.Text))
            {
                MessageBox.Show("Вы не ввели фамилию рабочего!");
                return;
            }
            else if (string.IsNullOrWhiteSpace(textMidName.Text))
            {
                MessageBox.Show("Вы не ввели имя рабочего!");
                return;
            }
            else if (comboRole.SelectedIndex < 0)
            {
                MessageBox.Show("Вы не выбрали должность для рабочего!");
                return;
            }
            else if (comboDepart.SelectedIndex < 0)
            {
                MessageBox.Show("Вы не выбрали профессию рабочего!");
                return;
            }

            var editor = new WorkerEdit();
            editor.EditWorker(new WorkerStruct()
            {
                ID = Guid.Empty,
                Name = textFirstName.Text,
                MiddleName = textMidName.Text,
                LastName = string.IsNullOrWhiteSpace(textLastName.Text) ? null : textLastName.Text,
                RoleID = roleList[comboRole.SelectedIndex].ID,
                DepartID = departList[comboDepart.SelectedIndex].ID,
            });

            this.Close();
        }

        private void comboRole_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void comboDepart_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
