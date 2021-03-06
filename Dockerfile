FROM microsoft/dotnet:2.1.3-aspnetcore-runtime-alpine

WORKDIR /app

ADD ./src/Rpg.Server/bin/Release/netcoreapp2.1/publish /app

EXPOSE 8080

ENV ASPNETCORE_URLS http://*:8080

CMD dotnet Rpg.Server.dll