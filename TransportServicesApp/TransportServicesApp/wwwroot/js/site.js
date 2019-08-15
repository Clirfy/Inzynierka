// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

function confirmDelete(uniqueId, isDeleteClicked) {
    var deleteSpan = 'deleteSpan_' + uniqueId;
    var confirmDeleteSpan = 'confirmDeleteSpan_' + uniqueId;

    if (isDeleteClicked) {
        $('#' + deleteSpan).hide();
        $('#' + confirmDeleteSpan).show();
    } else {
        $('#' + deleteSpan).show();
        $('#' + confirmDeleteSpan).hide();
    }
}


// TODO fix js request type show swap script (AddRequestAdvert.cshtml)
function ChangeRequestType(swapper) {
    var passenger = 'passenger';
    var cargo = 'cargo';

    if (!swapper) {
        $('#' + cargo).hide();
        $('#' + passenger).show();
    } else {
        $('#' + passenger).hide();
        $('#' + cargo).show();
    }
}
