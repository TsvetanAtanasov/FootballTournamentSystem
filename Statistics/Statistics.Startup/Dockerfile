#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /src
COPY ["Statistics/Statistics.Startup/Statistics.Startup.csproj", "Statistics/Statistics.Startup/"]
COPY ["Statistics/Statistics.Web/Statistics.Web.csproj", "Statistics/Statistics.Web/"]
COPY ["Core/Core.Application/Core.Application.csproj", "Core/Core.Application/"]
COPY ["Core/Core.Domain/Core.Domain.csproj", "Core/Core.Domain/"]
COPY ["Core/Core.Web/Core.Web.csproj", "Core/Core.Web/"]
COPY ["Statistics/Statistics.Application/Statistics.Application.csproj", "Statistics/Statistics.Application/"]
COPY ["Statistics/Statistics.Domain/Statistics.Domain.csproj", "Statistics/Statistics.Domain/"]
COPY ["Statistics/Statistics.Infrastructure/Statistics.Infrastructure.csproj", "Statistics/Statistics.Infrastructure/"]
COPY ["Core/Core.Infrastructure/Core.Infrastructure.csproj", "Core/Core.Infrastructure/"]
COPY ["Core/Core.Identity/Core.Identity.csproj", "Core/Core.Identity/"]
RUN dotnet restore "Statistics/Statistics.Startup/Statistics.Startup.csproj"
COPY . .
WORKDIR "/src/Statistics/Statistics.Startup"
RUN dotnet build "Statistics.Startup.csproj" -c Debug -o /app/build

FROM build AS publish
RUN dotnet publish "Statistics.Startup.csproj" -c Debug -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Statistics.Startup.dll"]