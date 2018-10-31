(function () {
    $(function () {
        $('#get-last-news').on('click', function () {
            $('#last-news').load('/LastNews.html');
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

        $('#submit-user').on('click', function () {
            $.ajax({
                method: 'GET',
                url: '/AddUser.aspx',
                data: { "name": $('#firstname').val(), "family": $('#lastname').val() }
            });
        });
    });
})();