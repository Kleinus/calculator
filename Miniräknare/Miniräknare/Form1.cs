namespace Miniräknare
{
    public partial class Form1 : Form
    {
        Double resultValue = 0;
        String oprationPerformed = "";
        bool isOperationPerformed = false;

        public Form1()
        {
            InitializeComponent(); 
        }
        // alla nummer
        private void button_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "0") || (isOperationPerformed))
                textBox1.Clear();
            isOperationPerformed = false;
            Button button = (Button)sender; 
            textBox1.Text = textBox1.Text + button.Text;
        }
        //gånger, minus och de
        private void operator_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (resultValue != 0)
            {
                button15.PerformClick();
                oprationPerformed = button.Text;
                resultValue = Double.Parse(textBox1.Text);
                labelCurrentOperation.Text = resultValue + " " + oprationPerformed;
                isOperationPerformed = true;

            }
            else
            {
                oprationPerformed = button.Text;
                resultValue = Double.Parse(textBox1.Text);
                labelCurrentOperation.Text = resultValue + " " + oprationPerformed;
                isOperationPerformed = true;
            }
        }
        //All clear
        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0"; 
        }
        //clear
        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            resultValue = 0; 
        }

        private void button15_Click(object sender, EventArgs e)
        {
            switch(oprationPerformed)
            {
                case "+":
                    textBox1.Text = (resultValue + Double.Parse(textBox1.Text)).ToString();
                    break;
                case "-":
                    textBox1.Text = (resultValue - Double.Parse(textBox1.Text)).ToString();
                    break;
                case "*":
                    textBox1.Text = (resultValue * Double.Parse(textBox1.Text)).ToString();
                    break;
                case "/":
                    textBox1.Text = (resultValue / Double.Parse(textBox1.Text)).ToString();
                    break;
                default:
                    break; 
            }
        }
    }
}