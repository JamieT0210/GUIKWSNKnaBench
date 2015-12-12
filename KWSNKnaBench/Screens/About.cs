/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// Author:      Jamie                                                                                                                                              //
// Date:        02/12/2015                                                                                                                                         //
// Description: Used to display an about screen with Hyperlinks to various websites                                                                                //            
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////// 
using System.Windows.Forms;

namespace KWSNKnaBench
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }
        //Hyperlink to jgopt.org
        private void hypJGOPT_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://jgopt.org/");
        }
        //Hyperlink to Lunatics
        private void hypLunatics_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://lunatics.kwsn.info/");
        }
        //Hyperlink to Crunchers Anon
        private void lblCrunchAnon_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://arkayn.us/forum");
        }
    }
}
