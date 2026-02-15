.PHONY: run build clean

run:
	dotnet run --project src/DesignPatterns.ConsoleApp/DesignPatterns.ConsoleApp.csproj

build:
	dotnet build

clean:
	dotnet clean
