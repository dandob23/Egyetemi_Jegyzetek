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
using RestSharp;

namespace _1122
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            InitializeUsersDataGridView();
        }

        RestClient restClient = new RestClient("http://localhost/sop/server/users.php");

        void InitializeUsersDataGridView()
        {
            usersData.Columns.Add("id", "ID");
            usersData.Columns.Add("username", "Username");
            usersData.Columns.Add("password", "Password");
        }

        void RefreshUserData()
        {
            RestRequest request = new RestRequest();
            try
            {
                RestResponse response = restClient.Get(request);
                if (response.StatusCode != System.Net.HttpStatusCode.OK)
                {
                    MessageBox.Show(response.StatusDescription);
                }
                else
                {
                    Response res = restClient.Deserialize<Response>(response).Data;
                    userData.Rows.Clear();
                    foreach (var user in res.Users)
                    {
                        usersData.Rows.Add(user.ID, user.username, user.password);
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            
        }

        public void ManageButton()
        {

        }

    }
}
