using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace WebhookManager2._0.Webhook
{
    class SendWebhook
    {
        public static void SendWebhookMethod(string webhookUrl, string message, string username)
        {
            WebClient wc = new WebClient();
            try
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
                MessageBox.Show("Webhook sent!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
