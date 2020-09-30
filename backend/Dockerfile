FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS pre-build
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["./Thread .NET.BLL/Thread .NET.BLL.csproj", "/Thread .NET.BLL/"]
COPY ["./Thread .NET.Common/Thread .NET.Common.csproj", "/Thread .NET.Common/"]
COPY ["./Thread .NET.DAL/Thread .NET.DAL.csproj", "/Thread .NET.DAL/"]
COPY ["./Thread .NET.WebAPI/Thread .NET.WebAPI.csproj", "/Thread .NET.WebAPI/"]
RUN dotnet restore "/Thread .NET.WebAPI/Thread .NET.WebAPI.csproj"
COPY . .
WORKDIR "Thread .NET.WebAPI"
RUN dotnet build "Thread .NET.WebAPI.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Thread .NET.WebAPI.csproj" -c Release -o /app/publish

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1 as runner
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Thread .NET.WebAPI.dll"]