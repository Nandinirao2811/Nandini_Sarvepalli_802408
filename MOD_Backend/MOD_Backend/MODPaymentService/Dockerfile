FROM mcr.microsoft.com/dotnet/core/aspnet:3.0-buster-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:3.0-buster AS build
WORKDIR /src
COPY ["MODPaymentService/MODPaymentService.csproj", "MODPaymentService/"]
RUN dotnet restore "MODPaymentService/MODPaymentService.csproj"
COPY . .
WORKDIR "/src/MODPaymentService"
RUN dotnet build "MODPaymentService.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "MODPaymentService.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MODPaymentService.dll"]