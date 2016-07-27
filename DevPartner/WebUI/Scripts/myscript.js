
$(document).ready(function () {

    $(".customer tbody tr").on("click", function (e) {

        var id = $(this).children(".hideme").first().text();

        $(".orders tbody.body tr ").hide();

        var elements = $(".orders tbody.body tr");
        for(var element in elements)
        {
            var id2 = $(element).children(".hideme").first().text();
            if(id2==id)
            {
                element.show();
            }
        }
    }

    )
})