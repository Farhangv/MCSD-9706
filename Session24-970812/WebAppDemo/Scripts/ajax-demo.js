(function () {

    function addUser() {
        $('#submit-user').html('').append($('<img>').attr('src', '/Images/ajax-loader.gif'));

        $('#submit-user').off('click');
        $('#submit-user').attr('disabled', 'disabled');

        $.ajax({
            method: 'GET',
            url: '/AddUser.aspx',
            data: { "name": $('#firstname').val(), "family": $('#lastname').val() }
        })
            .done(function (data) {
                $('#user-form-wrapper')
                    .prepend(
                        $('<div class="msg">').addClass('alert alert-success').html(data)
                );
            })
            .fail(function () {
                $('#user-form-wrapper')
                    .prepend(
                        $('<div class="msg">').addClass('alert alert-danger').html('خطایی در ثبت کاربر رخ داده')
                );
            })
            .always(function () {
                $('#submit-user').on('click', addUser);
                $('#submit-user').removeAttr('disabled');
                $('#submit-user').html('').html('<span class="fa fa-check"></span> ثبت');
                setTimeout(function () {
                    $('.msg').fadeOut(1500);
                }, 3000);

            });
    }

    $(function () {
        $(document).ajaxStart(function () { $('#loader').fadeIn(800); });
        $(document).ajaxComplete(function () { $('#loader').fadeOut(800); });




        $('#get-last-news').on('click', function () {
            //$('#last-news').load('/LastNews.html');
            $('#last-news').load('/DataSets/yjc.html .akhv_item:first');
            //$('#last-news').load('/DataSets/products.json');
        });

        $('#get-products').on('click', function () {
            $.getJSON('/DataSets/products.json', function (data) {
                //console.log(data);
                let products = data.products;

                for (let product of products) {
                    $('<tr>')
                        .append($('<td>').text(product.productId))
                        .append($('<td>').text(product.productName))
                        .append($('<td>').text(product.releaseDate))
                        .append($('<td>').text(product.starRating))
                        .append($('<td>').append($('<img class="img-thumbnail">').attr('src', product.imageUrl)))
                        .appendTo($('#products-table'));
                }
            });
        });

        $('#submit-user').on('click', addUser);
    });
})();