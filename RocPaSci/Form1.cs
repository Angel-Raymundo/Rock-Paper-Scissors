namespace RocPaSci
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_play_Click(object sender, EventArgs e)
        {
            Player user=new User();
            Player pc= new Pc();

            int selectedOption = cbx_options.SelectedIndex;

            if (selectedOption == 0) { user.doPlay(new Rock());
                }
            if (selectedOption == 1) { user.doPlay(new Paper());
                }
            if (selectedOption == 2) { user.doPlay(new Scissors());
               }

            
            string[] options = { "Rock", "Paper", "Scissors" };
            Random random = new Random();
            int randomOption = random.Next(options.Length);

            if (randomOption == 0) { pc.doPlay(new Rock());
               }
            if (randomOption == 1) { pc.doPlay(new Paper());
                }
            if (randomOption == 2) { pc.doPlay(new Scissors());
               }

            pbx_user.Image = user.Play.setImage();
            pbx_pc.Image = pc.Play.setImage();

            lbl_answer.Text = CompareThrows(user.Play.doThrow(), pc.Play.doThrow());
            lbl_user.Text = options[selectedOption];
            lbl_pc.Text = options[randomOption];
        }

        private string CompareThrows(string userThrow, string pcThrow)
        {
            if (userThrow == pcThrow)
            { 
                return "It's a draw";
            }

            if ((userThrow == "Rock" && pcThrow == "Scissors") ||
                (userThrow == "Paper" && pcThrow == "Rock") ||
                (userThrow == "Scissors" && pcThrow == "Paper"))
            {
                return "User Wins :)";
            }
            else
            {
                return "PC Wins :(";
            }
        }
    }
}
