using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;
using Newtonsoft.Json;

namespace SignalR.SignalR.WX
{
    [HubName("weiXin")]
    public class WeiXinHub : Hub
    {
        public static Dictionary<string, User> LoginUsers;
        private WeiXin _weiXin;

        public WeiXinHub()
        {
            LoginUsers = new Dictionary<string, User>();
            _weiXin = new WeiXin();
        }

        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="userId"></param>
        public void Login(string userId)
        {
            var user = _weiXin.GetUser(userId);
            user.userId = userId;
            user.connectionId = Context.ConnectionId;

            if (!LoginUsers.ContainsKey(userId))
            {
                //TODO: 添加
                LoginUsers.Add(userId, user);
            }
            else
            {
                //TODO: 更新
                LoginUsers[userId] = user;
            }

            GetContactsList(user);
        }

        /// <summary>
        /// 发送DevicesList
        /// </summary>
        /// <param name="user"></param>
        public void GetContactsList(User user)
        {
            //GET http://{$API_HOST}/contacts/list?token={$token}&imei={$imei}
            //输入参数:
            //  imei:对应的设备imei
            //返回结果:
            //{
            //  'status':1,
            //  'records': [
            //    {
            //      'wxid'		: '{好友wxid}',
            //            'nickname': '{好友昵称}',
            //      //其他信息字段待定
            //    },...
            //  ]
            //}
            //TODO：调用接口 /devices/list
            var jsonData = JsonConvert.SerializeObject(user);
            Clients.Client(user.connectionId).getContactsList(jsonData);


        }







    }
}