FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build

WORKDIR /src
COPY ["src/softtest.Web.Host/softtest.Web.Host.csproj", "src/softtest.Web.Host/"]
COPY ["src/softtest.Web.Core/softtest.Web.Core.csproj", "src/softtest.Web.Core/"]
COPY ["src/softtest.Application/softtest.Application.csproj", "src/softtest.Application/"]
COPY ["src/softtest.Core/softtest.Core.csproj", "src/softtest.Core/"]
COPY ["src/softtest.EntityFrameworkCore/softtest.EntityFrameworkCore.csproj", "src/softtest.EntityFrameworkCore/"]
WORKDIR "/src/src/softtest.Web.Host"
RUN dotnet restore 

WORKDIR /src
COPY ["src/softtest.Web.Host", "src/softtest.Web.Host"]
COPY ["src/softtest.Web.Core", "src/softtest.Web.Core"]
COPY ["src/softtest.Application", "src/softtest.Application"]
COPY ["src/softtest.Core", "src/softtest.Core"]
COPY ["src/softtest.EntityFrameworkCore", "src/softtest.EntityFrameworkCore"]
WORKDIR "/src/src/softtest.Web.Host"
RUN dotnet publish -c Release -o /publish --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:8.0
EXPOSE 80
WORKDIR /app
COPY --from=build /publish .
ENTRYPOINT ["dotnet", "softtest.Web.Host.dll"]
