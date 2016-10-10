#!bin/bash
set -e
dotnet restore
dotnet build -c release
rm -rf $(pwd)/publish/web
dotnet publish -c release -o $(pwd)/publish/web

