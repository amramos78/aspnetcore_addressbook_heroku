#!bin/bash
set -e
dotnet restore
rm -rf $(pwd)/publish/web
dotnet publish -c release -o $(pwd)/publish/web

