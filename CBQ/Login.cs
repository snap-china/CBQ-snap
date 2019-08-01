using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace CBQ
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            UpdateVerifyCode();

        }

        #region 简单冒泡排序
        /// <summary>
        /// 简单冒泡排序
        /// </summary>
        /// <param name="array"></param>
        static void BubbleSortSort(int[] array)
        {
            #region 简单参数检查
            if (array == null)
            {
                throw new ArgumentNullException("array");
            }
            if (array.Length <= 0)
            {
                throw new IndexOutOfRangeException("array");
            }
            #endregion
            int length = array.Length;//数组长度
            int tmp; //临时变量用于交换位置
            for (int i = 0; i < length; i++) //外层循环N次
            {
                for (int j = 0; j < length - 1; j++)//完成一次完整的相邻元素比较 N-1次
                {
                    if (array[j] > array[j + 1])//比较大小
                    {
                        //交换位置
                        tmp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = tmp;
                    }
                }
            }
        }

        #endregion

        #region 验证码
        //随机码的长度
        private const int iVerifyCodeLength = 6;
        //随机码
        private String strVerifyCode = "";
        //更新验证码
        private void UpdateVerifyCode()
        {
            strVerifyCode = CreateRandomCode(iVerifyCodeLength);
            CreateImage(strVerifyCode);
        }
        private string CreateRandomCode(int iLength)
        {
            int rand;
            char code;
            string randomCode = String.Empty;
            //生成一定长度的验证码
            System.Random random = new Random();
            for (int i = 0; i < iLength; i++)
            {
                rand = random.Next();
                if (rand % 3 == 0)
                {
                    code = (char)('A' + (char)(rand % 26));
                }
                else
                {
                    code = (char)('0' + (char)(rand % 10));
                }
                randomCode += code.ToString();
            }
            return randomCode;
        }
        /// 创建随机码图片
        private void CreateImage(string strVerifyCode)
        {
            try
            {
                int iRandAngle = 45; //随机转动角度
                int iMapWidth = (int)(strVerifyCode.Length * 21);
                Bitmap map = new Bitmap(iMapWidth, 28); //创建图片背景
                Graphics graph = Graphics.FromImage(map);
                graph.Clear(Color.AliceBlue);//清除画面，填充背景
                graph.DrawRectangle(new Pen(Color.Black, 0), 0, 0, map.Width - 1, map.Height - 1);//画一个边框
                graph.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;//模式
                Random rand = new Random();
                //背景噪点生成
                Pen blackPen = new Pen(Color.LightGray, 0);
                for (int i = 0; i < 50; i++)
                {
                    int x = rand.Next(0, map.Width);
                    int y = rand.Next(0, map.Height);
                    graph.DrawRectangle(blackPen, x, y, 1, 1);
                }
                //验证码旋转，防止机器识别
                char[] chars = strVerifyCode.ToCharArray();//拆散字符串成单字符数组
                                                           //文字距中
                StringFormat format = new StringFormat(StringFormatFlags.NoClip);
                format.Alignment = StringAlignment.Center;
                format.LineAlignment = StringAlignment.Center;
                //定义颜色
                Color[] c = { Color.Black, Color.Red, Color.DarkBlue, Color.Green, Color.Orange, Color.Brown, Color.DarkCyan, Color.Purple };
                //定义字体
                string[] font = { "Verdana", "Microsoft Sans Serif", "Comic Sans MS", "Arial", "宋体" };
                for (int i = 0; i < chars.Length; i++)
                {
                    int cindex = rand.Next(7);
                    int findex = rand.Next(5);
                    Font f = new System.Drawing.Font(font[findex], 13, System.Drawing.FontStyle.Bold);//字体样式(参数2为字体大小)
                    Brush b = new System.Drawing.SolidBrush(c[cindex]);
                    Point dot = new Point(16, 16);
                    float angle = rand.Next(-iRandAngle, iRandAngle);//转动的度数
                    graph.TranslateTransform(dot.X, dot.Y);//移动光标到指定位置
                    graph.RotateTransform(angle);
                    graph.DrawString(chars[i].ToString(), f, b, 1, 1, format);
                    graph.RotateTransform(-angle);//转回去
                    graph.TranslateTransform(2, -dot.Y);//移动光标到指定位置
                }
                pbVerifyCode.Image = map;
            }
            catch (ArgumentException)
            {
                MessageBox.Show("创建图片错误。");
            }
        }

        /// <summary>
        /// 看不清，换一张
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void butUpdateVerifyCode_Click(object sender, EventArgs e)
        {
            UpdateVerifyCode();
        }
        #endregion

        #region 登录
        private void skbtn_login_Click(object sender, EventArgs e)
        {
            string username = this.sktxb_user.Text.Trim();
            string password = this.sktxb_pwd.Text.Trim();

            if (!string.IsNullOrEmpty(sktxb_user.Text.Trim()))
            {
                username = sktxb_user.Text.Trim();
            }
            if (!string.IsNullOrEmpty(sktxb_pwd.Text.Trim()))
            {
                password = sktxb_pwd.Text.Trim();
            }

            Regex reMail = new Regex(@"[\w!#$%&'*+/=?^_`{|}~-]+(?:\.[\w!#$%&'*+/=?^_`{|}~-]+)*@(?:[\w](?:[\w-]*[\w])?\.)+[\w](?:[\w-]*[\w])?");//实例化一个Regex对象
            Regex reuser = new Regex(@"^/w+$"); //匹配由数字、26个英文字母或者下划线组成的字符串

            if (reMail.IsMatch(sktxb_user.Text) == true)//验证数据是否匹配
            {
                MessageBox.Show("邮箱正确");//匹配则弹出”邮箱正确“

            }
            else
            {
                MessageBox.Show("邮箱格式错误");//不匹配则弹出”邮箱错误“

            }
            if (reuser.IsMatch(sktxb_pwd.Text) == true)
            {
                MessageBox.Show("成功");
            }
            else
            {
                MessageBox.Show("错误！");
            }

            Index index = new Index();
            index.Show();
        }

        #endregion

        #region 注册


        #endregion

        private void sklb_agreements_Click(object sender, EventArgs e)
        {
            #region 协议内容

            Agreement agre = new Agreement();
            agre.Show();
            #endregion

        }
        #region 文本框提示
        private string Notes = "用户名/邮箱";
        private string NotPwd = "密码";
        private string notYZM = "验证码";
        private void sktxb_user_MouseEnter(object sender, EventArgs e)
        {
            //进入时，清空
            if (sktxb_user.Text == Notes)
            {
                sktxb_user.Text = "";
            }
        }

        private void sktxb_user_MouseLeave(object sender, EventArgs e)
        {
            //  退出时，重新显示
            if (string.IsNullOrEmpty(sktxb_user.Text))
            {
                sktxb_user.Text = Notes;
            }
        }
        private void sktxb_pwd_MouseEnter(object sender, EventArgs e)
        {
            //进入时，清空
            if (sktxb_pwd.Text == NotPwd)
            {
                sktxb_pwd.Text = "";
            }
        }

        private void sktxb_pwd_MouseLeave(object sender, EventArgs e)
        {
            //  退出时，重新显示
            if (string.IsNullOrEmpty(sktxb_pwd.Text))
            {
                sktxb_pwd.Text = NotPwd;
            }
        }

        private void sktxt_ValidCode_MouseEnter(object sender, EventArgs e)
        {
            //进入时，清空
            if (sktxb_ValidCode.Text == notYZM)
            {
                sktxb_ValidCode.Text = "";
            }
        }

        private void sktxt_ValidCode_MouseLeave(object sender, EventArgs e)
        {
            //  退出时，重新显示
            if (string.IsNullOrEmpty(sktxb_ValidCode.Text))
            {
                sktxb_ValidCode.Text = notYZM;
            }
        }

        #endregion
    }
}
