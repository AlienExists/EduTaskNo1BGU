using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace PP1
{
    public partial class AdditionalServicesSelection : Form
    {
        public int regId;
        public string selectedServices;
        DatabaseManager dbManager = new DatabaseManager();
        public AdditionalServicesSelection(int regId, string selectedServices)
        {

            this.regId = regId;
            InitializeComponent();
            getSelectedServices(selectedServices);
        }

        public void getSelectedServices(string selectedServices)
        {
            var selectedServicesList = selectedServices.Split(new char[] { ',' }).Select(s => s.Trim()).ToList();

            var allServices = dbManager.getAdditionalServices();

            foreach (var service in allServices)
            {
                additionalServicesChBL.Items.Add(service.name, selectedServicesList.Contains(service.name));
            }
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            List<string> aservices = new List<string>();
            foreach (string item in additionalServicesChBL.CheckedItems)
            {
                aservices.Add(item);
            }
            List<int> aservicesid = dbManager.searchCheckedServices(aservices);

            dbManager.updateAdditionalServices(this.regId, aservicesid);
            this.DialogResult = DialogResult.OK;
            this.Close();

        }
    }
}
