﻿// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

// show/ hide delete confirmation buttons
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


// for example: when cargo type checked - hide passenger options
function ChangeAdvertType(swapper) {

    switch (swapper) {
        case 1:
            $('#cargo').hide();
            $('#passenger').show();
            $('#passengerRadio').prop("checked", true);
            break;
        case 2:
            $('#passenger').hide();
            $('#cargo').show();
            $('#cargoRadio').prop("checked", true);
            break;
        default:
            $('#passenger').show();
            $('#cargo').show();
            $('#customRadio').prop("checked", true);
            break;
    }
}
