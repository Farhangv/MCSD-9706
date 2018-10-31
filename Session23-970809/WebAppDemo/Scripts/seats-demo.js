(function () {

    $(function () {

        let locationSeats = [
            { "name": "سالن ۱", "seats": [25,25,15,15,15,15,20,23] , "movieName" : "ابد و یک روز"}, //0
            { "name": "سالن ۲", "seats": [10, 10, 10, 15, 15, 12, 10], "movieName": "گشت ۲"}, //1
            { "name": "سالن ۳", "seats": [23, 15, 15, 15, 15], "movieName": "اکسیر"}, //2
            { "name": "سالن ۴", "seats": [12, 12, 15, 23, 25, 25], "movieName": "پستچی سه بار در نمیزند"} //3
        ];
        let selectedSeats = [];


        $(locationSeats).each(function (ix, location) {
            $('<option>').attr('value', ix)
                .text(`${location.name} (${location.movieName})`).appendTo('#location-selector');
        });

        $('#location-selector').change(function () {
            $('#seats-wrapper').html('');
            let selectedIndex = $(this).val();
            if (selectedIndex >= 0) {
                let seats = locationSeats[selectedIndex].seats;
                for (let ix in seats) {
                    let $seatsRow = $('<div>').addClass('row')
                        .append($('<div>').addClass('col-md-1').text(+ix + 1));
                    let $seatsCol = $('<div>').addClass('col-md-11');

                    for (var i = 1; i <= seats[ix]; i++) {
                        $('<button>')
                            .addClass('btn btn-primary btn-xs seat-btn')
                            .text(i)
                            .appendTo($seatsCol)
                            .attr('data-row-index', ix)
                            .click(function () {
                                $(this)
                                    .toggleClass('btn-primary')
                                    .toggleClass('btn-success')
                                    .toggleClass('selected-seat');
                            });
                    }
                    $seatsRow.append($seatsCol).appendTo($('#seats-wrapper'));
                }

            }
        });

        $('#user-name,#user-phone').on('input', function () {
            if ($('#user-name').val() && $('#user-phone').val()) {
                $('#submit').removeAttr('disabled');
            }
            else {
                $('#submit').attr('disabled', 'disabled');
            }
        });


        $('#submit').on('click', function () {
            $('#selected-seats-table').html('');
            $('.selected-seat').each(function (ix,seat) {
                //console.log(seat);
                selectedSeats.push(
                    { "seat": +$(seat).text(), "row": +$(seat).attr('data-row-index') + 1 });
            });

            $(selectedSeats).each(function (ix, seat) {
                $('<tr>')
                    .append($('<td>').text(seat.row))
                    .append($('<td>').text(seat.seat))
                    .appendTo($('#selected-seats-table'));
            });

            console.log(selectedSeats);
            $('#submit-modal').modal();

        });

    });

})();