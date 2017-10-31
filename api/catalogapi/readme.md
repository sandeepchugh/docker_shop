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
```

To shut down
```sh
docker-compose -f docker-compose.yml down
```
