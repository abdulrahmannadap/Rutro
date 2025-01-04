$(document).ready(function () {
    $('#theme-toggle').click(function () {

        var themeAtt = $('html').attr('data-bs-theme');

        if (themeAtt === 'dark') {
            $('html').attr('data-bs-theme', 'white');
            $('.nav-link').addClass('text-dark');
            $('#test').addClass('text-dark');
            $('.bi').removeClass('bi-brightness-high-fill').addClass('bi-moon-stars');
            $('#theme-toggle').removeClass('btn-light').addClass('btn-dark');

        }
        else if (themeAtt === 'white') {

            $('html').attr('data-bs-theme', 'dark');
            $('.nav-link').removeClass('text-dark');
            $('#test').removeClass('text-dark');
            $('.bi').removeClass('bi-moon-stars').addClass('bi-brightness-high-fill');
            $('#theme-toggle').removeClass('btn-dark').addClass('btn-light');
        }
    });
});
