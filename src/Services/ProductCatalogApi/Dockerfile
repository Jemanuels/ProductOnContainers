﻿FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build-env

WORKDIR /code

# Copy csproj and restore as distinct layer
COPY *.csproj ./
RUN dotnet restore

#Copy everything else and build
COPY . ./
RUN  dotnet publish -c Release -o out

# Build runtime image
FROM mcr.microsoft.com/dotnet/core/aspnet:3.1
WORKDIR /code
COPY --from=build-env /code/out .
ENTRYPOINT ["dotnet", "ProductCatalogApi.dll"]