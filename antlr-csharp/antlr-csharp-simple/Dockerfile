FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["antlr-csharp-simple/antlr-csharp-simple.csproj", "antlr-csharp-simple/"]
RUN dotnet restore "antlr-csharp-simple/antlr-csharp-simple.csproj"
COPY . .
WORKDIR "/src/antlr-csharp-simple"
RUN dotnet build "antlr-csharp-simple.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "antlr-csharp-simple.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "antlr-csharp-simple.dll"]
