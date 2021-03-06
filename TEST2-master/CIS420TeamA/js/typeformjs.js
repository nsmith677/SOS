﻿let physicianForm, nonphysicianForm, nonclinicalForm, interpreterForm, commentForm, referralForm;

window.addEventListener('DOMContentLoaded', function () {

    physicianForm = window.typeformEmbed.makePopup('https://savannahjames.typeform.com/to/i7DE5N', {
        hideHeaders: false,
        hideFooter: false
    });

    nonphysicianForm = window.typeformEmbed.makePopup('https://savannahjames.typeform.com/to/dx25pj', {
        hideHeaders: false,
        hideFooter: false
    });

    nonclinicalForm = window.typeformEmbed.makePopup('https://savannahjames.typeform.com/to/V8ayYJ', {
        hideHeaders: false,
        hideFooter: false
    });

    interpreterForm = window.typeformEmbed.makePopup('https://savannahjames.typeform.com/to/V6fiB1', {
        hideHeaders: false,
        hideFooter: false
    });

    commentForm = window.typeformEmbed.makePopup('https://savannahjames.typeform.com/to/e7fP9h', {
        hideHeaders: false,
        hideFooter: false
    });

    referralForm = window.typeformEmbed.makePopup('https://savannahjames.typeform.com/to/dONmAG', {
        hideHeaders: false,
        hideFooter: false
    });


    physicianFormHeader = window.typeformEmbed.makePopup('https://savannahjames.typeform.com/to/i7DE5N', {
        hideHeaders: false,
        hideFooter: false
    });

    nonphysicianFormHeader = window.typeformEmbed.makePopup('https://savannahjames.typeform.com/to/dx25pj', {
        hideHeaders: false,
        hideFooter: false
    });

    nonclinicalFormHeader = window.typeformEmbed.makePopup('https://savannahjames.typeform.com/to/V8ayYJ', {
        hideHeaders: false,
        hideFooter: false
    });

    interpreterFormHeader = window.typeformEmbed.makePopup('https://savannahjames.typeform.com/to/V6fiB1', {
        hideHeaders: false,
        hideFooter: false
    });

    commentFormHeader = window.typeformEmbed.makePopup('https://savannahjames.typeform.com/to/e7fP9h', {
        hideHeaders: false,
        hideFooter: false
    });

    referralFormHeader = window.typeformEmbed.makePopup('https://savannahjames.typeform.com/to/dONmAG', {
        hideHeaders: false,
        hideFooter: false
    });

})

document.getElementById('physicianForm').addEventListener('click', function () {
    physicianForm.open();
});

document.getElementById('nonphysicianForm').addEventListener('click', function () {
    nonphysicianForm.open();
});

document.getElementById('nonclinicalForm').addEventListener('click', function () {
    nonclinicalForm.open();
});

document.getElementById('interpreterForm').addEventListener('click', function () {
    interpreterForm.open();
});

document.getElementById('commentForm').addEventListener('click', function () {
    commentForm.open();
});

document.getElementById('referralForm').addEventListener('click', function () {
    referralForm.open();
});

document.getElementById('physicianFormHeader').addEventListener('click', function () {
    physicianForm.open();
});

document.getElementById('nonphysicianFormHeader').addEventListener('click', function () {
    nonphysicianForm.open();
});

document.getElementById('nonclinicalFormHeader').addEventListener('click', function () {
    nonclinicalForm.open();
});

document.getElementById('interpreterFormHeader').addEventListener('click', function () {
    interpreterForm.open();
});

document.getElementById('commentFormHeader').addEventListener('click', function () {
    commentForm.open();
});

document.getElementById('referralFormHeader').addEventListener('click', function () {
    referralForm.open();
});






