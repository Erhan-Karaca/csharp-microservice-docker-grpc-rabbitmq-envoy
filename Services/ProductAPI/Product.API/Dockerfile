#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0-buster-slim AS base
WORKDIR /app
EXPOSE 9001

FROM mcr.microsoft.com/dotnet/sdk:5.0-buster-slim AS build
WORKDIR /src
COPY ["Services/ProductAPI/Product.API/Product.API.csproj", "Services/ProductAPI/Product.API/"]
COPY ["Services/ProductAPI/Product.API.Infrastructure/Product.API.Infrastructure.csproj", "Services/ProductAPI/Product.API.Infrastructure/"]
COPY ["Services/ProductAPI/Product.API.Models/Product.API.Models.csproj", "Services/ProductAPI/Product.API.Models/"]
COPY ["Services/ProductAPI/Product.API.Services/Product.API.Services.csproj", "Services/ProductAPI/Product.API.Services/"]
RUN dotnet restore "Services/ProductAPI/Product.API/Product.API.csproj"
COPY . .
WORKDIR "/src/Services/ProductAPI/Product.API"
RUN dotnet build "Product.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Product.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Product.API.dll"]