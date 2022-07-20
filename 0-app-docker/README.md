
1. To implement business logic of CurrentTime.com, we can create `TimeController.cs`
```CS
    [Route("api/time")]
    public class TimeController : Controller
    {
        [HttpGet]
        public ActionResult Get()
        {
            return Ok(new
            {
                Version = "V1",
                Time = DatTime.Now.ToString()
            });
        }
    }
```

2. Since we know nothing about the hosting environment, we can consider container as a host agnostic environment where containers could have become a lightweight VM replacement. This will satisfy the **portability** requirement
The benefit of containers, once we have tested our containerized application we can deploy it to any other system where Container Engine (e.g. Docker) is running and we can be sure that our application will perform exactly as it did when we tested it.

Create `Dockerfile` for our application, an example of Dockefile can be taken from https://docs.docker.com/samples/dotnetcore/. Make sure you create a new application and copy TimeController.cs to your application

```diff
FROM mcr.microsoft.com/dotnet/sdk:3.1 AS builder

WORKDIR /app
+ RUN dotnet new webapi
+ COPY TimeController.cs Controllers

RUN dotnet restore
RUN dotnet publish -c Release -o out
```

3. To build the first version of application, we can use the following command

`docker build -t time-server-api:1.0 .`

4. Let's run the application and test it. http://localhost:30080/api/time

`docker run -d -p 30080:80 --name time-server-api-container time-server-api:1.0`

5. After initial build, we get a feature request to add server time zone. Let's make a changes in `TimeController.cs`

```diff
-                Version = "V1",
-                Time = DateTime.Now.ToString()
+                Version = "V2",
+                Time = DatTime.Now.ToString(),
+                TimeZone = TimeZoneInfo.Local.DisplayName
```

When the application change is made we can build the application with new version

`docker build -t time-server-api:2.0 .`

6. Delete previous running container and run the new version of the application. http://localhost:30080/api/time

`docker run -d -p 30080:80 --name time-server-api-container time-server-api:2.0`

7. Application won't start automatically if by a reason container stops

`docker stop $(docker ps -q)`



## Results
- [x] Application is working
- [x] Portable. We can run application on any host that has Docker Engine
- [ ] No self healing
- [ ] Not scalable
- [ ] Manual deployment only