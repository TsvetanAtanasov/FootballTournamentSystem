FROM mcr.microsoft.com/dotnet/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /src
COPY ["Person.Startup/Person.Startup.csproj", "Person.Startup/"]
COPY ["Person.Web/Person.Web.csproj", "Person.Web/"]
COPY ["Common.Application/Core.Application.csproj", "Common.Application/"]
COPY ["Common.Domain/Core.Domain.csproj", "Common.Domain/"]
COPY ["Person.Application/Person.Application.csproj", "Person.Application/"]
COPY ["Person.Domain/Person.Domain.csproj", "Person.Domain/"]
COPY ["Core.Web/Core.Web.csproj", "Core.Web/"]
COPY ["Person.Infrastructure/Person.Infrastructure.csproj", "Person.Infrastructure/"]
COPY ["Common.Infrastructure/Core.Infrastructure.csproj", "Common.Infrastructure/"]
RUN dotnet restore "Person.Startup/Person.Startup.csproj"
COPY . .
WORKDIR "/src/Person.Startup"
RUN dotnet build "Person.Startup.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Person.Startup.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Person.Startup.dll"]