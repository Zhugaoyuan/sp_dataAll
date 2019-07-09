using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Exceptions;
using Aliyun.Acs.Core.Profile;
using Aliyun.Acs.Dysmsapi.Model.V20170525;
using System;

namespace _7._17Template1.Controllers
{
    public  class ALiYunSendSms
    {
       
        public static string RandomId { get; set; }
        static String product = "Dysmsapi";//短信API产品名称
        static String domain = "dysmsapi.aliyuncs.com";//短信API产品域名
        static String accessId = "LTAI9qn1YUUCmshw";
        static String accessSecret = "VOICjaIFYbDQwn0MkA1zyYV5y1E4fH";
        static String regionIdForPop = "cn-hangzhou";
        public  void SendSmss(string sc)
        {
            IClientProfile profile = DefaultProfile.GetProfile(regionIdForPop, accessId, accessSecret);
            DefaultProfile.AddEndpoint(regionIdForPop, regionIdForPop, product, domain);
            IAcsClient acsClient = new DefaultAcsClient(profile);
            SendSmsRequest request = new SendSmsRequest();
            try
            {
                //request.SignName = "上云预发测试";//"管理控制台中配置的短信签名（状态必须是验证通过）"
                //request.TemplateCode = "SMS_71130001";//管理控制台中配置的审核通过的短信模板的模板CODE（状态必须是验证通过）"
                //request.RecNum = "13567939485";//"接收号码，多个号码可以逗号分隔"
                //request.ParamString = "{\"name\":\"123\"}";//短信模板中的变量；数字需要转换为字符串；个人用户每个变量长度必须小于15个字符。"
                //SingleSendSmsResponse httpResponse = client.GetAcsResponse(request);
                string c =  Radom();
                RandomId = c;
                //HttpCookie cookie = new HttpCookie("MyCook");
                //DateTime dt = DateTime.Now;
                //TimeSpan ts = new TimeSpan(0, 0, 1, 0, 0);
                //cookie.Expires = dt.Add(ts);
                //cookie.Values.Add("user1", c);
                //2、radis缓存
                //RedisClient client = new RedisClient();
                //if (sc != null)
                //{
                //    client.Set("PhoneNumber", sc);
                //    client.Set("Sms", c,DateTime.Now.AddMilliseconds(60000));
                //}
                //client.Set("PhoneNumber", sc);
                request.PhoneNumbers = sc;
                request.SignName = "个体商城";
                request.TemplateCode = "SMS_169899947";
                request.TemplateParam = "{\"code\":\"" + c + "\"}";
                request.OutId = "xxxxxxxx";
                //请求失败这里会抛ClientException异常
                SendSmsResponse sendSmsResponse = acsClient.GetAcsResponse(request);
                System.Console.WriteLine(sendSmsResponse.Message);


            }
            catch (ServerException e)
            {
                System.Console.WriteLine("ServerException");
            }
            catch (ClientException e)
            {
                System.Console.WriteLine("ClientException");
            }
        }
        public string Radom()
        {
            Random random = new Random();
            string a= random.Next(100000, 1000000).ToString();
            return a;
        }
    }
}