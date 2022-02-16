#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /src
COPY ["FootballTournamentSystem.Identity/FootballTournamentSystem.Identity.csproj", "FootballTournamentSystem.Identity/"]
COPY ["Core/Core.Infrastructure/Core.Infrastructure.csproj", "Core/Core.Infrastructure/"]
COPY ["Core.Identity/Core.Identity.csproj", "Core.Identity/"]
COPY ["Core/Core.Application/Core.Application.csproj", "Core/Core.Application/"]
COPY ["Core/Core.Domain/Core.Domain.csproj", "Core/Core.Domain/"]
COPY ["Core/Core.Web/Core.Web.csproj", "Core/Core.Web/"]
RUN dotnet restore "FootballTournamentSystem.Identity/FootballTournamentSystem.Identity.csproj"
COPY . .
WORKDIR "/src/FootballTournamentSystem.Identity"
RUN dotnet build "FootballTournamentSystem.Identity.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "FootballTournamentSystem.Identity.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "FootballTournamentSystem.Identity.dll"]