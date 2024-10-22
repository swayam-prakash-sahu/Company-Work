CREATE Table Appointment (appointment_id Int Primary key identity(1,1),
username varchar(20),dated date,contact varchar(10), timeslot time, userid int foreign key references users);


