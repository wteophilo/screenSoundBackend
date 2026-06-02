FROM mcr.microsoft.com/dotnet/sdk:8.0
WORKDIR /App

# Copy everything else
COPY . ./

ENTRYPOINT ["dotnet", "run"]
