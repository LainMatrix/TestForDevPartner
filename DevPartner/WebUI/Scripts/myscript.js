
$(document).ready(function () {

    $(".customer tbody tr").on("click", function (e) {

        var id = $(this).children(".hideme").first().text();

        $(".orders tbody.body tr ").hide();

        var elements = $(".orders tbody.body tr");
        elements.each(function()
        {
            var id2 = $(this).children(".hideme").first().text();
            if(id2==id)
            {
                $(this).show();
            }
        }
       
        )
        $(".bt").show();
        $(".message").hide();
    });
   
    
    
    $(".bt").on("click",function(){


        $(this).hide();
        $(".message").show();
        $(".orders tbody.body tr ").show();

    
    } )  ;
});