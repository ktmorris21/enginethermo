// geometryModal.js
// Contains scripting for the geometry definition modal

// Calculates displacement volume and clearance volume in cubic meters and sets the bound inputs for the model 
function setModelVolumeInputsByDisplacement() {
    var cylinderDisplacement = $("#cylinderDisplacementRawInput").val() 
        * $("#cylinderDisplacementInputUnits").val();
    var cylinderClearance = cylinderDisplacement / ($("#cylinderCompressionRatioRawInput").val() - 1);
    $("#cylinderDisplacement").val(cylinderDisplacement);
    $("#cylinderClearance").val(cylinderClearance);
}

// Enable and disable the inputs based on selected volume definition method
$("input[name=cylinderGeometryDefMethod").change(function(){
    if ($("input[name=cylinderGeometryDefMethod]:checked").val() === "displacement") {
        // Disable displacement inputs
        $("#cylinderDisplacementRawInput").prop("disabled", false);
        $("#cylinderDisplacementInputUnits").prop("disabled", false);
        $("#cylinderCompressionRatioRawInput").prop("disabled", false);

        // Enable stroke/bore inputs
        $("#cylinderStrokeRawInput").prop("disabled", true);
        $("#cylinderStrokeInputUnits").prop("disabled", true);
        $("#cylinderBoreRawInput").prop("disabled", true);
        $("#cylinderBoreInputUnits").prop("disabled", true);
        $("#cylinderClearanceVolumeRawInput").prop("disabled", true);
        $("#cylinderClearanceVolumeInputUnits").prop("disabled", true);
    }
    else {
        // Enable displacement inputs 
        $("#cylinderDisplacementRawInput").prop("disabled", true);
        $("#cylinderDisplacementInputUnits").prop("disabled", true);
        $("#cylinderCompressionRatioRawInput").prop("disabled", true);

        // Disable stroke/bore inputs
        $("#cylinderStrokeRawInput").prop("disabled", false);
        $("#cylinderStrokeInputUnits").prop("disabled", false);
        $("#cylinderBoreRawInput").prop("disabled", false);
        $("#cylinderBoreInputUnits").prop("disabled", false);
        $("#cylinderClearanceVolumeRawInput").prop("disabled", false);
        $("#cylinderClearanceVolumeInputUnits").prop("disabled", false);
    }
});

// Event handler on displacement raw inputs to calculate model inputs
$(".displacementInputs").each(function(){
    $(this).on("change", function(){
        setModelVolumeInputsByDisplacement();
    });
});