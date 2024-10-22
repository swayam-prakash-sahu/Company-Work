let accounts = [];
        function showLogin() 
        {
            document.getElementById("loginTab").style.display = "none";
            document.getElementById("loginForm").style.display = "block";
            document.getElementById("createAccountForm").style.display = "none";
        }
        function showCreateAccount() 
        {
            document.getElementById("loginTab").style.display = "none";
            document.getElementById("loginForm").style.display = "none";
            document.getElementById("createAccountForm").style.display = "block";
        }
        document.getElementById("loginForm").addEventListener("submit", function(event) 
        {
            event.preventDefault(); 
            let username = document.getElementById("username").value;
            let password = document.getElementById("password").value;
            var account = accounts.find(acc => acc.username === username && acc.password === password);
            if (account) { 
                window.location.href = "month.html";
            } else {
                alert("Invalid");
            }
        });
        document.getElementById("createAccountForm").addEventListener("submit", function(event) 
        {
            event.preventDefault(); 
            const newUsername = document.getElementById("newUsername").value;
            const newPassword = document.getElementById("newPassword").value;
            accounts.push({ username: newUsername, password: newPassword });
            alert("Account created successfully. Please login.");
            showLogin(); 
        });