using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace SignalR.SignalR.WX
{
    public class WeiXinHub : Hub
    {
        public static Dictionary<string, User> LoginUsers;
        private WeiXin _weiXin;

        public WeiXinHub()
        {
            LoginUsers = new Dictionary<string, User>();
            _weiXin = new WeiXin();
        }


        public void Login(string userId)
        {
            var user = _weiXin.GetUser(userId);
            user.connectionId = Context.ConnectionId;

            if (!LoginUsers.ContainsKey(userId))
            {
                //TODO 添加
                LoginUsers.Add(userId, user);
            }
            else
            {
                //TODO 更新
                LoginUsers[userId] = user;
            }

        }







    }
}