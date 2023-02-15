namespace NrPrim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            int result = 0;
            bool isNumber = Int32.TryParse(numberTextBox.Text, out result);

            if (isNumber)
            {
                bool isPrime = true;

                if (result == 0 || result == 1) isPrime = false;
                for (int i = 2; i <= result / 2; i++)
                    if (result % i == 0)
                        isPrime = false;

                if (isPrime)
                {
                    this.BackColor = Color.Green;
                } else
                {
                    this.BackColor = Color.Red;
                }
            }
            else
            {
                this.BackColor = Color.Yellow;
                MessageBox.Show("Textul introdus nu este un numar!");
            }

            numberTextBox.Text = "";
        }
    }
}