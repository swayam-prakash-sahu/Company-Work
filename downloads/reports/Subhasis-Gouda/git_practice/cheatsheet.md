# This cheatsheet contains all about how to use git

## Basic commands to use the terminal

**Basic Directory Operations**
|**Command**| **use**|
|-----------|--------|
|**pwd**|Display the path of the current directory|
|**cd <destinatondirectory>**| changes the directory| 
|**cd ..**| to navigate to the parent directory|
|**ls**|To list all the directories|
|**ls -la**|To list the hidden directories|
|**mkdir <directory>**|Create a new folder "directory"|

**Basic File Operations**
|**Command**| **use**|
|-----------|--------|
|**touch <file>**|Creates a file|
|**rm <file>**|Delete the file|
|**rm -r<directory>**|Delete the directory|
|**mv <file><directory>**|To move the file|
|**mv <file-old><file-new>**|To rename a file|
|**cp <file><directory>**|To copy file to directory|
|**cp -r<directory1><directory2>**|To copy files from dir 1 to dir 2|

## Better to use these steps to initiate git 
<!--if you haven't initialised before-->
1. git init 
<!-- now add the url of your repository without using "[" "]"-->
2. git remote add origin [https://github.com/SubhasisGouda/reponame.git] (enter ur url)
<!-- here i have changed my branch to main from master -->
3. git checkout -b main
<!-- here i have fetched the main branch this basically checks the changes done on the online repository -->
4. git fetch origin main 
<!-- now i have merged the changes with my local repository -->
5. git merge origin/main
<!-- git pull can be used to insantly merge the changes -->
<!-- git pull is different from git merge it directly clones the changes of repository-->
6. git pull origin main [ skip 3 and 4 and use this ]
<!-- now add the files you want to add to the remote repository -->
7. git add . (to add the all the files)
<!-- use this if you want to stage a particular file -->
6. git add filename (to add specific file)
<!-- now commit the changes you have made and add an update message -->
8. git commit -m "message"
<!-- now push the changes to the remote repository-->
9. git push -u origin main

## To upload a file 
<!-- To update changes -->
1. git fetch origin main 
<!-- merge the changes with my local repository -->
2. git merge origin/main
<!-- to check the status -->
3. git status
<!-- now add the files you want to add to the remote repository -->
4. git add .
<!-- now commit the changes you have made and add an update message -->
5. git commit -m "message"
<!-- now push the changes to the remote repository-->
6. git push -u origin main