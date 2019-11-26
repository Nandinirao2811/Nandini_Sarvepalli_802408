FROM mcr.microsoft.com/dotnet/core/aspnet:3.0-buster-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:3.0-buster AS build
WORKDIR /src
COPY ["MODAuthenticateService/MODAuthenticateService.csproj", "MODAuthenticateService/"]
RUN dotnet restore "MODAuthenticateService/MODAuthenticateService.csproj"
COPY . .
WORKDIR "/src/MODAuthenticateService"
RUN dotnet build "MODAuthenticateService.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "MODAuthenticateService.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MODAuthenticateService.dll"]