FROM microsoft/dotnet:2.1.300-preview1-sdk

WORKDIR /app

ADD . /app

EXPOSE 8080

ENV ASPNETCORE_URLS http://*:8080

CMD [ "dotnet", "run", "--project",  "src/Rpg.Server/Rpg.Server.csproj", "-c", "Release" ]