using Form3;
using static System.Net.Mime.MediaTypeNames;

namespace maxx
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            // 創建 Form3 的實例並顯示它
            Form3 form3Instance = new Form3();
            form3Instance.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            // 創建 Form3 的實例並顯示它
            Form3 form3Instance = new Form3();
            form3Instance.Show();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            // Navigate to Window Page 3
            WindowPage3 windowPage3 = new WindowPage3();
            windowPage3.Show();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            // Navigate to Window Page 4
            WindowPage4 windowPage4 = new WindowPage4();
            windowPage4.Show();
        }
    }
}
