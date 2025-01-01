
$(document).ready(function () {
    let currentStep = 1;
    const totalSteps = 6;
    const steps = document.querySelectorAll('.step');
    const progressBar = document.getElementById('formProgress');
    const stepIndicators = document.querySelectorAll('.step-indicator');

    function validateEmail(email) {
        var pattern = /^[^\s@]+@[^\s@]+\.[^\s@]+$/;
        return pattern.test(email);
    }

    function validateUrl(url) {
        try {
            new URL(url);
            return true;
        } catch {
            return false;
        }
    }

    function updateProgress(step) {
        var progressPercentage = ((step - 1) / (totalSteps - 1)) * 100;
        progressBar.style.width = progressPercentage + '%';

        stepIndicators.forEach(function (indicator, index) {
            indicator.style.transition = 'all 0.3s ease-in-out';
            if (index + 1 < step) {
                indicator.classList.remove('btn-secondary');
                indicator.classList.add('btn-success');
                indicator.innerHTML = '<i class="bi bi-check-lg"></i>';
            } else if (index + 1 === step) {
                indicator.classList.remove('btn-secondary', 'btn-success');
                indicator.classList.add('btn-primary');
                indicator.textContent = index + 1;
            } else {
                indicator.classList.remove('btn-primary', 'btn-success');
                indicator.classList.add('btn-secondary');
                indicator.textContent = index + 1;
            }
        });
    }

    function validateStep(step) {
        var currentStepElement = steps[step - 1];
        var inputs = currentStepElement.querySelectorAll('input[required], select[required]');
        var isValid = true;
        var firstInvalid = null;

        inputs.forEach(function (input) {
            input.classList.remove('is-invalid', 'is-valid');

            if (!input.value.trim()) {
                input.classList.add('is-invalid');
                input.classList.add('shake');
                setTimeout(function () {
                    input.classList.remove('shake');
                }, 500);
                isValid = false;
                if (!firstInvalid) firstInvalid = input;
            } else {
                // Validate email fields
                if (input.type === 'email' && !validateEmail(input.value)) {
                    input.classList.add('is-invalid');
                    isValid = false;
                    if (!firstInvalid) firstInvalid = input;
                }
                // Validate URL fields
                else if (input.type === 'url' && !validateUrl(input.value)) {
                    input.classList.add('is-invalid');
                    isValid = false;
                    if (!firstInvalid) firstInvalid = input;
                }
                else {
                    input.classList.add('is-valid');
                }
            }
        });

        if (firstInvalid) {
            firstInvalid.focus();
        }

        return isValid;
    }

    function showStep(step) {
        if (step < 1 || step > totalSteps) return;

        // Validate the current step before moving to the next step
        if (step > currentStep) {
            if (!validateStep(currentStep)) {
                return;
            }
        }

        // Hide the current step
        steps[currentStep - 1].classList.add('fade-out');
        setTimeout(() => {
            steps[currentStep - 1].classList.remove('active');
            steps[currentStep - 1].style.display = 'none';
            steps[currentStep - 1].classList.remove('fade-out');

            // Show the new step
            currentStep = step;
            steps[currentStep - 1].style.display = 'block';
            steps[currentStep - 1].classList.add('active', 'fade-in');
            setTimeout(() => {
                steps[currentStep - 1].classList.remove('fade-in');
            }, 300);

            // Update progress bar and step indicators
            updateProgress(currentStep);

            // Scroll to the form smoothly
            $('#multiStepForm').get(0).scrollIntoView({
                behavior: 'smooth',
                block: 'start'
            });
        }, 300); // Delay for fade-out animation
    }


    // Event listeners
    $('[id^="next"]').on('click', function () {
        showStep(currentStep + 1);
    });

    $('[id^="prev"]').on('click', function () {
        showStep(currentStep - 1);
    });

    // Real-time validation
    $('input[required], select[required]').on('input', function () {
        var input = $(this);
        if (input.val().trim()) {
            input.removeClass('is-invalid').addClass('is-valid');

            if (input.attr('type') === 'email' && !validateEmail(input.val())) {
                input.removeClass('is-valid').addClass('is-invalid');
            }
            else if (input.attr('type') === 'url' && !validateUrl(input.val())) {
                input.removeClass('is-valid').addClass('is-invalid');
            }
        } else {
            input.removeClass('is-valid').addClass('is-invalid');
        }
    });

    // Form submission
    $('#multiStepForm').on('submit', function (e) {
        e.preventDefault();
        if (validateStep(currentStep)) {
            alert('Form submitted successfully!');
        }
    });

    // Initialize
    updateProgress(currentStep);
});


//const themeToggleBtn = document.getElementById('themeToggleBtn');
//const htmlElement = document.documentElement;

//themeToggleBtn.addEventListener('click', () => {
//    // Toggle between light and dark themes
//    if (htmlElement.getAttribute('data-bs-theme') === 'light') {
//        htmlElement.setAttribute('data-bs-theme', 'dark');
//        themeToggleBtn.textContent = 'Switch to Light Mode';
//    } else {
//        htmlElement.setAttribute('data-bs-theme', 'light');
//        themeToggleBtn.textContent = 'Switch to Dark Mode';
//    }
//});