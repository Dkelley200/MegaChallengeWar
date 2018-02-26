using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;


namespace MegaChallengeWar
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.Length.ToString("< span style = 'color:blue;font-weight:bolder;' > It's time to Play War! </ span > ");
        }

        protected void playgameButton_Click(object sender, EventArgs e)
        {
            
        }

        protected void playgameButton_Click1(object sender, EventArgs e)
        {
            Game game = new Game("Player1", "Player2");
            resultLabel.Text = game.Play();
        }
    }
}