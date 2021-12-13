# https://hub.docker.com/_/microsoft-dotnet
FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /api

# copy csproj and restore as distinct layers
COPY ./. ./
WORKDIR /api/AS.webapi
RUN dotnet restore

RUN dotnet publish -c release -o /app --no-restore

# final stage/image
FROM mcr.microsoft.com/dotnet/aspnet:5.0
WORKDIR /
COPY --from=build /app ./
COPY --from=build /app ./

RUN useradd -m myappuser
USER myappuser

# Opção DEFUAL
# ENTRYPOINT ["dotnet", "AS.webapi.dll"]
# Opção utilizada pelo heroku
CMD ASPNETCORE_URLS=http://*:$PORT dotnet AS.webapi.dll