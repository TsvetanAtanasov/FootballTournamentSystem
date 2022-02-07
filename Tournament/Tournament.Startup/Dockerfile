FROM mcr.microsoft.com/dotnet/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /src
COPY ["Tournament.Startup/Tournament.Startup.csproj", "Tournament.Startup/"]
COPY ["Tournament.Web/Tournament.Web.csproj", "Tournament.Web/"]
COPY ["Tournament.Application/Tournament.Application.csproj", "Tournament.Application/"]
COPY ["Tournament.Domain/Tournament.Domain.csproj", "Tournament.Domain/"]
COPY ["Common.Domain/Core.Domain.csproj", "Common.Domain/"]
COPY ["Common.Application/Core.Application.csproj", "Common.Application/"]
COPY ["Core.Web/Core.Web.csproj", "Core.Web/"]
COPY ["Tournament.Infrastructure/Tournament.Infrastructure.csproj", "Tournament.Infrastructure/"]
COPY ["Common.Infrastructure/Core.Infrastructure.csproj", "Common.Infrastructure/"]
RUN dotnet restore "Tournament.Startup/Tournament.Startup.csproj"
COPY . .
WORKDIR "/src/Tournament.Startup"
RUN dotnet build "Tournament.Startup.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Tournament.Startup.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Tournament.Startup.dll"]