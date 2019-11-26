FROM mcr.microsoft.com/dotnet/core/aspnet:3.0-buster-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:3.0-buster AS build
WORKDIR /src
COPY ["MODAPIGateway/MODAPIGateway.csproj", "MODAPIGateway/"]
RUN dotnet restore "MODAPIGateway/MODAPIGateway.csproj"
COPY . .
WORKDIR "/src/MODAPIGateway"
RUN dotnet build "MODAPIGateway.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "MODAPIGateway.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MODAPIGateway.dll"]