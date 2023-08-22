# School App .NET Backend Task

This repository contains the backend day task for our onboarding process. It's a simple School App API that currently has the teacher model implemented. Your task is to work on implementing the student model, which involves basic CRUD operations.

## Getting Started

Follow these instructions to set up your development environment:

### Prerequisites

Before you begin, ensure you have the following installed:

- .NET SDK: Follow the steps in the [Hello World Tutorial](https://dotnet.microsoft.com/en-us/learn/dotnet/hello-world-tutorial/intro) to install and set up .NET.

- PostgreSQL: Follow the steps outlined in the [Prisma PostgreSQL Setup Guide](https://www.prisma.io/dataguide/postgresql/setting-up-a-local-postgresql-database) to install and configure PostgreSQL.

### Setting Up PostgreSQL and Creating a Database

#### For Linux:

1. **Install PostgreSQL**: If you haven't already, you can install PostgreSQL on Linux using the following commands (for Ubuntu):

   ```bash
   sudo apt update
   sudo apt install postgresql postgresql-contrib
   ```

2. **Start PostgreSQL**: After installation, start the PostgreSQL service:

   ```bash
   sudo service postgresql start
   ```

3. **Create a Database User**: By default, PostgreSQL creates a user called `postgres`. You can switch to this user and create a new database user with the following commands:

   ```bash
   sudo -i -u postgres
   createuser --interactive
   ```

   Follow the prompts to create a new user.

4. **Create a Database**: Still as the `postgres` user, you can create a new database:

   ```bash
   createdb your_database_name
   ```

#### For Windows:

1. **Download and Install PostgreSQL**: Download the PostgreSQL installer for Windows from the [official website](https://www.postgresql.org/download/windows/), and follow the installation instructions.

2. **Start PostgreSQL**: After installation, start the PostgreSQL service from the Windows Services Manager, or it might start automatically.

3. **Create a Database User**: By default, PostgreSQL creates a user called `postgres`. You can open the SQL Shell (psql) from the Start menu and run the following command to create a new user:

   ```sql
   CREATE ROLE your_username WITH LOGIN PASSWORD 'your_password';
   ```

   Replace `your_username` and `your_password` with your desired username and password.

4. **Create a Database**: In the SQL Shell, you can create a new database:

   ```sql
   CREATE DATABASE your_database_name;
   ```

   Replace `your_database_name` with the desired name of your database.

### Update Connection String

After creating the database, you'll need to update the connection string in your application's configuration to point to your PostgreSQL database. Locate the connection string in your project (typically in the `appsettings.json` or `appsettings.Development.json` file) and modify it like this:

```json
"DefaultConnection": "Host=localhost;Port=5432;Database=your_database_name;Username=your_username;Password=your_password;"
```

- `Host`: Use `localhost` if your PostgreSQL server is running locally.
- `Port`: Default PostgreSQL port is 5432.
- `Database`: Replace with the name of the database you created.
- `Username`: Replace with the username you created.
- `Password`: Replace with the password for the username.


### Optional: Use SQLite (In-memory)

If you encounter issues with PostgreSQL installation or prefer an in-memory database, you can use SQLite by switching to the `In_memory` branch of this repository. SQLite is a self-contained, serverless, and zero-configuration SQL database engine.

### Managing Packages

In case you encounter issues with package installation or need to manually install a package, you have a couple of options:

1. **Visual Studio**: Install the "NuGet Gallery" extension if you're using Visual Studio. Follow the instructions to get the desired package.

2. **Command Line (Terminal)**: You can also use the command line to install packages. Run the following command to add a package. For instance, to add the SQLite package, use:

   ```shell
   dotnet add package Microsoft.EntityFrameworkCore.Sqlite
   ```

   Please note that most of the required packages should already be set up in this project. Manually installing packages is only necessary if you encounter any issues.

## Your Task

Your task is to implement the student model in the School App API, including basic CRUD (Create, Read, Update, Delete) operations. You can start by forking this repository and working on your solution.

Feel free to reach out if you have any questions or encounter any difficulties during the task. 
