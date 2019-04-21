// Get inital model state values from hidden inputs
var initialModelCylinderCount = $("#modelStateCylinderCount").val();
var cylinderDisplacementRawInput = $("#cylinderDisplacementRawInput").val();
 
 // Vue app
 var engineThermoApp = new Vue({
    el: "#engineThermoApp",
    data: {
        modelCylinderCount: initialModelCylinderCount,
        geometryMode: 'displacement'
    }
 });


 // Set jquery validation to work on all inputs (esp. our hidden inputs used to store state)
 $.validator.setDefaults({ ignore: null });
 