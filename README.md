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

![Database Diagram](https://i.ibb.co/prvfc2JG/Screenshot-2025-04-22-155052.png)

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

## Environment Variables

To run this project, you will need to add the following environment variables

`ConnectionStrings__DefaultConnection`
