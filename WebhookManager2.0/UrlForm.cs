using Siticone.Desktop.UI.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebhookManager2._0
{
    public partial class UrlForm : Form
    {
        public UrlForm()
        {
            InitializeComponent();
        }

        private void urlSubmitButton_Click(object sender, EventArgs e)
        {
            if (webhookUrlInput.Text != "")
            {
                if (!webhookUrlInput.Text.StartsWith("https://discord.com/api/webhooks"))
                {
                    MessageBox.Show("Inputted URL isn't discord webhook!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    this.Hide();
                    var mainForm = new MainForm();
                    mainForm.Show();     
                    mainForm.SaveUrl = webhookUrlInput.Text;
                }
            }
            else
            {
                MessageBox.Show("Inputted URL can't be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
