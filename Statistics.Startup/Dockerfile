FROM mcr.microsoft.com/dotnet/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /src
COPY ["Statistics.Startup/Statistics.Startup.csproj", "Statistics.Startup/"]
COPY ["Statistics.Web/Statistics.Web.csproj", "Statistics.Web/"]
COPY ["Common.Application/Core.Application.csproj", "Common.Application/"]
COPY ["Common.Domain/Core.Domain.csproj", "Common.Domain/"]
COPY ["Statistics.Application/Statistics.Application.csproj", "Statistics.Application/"]
COPY ["Statistics.Domain/Statistics.Domain.csproj", "Statistics.Domain/"]
COPY ["Core.Web/Core.Web.csproj", "Core.Web/"]
COPY ["Statistics.Infrastructure/Statistics.Infrastructure.csproj", "Statistics.Infrastructure/"]
COPY ["Common.Infrastructure/Core.Infrastructure.csproj", "Common.Infrastructure/"]
RUN dotnet restore "Statistics.Startup/Statistics.Startup.csproj"
COPY . .
WORKDIR "/src/Statistics.Startup"
RUN dotnet build "Statistics.Startup.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Statistics.Startup.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Statistics.Startup.dll"]