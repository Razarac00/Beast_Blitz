# FROM mcr.microsoft.com/dotnet/core/aspnet:2.2 AS base
# WORKDIR /app
# EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:2.2 AS buildstage
WORKDIR /src
COPY ["Beast_Blitz.Client/Beast_Blitz.Client.csproj", "Beast_Blitz.Client/"]
RUN dotnet restore Beast_Blitz.Client/Beast_Blitz.Client.csproj
COPY . .
WORKDIR /src/Beast_Blitz.Client
RUN dotnet build Beast_Blitz.Client.csproj

FROM buildstage AS publish
RUN dotnet publish Beast_Blitz.Client.csproj --no-restore -c Release -o /app

FROM mcr.microsoft.com/dotnet/core/aspnet:2.2
WORKDIR /deploy
COPY --from=publish /app .
CMD [ "dotnet", "Beast_Blitz.Client.dll" ]