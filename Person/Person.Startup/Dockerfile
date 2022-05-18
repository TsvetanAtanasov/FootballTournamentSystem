#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /src
COPY ["Person/Person.Startup/Person.Startup.csproj", "Person/Person.Startup/"]
COPY ["Person/Person.Web/Person.Web.csproj", "Person/Person.Web/"]
COPY ["Core/Core.Application/Core.Application.csproj", "Core/Core.Application/"]
COPY ["Core/Core.Domain/Core.Domain.csproj", "Core/Core.Domain/"]
COPY ["Core/Core.Web/Core.Web.csproj", "Core/Core.Web/"]
COPY ["Person/Person.Application/Person.Application.csproj", "Person/Person.Application/"]
COPY ["Person/Person.Domain/Person.Domain.csproj", "Person/Person.Domain/"]
COPY ["Person/Person.Infrastructure/Person.Infrastructure.csproj", "Person/Person.Infrastructure/"]
COPY ["Core/Core.Infrastructure/Core.Infrastructure.csproj", "Core/Core.Infrastructure/"]
COPY ["Core.Identity/Core.Identity.csproj", "Core.Identity/"]
RUN dotnet restore "Person/Person.Startup/Person.Startup.csproj"
COPY . .
WORKDIR "/src/Person/Person.Startup"
RUN dotnet build "Person.Startup.csproj" -c Debug -o /app/build

FROM build AS publish
RUN dotnet publish "Person.Startup.csproj" -c Debug -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Person.Startup.dll"]