FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["OpenFood.ApiGateway/OpenFood.ApiGateway.csproj", "OpenFood.ApiGateway/"]
RUN dotnet restore "OpenFood.ApiGateway/OpenFood.ApiGateway.csproj"
COPY . .
WORKDIR "/src/OpenFood.ApiGateway"
RUN dotnet build "OpenFood.ApiGateway.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "OpenFood.ApiGateway.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "OpenFood.ApiGateway.dll"]