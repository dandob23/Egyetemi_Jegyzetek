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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        RestClient restClient = new RestClient("http://localhost/sop/server/users.php");

        void RefreshUserData()
        {
            RestRequest request = new RestRequest();
            try
            {
                RestResponse response = restClient.Get(request);
                MessageBox.Show(response.StatusCode.ToString());
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
    }
}
