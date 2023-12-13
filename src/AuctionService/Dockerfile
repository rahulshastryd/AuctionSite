#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

#Depending on the operating system of the host machines(s) that will build or run the containers, the image specified in the FROM statement may need to be changed.
#For more information, please see https://aka.ms/containercompat

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /app
EXPOSE 80

# copy all .csproj files and restore as distinct layers. Use of the same COPY command
# for every dockerfile in the project to take advantage of docker caching

COPY Carsties.sln Carsties.sln
COPY AuctionService/AuctionService.csproj src/AuctionService/AuctionService.csproj
COPY SearchService/SearchService.csproj src/SearchService/SearchService.csproj.
COPY GatewayService/GatewayService.csproj src/GatewayService/GatewayService.csproj
COPY Contracts/Contracts.csproj src/Contracts/Contracts.csproj
COPY IdentityService/IdentityService.csproj src/IdentityService/IdentityService.csproj

# Restore package deps
RUN dotnet restore Carsties.sln

# Copy the app folders over
COPY AuctionService src/AuctionService
COPY Contracts src/Contracts
WORKDIR /app/src/AuctionService
RUN dotnet publish -c Release -o /app/src/out

#Build runtime image
FROM mcr.microsoft.com/dotnet/aspnet:7.0
WORKDIR /app
COPY --from=build /app/src/out .
ENTRYPOINT ["dotnet","AuctionService.dll"]