![icon_logo](https://github.com/varun-FSDeveloper/BTreeFlight/assets/153975508/7b010aed-1466-46e3-8636-891bf59dcb25)



An employee management system written in ASP.NET MVC using C#, HTML, CSS, and JavaScript. This is the BTree project for the .NET Programming BootCamp with ASP.NET and JavaScript.

#### Project Video: [Watch on Youtube](https://www.youtube.com/channel/UC3CWkAYRbqUFLq6wQF-VyPw)
#### Live Demo : [Click Here](http://54.175.64.42:8000/)

<img alt="flight" src="https://github.com/user-attachments/assets/56ae4829-5487-4b5a-8e97-fb36c2234adc">
<br/>
<img alt="flight" src="https://github.com/user-attachments/assets/8bd6b459-5398-42e5-9a38-ef674eeed55c">

# Employee Management System

## Features
1. Create, Update, and Delete an Employee's details.
2. View single employee details as well as all records for employees.
3. Webpages are mobile responsive.
4. As-you-type search functionality.

## Files & Directories

### Project Directory: `Employee`

- **Properties**: Contains project properties and settings files.
- **References**: Contains references to other projects and libraries.
- **App_Data**: Contains application data files.
- **App_Start**
  - `BundleConfig.cs`: Handles the bundling of CSS and JavaScript files.
  - `FilterConfig.cs`: Handles the configuration of global filters.
  - `RouteConfig.cs`: Handles the routing configuration of the application.
- **Content**: Contains all CSS files for styling the webpages.
- **Controllers**: Contains all controllers.
  - `HomeController.cs`: Main controller handling the homepage and other general pages.
  - `EmployeeController.cs`: Controller handling employee-related actions.
- **Fonts**: Contains font files used in the application.
- **Models**: Contains all the models used in the application.
  - `EmployeeModel.cs`: Model containing employee details properties.
- **Scripts**: Contains all JavaScript files used in the application.
- **Views**: Contains all application views.
  - **Employee**: Contains employee controller views.
    - `Index.cshtml`: View for displaying all employees.
    - `Details.cshtml`: View for displaying a single employee's details.
    - `Create.cshtml`: View for creating a new employee.
    - `Edit.cshtml`: View for editing an existing employee.
    - `Delete.cshtml`: View for deleting an employee.
  - **Home**: Contains home controller views.
    - `About.cshtml`: View for the About page.
    - `Contact.cshtml`: View for the Contact page.
    - `Index.cshtml`: View for the homepage.
  - **Shared**: Contains common layout views.
    - `_Layout.cshtml`: Main layout view.
    - `Error.cshtml`: View for displaying error messages.
- `_ViewStart.cshtml`: Specifies the layout for the views.
- `Web.config`: Contains the configuration settings for the web application.
- `Global.asax`: Handles application-level events.
- `Packages.config`: Contains all the NuGet packages that need to be installed to run this web application.

## Justification

1. Mobile responsive webpages.
2. More complex models.
3. More interactive because webpages use AJAX functionality (e.g., fetch) written in JavaScript.
4. Provides create, update, delete, and search functionalities for employee records.

## Installation

- Install .NET Core SDK from here manually.
- Install project dependencies by running dotnet restore in the project directory.
- Run the command dotnet ef migrations add InitialCreate and dotnet ef database update in the project directory to make and apply migrations.
- Create an administrator account using a custom script or directly within the application.
- Run the command dotnet run to run the web server.
- Open a web browser and go to https://localhost:5001 URL to start using the web application.

### Our Other Social Platforms

- ![Untitled design (9)](https://github.com/varun-FSDeveloper/BTreeFlight/assets/153975508/33ae95e1-c4d7-47d3-a160-90a6f060896b) Youtube - https://bit.ly/Youtubebtree
- ![icon_logo](https://github.com/varun-FSDeveloper/BTreeFlight/assets/153975508/948141f8-8cdc-4ef1-9615-0fb06cd35574) Instagram - https://bit.ly/Instagrambtree 
- ![Untitled design (10)](https://github.com/varun-FSDeveloper/BTreeFlight/assets/153975508/51189b66-5f75-43fc-a992-dca4805152a0) Facebook - https://bit.ly/btreefacebookpage 
- ![Untitled design (11)](https://github.com/varun-FSDeveloper/BTreeFlight/assets/153975508/0177cf07-7034-41fb-a41c-e292b2eea000) LinkedIn - https://bit.ly/Linkedinbtree 
- ![Untitled design (13)](https://github.com/varun-FSDeveloper/BTreeFlight/assets/153975508/81b02b10-6291-4aeb-8f14-d3f296f2698b) Twitter - https://bit.ly/Twitterbtree 

 Your Dev - Varun👍🏻
