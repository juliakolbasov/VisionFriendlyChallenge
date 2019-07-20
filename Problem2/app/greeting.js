

$(document).ready(function () {
    $.validator.addMethod("verifyInput", function (value) {
        return value.length > 0 ? /^[a-zA-Z]+$/i.test(value) : true;
    }, "Please use alphabetical symbols only!");

    $('#sign_in').validate({
        rules: {
            firstname: { verifyInput: true },
            lastname: { verifyInput: true },
        },
    });
}); // end ready


function formSubmit() {
    if (!$('#sign_in').valid()) return false;

    result.style.visibility = 'visible'
    if (firstname.value.length == 0 && lastname.value.length == 0) {
        result.innerHTML = `<h4 >At least one of the fields must be filled. </h4>`;
        result.classList.add("alert-danger");
        result.classList.remove("alert-success");
        firstname.focus();
    }
    else {
        result.innerHTML = `<h4 >Your name is <strong> ${firstname.value} ${lastname.value} </strong></h4>`;
        result.classList.add("alert-success");
        result.classList.remove("alert-danger");
    }
    return false;
}

