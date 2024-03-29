FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["DemoIngresso.Api/DemoIngresso.Api.csproj", "DemoIngresso.Api/"]
COPY ["DemoIngresso.Domain/DemoIngresso.Domain.csproj", "DemoIngresso.Domain/"]
COPY ["DemoIngresso.Application/DemoIngresso.Application.csproj", "DemoIngresso.Application/"]
COPY ["DemoIngresso.Core/DemoIngresso.Core.csproj", "DemoIngresso.Core/"]
RUN dotnet restore "DemoIngresso.Api/DemoIngresso.Api.csproj"
COPY . .
WORKDIR "/src/DemoIngresso.Api"
RUN dotnet build "DemoIngresso.Api.csproj" -c Release -o /app/build
FROM build AS publish
RUN dotnet publish "DemoIngresso.Api.csproj" -c Release -o /app/publish
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "DemoIngresso.Api.dll"]
