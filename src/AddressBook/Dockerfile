FROM microsoft/aspnetcore
WORKDIR /AddressBook
COPY . .
EXPOSE 5000
ENTRYPOINT ["dotnet", "AddressBook.dll", "--server.urls", "http://0.0.0.0:5000"]
