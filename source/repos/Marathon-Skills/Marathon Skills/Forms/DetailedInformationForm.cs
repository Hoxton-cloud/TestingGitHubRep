using System.Windows.Forms;

namespace Marathon_Skills.Forms
{
    public partial class DetailedInformationForm : Form
    {
        public DetailedInformationForm()
        {
            InitializeComponent();

            Program.LoadTime(label10);
        }

        private void roundedButton5_Click(object sender, System.EventArgs e)
        {
            Program.MoveToForm<MainForm>(this);
        }

        private void roundedButton1_Click(object sender, System.EventArgs e)
        {
            Program.MoveToForm<AboutMarathonSkillsForm>(this);
        }

        private void roundedButton2_Click(object sender, System.EventArgs e)
        {
            Program.MoveToForm<HowLongMarathonForm>(this);
        }

        private void roundedButton3_Click(object sender, System.EventArgs e)
        {
            Program.MoveToForm<PreviousRaceResultsForm>(this);
        }

        private void roundedButton4_Click(object sender, System.EventArgs e)
        {
            Program.MoveToForm<CharityOrganisationsForm>(this);
        }

        private void roundedButton6_Click(object sender, System.EventArgs e)
        {
            Program.MoveToForm<BMICalculatorForm>(this);
        }

        private void roundedButton7_Click(object sender, System.EventArgs e)
        {
            Program.MoveToForm<BMRCalculatorForm>(this);
        }
    }
}
