using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _7._17Template1.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        /// <summary>
        /// 登陆
        /// </summary>
        /// <returns></returns>
        public ActionResult LoginPage()
        {
            return View();
        }
        /// <summary>
        /// 注册
        /// </summary>
        /// <returns></returns>
        public ActionResult Register()
        {
            return View();
        }
        /// <summary>
        /// 注册
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Register(string userName, string passWord, string phone, string _msg)
        {
            string code = ALiYunSendSms.RandomId;
            if (_msg == code)
            {
                Response.Write("<script>alert('注册成功')</script>");
            }
            else
            {
                Response.Write("<script>alert('验证码不正确')</script>");
            }

            return View();
        }

        /// <summary>
        /// 获取验证码
        /// </summary>
        /// <param name="phone">手机号</param>
        public void GetVallue(string phone)
        {
            ALiYunSendSms aliyun = new ALiYunSendSms();
            Session.Timeout = 1;
            aliyun.SendSmss(phone);
        }
    }
}