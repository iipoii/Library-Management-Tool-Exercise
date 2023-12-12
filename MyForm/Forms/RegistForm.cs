using MyForm.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace MyForm
{
    public partial class RegistForm : Form
    {
        public RegistForm()
        {
            InitializeComponent();
        }
        // count_time_s表示获取一次验证码后，要获取下一次验证码所需等待的时间，单位为秒
        // captcha存储验证码，可以被全局访问
        int count_time_s;
        string captcha = string.Empty;

        public string GenerateCaptcha()
        {
            // 这个函数生成一个6位的验证码
            // captcha_list 包含所需要的验证码元素
            string captcha_list = "0123456789";
            captcha_list += "abcdefghijklmnopqrstuvwxyz";
            captcha_list += "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            // 每次从captcha_list随机获取一位字符，循环6次，得到一个随机的六位数的验证码
            captcha = string.Empty;
            Random random = new Random();
            for (int i = 0; i < 6; i++)
            {
                captcha += captcha_list.Substring(random.Next(0, captcha_list.Length), 1);
            }
            return captcha;
        }

        private void btnGetCaptcha_Click(object sender, EventArgs e)
        {
            string user_email = txtEmail.Text;
            // 通过正则表达式校验邮箱格式是否正确
            Regex isEmail = new Regex(@"^\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$");
            if (!isEmail.IsMatch(user_email))
            {
                MessageBox.Show("请输入正确的邮箱");
                return;
            }
            // 生成验证码并通过邮箱发送
            string email_subject = "这是您的账号注册验证码";
            GenerateCaptcha();
            SMTP.SendMessageTo(user_email, captcha, email_subject);
            // 关闭获取验证码按钮使能，等待10s后再次开启
            count_time_s = 10;
            btnGetCaptcha.Enabled = false;
            timerCaptchaGap.Start();

        }

        private void timerCaptchaGap_Tick(object sender, EventArgs e)
        {
            // Tick事件每秒触发一次
            // 开始计数时，btnGetCaptcha使能被关闭，同时显示剩余所需等待的时间
            count_time_s--;
            btnGetCaptcha.Text = count_time_s.ToString();
            if (count_time_s == 0)
            {
                timerCaptchaGap.Stop();
                btnGetCaptcha.Text = "获取验证码";
                btnGetCaptcha.Enabled = true;
            }
        }

        private void btnRegistConfirm_Click(object sender, EventArgs e)
        {
            string username;
            string password;
            // 空验证码判断
            // 进行空判是有必要的，因为未点击获取验证码前，验证码初始化为空，直接进行判断的话，可能会与空输入匹配
            if (txtCaptcha.Text == string.Empty)
            {
                MessageBox.Show("请获取验证码");
            }
            // 验证码正确
            else if (txtCaptcha.Text == captcha)
            {
                // 读取username和password加入数据库中
                username = txtUsername.Text;
                password = txtPassword.Text;
                TemporaryDatabase.AddRow("账号表", username, password, "guest");
                MessageBox.Show("注册成功，请前往登录");
                // 注册成功关闭窗口
                this.Close();
            }
            // 验证码错误
            else
            {
                MessageBox.Show("验证码错误");
            }

        }

        private void checkBoxTest_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxTest.Checked)
            {
                TemporaryDatabase.test_mode = true;
            }
            else
            {
                TemporaryDatabase.test_mode = false;
            }
        }
    }
}
