FROM microsoft/dotnet:2.1.300-preview2-sdk-alpine

WORKDIR /app

ADD . /app

EXPOSE 8080

ENV ASPNETCORE_URLS http://*:8080

RUN dotnet build src/Rpg.Server/Rpg.Server.csproj -c Release

CMD [ "dotnet", "run", "--project",  "src/Rpg.Server/Rpg.Server.csproj", "-c", "Release", "--no-build" ]