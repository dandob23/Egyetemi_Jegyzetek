using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1122
{
    public partial class UserHandler : Form
    {
        public UserHandler(RestClient restClient, Main mainForm, RequestType requestType)
        {
            InitializeComponent();
            this.restClient = restClient;
            this.mainForm = mainForm;
            this.requestType = requestType;
            SetFormElements();
        }

        void SetFormElements()
        {
            switch (requestType)
            {
                case RequestType.POST:
                    idLabel.Visible = false;
                    idBox.Visible = false;
                    userHandlerButton.Text = "ADD";
                    break;
                case RequestType.PUT:
                    userHandlerButton.Text = "UPDATE";
                    break;
                default:
                    break;
            }
        }

        RestClient restClient;
        Main mainForm;
        RequestType requestType;

        private void idBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void usernameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void passwordBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void userHandlerButton_Click(object sender, EventArgs e)
        {

        }

        void UpdateUser()
        {
            RestRequest request = new RestRequest();

            request.AddBody(new
            {
id = idBox.Text, username = usernameBox.Text, password = passwordBox.Text });

            try
            {
                RestResponse response = restClient.Put(request);
                if (response.StatusCode != System.Net.HttpStatusCode.OK)
                {
                    MessageBox.Show(response.StatusDescription);
                }
                else
                {
                    mainForm.RefreshUserData();
                    mainForm.ManageButton(true);
                    this.Close();
                }
            }
            catch (Exception e)
            {

                throw;
            }
        }
    }
}
