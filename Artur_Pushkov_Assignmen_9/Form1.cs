namespace Artur_Pushkov_Assignmen_9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String textBoxString = textBox1.Text;
            int[] chars = new int[256];
            int textBoxStringLength = textBoxString.Length;
            for (int i = 0; i < textBoxStringLength; i++)
            {
                chars[textBoxString[i]]++;
            }


            int max = -1;
            char char = ' ';
            for (int i = 0; i < textBoxStringLength; i++)
            {
                if (max < chars[textBoxString[i]])
                {
                    max = chars[textBoxString[i]];
                    char = textBoxString[i];
                }
            }
            MessageBox.Show("Most frequent symbol is: " + char);
        }
    }
}