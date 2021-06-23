#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /src
COPY ["StockMarket.ManageStockExchange.Api/StockMarket.ManageStockExchange.Api.csproj", "StockMarket.ManageStockExchange.Api/"]
RUN dotnet restore "StockMarket.ManageStockExchange.Api/StockMarket.ManageStockExchange.Api.csproj"
COPY . .
WORKDIR "/src/StockMarket.ManageStockExchange.Api"
RUN dotnet build "StockMarket.ManageStockExchange.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "StockMarket.ManageStockExchange.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "StockMarket.ManageStockExchange.Api.dll"]