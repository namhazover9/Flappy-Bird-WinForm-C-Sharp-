namespace Flappy_Bird_WF
{
    public partial class Form1 : Form
    {

        // Variables start here

        int pipeSpeed = 8; // default pipe speed defined with an integer
        int gravity = 10; // default gravity speed defined with an integer
        int score = 0;   // default score integer set to 0

        public Form1()
        {
            InitializeComponent();
        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            flappyBird.Top += gravity;
            pipeTop.Left -= pipeSpeed;
            pipeBottom.Left -= pipeSpeed;
            scoreText.Text = "Score: " + score;

            if (pipeBottom.Left < -150 ) 
            {
                pipeBottom.Left = 800;
                score++;
            }
            if(pipeTop.Left < -180)
            {
                pipeTop.Left = 950;
                score++;
            }

            if (flappyBird.Bounds.IntersectsWith(pipeTop.Bounds) ||
                flappyBird.Bounds.IntersectsWith(pipeBottom.Bounds) ||
                flappyBird.Bounds.IntersectsWith(ground.Bounds) ||
                flappyBird.Top < -25)
            {
                endGame();
            }

            if (score > 10)
            {
                pipeSpeed= 10;
            }
        }

        private void gamekeyisdown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space)
            {
                gravity = -10;
            }
        }

        private void gamekeyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 10;
            }
        }

        private void endGame()
        {
            gameTimer.Stop();
            scoreText.Text += " Game Over!!";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void scoreText_Click(object sender, EventArgs e)
        {

        }
    }
}