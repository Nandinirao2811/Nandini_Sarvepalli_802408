FROM mcr.microsoft.com/dotnet/core/aspnet:3.0-buster-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:3.0-buster AS build
WORKDIR /src
COPY ["MODTechnologyService/MODTechnologyService.csproj", "MODTechnologyService/"]
RUN dotnet restore "MODTechnologyService/MODTechnologyService.csproj"
COPY . .
WORKDIR "/src/MODTechnologyService"
RUN dotnet build "MODTechnologyService.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "MODTechnologyService.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MODTechnologyService.dll"]