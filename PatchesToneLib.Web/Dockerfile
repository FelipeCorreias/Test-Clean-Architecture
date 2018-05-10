FROM microsoft/aspnetcore-build:2.0

WORKDIR /app

COPY . .

CMD ASPNETCORE_URLS=http://*:$PORT dotnet PatchesToneLib.Web.dll