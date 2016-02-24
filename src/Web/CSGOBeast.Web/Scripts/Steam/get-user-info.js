(function () {
    $.ajax({
        type: 'GET',
        url: '/Steam/GetProfile',
        dataType: 'json',
        success: function (data) {
            if (data.response.players) {
                $.each(data.response.players, function (key, value) {
                    if (value.avatar && value.personaname) {
                        if ($('.profile')) {
                            $('.profile-name').html("");
                            $('.profile-name').append("<img src='" + value.avatar + "'/>");
                            $('.profile-name').append(" " + value.personaname);
                        }
                    }
                    console.log(value)
                });
            }
        }, error: function (httpReq, status, exception) {
            console.log(status + " " + exception);
        }
    });
}());