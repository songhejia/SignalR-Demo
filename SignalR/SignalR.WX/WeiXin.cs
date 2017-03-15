using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SignalR.SignalR.WX
{
    public class WeiXin
    {
        public static List<User> UserList;

        public WeiXin()
        {
            UserList = new List<User>();
        }

        public void Login(string userId)
        {
            string imei = userId;
            //if (UserList.Select(r => r.imei).Contains(imei))
            //{
            //    //TODO 更新
            //}
            //else
            //{
            //    //TODO 添加
            //}
        }

        public User GetUser(string userId)
        {
            return new User();
        }
    }
}