run:
	dotnet run --project examples/RASharp.Examples.csproj

test:
	dotnet test

doc-gen:
	rm -rf docs/RASharp/api
	rm -rf docs/RASharp/_site
	docfx docs/RASharp/docfx.json

doc:
	rm -rf docs/RASharp/api
	rm -rf docs/RASharp/_site
	docfx docs/RASharp/docfx.json --serve