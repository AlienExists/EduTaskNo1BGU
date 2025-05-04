using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace PP1
{
    public partial class Form1 : Form
    {
        bool participationsFormIsActive = false;
        DatabaseManager dbManager;
        Form2 f2 = new Form2();
        public bool registrationIsActive = true;
        public Form1()
        {
            InitializeComponent();
            dbManager = new DatabaseManager();
            ConferentionsList.CList = dbManager.getConferentions();
            ServicesList.SList = dbManager.getAdditionalServices();
            SectionsList.SList = dbManager.getSections();
            ParticipantsList.Plist = dbManager.getPersons();

            for (int i = 0; i < ConferentionsList.CList.Count; i++)
            {
                ConferentionsCB.Items.Add($"{ConferentionsList.CList[i].id} {ConferentionsList.CList[i].name} {ConferentionsList.CList[i].date} {(ConferentionsList.CList[i].format == true ? "Очная" : "Онлайн")}");
            }

            for (int i = 0; i < ServicesList.SList.Count; i++)
            {
                additionalServicesChLB.Items.Add($"{ServicesList.SList[i].name}");
            }

            for (int i = 0; i < SectionsList.SList.Count; i++)
            {
                SectionsCB.Items.Add($"{SectionsList.SList[i].name}");

            }

            for (int i = 0; i < ParticipantsList.Plist.Count; i++)
            {
                ExistingPersonsCB.Items.Add($"{ParticipantsList.Plist[i].FirstName} {ParticipantsList.Plist[i].SecondName}");
            }

        }




        private void registrationBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Person person;
                if (registrationIsActive)
                {
                    person = new Person(FirstNameField.Text, SecondNameField.Text);
                }
                else
                {
                    person = new Person(ExistingPersonsCB.Text.Split(new char[] { ' ' })[0], ExistingPersonsCB.Text.Split(new char[] { ' ' })[1]);
                }
                int personid = dbManager.addNewPerson(person);
                int conferentionid = int.Parse(ConferentionsCB.SelectedItem.ToString().Substring(0, ConferentionsCB.SelectedItem.ToString().IndexOf(' ')));
                int? sectionid = dbManager.sectionSearch(SectionsCB.SelectedItem.ToString());
                List<string> aservices = new List<string>();
                foreach (string item in additionalServicesChLB.CheckedItems)
                {
                    aservices.Add(item);
                }
                List<int> aservicesid = dbManager.searchCheckedServices(aservices);


                dbManager.createRegistration(personid, conferentionid, sectionid, aservicesid);
                MessageBox.Show(personid.ToString());
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //try
            //{
            //    string fio = FIOField.Text;
            //    string pformat = "";
            //    if(onlineParticipationRB.Checked)
            //    {
            //        pformat = "Онлайн";
            //    }
            //    else if (offlineParticipationRB.Checked)
            //    {
            //        pformat = "Оффлайн";
            //    }
            //    else 
            //    {
            //        MessageBox.Show("Не выбран формат участия");
            //    }

            //    string psection = participationSectionCB.SelectedItem.ToString();
            //    List<string> aservices = new List<string>();
            //    foreach(string item in additionalServicesChLB.CheckedItems)
            //    {
            //        aservices.Add(item);
            //    }
            //    Participant participant = new Participant(fio, pformat, psection, aservices);
            //    ParticipantsList.Plist.Add(participant);
            //    MessageBox.Show("Участник зарегистрирован");

            //}
            //catch
            //{
            //    MessageBox.Show("Заполните все поля");
            //}

        }



        private void toParticipationsBtn_Click(object sender, EventArgs e)
        {
            f2.ShowDialog();

            //if (!participationsFormIsActive)
            //{

            //    //f2.Location = new Point(this.Location.X + this.Width, this.Location.Y);
            //    //participationsFormIsActive = true;
            //    //toParticipationsBtn.Text = "Список участников <<";
            //}
            //else
            //{

            //    f2.Hide();
            //    participationsFormIsActive = false;
            //    toParticipationsBtn.Text = "Список участников >>";
            //}
        }
        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private void toParticipationsBtn_MouseEnter(object sender, EventArgs e)
        {
            toParticipationsBtn.BackColor = Color.FromArgb(49, 68, 102);
        }

        private void toParticipationsBtn_MouseLeave(object sender, EventArgs e)
        {
            toParticipationsBtn.BackColor = Color.FromArgb(41, 57, 85);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void RegistratePersonL_Click(object sender, EventArgs e)
        {
            registrationIsActive = true;
            RegistratePersonL.BackColor = Color.FromArgb(41, 57, 85);
            RegistratePersonL.ForeColor = Color.White;
            RegistratePersonL.Font = new Font(RegistratePersonL.Font, FontStyle.Bold);

            ExistingPersonL.BackColor = Color.FromArgb(214, 219, 233);
            ExistingPersonL.ForeColor = Color.Black;
            ExistingPersonL.Font = new Font(RegistratePersonL.Font, FontStyle.Regular);

            FirstNameField.Visible = true;
            SecondNameField.Visible = true;

            ExistingPersonsCB.Visible = false;
        }

        private void ExistingPersonL_Click(object sender, EventArgs e)
        {
            registrationIsActive = false;
            ExistingPersonL.BackColor = Color.FromArgb(41, 57, 85);
            ExistingPersonL.ForeColor = Color.White;
            ExistingPersonL.Font = new Font(RegistratePersonL.Font, FontStyle.Bold);

            RegistratePersonL.BackColor = Color.FromArgb(214, 219, 233);
            RegistratePersonL.ForeColor = Color.Black;
            RegistratePersonL.Font = new Font(RegistratePersonL.Font, FontStyle.Regular);

            FirstNameField.Visible = false;
            SecondNameField.Visible = false;

            ExistingPersonsCB.Visible = true;

        }
    }



}
