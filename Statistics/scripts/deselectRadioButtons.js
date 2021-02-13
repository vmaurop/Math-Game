
$(document).ready(function () {
    $('input[type=radio]').change(function () {
        if (this.checked) {
            $(this).closest('.question')
                .find('input[type=radio]').not(this)
                .prop('checked', false);
        }
    });
});
