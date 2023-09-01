$.ajax({
    url: '@Url.Action("GetDefaultMapOptions", "ScheduleController")',
    method: 'GET',
    success: function (data) {

        var mapOptions = {
            center: { lat: data.lat, lng: data.lon }
        };
        var map = new google.maps.Map(document.getElementById("googleMap"), mapOptions);
        } 
    });