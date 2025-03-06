namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        float number, res, n1;
        string action="";
        //plus
        private void button2_Click(object sender, EventArgs e)
        {
            n1 = number;
            textBox2.Text = "";
            action = "add";
        }
        //minus
        private void button3_Click(object sender, EventArgs e)
        {
            
            n1 = number;
            textBox2.Text = "";
            action = "subtr";
        }
     
        //division
        private void button4_Click(object sender, EventArgs e)
        {
           
            n1 = number;
            textBox2.Text = "";
            action = "div";
        }
        //multi
        private void button5_Click(object sender, EventArgs e)
        {
          
            n1 = number;
            textBox2.Text = "";
            action = "multi";
        }
        //calc
        private void button1_Click(object sender, EventArgs e)
        {
            if (action == "add")
            {
                res = n1 + number;
                textBox2.Text = (res).ToString();
            }
            else if (action == "multi")
            {
                res = n1 * number;
                textBox2.Text = (res).ToString();
            }
            else if (action == "div")
            {
                res = n1 / number;
                textBox2.Text = (res).ToString();
            }
            else if (action == "subtr")
            {
                res = n1 - number;
                textBox2.Text = (res).ToString();
            }

        }
        //refresh
        private void button7_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            
        }
        //text
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox2.Text))
            {


                number = float.Parse(textBox2.Text);
            }

        }
    }
}
