#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
RUN apt-get update -yq \
    && apt-get install curl gnupg -yq \
    && curl -sL https://deb.nodesource.com/setup_14.x | bash \
    && apt-get install nodejs -yq
WORKDIR /src
COPY ["CityHall.Web/CityHall.Web.csproj", "CityHall.Web/"]
RUN dotnet restore "CityHall.Web/CityHall.Web.csproj"
COPY . .
WORKDIR "/src/CityHall.Web"
RUN dotnet build "CityHall.Web.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "CityHall.Web.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "CityHall.Web.dll"]
