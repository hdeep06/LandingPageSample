# LandingPageSample
Subscription Form

This project solution consists of three projects, namely,

    ▪ Signup WebAPI

    ▪ DAL (Data Application Layer)

    ▪ Landing Page HTML (View)

Hence, it follows the best practice web application standards, i.e., MVC (Model-View-Controller).


► How to install a project,

  ▪ It can be directly pulled from the GitHub repository to the Visual Studio, i.e, clone the repository.

    ▫ Open Visual Studio.

    ▫ Select 'Clone a Repository'.

    ▫ From 'Browse a Repository' section, choose 'GitHub'.

    ▫ Enter the project URL, 'https://github.com/hdeep06/LandingPageSample'.

    ▫ Also, browse the local path where this repository needs to be cloned.

    ▫ Then, click 'Clone'.

    ▫ Wait until the project cloned successfully.

    ▫ Now, from 'Solution Explorer', select 'LandingPageSample' Solution.
  
   ▪ Alternatively, from GitHub

    ▫ Goto URL, 'https://github.com/hdeep06/LandingPageSample'

    ▫ Select 'Code', from dropdown Select 'Open in Visual Studio' or download as a zip.
  

► How to launch a project,

  ▪ Steps to be followed,

    ▫ After opening the solution, right-click on 'Solution' and select 'Properties'.

    ▫ In the 'Startup Project' section, select 'Multiple Startup Projects'. (*Note: These steps need to followed in order to run the complete project successfully.)

    ▫ Now, select 'Run' for 'LandingPage' and 'SigupAPI'.

    ▫ And, select 'None' for 'SampleDAL'.
  
  ▪ Configure the database
  
    ▫ From 'SampleDAL', open 'SampleDBContext.cs'

    ▫ Update line 8, optionsBuilder.UseSqlServer(@"Server=localhost; Database=Localdb; Trusted_Connection=true;");
      with the local machine sql configurations.

    ▫ For creating the 'Subscribers' table, use the query specified in the 'SQL Query' text file.
    
  ▪ Now, run the project.

► Project URLs,

     ▫ SignupAPI, 'http://localhost:59662/api/Signup' (to see the list of subscribers added in the database). 
       Alternatively, use Swagger to see a more detailed version of API, 'http://localhost:59662/swagger/index.html'

     ▫ LangingPage, 'http://localhost:59693/' or 'http://localhost:59693/index.html'
