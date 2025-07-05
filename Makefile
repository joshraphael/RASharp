run:
	dotnet run --project examples/RASharp.Examples.csproj

test:
	dotnet test

doc-gen:
	rm -rf docs/api
	rm -rf docs/_site
	docfx docs/docfx.json

doc:
	rm -rf docs/api
	rm -rf docs/_site
	docfx docs/docfx.json --serve