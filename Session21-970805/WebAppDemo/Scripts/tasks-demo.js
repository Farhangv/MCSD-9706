/// <reference path="jquery-2.2.4.js" />

//function markAsDone(clickedButton) {
//    clickedButton.parentElement.parentElement.className = 'done-task';
//}
//(function () {
//    document.getElementById('btn-add').addEventListener('click', () => {

//        let task_row = document.createElement('tr');
//        let task_name_col = document.createElement('td');
//        let task_date_col = document.createElement('td');
//        let task_last_col = document.createElement('td');
//        let task_done_btn = document.createElement('button');

//        //task_done_btn.setAttribute('class', 'btn btn-success btn-sm')
//        task_done_btn.className = 'btn btn-success btn-sm';
//        task_done_btn.innerHTML = '<span class="glyphicon glyphicon-ok"></span>';

//        task_done_btn.setAttribute('onclick', 'markAsDone(this);');

//        //task_done_btn.addEventListener('click', function () {
//        //    //alert('clicked');
//        //});

//        task_name_col.innerHTML = document.getElementById('task-name').value;
//        task_date_col.innerHTML = document.getElementById('task-date').value;

//        task_last_col.appendChild(task_done_btn);

//        task_row.appendChild(task_name_col);
//        task_row.appendChild(task_date_col);
//        task_row.appendChild(task_last_col);

//        document.getElementById('tasks-body').appendChild(task_row);
        
//    });



//})();



//jQuery Version
(function () {

    //$(document).on('ready', function () {
    //$(document).ready(function () {
    $(function () { 

        //document.getElementById('btn-add');
        $('#btn-add').click(function () {
            $('<tr>')
                .append($('<td>').html($('#task-name').val()))
                .append($('<td>').html($('#task-date').val()))
                .append($('<td>').append(
                    $('<button>').html('<span class="glyphicon glyphicon-ok"></span>').addClass('btn btn-success btn-sm')
                        .on('click', function () {
                            $(this).parentsUntil('tbody').addClass('done-task');
                        })
                    )//td

                )//tr
                .appendTo($('#tasks-body'));
        });

    });

})();