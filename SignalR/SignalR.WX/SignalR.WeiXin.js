$(function () {
    var weiXin = $.connection.weiXin;

    function login(userid) {
        weiXin.server.login(userid).done(function (data) {
            console.log(data);
        });
    }

    $.extend(weiXin.client, {
        getContactsList: function(data) {
            console.log(data);
        }
    });

    // Start the connection
    $.connection.hub.start().done(function () {
        login("2568952");
        login("sss");
    });
})