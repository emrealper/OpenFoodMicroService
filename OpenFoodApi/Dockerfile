#FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
#WORKDIR /app
#EXPOSE 80
#
#FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
#WORKDIR /src
#COPY ["OpenFoodApi/OpenFoodApi.csproj", "OpenFoodApi/"]
#COPY ["OpenFood.Application/OpenFood.Application.csproj", "OpenFood.Application/"]
#COPY ["OpenFood.Domain/OpenFood.Domain.csproj", "OpenFood.Domain/"]
#COPY ["OpenFood.Infrastructure/OpenFood.Infrastructure.csproj", "OpenFood.Infrastructure/"]
#RUN dotnet restore "OpenFoodApi/OpenFoodApi.csproj"
#COPY . .
#WORKDIR "/src/OpenFoodApi"
#RUN dotnet build "OpenFoodApi.csproj" -c Release -o /app/build
#
#FROM build AS publish
#RUN dotnet publish "OpenFoodApi.csproj" -c Release -o /app/publish
#
#FROM base AS final
#WORKDIR /app
#COPY --from=publish /app/publish .
#ENTRYPOINT ["dotnet", "OpenFoodApi.dll"]


FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
COPY  . .
ENV ASPNETCORE_URLS http://*:5000
EXPOSE 5000
ENTRYPOINT ["dotnet", "OpenFoodApi.dll"]