using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace WebhookManager2._0.Webhook
{
    class SpamWebhook
    {
        public static void SpamWebhookMethod(string webhookUrl, string username, string message, int messageDelay)
        {
            WebClient wc = new WebClient();
            try
            {
                MessageBox.Show("Webhook spam started!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                while (true)
                {
                    wc.UploadValues(webhookUrl, new NameValueCollection
                    {
                        {
                            "content", message
                        },
                        {
                            "username", username
                        }
                    });
                    Thread.Sleep(messageDelay);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
