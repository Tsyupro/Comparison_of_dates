namespace Comparison_of_dates
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime dateTime = new DateTime((int)numericUpDown4.Value ,(int)numericUpDown5.Value ,(int)numericUpDown6.Value);
                DateTime dateTime1 = new DateTime((int)numericUpDown1.Value, (int)numericUpDown2.Value, (int)numericUpDown3.Value);
                TimeSpan time = dateTime - dateTime1;   
                MessageBox.Show($"{dateTime.ToShortDateString()} - {dateTime1.ToShortDateString()} = Days {time.Days}");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}