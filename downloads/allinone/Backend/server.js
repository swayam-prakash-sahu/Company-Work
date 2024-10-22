const express = require("express");
const nodemailer = require("nodemailer");
const sql = require("mssql");
var bodyParser = require("body-parser");
require("dotenv").config();
const cors = require("cors");

const app = express();
app.use(cors());

app.use(bodyParser.urlencoded({ extended: false }));
app.use(bodyParser.json());

//Connection String
const pool = {
  user: "sa",
  password: "sa",
  server: "IN-7TH3NX3",
  database: "userdata",
  options: {
    encrypt: true,
    trustServerCertificate: true,
  },
};

//Email config
let config = {
  host: "smtp.gmail.com",
  port: 587,
  auth: {
    user: "dev.ashwinalexander@gmail.com",
    pass: "fsqxginpqingrcnn",
  },
};

let transporter = nodemailer.createTransport(config);
transporter.verify().then(console.log).catch(console.error);

app.get("/", (re, res) => {
  return res.json("From BAckend Side");
});

async function executeSelect(query) {
  try {
    console.log(query);
    await sql.connect(pool);
    console.log("Connected to SQL Server");

    const result = await sql.query(query);
    console.log("Result : ", result);

    await sql.close();
    console.log("Connection closed");
    return result.recordsets[0];
  } catch (error) {
    console.error("Error:", error.message);
  }
}

async function executeQuery(query) {
  try {
    console.log(query);
    await sql.connect(pool);
    console.log("Connected to SQL Server");

    const result = await sql.query(query);
    console.log("Result : ", result);

    await sql.close();
    console.log("Connection closed");
    return { affectedRows: result.rowsAffected[0] };
  } catch (error) {
    console.error("Error:", error.message);
  }
}

app.get("/users", async (req, res) => {
  const result = await executeSelect("select * from users");
  return res.status(201).json(result);
});

app.post("/login", async (req, res) => {
  const result = await executeSelect(
    "SELECT top 1 * from users where username='" +
    req.body.username +
    "' and password='" +
    req.body.password +
    "'"
  );
  return res.status(201).json(result);
});

app.post("/saveuser", async (req, res) => {
  console.log(req.body);
  const result = await executeQuery(
    "insert into users (username,email,password,verify) values ('" +
    req.body.username +
    "','" +
    req.body.email +
    "','" +
    req.body.password +
    "',0);"
  );
  return res.status(201).json(result);
});




app.post("/verifyuser", async (req, res) => {
  console.log(req.body);
  const result = await executeQuery(
    "Update users set verify = 1 where userid = " + req.body.userid + ";"
  );
  console.log(result);
  if (result.affectedRows <= 0) {
    return res.json(result);
  } else {
    let message = {
      from: "avinash.kumar2@gmail.com",
      to: req.body.email,
      subject: "Welcome to ABC Website!",
      html:
        "<b>Your Email is Verified !!! <br>" +
        "username : " +
        req.body.username +
        "<br>password : " +
        req.body.password +
        "<br><a href='http://localhost:4200/login' target='_blank'> Login</a>" +
        " </br>",
    };
    transporter
      .sendMail(message)
      .then((info) => {
        return res.status(201).json({
          msg: "Email sent",
          info: info.messageId,
          preview: nodemailer.getTestMessageUrl(info),
        });
      })
      .catch((err) => {
        return res.status(500).json({ msg: err });
      });
  }
});


//book appointment 
// Endpoint for users to book appointments
app.post("/book-appointment", async (req, res) => {
  try {
    const { userID, appointmentTime } = req.body;
    console.log(userID, appointmentTime);
    const result = await executeQuery(
      `INSERT INTO Appointments (UserID, AppointmentTime, Accept) 
       VALUES (${userID},'${appointmentTime}', 0)`
    );
    return res.status(201).json({ success: true, message: "Appointment booked successfully" });
  } catch (error) {
    console.error("Error:", error.message);
    return res.status(500).json({ success: false, error: error.message });
  }
});

// Endpoint for the doctor to view booked appointments
app.get("/get-appointments", async (req, res) => {
  try {
    const result = await executeSelect(
      ` SELECT a.AppointmentID,u.username,u.email,a.appointmentTime,a.Accept FROM users u inner join Appointments a on u.userid=a.userId`
    );
    return res.status(200).json(result);
  } catch (error) {
    console.error("Error:", error.message);
    return res.status(500).json({ error: error.message });
  }
});


app.post("/acceptAppointment", async (req, res) => {
  console.log(req.body);
  const result = await executeQuery(
    "Update appointments set accept = 1 where appointmentId = " + req.body.appointmentId + ";"
  );
  console.log(result);
  if (result.affectedRows <= 0) {
    return res.json(result);
  } else {
    let message = {
      from: "avinash.kumar2@gmail.com",
      to: req.body.email,
      subject: "Welcome to Doctor Website!",
      html:
        "<b>Your Appointment is Confirmed !!! <br>" +
        "username : " +
        req.body.username +
        "<br>Appointment Time : " +
        req.body.appointmenttime +
        "<br><a href='http://localhost:4200/login' target='_blank'> Login</a>" +
        " </br>",
    };
    transporter
      .sendMail(message)
      .then((info) => {
        return res.status(201).json({
          msg: "Email sent",
          info: info.messageId,
          preview: nodemailer.getTestMessageUrl(info),
        });
      })
      .catch((err) => {
        return res.status(500).json({ msg: err });
      });
  }
});


app.listen(8081, () => {
  console.log("listening");
});
