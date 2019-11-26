FROM mcr.microsoft.com/dotnet/core/aspnet:3.0-buster-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:3.0-buster AS build
WORKDIR /src
COPY ["MODUserService/MODUserService.csproj", "MODUserService/"]
RUN dotnet restore "MODUserService/MODUserService.csproj"
COPY . .
WORKDIR "/src/MODUserService"
RUN dotnet build "MODUserService.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "MODUserService.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MODUserService.dll"]