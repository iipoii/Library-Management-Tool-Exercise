using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.ComponentModel;
using Newtonsoft.Json;


namespace MyForm.Class
{
    internal class SMTP
    {
        
        private class SmtpSettings
        {
            // 请确保与json文件中属性名一致
            public string smtpServer { get; set; }
            public string from { get; set; }
            public string password { get; set; }
        }

        // 从json文件中读取smtp服务的设置参数
        private static SmtpSettings ReadSmtpSettingsFromJson()
        {
            SmtpSettings settings = new SmtpSettings();
            try
            {
                // string jsonFilePath = "path_to_your_json_file.json";
                string jsonFilePath = "C:\\Users\\lenovo\\OneDrive\\桌面\\shiyan\\winform\\MyForm\\MyForm\\config\\SMTP_config.json";
                string jsonContent = File.ReadAllText(jsonFilePath);
                settings = JsonConvert.DeserializeObject<SmtpSettings>(jsonContent);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "SMTP邮件服务加载设置错误");
            }
            
            return settings;
        }

        // 这个函数是发送邮件动作完成后的回调函数
        private static void SendCompletedCallback(object sender, AsyncCompletedEventArgs e)
        {
            // Get the unique identifier for this asynchronous operation.
            // 此处的token即为代码末尾处的userState变量
            string token = e.UserState.ToString();
            // 读取参数，看邮件是否成功发送
            if (e.Cancelled)
            {
                // 邮件发送被取消
                MessageBox.Show(String.Format("[{0}] Send canceled.", token));
            }
            if (e.Error != null)
            {
                // 读取错误信息
                MessageBox.Show(String.Format("[{0}] {1}", token, e.Error.ToString()));
            }
            else
            {
                MessageBox.Show("Message sent.");
            }
        }

        public static void SendMessageTo(string dst_email, string body, string subject)
        {
            SmtpSettings settings = ReadSmtpSettingsFromJson();
            // 定义邮件服务器
            SmtpClient client = new SmtpClient(settings.smtpServer);
            // 定义邮件内容
            MailAddress from = new MailAddress(settings.from, "图书管理系统", Encoding.UTF8);
            MailAddress to = new MailAddress(dst_email);
            MailMessage message = new MailMessage(from, to);
            message.Body = body; 
            message.Subject = subject;
            message.BodyEncoding = Encoding.UTF8;
            message.SubjectEncoding = Encoding.UTF8;
            // 创建互联网安全证书,第一个参数为发送者邮箱地址，第二个参数为邮箱的smtp服务授权码
            NetworkCredential cred = new NetworkCredential(settings.from, settings.password);
            //证书绑定到服务器对象以便服务器验证
            client.Credentials = cred;
            // 使用SendAsync，选择异步发送邮件，不阻塞主进程
            // 设置当邮件发送操作结束时所调用的函数
            // Set the method that is called back when the send operation ends.
            client.SendCompleted += new SendCompletedEventHandler(SendCompletedCallback);
            // The userState can be any object that allows your callback method to identify this send operation.
            // For this example, the userToken is a string constant.
            string userState = "The message";
            client.SendAsync(message, userState);
        }

    }
}
