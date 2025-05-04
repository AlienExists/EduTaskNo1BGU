using System;
using System.Windows.Forms;

namespace PP1
{
    public partial class Form2 : Form
    {
        DatabaseManager dbManager;

        int regId = -1;
        int confId = -1;
        int sectId = -1;
        string first_name;
        string second_name;
        Person selectedPerson;

        public Form2()
        {
            InitializeComponent();

            dbManager = new DatabaseManager();

            dataGridView1.DataSource = dbManager.getRegistrations();
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].Visible = false;

        }


        private void participationSectionShowCB_SelectedIndexChanged(object sender, EventArgs e)
        {




        }

        private void databaseListLB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //for (int i = 0; i < ParticipantsList.Plist.Count; i++)
            //{
            //    if (!ParticipantsList.Plist[i].isAdded)
            //    {

            //        ParticipantsList.Plist[i].isAdded = true; 
            //    }

            //}
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void databaseListLB_DoubleClick(object sender, EventArgs e)
        {

        }


        private void fillDgv()
        {
            dataGridView1.DataSource = dbManager.getRegistrations();
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].Visible = false;
            //dataGridView1.Columns[7].Width;

            //MessageBox.Show(dataGridView1.Columns.ToString());
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var selectedRow = e.RowIndex;
                if (selectedRow >= 0)
                {
                    DataGridViewRow row = dataGridView1.Rows[selectedRow];


                    // Отображаем имя пользователя в текстбоксах

                    selectedPerson = new Person(row.Cells[3].Value.ToString(), row.Cells[4].Value.ToString());
                    firstName_TB.Text = selectedPerson.FirstName;
                    secondName_TB.Text = selectedPerson.SecondName;

                    // Отображаем конференции в комбо боксе
                    var selectedConf = ConferentionsList.CList.Find(c => c.id == (int)row.Cells[1].Value);
                    conferentions_CB.Text = $"{selectedConf.id} {selectedConf.name} {selectedConf.date} {(selectedConf.format == true ? "Очная" : "Онлайн")}";
                    conferentions_CB.Items.Clear();
                    for (int i = 0; i < ConferentionsList.CList.Count; i++)
                    {
                        conferentions_CB.Items.Add($"{ConferentionsList.CList[i].id} {ConferentionsList.CList[i].name} {ConferentionsList.CList[i].date} {(ConferentionsList.CList[i].format == true ? "Очная" : "Онлайн")}");
                    }

                    // Получаем айди выбранной конфы

                    confId = selectedConf.id;

                    // Получаем айди выбранной регистрации
                    regId = (int)(row.Cells[0].Value);

                    var selectedSect = SectionsList.SList.Find(c => c.id == (int)row.Cells[2].Value);

                    sectId = selectedSect.id;
                    psections_CB.Items.Clear();
                    for (int i = 0; i < SectionsList.SList.Count; i++)
                    {
                        psections_CB.Items.Add($"{SectionsList.SList[i].name}");

                    }
                    psections_CB.Text = selectedSect.name;
                }
            }
            catch (Exception ex)
            {

            }


        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            Person person = new Person(firstName_TB.Text, secondName_TB.Text);
            confId = int.Parse(conferentions_CB.Text.Split(new char[] { ' ' })[0]);
            sectId = SectionsList.SList.Find(s => s.name == psections_CB.Text).id;
            dbManager.updateReg(regId, confId, sectId, person);

            MessageBox.Show($"Изменена запись под номером {regId}");
            dataGridView1.DataSource = dbManager.getRegistrations();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (regId != -1)
            {
                dbManager.deleteReg(regId);
                MessageBox.Show("Запись удалена");
                dataGridView1.DataSource = dbManager.getRegistrations();
            }
            else
            {
                MessageBox.Show("Не выбрана запись");
            }
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            fillDgv();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridView1.Columns["Доп"].Index)
            {
                string selectedServices = dataGridView1.Rows[e.RowIndex].Cells["Доп"].Value?.ToString() ?? "";
                AdditionalServicesSelection selectionForm = new AdditionalServicesSelection(regId, selectedServices);
                if (selectionForm.ShowDialog() == DialogResult.OK)
                {
                    fillDgv();
                }

            }
        }
    }
}
