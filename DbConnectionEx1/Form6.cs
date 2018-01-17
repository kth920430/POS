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

namespace DbConnectionEx1
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            string query = "select * from Friends for xml auto,elements, binary base64";
            using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["compactDb"].ConnectionString))
            {
                using (var cmd = new SqlCommand(query, con))
                {
                    con.Open();
                    var reader = cmd.ExecuteXmlReader();
                    while (reader.Read())
                    {

                    }
                }
            }
        }
    }
}
