FROM mcr.microsoft.com/dotnet/sdk:6.0 AS builder

WORKDIR /app
RUN dotnet new webapi
COPY TimeController.cs Controllers

RUN dotnet publish -c Release -o out

# Build runtime image
FROM mcr.microsoft.com/dotnet/aspnet:6.0 as runtime
WORKDIR /app
COPY --from=builder /app/out .
ENTRYPOINT ["dotnet", "app.dll"]
