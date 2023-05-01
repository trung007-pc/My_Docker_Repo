FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["/My_Docker.csproj", "My_Docker/"]
RUN dotnet restore "My_Docker/My_Docker.csproj"

WORKDIR "/src/My_Docker"
COPY . .
RUN dotnet build "My_Docker.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "My_Docker.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "My_Docker.dll"]
