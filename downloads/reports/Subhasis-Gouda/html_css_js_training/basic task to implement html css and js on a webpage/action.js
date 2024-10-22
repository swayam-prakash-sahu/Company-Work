function showDateAndCalendar() {
    const currentDate = new Date();
    const dateOptions = { weekday: 'long', year: 'numeric', month: 'long', day: 'numeric' };
    const calendarOptions = { weekday: 'long', year: 'numeric', month: 'long', day: 'numeric', hour: 'numeric', minute: 'numeric', second: 'numeric' };

    const dateString = currentDate.toLocaleDateString(undefined, dateOptions);
    const calendarString = currentDate.toLocaleString(undefined, calendarOptions);

    console.log('Current Date:', dateString);
    console.log('Current Calendar:', calendarString);
}

