#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

# Copy the certificate file to the Docker container
COPY ["certs/aspnetapp.pfx", "/https/aspnetapp.pfx"]

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["ExxerIoT.UI.Web/ExxerIoT.UI.Web.csproj", "ExxerIoT.UI.Web/"]
RUN dotnet restore "ExxerIoT.UI.Web/ExxerIoT.UI.Web.csproj"
COPY . .
WORKDIR "/src/ExxerIoT.UI.Web"
RUN dotnet build "ExxerIoT.UI.Web.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ExxerIoT.UI.Web.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ExxerIoT.UI.Web.dll"]
