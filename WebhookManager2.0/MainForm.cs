using WebhookManager2._0.Utils;
using WebhookManager2._0.Webhook;
using WebhookManager2._0.Webhook.Embed;

namespace WebhookManager2._0
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            UrlForm urlForm = new UrlForm();
            string webhookUrl = SaveUrl;
            string username = webhooksUsernameInput.Text;
            string message = messageInput.Text;
            string title = titleInput.Text;
            string description = descriptionInput.Text;
            string thumbnail = thumbnailInput.Text;
            if(delayInput.Text != "")
            {
                int delay = int.Parse(delayInput.Text);
            }

            if (activityChoice.GetItemText(activityChoice.SelectedItem) == "Send Webhook")
            {
                SendWebhook.SendWebhookMethod(webhookUrl, message, username);
            }
            else if(activityChoice.GetItemText(activityChoice.SelectedItem) == "Delete Webhook")
            {
                DeleteWebhook.DeleteWebhookMethod(webhookUrl);
            }
            else if (activityChoice.GetItemText(activityChoice.SelectedItem) == "Send Embed")
            {
                SendEmbed.SendEmbedMethod(webhookUrl, username, title, description, thumbnail);
            }
            else if (activityChoice.GetItemText(activityChoice.SelectedItem) == "Spam Webhook")
            {
                SpamWebhook.SpamWebhookMethod(webhookUrl, username, message, delay);
            }
        }

        private void activityChoice_SelectedValueChanged(object sender, EventArgs e)
        {
            submitButton.Text = activityChoice.GetItemText(activityChoice.SelectedItem);
            if(activityChoice.GetItemText(activityChoice.SelectedItem) == "Send Webhook")
            {
                Unavailable.SetUnavailable(titleInput);
                Unavailable.SetUnavailable(descriptionInput);
                Unavailable.SetUnavailable(thumbnailInput);
                Unavailable.SetUnavailable(delayInput);
                Available.SetAvailable(webhooksUsernameInput);
                Available.SetAvailable(messageInput);
            } 
            else if(activityChoice.GetItemText(activityChoice.SelectedItem) == "Delete Webhook")
            {
                Unavailable.SetUnavailable(webhooksUsernameInput);
                Unavailable.SetUnavailable(messageInput);
                Unavailable.SetUnavailable(titleInput);
                Unavailable.SetUnavailable(descriptionInput);
                Unavailable.SetUnavailable(thumbnailInput);
                Unavailable.SetUnavailable(delayInput);
            }
            else if (activityChoice.GetItemText(activityChoice.SelectedItem) == "Send Embed")
            {
                Unavailable.SetUnavailable(messageInput);
                Unavailable.SetUnavailable(delayInput);
                Available.SetAvailable(webhooksUsernameInput);
                Available.SetAvailable(titleInput);
                Available.SetAvailable(descriptionInput);
                Available.SetAvailable(thumbnailInput);
            } 
            else if (activityChoice.GetItemText(activityChoice.SelectedItem) == "Spam Webhook")
            {
                Unavailable.SetUnavailable(titleInput);
                Unavailable.SetUnavailable(descriptionInput);
                Unavailable.SetUnavailable(thumbnailInput);
                Available.SetAvailable(webhooksUsernameInput);
                Available.SetAvailable(messageInput);
                Available.SetAvailable(delayInput);
            }
            else
            {
                Unavailable.SetUnavailable(webhooksUsernameInput);
                Unavailable.SetUnavailable(messageInput);
                Unavailable.SetUnavailable(titleInput);
                Unavailable.SetUnavailable(descriptionInput);
                Unavailable.SetUnavailable(thumbnailInput);
                Unavailable.SetUnavailable(delayInput);
            }
        }
        public string SaveUrl
        {
            get
            {
                return this.webhookUrlBox.Text;
            }
            set
            {
                this.webhookUrlBox.Text = value;
            }
        }
    }
}
