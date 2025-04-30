# Bug Ticketing System

The Bug Ticketing System is a web application that helps teams manage bugs and issues in software projects. It enables users (Managers, Developers, and Testers) to track, report, and resolve bugs effectively. The system allows users to create, view, and manage bugs, handle user accounts, and manage attachments related to bugs.

## Key Components:

1. Users: Each user (Manager, Developer, Tester) can have multiple roles and may be assigned to various bugs.
2. Projects: Each project contains multiple bugs, but each bug belongs to one specific project.
3. Bugs: Bugs can have multiple assignees and attachments (like images).
4. Attachments: Each attachment is linked to a specific bug.

## ERD

![ERD](https://i.ibb.co/TBM77dXw/Untitled-Diagram.png)

## Database Diagram

![Database Diagram](https://i.ibb.co/c4DtHyy/Screenshot-2025-04-28-234151.png)

## API Reference

#### User Management:

- Register User: Create a new user account.

```http
  POST /api/users/register
```

- Login User: Authenticate user and provide a token.

```http
  POST /api/users/login
```

#### Project Management

- Create Project: **Managers only** can add a new project.

```http
 POST /api/projects
```

- Get All Projects: List all projects.

```http
 GET /api/projects
```

- Get Project Details: View specific project information and bugs.

```http
 GET /api/projects/:id
```

#### Bug Management

- Create Bug: **Tester only** can report a new bug.

```http
  POST /api/bugs
```

- Get All Bugs: List all bugs.

```http
  GET /api/bugs
```
- Get Bug Details: View detailed info on a specific bug.

```http
  GET /api/bugs/:id
```
#### User-Bug Relationships: 

- Assign User to Bug:**Managers only** can assign a user to a bug and assignees must be **Developer only**. 

```http
  POST /api/bugs/:id/assignees 
```
#### File Management: 
- Upload Attachment:**Developers only** can add an attachment to a bug.

```http
  POST /api/bugs/:id/attachments
```
## Environment Variables

To run this project, you will need to add the following environment variables

`ConnectionStrings__DefaultConnection`
`JWT__SecretKey`

## Tech Stack

- ASP .Net Core API
- SQL Server
- Entity Framework
- JWT
- LINQ
- FluentValidation
