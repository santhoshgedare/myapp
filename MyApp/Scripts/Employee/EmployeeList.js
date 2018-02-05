$(document).ready(function () {
    bindEmployeeDataTable();
});

function bindEmployeeDataTable() {
    //$("#tblEmployee").dataTable().destroy();
    $.ajax({
        url: "http://localhost:51203/api/Employee/GetAllEmployee",
        method: 'GET',
        dataType: 'json',
        contentType: "application/json; charset=utf-8",
        success: function (data) {
            console.log(data.Items);
            $('#tblQuotations').dataTable({
                paging: true,
                sort: true,
                searching: true,
                data: data.Items,
                stateSave: true,
                columns: [
                    { 'data': 'EmployeeName' },
                    { 'data': 'EmployeeID' },
                    {'data': 'DepartmentID'}
                ]
            });
        }
    });
}