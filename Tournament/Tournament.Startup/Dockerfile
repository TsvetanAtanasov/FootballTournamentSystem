#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /src
COPY ["Tournament/Tournament.Startup/Tournament.Startup.csproj", "Tournament/Tournament.Startup/"]
COPY ["Tournament/Tournament.Web/Tournament.Web.csproj", "Tournament/Tournament.Web/"]
COPY ["Core/Core.Application/Core.Application.csproj", "Core/Core.Application/"]
COPY ["Core/Core.Domain/Core.Domain.csproj", "Core/Core.Domain/"]
COPY ["Tournament/Tournament.Application/Tournament.Application.csproj", "Tournament/Tournament.Application/"]
COPY ["Tournament/Tournament.Domain/Tournament.Domain.csproj", "Tournament/Tournament.Domain/"]
COPY ["Core/Core.Web/Core.Web.csproj", "Core/Core.Web/"]
COPY ["Tournament/Tournament.Infrastructure/Tournament.Infrastructure.csproj", "Tournament/Tournament.Infrastructure/"]
COPY ["Core/Core.Infrastructure/Core.Infrastructure.csproj", "Core/Core.Infrastructure/"]
COPY ["Core.Identity/Core.Identity.csproj", "Core.Identity/"]
RUN dotnet restore "Tournament/Tournament.Startup/Tournament.Startup.csproj"
COPY . .
WORKDIR "/src/Tournament/Tournament.Startup"
RUN dotnet build "Tournament.Startup.csproj" -c Debug -o /app/build

FROM build AS publish
RUN dotnet publish "Tournament.Startup.csproj" -c Debug -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Tournament.Startup.dll"]