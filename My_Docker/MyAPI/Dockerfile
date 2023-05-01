FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["/MyAPI.csproj", "MyAPI/"]
RUN dotnet restore "MyAPI/MyAPI.csproj"
WORKDIR "/src/MyAPI"
COPY . .
RUN dotnet build "MyAPI.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "MyAPI.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MyAPI.dll"]
