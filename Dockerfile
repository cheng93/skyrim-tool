FROM microsoft/dotnet:2.1.300-preview2-sdk

WORKDIR /app

ADD ./src/Rpg.Server/bin/Release/netcoreapp2.0/publish /app

EXPOSE 8080

ENV ASPNETCORE_URLS http://*:8080

CMD dotnet Rpg.Server.dll