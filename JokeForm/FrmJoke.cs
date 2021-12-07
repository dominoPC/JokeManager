/* Joseph Tankersley tankerjh@mail.uc.edu
 * Final Project
 * Contemporary Programming Fall 2021
 * 07 December 2021
 * Windows form frontend for the Joke Manager project
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JokeForm
{
    public partial class FrmJoke : Form
    {
        public FrmJoke()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblMessage.Text = null;
            txtJoke.Text = null;
            txtUCID.Text = null;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(txtUCID.Text.Trim() == "" || txtJoke.Text.Trim() == "")
            {
                lblMessage.Text = "Both fields are required";
            }
            else
            {
                lblMessage.Text = null;
                if(JokeManagerNamespace.JokeManager.SaveJoke(txtUCID.Text, txtJoke.Text) == 0) //indicates success
                {
                    txtUCID.Text = null; //clears the text boxes
                    txtJoke.Text = null;
                    lblMessage.Text = "Joke saved";
                }
                else
                {
                    lblMessage.Text = "Joke not saved";
                }
                
            }
        }
    }
}
