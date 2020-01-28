(function () {
    $(document).ready(function () {
        var form = $("form");
        form.submit(function (e) {
            if (!form.valid) {
                return;
            } else {
                e.preventDefault();
                var errorList = $("#errorSummary ul");
                var formData = {
                    Name: $("#Name").val(),
                    Category: $("#Category").val(),
                    Price: $("#Price").val()
                };
                $.ajax({
                    url: "/api/product",
                    type: "POST",
                    data: formData,
                    dataType: "json",
                    success: function (product) {

                    },
                    error: function (jqXHR, status, error) {

                    }
                });
            }
        });
    });
});