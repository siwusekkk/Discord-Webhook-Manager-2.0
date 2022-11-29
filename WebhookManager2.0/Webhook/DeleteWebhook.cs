using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace WebhookManager2._0.Webhook
{
    class DeleteWebhook
    {
        public static void DeleteWebhookMethod(string webhookUrl)
        {
            try
            {
                var request = WebRequest.Create(webhookUrl);
                request.Method = "DELETE";
                var response = (HttpWebResponse)request.GetResponse();
                MessageBox.Show("Webhook deleted!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
