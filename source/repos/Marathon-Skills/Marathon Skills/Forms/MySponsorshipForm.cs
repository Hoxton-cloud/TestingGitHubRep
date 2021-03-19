using System.Data.SqlClient;
using System.Windows.Forms;

namespace Marathon_Skills.Forms
{
    public partial class MySponsorshipForm : Form
    {
        private readonly int _runnerId;
        SqlConnection con = new SqlConnection(Program.ConnectionString);

        public MySponsorshipForm(int runnerId)
        {
            InitializeComponent();

            _runnerId = runnerId;

            con.Open();
            RefreshGrid($"select Charity.CharityName, Charity.CharityDescription, Charity.CharityLogo, Sponsorship.SponsorName, Sponsorship.Amount, Registration.RegistrationId, Registration.CharityId from Registration join Sponsorship on Registration.RegistrationId = Sponsorship.RegistrationId join Charity on Registration.CharityId = Charity.CharityId where Registration.RunnerId = {_runnerId}");
        }

        private void RefreshGrid(string comand)
        {
            dataGridView1.Rows.Clear();
            SqlCommand cmd = new SqlCommand(comand, con);
            using (SqlDataReader sqlReader = cmd.ExecuteReader())
            {
                label3.Text = sqlReader.GetString(0);
                int i = 0;
                for (; sqlReader.Read(); i++)
                {
                    dataGridView1.Rows.Add();

                    dataGridView1[0, i].Value = sqlReader.GetString(0);
                    dataGridView1[1, i].Value = sqlReader.GetString(1);
                    dataGridView1[2, i].Value = sqlReader.GetString(2);
                    dataGridView1[3, i].Value = sqlReader.GetString(3);
                    dataGridView1[4, i].Value = "Edit";
                }
                label4.Text = i.ToString();
            }

        }
    }

}
