#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0-buster-slim AS base
WORKDIR /app
EXPOSE 9000

FROM mcr.microsoft.com/dotnet/sdk:5.0-buster-slim AS build
WORKDIR /src
COPY ["Services/UserAPI/User.API/User.API.csproj", "Services/UserAPI/User.API/"]
COPY ["Services/UserAPI/User.API.Models/User.API.Models.csproj", "Services/UserAPI/User.API.Models/"]
COPY ["Services/UserAPI/User.API.Services/User.API.Services.csproj", "Services/UserAPI/User.API.Services/"]
COPY ["Services/UserAPI/User.API.Infrastructure/User.API.Infrastructure.csproj", "Services/UserAPI/User.API.Infrastructure/"]
RUN dotnet restore "Services/UserAPI/User.API/User.API.csproj"
COPY . .
WORKDIR "/src/Services/UserAPI/User.API"
RUN dotnet build "User.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "User.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "User.API.dll"]