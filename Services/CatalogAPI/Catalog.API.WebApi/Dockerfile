#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0-buster-slim AS base
WORKDIR /app
EXPOSE 9002

FROM mcr.microsoft.com/dotnet/sdk:5.0-buster-slim AS build
WORKDIR /src
COPY ["Services/CatalogAPI/Catalog.API.WebApi/Catalog.API.WebApi.csproj", "Services/CatalogAPI/Catalog.API.WebApi/"]
COPY ["Services/CatalogAPI/Catalog.API.Application/Catalog.API.Application.csproj", "Services/CatalogAPI/Catalog.API.Application/"]
COPY ["Services/CatalogAPI/Catalog.API.Domain/Catalog.API.Domain.csproj", "Services/CatalogAPI/Catalog.API.Domain/"]
COPY ["Services/CatalogAPI/Catalog.API.Persistence/Catalog.API.Persistence.csproj", "Services/CatalogAPI/Catalog.API.Persistence/"]
RUN dotnet restore "Services/CatalogAPI/Catalog.API.WebApi/Catalog.API.WebApi.csproj"
COPY . .
WORKDIR "/src/Services/CatalogAPI/Catalog.API.WebApi"
RUN dotnet build "Catalog.API.WebApi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Catalog.API.WebApi.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Catalog.API.WebApi.dll"]