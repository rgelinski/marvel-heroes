FROM mcr.microsoft.com/dotnet/core/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build
WORKDIR /src
COPY ["MarvelBackend/MarvelBackend.csproj", "MarvelBackend/"]

RUN dotnet restore "MarvelBackend/MarvelBackend.csproj"
COPY . .
WORKDIR "/src/MarvelBackend"
RUN dotnet build "MarvelBackend.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "MarvelBackend.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MarvelBackend.dll"]