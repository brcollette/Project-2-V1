/*
 * ICT 710 Assignment 2: Control Structures 
 * By: Brandon Collette
 * November, 2024
 * Calgary, Alberta
 * The general concept of this project is to code in the C# language a windows forms app to allow a student to enter the grades they 
 * received in their 3 quizes, along with their midterm and final. The app will then do the following: 
 * 1. Drop the quiz that has the lowest mark and then calculate the quiz average based on the top 2 highest quizes
 * 2. Weight the above quiz average at 30% of the overall final grade determination
 * 3. Weight the midterm mark at 30% of the overall final grade determination
 * 4. Weight the final exam mark at 40% of the overall final grade determination
 * 5. Present the user with a total averaged % grade AND present a letter grade corrosponding to that average %
 * 6. Notify the user which quiz mark was dropped
 * 7. Provide other standard features like a calculate button and a clear button
 * 
 */

namespace Project__2_V1
{
    public partial class frmGrades : Form
    {
        public frmGrades()
        {
            InitializeComponent();
        }
        // The below handler showed up here by accident when I clicked "something" (not sure what) in the forms app.
        // To avoid breaking something I will leave it here, unused 
        private void txtTotal_TextChanged(object sender, EventArgs e)
        {

        }
        // The below event handler will represent the main entry point of the code and is attached to the clicking of the calculate button
        // Our primary code should be driven by this event handler because the user clicking the calculate button is the primary feature of the app
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            /*
             * Below I am declaring several of the variables needed to perform the calculations
             * Note that all grade entry variables will be set to zero to avoid issues with the IDE 
             */

            decimal quiz1 = 0;
            decimal quiz2 = 0;
            decimal quiz3 = 0;
            decimal midterm = 0;
            decimal final = 0;
            decimal Total = 0;
            string lettergrade;
            decimal minimumquiz = 0;
            const decimal quizweight = 0.3m; // A constant variable can be chosen for the grade allocations as these are fixed ratio's
            const decimal midtermweight = 0.3m; // See above rationale 
            const decimal finalweight = 0.4m; // See above rationale for use of constant
            
            /*
            * The below code serves to "fetch" the user inputed marks and connect their entry into the form with
            * the appropriate variable that has been delared above 
            */
            
            quiz1 = Convert.ToDecimal(txtQuiz1.Text);
            quiz2 = Convert.ToDecimal(txtQuiz2.Text);
            quiz3 = Convert.ToDecimal(txtQuiz3.Text);
            midterm = Convert.ToDecimal(txtMidterm.Text);
            final = Convert.ToDecimal(txtFinal.Text);

            /*
             * The code below is to handle the average quiz grade portoion of the calculation and determining which one will be dropped
             * NOTE: In class we were shown one possible way to determine the lowest mark. I will use this second method in a seperate section 
             * below (the section where I flush to the text box the quiz grade that was dropped) BUT will use my own attempt to determine this 
             * amount below. 
             */

            decimal minQ1Q2 = Math.Min(quiz1, quiz2); // This finds the minimuim of Q1 and Q2 and assigns it to the variable "minQ1Q2"
            decimal minOverall = Math.Min(minQ1Q2, quiz3); // This finds the minimum betwee the above and quiz 3 and assigns it to the variable "minOverall"
            decimal droppedQuiz = Math.Min(minQ1Q2, minOverall); // This finds the minimum of BOTH items above which will identify the dropped quiz grade
            decimal totalQuiz = ((quiz1 + quiz2 + quiz3) - droppedQuiz) / 2; // Calculates the average Quiz grade
            txtAverageQuiz.Text = totalQuiz.ToString(); // sends the average of the best 2 quizes to the text box

            /*
             * The code below will let the student know which quiz was dropped via "flusing" the minimum quiz grade + some commentary to the textbox
             * Note also that the text box to show the lowest grade is hidden by default and some of the code below
             * will cause it to become visible when the user presses calculate
             */

            minimumquiz = Math.Min(quiz1, (Math.Min(quiz2, quiz3))); // Here I am using the code presented in class
            txtQuizDropped.Text = "You get to drop the lowest quiz in the average below - the quiz mark droped is " + minimumquiz.ToString();
            txtQuizDropped.Visible = true; 
            lblAverageQuiz.Visible = true;
            txtAverageQuiz.Visible = true;
            
            // The code below is to determine the total overall score now that the quiz aveage above has been determined. It uses the constants declared above
            decimal total = ((totalQuiz * quizweight) + (midterm * midtermweight) + (final * finalweight));
            txtTotal.Text = total.ToString();

            /*
             * The code below will serve to assign a letter grade based on the now calculated above variable called "total" 
             * Each of the "else if" statements will use the && logical statement which will ensure BOTH conditions are evaluated
             * This is needed so that certain grades have both a "floor" and "ceiling"
             */
          
            if (total >= 90)
            {
                lettergrade = "A";
                txtTotalLtr.Text = lettergrade;
            }
            else if (total >= 80 && total < 90)
            {
                lettergrade = "B";
                txtTotalLtr.Text = lettergrade;
            }
            else if (total >= 70 && total < 80)
            {
                lettergrade = "C";
                txtTotalLtr.Text = lettergrade;            
            }
            else if (total >= 60 && total < 70)
            {
                lettergrade = "D";
                txtTotalLtr.Text = lettergrade;
            }
            else
            {
                lettergrade = "F";
                txtTotalLtr.Text = lettergrade;
            }

        }
        // The code below will clear all the buttons when the user presses the clear button 
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtQuiz1.Clear();
            txtQuiz2.Clear();
            txtQuiz3.Clear();
            txtQuizDropped.Clear();
            txtAverageQuiz.Clear();
            txtMidterm.Clear();
            txtFinal.Clear();
            txtTotal.Clear();
            txtTotalLtr.Clear();
        }
    }
}
