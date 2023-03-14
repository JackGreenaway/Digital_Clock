namespace Digital_Clock
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime time_now = DateTime.UtcNow;

            string selected_time = comboBox1.SelectedItem.ToString();
            if (selected_time == "Pacific Standard Time" || selected_time == "Central Standard Time" || selected_time == "Eastern Standard Time")
            {
                TimeZoneInfo zone = TimeZoneInfo.FindSystemTimeZoneById(selected_time);
                DateTime converted_time = TimeZoneInfo.ConvertTimeFromUtc(time_now, zone);
                label2.Text = converted_time.ToString();
                update_time.Start();
            }
            else
            {
                label2.Text = time_now.ToString();
                update_time.Start();
            }
        }
    }
}