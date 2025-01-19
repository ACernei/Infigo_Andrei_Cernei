FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["CMSPlus.Presentation/CMSPlus.Presentation.csproj", "CMSPlus.Presentation/"]
COPY ["CMSPlus.Services/CMSPlus.Services.csproj", "CMSPlus.Services/"]
COPY ["CMSPlus.Domain/CMSPlus.Domain.csproj", "CMSPlus.Domain/"]
RUN dotnet restore "CMSPlus.Presentation/CMSPlus.Presentation.csproj"
COPY . .
WORKDIR "/src/CMSPlus.Presentation"
RUN dotnet build "CMSPlus.Presentation.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "CMSPlus.Presentation.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "CMSPlus.Presentation.dll"]
