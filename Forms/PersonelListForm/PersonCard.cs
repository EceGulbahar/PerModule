using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PerModule.Forms.PersonelListForm
{
    public partial class PersonCard : Form
    {
        SqlConnection baglan = new SqlConnection(ConfigurationManager.ConnectionStrings["PerModule.Properties.Settings.PerModuleCS"].ConnectionString);
        public PersonCard()
        {
            InitializeComponent();
            //usercontrol yapıcaz.
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        

        private void PersonCard_Load(object sender, EventArgs e)
        {

        }
    }
}
