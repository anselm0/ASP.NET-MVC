FROM microsoft/dotnet:2.2-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/dotnet:2.2-sdk AS build
WORKDIR /src
COPY EComm.Web/EComm.Web.csproj EComm.Web/
COPY EComm.DataAccess/EComm.DataAccess.csproj EComm.DataAccess/
COPY EComm.Model/EComm.Model.csproj EComm.Model/
RUN dotnet restore EComm.Web/EComm.Web.csproj
COPY . .
WORKDIR /src/EComm.Web
RUN dotnet build EComm.Web.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish EComm.Web.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "EComm.Web.dll"]
