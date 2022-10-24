using System.Text;
using System.Windows.Forms;
namespace fappybird_game
{
    
    public partial class fappygame : Form
    {
        
        int gravity = 5;
        int pipespeed = -8;
        int scoreb = 0;
        public fappygame()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
        private void downkey(object sender, KeyEventArgs e)
        {
            
            
        }
        private void upkey(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = -15;
            }
        }

        private void gametimer_Tick(object sender, EventArgs e)
        {
            bird.Top += gravity;
            pipedown.Left += pipespeed;
            pipeup.Left += pipespeed;
            score.Text = "Score:" + scoreb;
            

            if(pipedown.Left <-50)
            {
                pipedown.Left = 900;
                scoreb++;

            }
            if(pipeup.Left <-150)
            {
                pipeup.Left = 700;
                scoreb++;
            }
            if(bird.Bounds.IntersectsWith(pipeup.Bounds) || bird.Bounds.IntersectsWith(pipedown.Bounds) 
                || bird.Bounds.IntersectsWith(ground.Bounds))
            {
                EndGame();

            } 
           
            


            

        }
        private void EndGame()
        {
            gametimer.Stop();
            score.Text += " Game over..!";
        }

        private void birdIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = -5;
            }

        }

        private void birdIsDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space)
            {
                gravity = 5;
            }
        }

        private void score_Click(object sender, EventArgs e)
        {

        }
    }
}