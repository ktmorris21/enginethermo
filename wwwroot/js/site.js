// Get inital model state values from hidden inputs
 var modelCylinderCount = $("#modelStateCylinderCount").val();

 
 // Vue app
 var engineThermoApp = new Vue({
    el: "#engineThermoApp",
    data: {
        vueCylinderCount: modelCylinderCount        
    }
 });
 