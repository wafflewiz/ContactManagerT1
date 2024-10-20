# Contact Manager

A simple MVC .NET application for managing contacts. This project allows users to create, read, update, and delete contact information, making it easy to keep track of personal or professional contacts.

## Features

- **Add New Contacts**: Easily input contact details including name, phone number, email, and address.
- **View Contacts**: Display a list of all saved contacts with quick access to details.
- **Edit Contacts**: Modify existing contact information.
- **Delete Contacts**: Remove contacts that are no longer needed.
- **Search Functionality**: Quickly find contacts by name or other criteria.

## Technologies Used

- **ASP.NET MVC**: Framework for building web applications.
- **Entity Framework**: ORM for database interactions.
- **SQL Server**: Database to store contact information.

## Project Wireframe

/ContactManagerT1
│
├── README.md                  # Overview of the project, installation, usage, etc.
├── LICENSE                    # Licensing information
├── .gitignore                 # Files and directories to ignore in Git
├── CONTRIBUTING.md            # Guidelines for contributing to the project
│
├── src                        # Source code for the application
│   ├── ContactManager         # Main project directory
│   │   ├── Controllers        # MVC controllers
│   │   │   └── ContactController.cs
│   │   ├── Models             # Data models
│   │   │   └── Contact.cs
│   │   ├── Views              # Views for MVC
│   │   │   ├── Contact        # Views related to contacts
│   │   │   │   ├── Index.cshtml
│   │   │   │   ├── Create.cshtml
│   │   │   │   ├── Edit.cshtml
│   │   │   │   └── Details.cshtml
│   │   │   └── Shared         # Shared views (e.g., layout)
│   │   │       └── _Layout.cshtml
│   │   ├── wwwroot            # Static files (CSS, JS, images)
│   │   │   ├── css
│   │   │   │   └── site.css
│   │   │   ├── js
│   │   │   │   └── scripts.js
│   │   │   └── images
│   │   └── appsettings.json    # Application settings
│   │
│   └── ContactManager.Tests    # Unit tests for the application
│       ├── ContactControllerTests.cs
│       └── ContactServiceTests.cs
│
└── docs                        # Documentation (optional)
    ├── user-manual.md         # User manual
    └── api-reference.md       # API reference documentation

