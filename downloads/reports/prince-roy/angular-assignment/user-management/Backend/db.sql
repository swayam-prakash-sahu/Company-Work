Create Database userdata;


create table users (
userid int NOT NULL IDENTITY(1,1),
username varchar(500),
email varchar(500),
verify bit,
password varchar(50),
PRIMARY KEY (userid)
);
