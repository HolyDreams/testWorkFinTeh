using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using testWorkFinTeh.Forms;
using testWorkFinTeh.Methods;
using testWorkFinTeh.Models;

namespace testWorkFinTeh.Pages
{
    public partial class pWorkers : UserControl
    {
        List<WorkerStruct> mainList;
        public pWorkers()
        {
            InitializeComponent();
        }

        private void pWorkers_Load(object sender, EventArgs e)
        {
            comboDate.Items.Clear();
            comboDate.Items.AddRange(new string[] { "Все", "Январь", "Февраль", "Март", "Апрель", "Май", "Июнь", "Июль", "Август", "Сентябрь", "Октябрь", "Ноябрь", "Декабрь" });
            comboDate.SelectedIndex = 0;
        }

        private void butAdd_Click(object sender, EventArgs e)
        {
            var addWorker = new fAddWorker();
            addWorker.StartPosition = FormStartPosition.CenterParent;
            addWorker.ShowDialog(this);

            loadTable();
        }

        private void butDel_Click(object sender, EventArgs e)
        {
            var row = (WorkerStruct)dataGridView1.CurrentRow.DataBoundItem;
            if (row == null)
                return;

            var question = MessageBox.Show(string.Join(" ", "Уверены что хотите удалить", row.Name, row.MiddleName, "?"), "Подтверждение удаления", MessageBoxButtons.YesNo);
            if (question == DialogResult.Yes)
            {
                var editor = new WorkerEdit();
                editor.DelWorker(row.ID);

                loadTable();
            }
        }

        private void textSearch_TextChanged(object sender, EventArgs e)
        {
            var search = textSearch.Text.ToLower();
            var searchList = mainList.Where(a => a.Name.ToLower().Contains(search) || a.MiddleName.ToLower().Contains(search) || a.LastName.ToLower().Contains(search)).ToList();

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = searchList;

            printTable();
        }

        private void comboDate_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (mainList == null)
                loadTable();

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = comboDate.SelectedIndex == 0 ? mainList : mainList.Where(a => a.VacationStart.HasValue && a.VacationStart.Value.Month <= comboDate.SelectedIndex &&
                                                                                                     (!a.VacationEnd.HasValue || (a.VacationEnd.HasValue && a.VacationEnd.Value.Month >= comboDate.SelectedIndex))).ToList();
            printTable();
        }

        private void butEdit_Click(object sender, EventArgs e)
        {
            var row = (WorkerStruct)dataGridView1.CurrentRow.DataBoundItem;
            if (row == null)
                return;

            var editWorker = new fAddWorker(row.ID);
            editWorker.StartPosition = FormStartPosition.CenterParent;
            editWorker.ShowDialog(this);

            loadTable();
        }

        private void butRefresh_Click(object sender, EventArgs e)
        {
            loadTable();
        }

        private void loadTable()
        {
            var loader = new GetData();
            mainList = loader.GetWorkers();

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = mainList;

            printTable();
        }
        private void printTable()
        {
            dataGridView1.Columns["ID"].Visible = false;
            dataGridView1.Columns["RoleID"].Visible = false;
            dataGridView1.Columns["DepartID"].Visible = false;

            dataGridView1.Columns["Name"].HeaderText = "Фамилия";
            dataGridView1.Columns["Name"].DisplayIndex = 0;

            dataGridView1.Columns["MiddleName"].HeaderText = "Имя";
            dataGridView1.Columns["MiddleName"].DisplayIndex = 1;

            dataGridView1.Columns["LastName"].HeaderText = "Отчество";
            dataGridView1.Columns["LastName"].DisplayIndex = 2;

            dataGridView1.Columns["RoleName"].HeaderText = "Должность";
            dataGridView1.Columns["RoleName"].DisplayIndex = 3;

            dataGridView1.Columns["DepartName"].HeaderText = "Отдел";
            dataGridView1.Columns["DepartName"].DisplayIndex = 4;

            dataGridView1.Columns["VacationStart"].HeaderText = "Дата ухода в отпуск";
            dataGridView1.Columns["VacationStart"].DisplayIndex = 5;

            dataGridView1.Columns["VacationEnd"].HeaderText = "Дата прихода с отпуска";
            dataGridView1.Columns["VacationEnd"].DisplayIndex = 6;
        }
    }
}
