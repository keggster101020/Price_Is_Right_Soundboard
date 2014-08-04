//using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;



namespace The_Price_Is_Wrong
{
    public partial class The_Price_is_Right : MetroForm
    {

        public The_Price_is_Right()
        {
            InitializeComponent();
            Sounds.Select();

        }


        private void metroButton1_Click(object sender, EventArgs e)
        {
            playSound("Open");
        }

        private void Winner_Click(object sender, EventArgs e)
        {
            playSound("Winner");
        }

        private void Loser_Click(object sender, EventArgs e)
        {
            playSound("Loser");
        }

        private void Flip_Click(object sender, EventArgs e)
        {
            
            //make sure one of the buttons is checked
            if (!(Heads.Checked || Tails.Checked))
            {
                metroMessage("Select Heads or Tails");

            }
            
            else
            {
                Random rand = new Random();
                int result = -1;

                if (ForceHeads.Checked && ForceTails.Checked)
                {
                    metroMessage("Only select force heads/tails, not both");
                }
                //check if you're forcing a heads result
                else if (ForceHeads.Checked)
                {
                    result = 1;
                }

                else if (ForceTails.Checked)
                {
                    result = 0;
                }
                
                else
                {
                    result = rand.Next(0, 2);
                }

                //if 1 is pulled, winner is heads
                if (result == 1)
                {
                    OutcomeResult.Text = "Heads";
                    OutcomeResult.Show();

                    //if the guess was heads and heads was drawn, play the winning sound, else play loser sound
                    if (Heads.Checked)
                    {
                        playSound("Winner");
                    }
                    else
                    {
                        playSound("Loser");
                    }
                }
                else if (result == 0)
                {
                    OutcomeResult.Text = "Tails";
                    OutcomeResult.Show();
                    if (Tails.Checked)
                    {
                        playSound("Winner");
                    }
                    else
                    {
                        playSound("Loser");
                    }
                }
                else
                {
                    OutcomeResult.Text = "Try again";
                    OutcomeResult.Show();
                }
            }

            
        }

        /*******************************************************************
         Play the sound of either winning, losing, or the opening theme song
         ********************************************************************/
        public void playSound(String sound)
        {
            if (sound.Equals("Winner"))
            {
                try
                {
                    SoundPlayer player = new SoundPlayer(The_Price_Is_Wrong.Properties.Resources.Winner);
                    player.Play();
                }
                catch (Exception exc)
                {
                    MessageBox.Show("Error: " + exc);
                }
            }

            else if (sound.Equals("Loser"))
            {
                try
                {
                    SoundPlayer player = new SoundPlayer(The_Price_Is_Wrong.Properties.Resources.Loser);
                    player.Play();
                }
                catch (Exception exc)
                {
                    MessageBox.Show("Error: " + exc);
                }
            }

            else if (sound.Equals("Open"))
            {
                try
                {
                    SoundPlayer player = new SoundPlayer(The_Price_Is_Wrong.Properties.Resources.Opening);
                    player.Play();
                }
                catch (Exception exc)
                {
                    MessageBox.Show("Error: " + exc);
                }
            }
            else
            {
                MessageBox.Show("Error selecting sound type, check playsound(@String)");
            }

        }


        /*******************************************************************
         Display a metro style alert with a @string message
         ********************************************************************/
        public void metroMessage(String message)
        {
            MetroMessageBox box = new MetroMessageBox();
            box.Theme = MetroFramework.MetroThemeStyle.Dark;
            box.Style = MetroFramework.MetroColorStyle.Teal;
            box.Height = 100;
            box.Width = 450;

            box.Text = message;
            box.Show();
        }

    }
}
