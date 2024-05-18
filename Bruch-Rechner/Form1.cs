using Bruchrechner;


namespace Bruch_Rechner
{
    public partial class Form1 : Form
    {
        FractionCalculator calc = new FractionCalculator();
        Fraction[] bruch = new Fraction[2]; // crates an object for the two fractions
        Fraction result = new Fraction(); // crates an object to store the result
        string oper = ""; // saves the operator


        public Form1()
        {
            InitializeComponent();
        }

        private void btn_plus_Click(object sender, EventArgs e)
        {
            oper = "+"; // sets the operator to know which operation to use
            tB_Oper.Text = oper; // outputs the operator in a textBox 
        }

        private void btn_minus_Click(object sender, EventArgs e)
        {
            oper = "-";
            tB_Oper.Text = oper;
        }

        private void btn_mult_Click(object sender, EventArgs e)
        {
            oper = "*";
            tB_Oper.Text = oper;
        }

        private void btn_div_Click(object sender, EventArgs e)
        {
            oper = "/";
            tB_Oper.Text = oper;
        }

        private void btn_power_Click(object sender, EventArgs e)
        {
            // Gets the fraction
            string[] trimmedNums = tB_Bruch1.Text.Split('/');
            int[] bruch1 = new int[] { Convert.ToInt32(trimmedNums[0]), Convert.ToInt32(trimmedNums[1]) };
            bruch[0] = new Fraction(bruch1[0], bruch1[1]);
            //Gets the exponent
            int exp = Convert.ToInt32(tB_Bruch2.Text);

            
            oper = "^";
            tB_Oper.Text = oper;
            tB_Result.Text = calc.Power(bruch[0], exp).ToString(); // cals the Power funktion from the FractionCalculator object and outputs the result in the textBox tB_Result
        }

        private void btn_sqrt_Click(object sender, EventArgs e)
        {
            // Gets the fraction
            string[] trimmedNums = tB_Bruch1.Text.Split('/');
            int[] bruch1 = new int[] { Convert.ToInt32(trimmedNums[0]), Convert.ToInt32(trimmedNums[1]) };
            bruch[0] = new Fraction(bruch1[0], bruch1[1]);


            oper = "√";
            tB_Bruch1.Text = "√" + tB_Bruch1.Text;
            tB_Result.Text = calc.SquareRoot(bruch[0]).ToString(); // cals the SquareRoot funktion from the FractionCalculator object  and outputs the result in the textBox tB_Result
        }

        private void btn_equals_Click(object sender, EventArgs e)
        {
            //splits the fraction line from both fractions
            string[] trimmedNums1 = tB_Bruch1.Text.Split('/');
            string[] trimmedNums2 = tB_Bruch2.Text.Split('/');

            //converts the splited string into an int 
            int[] bruch1 = new int[] { Convert.ToInt32(trimmedNums1[0]), Convert.ToInt32(trimmedNums1[1]) };
            int[] bruch2 = new int[] { Convert.ToInt32(trimmedNums2[0]), Convert.ToInt32(trimmedNums2[1]) };

            //initializez the bruch objects using the class constructor
            bruch[0] = new Fraction(bruch1[0], bruch1[1]);
            bruch[1] = new Fraction(bruch2[0], bruch2[1]);

            //checks which operations to use with the help of the oper variable
            switch (oper)
            {
                case "+":
                    result = calc.Add(bruch[0], bruch[1]); // Calls funktion Add and outputs the result 
                    break;
                case "-":
                    result = calc.Sub(bruch[0], bruch[1]);// Calls funktion Sub and outputs the result 
                    break;
                case "*":
                    result = calc.Mult(bruch[0], bruch[1]);// Calls funktion Mult and outputs the result 
                    break;
                case "/":
                    result = calc.Div(bruch[0], bruch[1]);// Calls funktion Div and outputs the result 
                    break;
            }

            tB_Result.Text = result.ToString(); // uses the overriden ToString() method to return the fraction as a string
        }

        
    }
}
