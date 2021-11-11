#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["PQS.DockerCourse.Web/PQS.DockerCourse.Web.csproj", "PQS.DockerCourse.Web/"]
COPY ["PQS.DockerCourse.Messaging/PQS.DockerCourse.Messaging.csproj", "PQS.DockerCourse.Messaging/"]
RUN dotnet restore "PQS.DockerCourse.Web/PQS.DockerCourse.Web.csproj"
COPY . .
WORKDIR "/src/PQS.DockerCourse.Web"
RUN dotnet build "PQS.DockerCourse.Web.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "PQS.DockerCourse.Web.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "PQS.DockerCourse.Web.dll"]