# Catalog API

Catalog microservice developed using C#/ASP.NET core and hosted in a docker linux container.

### Prerequisites
- Windows 10
- Hyper-V 
- Docker for Windows community edition -  https://store.docker.com/editions/community/docker-ce-desktop-windows 

### Debugging (Docker)
- Set the Docker-Compose project as the startup project
- Press F5 or the green play button in Visual Studio to launch the debugger and run the code in the docker container.

### Debugging (IIS Express)
- Set the CatalogApi project as the startup project
- Press F5 or the green play button in Visual Studio to launch the application in IIS debug mode

### Command Line
Go to the folder containing the solution and docker compose files

```sh
docker-compose -f docker-compose.yml build
docker-compose -f docker-compose.yml -d up

// Load balanced containers - use the scale property to increase number of container instances
docker-compose -f docker-compose.yml up --scale catalogapi=3
```

To shut down
```sh
docker-compose -f docker-compose.yml down
```

# Database

## Sql Server
To setup the Sql Server database, update the connection string in CatalogApi.Database.SqlServer and point to a valid Sql Server instance. Run the Catalogapi.Database.SqlServer project in visual studio or the exe and it will setup the database

## MySql
To setup the mysql database, change connection string to point to a valid mysql server and run the Catalogapi.Database.MySql project in visual studio or the exe to setup the database

Alternatively, you can run the mysql in a container. Run the following docker compose file before running the Catalogapi.Database.MySql and leave the connection string in the project as is
```sh
docker-compose -f docker-compose-mysql.yml build
docker-compose -f docker-compose-mysql.yml -d up
```

## Note
As the docker file expects the source to copy the code from - "obj/Docker/publish", create a new folder publish profile in visual studio with the Target location as "obj/Docker/publish" and publish the code before running docker-compose build and up 
