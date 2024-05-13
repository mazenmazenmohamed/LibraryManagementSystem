# Library Management System API Documentation
Introduction

Welcome to the documentation for the Library Management System API. 
This API allows librarians to manage books, patrons, and borrowing records.

Getting Started

Prerequisites:
Before running the application, ensure that you have the following installed:

.NET Core SDK (version X.X or later)
Visual Studio Code (optional but recommended) or any other code editor
Running the Application
Follow these steps to run the Library Management System API:

Clone the repository from GitHub:

bash:
Copy code
git clone https://github.com/your-repo/library-management-system.git
Navigate to the project directory:

bash:
Copy code
cd library-management-system
Open the project in your preferred code editor.

Set up the database connection string in the appsettings.json file:

json
Copy code
"ConnectionStrings": {
    "DefaultConnection": "YourConnectionStringHere"
}
Restore NuGet packages:

Copy code
dotnet restore
Run the application:

arduino
Copy code
dotnet run
The API will start running on http://localhost:5000 by default.

API Endpoints
The following endpoints are available in the API:

Books

GET /api/books: Retrieve a list of all books.
GET /api/books/{id}: Retrieve details of a specific book by ID.
POST /api/books: Add a new book to the library.
PUT /api/books/{id}: Update an existing book's information.
DELETE /api/books/{id}: Remove a book from the library.


Patrons

GET /api/patrons: Retrieve a list of all patrons.
GET /api/patrons/{id}: Retrieve details of a specific patron by ID.
POST /api/patrons: Add a new patron to the system.
PUT /api/patrons/{id}: Update an existing patron's information.
DELETE /api/patrons/{id}: Remove a patron from the system.


Borrowing

POST /api/borrow/{bookId}/patron/{patronId}: Allow a patron to borrow a book.
PUT /api/return/{bookId}/patron/{patronId}: Record the return of a borrowed book by a patron.
Interacting with the API
You can interact with the API using tools like Postman or curl. Here's how you can make requests to the API endpoints:

Example Requests
GET /api/books
Retrieve a list of all books:

bash
Copy code
GET http://localhost:5000/api/books
POST /api/books
Add a new book to the library:

bash
Copy code
POST http://localhost:5000/api/books

Body:
{
    "title": "Book Title",
    "author": "Author Name",
    "publicationYear": 2022,
    "isbn": "1234567890"
}
PUT /api/books/{id}
Update an existing book's information:

bash
Copy code
PUT http://localhost:5000/api/books/1

Body:
{
    "title": "Updated Title"
}
DELETE /api/books/{id}
Remove a book from the library:

bash
Copy code
DELETE http://localhost:5000/api/books/1

Conclusion
Congratulations! 
You've successfully learned how to run the Library Management System API and interact with its endpoints.
If you have any further questions or need assistance, feel free to reach out to the development team.