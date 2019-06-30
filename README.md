# PremiumApp

Please note that below technologies are mainly used to develop the solution.
 1. Angular 6
 2. .net core MVC
 3. Web API


The code is checkedin the below git repo.

https://github.com/jebs01/PremiumApp

To avoid any potential issue with git sync, I have also zipped the file
and shared below.

https://drive.google.com/drive/folders/1HVM_rrhyEOshOj_XEF0gu_8C6Dq0iElZ?usp=sharing

In order to review & run the code, download the zip file from above and follow the below instructions.


How to run the code.

1. Download the zip file and unzip to local drive.
   You would see below folder heirarchy on unzipping.
     PremiumApp
       - PremiumApp-SPA (FrontEnd)
       - PremiumApp.API (BackEnd)

2. Open the folder - PremiumApp  in VS code. Menu-> File-> OpenFolder
3. Go to Menu -> View -> Terminal
4. Execute the below command in terminal to change directory to frontend tier directory 
      cd PremiumApp-SPA 
5. Execute the below command to run web tier and confirm you get
   success message on screen - compiled successfully. Please wait for few seconds to load.
        ng serve 

6. Open a new terminal by clicking + on the top right side of terminal window
   and change directory to backend tier directory 
        cd PremiumApp.API       

7. Execute the below command to run service tier and confirm you get
   message on screen - Now listening. Please wait for few seconds to load.
    dotnet run
    

8. Open the url - http://localhost:4200/

