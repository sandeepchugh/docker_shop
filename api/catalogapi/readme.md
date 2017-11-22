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

## Note
As the docker file expects the source to copy the code from - "obj/Docker/publish", create a new folder publish profile in visual studio with the Target location as "obj/Docker/publish" and publish the code before running docker-compose build and up 
