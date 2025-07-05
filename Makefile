run:
	dotnet run --project examples/RASharp.Examples.csproj

test:
	dotnet test

doc:
	docfx docs/RASharp/docfx.json --serve