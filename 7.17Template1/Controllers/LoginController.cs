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
        [HttpPost]
        public void GetVallue(string phone)
        {

            ALiYunSendSms aliyun = new ALiYunSendSms();
            string sc = phone;
            aliyun.SendSmss(sc);
            
        }
    }
}