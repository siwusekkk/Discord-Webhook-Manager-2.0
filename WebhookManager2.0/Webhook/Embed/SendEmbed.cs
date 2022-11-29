using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using WebhookManager2._0.Webhook.Embed;

namespace WebhookManager2._0.Webhook.Embed
{
    class SendEmbed
    {
        public static void SendEmbedMethod(string webhookUrl, string username, string title, string description, string thumbnailUrl)
        {
            try
            {
                WebRequest request = (HttpWebRequest)WebRequest.Create(webhookUrl);
                request.ContentType = "application/json";
                request.Method = "POST";
                using (var sw = new StreamWriter(request.GetRequestStream()))
                {
                    string json = JsonConvert.SerializeObject(new
                    {
                        username,
                        embeds = new[]
                        {
                            new
                            {
                                description,
                                title,
                                color = "16515859",
                                thumbnail = new Thumbnail
                                {
                                    url = thumbnailUrl,
                                }
                            }
                        }
                    });
                    sw.Write(json);
                }
                var response = (HttpWebResponse)request.GetResponse();
                MessageBox.Show("Webhook sent!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
