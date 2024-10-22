let currentMonthOffset = 0;

function changeMonth(offset) {
    currentMonthOffset += offset;
    renderCalendar();
}

function jumpToDate() {
    const jumpToDateInput = document.getElementById('jumpToDate');
    const selectedDate = new Date(jumpToDateInput.value);
    const currentDate = new Date();
    currentMonthOffset = (selectedDate.getMonth() - currentDate.getMonth()) + (12 * (selectedDate.getFullYear() - currentDate.getFullYear()));
    renderCalendar();
}
function renderCalendar() {
    const monthNameElement = document.getElementById('monthName');
    const yearNameElement = document.getElementById('yearName');
    const weekContainer = document.getElementById('weekContainer');
    const currentDate = new Date();
    currentDate.setMonth(currentDate.getMonth() + currentMonthOffset);
    currentDate.setDate(1); // Set to the first day of the month to ensure correct weekday calculation
    const currentYear = currentDate.getFullYear();
    const currentMonth = currentDate.getMonth();
    const daysInMonth = new Date(currentYear, currentMonth + 1, 0).getDate();
    let startingDay = currentDate.getDay(); // Starting day of the week (0 - Sunday, 1 - Monday, ..., 6 - Saturday)

    // Adjust the starting day to be one day behind
    startingDay = (startingDay === 0) ? 6 : startingDay - 1;

    monthNameElement.textContent = currentDate.toLocaleString('default', { month: 'long' });
    yearNameElement.textContent = currentYear;
    weekContainer.innerHTML = '';

    const weeks = Math.ceil((daysInMonth + startingDay) / 7);
    const daysInWeek = 7;

    let dayCounter = 1;
    for (let i = 0; i < weeks; i++) {
        const tr = document.createElement('tr');
        weekContainer.appendChild(tr);

        for (let j = 0; j < daysInWeek; j++) {
            const td = document.createElement('td');
            td.className = 'w5';
            tr.appendChild(td);

            if (i === 0 && j < startingDay) {
                td.textContent = '-';
            } else if (dayCounter <= daysInMonth) {
                const textarea = document.createElement('textarea');
                textarea.placeholder = 'Enter your plans here';
                textarea.name = `day ${dayCounter}`;
                textarea.id = `w${dayCounter}`;
                textarea.cols = 12;
                textarea.rows = 6;
                td.appendChild(textarea);

                const br = document.createElement('br');
                td.appendChild(br);

                const textNode = document.createTextNode(dayCounter);
                td.appendChild(textNode);

                dayCounter++;
            } else {
                td.textContent = '-';
            }
        }
    }
}

renderCalendar();