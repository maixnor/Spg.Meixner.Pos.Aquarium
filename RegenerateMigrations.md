
# Regenerate EF Core Migrations using dotnet CLI

### Problem

You created a new project and it came with SQLite out of the box. 
Now you want some other Provider (like Postgres) but the Migrations 
are not created for this Provider and will thus fail during runtime (very nasty).

### Solution

Regenerate the Migrations:

##### Install the tools

Either install or update the `dotnet-ef` tool.

`dotnet tool install --global dotnet-ef`

`dotnet tool update --global dotnet-ef`

Should the tool not be present afterwards in your shell then
your path setup is most likely not correct.

##### Ensure correct setup

Check if your migrations are correct by using:
`dotnet ef migrations list`.

Should a migration be missing you can set the current state by using:
`dotnet ef migrations add <NAME>`.

##### Remove all migrations

use `dotnet ef migrations remove` to remove all the migrations. 

#### Regenerate the migrations

use `dotnet ef migrations add <NAME>` to add a new migration. 
Sadly all previous migrations will be squashed into one.

##### Update the Database

By using `dotnet ef database update` you can update the database according to the migrations.
