# _Candyman: Pierre part III | an Epicodus Code Review_

#### By Zachary Green

#### _This project is a demonstration of using Many-to-Many Relationships in mySQL using Microsoft Entity Framework and handling User Authentication with Microsoft Indentity Framework. This project was possible under the guidance of Epicodus https://www.epicodus.com/_

## Technologies Used

* `C#`
* `Microsoft Entity Framework`
* `Microsoft Indentity Framework`
* `ASP.NET Core MVC`
* `Bootstrap`
* `CSS`

## Description

_Pierre wants to be able to create, edit, remove and view details about their treats on their shops and add treats to a list of flavors and viceversa. They want to be able to have user's login and look at what he has for sale, but he right to make changes to these items should be reserved for Pierre. Project uses CRUD (Create, Read, Update, Destroy) functionality for the Webpage's functionality. It also utilizes Microsoft Entity to build out a database in mySQL Server. User login and registration is handled by Microsoft Identity and stored into the database created in mySQL_

## Setup/Installation Requirements

<strong><em>Requirements for Running the Project in a Browser</em></strong>
#

Developer Note -- <em>You do not need to type in `$` into the terminal, the terminal starts with `$` on GitBash and `%` on Bash.</em>

* Visit https://github.com/Ultra-Zactimus/Pierre_Candy
* Clone this repository to your desktop.
* Navigate to the top level directory in your terminal.
* Run "$ `touch appsettings.json`"
* Run "$ `code .`" to open the project in VS Code. If you do not have VS Code please visit their website: https://code.visualstudio.com/
* Add in this code to the `appsettings.json` file inside `VS Code`:

  {
    "ConnectionStrings": {
        "DefaultConnection": "Server=localhost;Port=3306;database=zachary-a-green;uid=root;pwd=[YOUR-PASSWORD-HERE];"
    }
  }

* Create a gitignore file. Run "$ `touch .gitignore`" on the top level of the project.
* Inside of `VS Code` type in `appsettings.json` into the gitignore file. This will keep your password safe.
* Change the password to be whatever password you will want to use with SQL.


Developer Note -- <em>You do not need the square brackets around the password field in the appsettings.json file, they are included only to demonstate where the password needs to be.</em>

* Run "$ `dotnet add package Microsoft.EntityFrameworkCore -v 5.0.0`"
* Run "$ `dotnet add package Pomelo.EntityFrameworkCore.MySql -v 5.0.0-alpha.2`"
* Run "$ `dotnet add package Microsoft.EntityFrameworkCore.Proxies -v 5.0.0`"
* Run "$ `dotnet add package Microsoft.AspNetCore.Identity.EntityFrameworkCore -v 5.0.0`"
* Run "$ `dotnet restore`" to restore the bin and obj folders.
* Run "$ `dotnet tool install --global dotnet-ef --version 5.0.1`"
* Run "$ `dotnet build`" to build the project.
* Run "$ `dotnet ef migrations add Initial`"
* Run "$ `dotnet ef database update`"
* Run "$ `dotnet watch run`" to launch a LocalHost. Click on `LocalHost:5000`. You may have to hold Ctrl or Command when clicking it to get it to open in your internet broswer.


## Known Bugs

No known bugs at this time

## Stretch Goals

* I would like to have search functionality for the user.
* I would like to have floating text boxes for some of the information.
* It would be nice if the user name could be added to credentials and display instead of just the email.
* Would love to implement some of the stuff from the previous Pierre project so users could also buy things on the website, and maybe even have a table that could keep track of inventory.

## License

MIT

Copyright © 2022 Zachary Green