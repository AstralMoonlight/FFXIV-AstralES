# Publica una versión nueva de AstralES en el repositorio de Dalamud.
#
#   1. Sube <Version> en src/AstralES/AstralES.csproj (Dalamud solo actualiza si cambia).
#   2. powershell -File publish.ps1
#
# Compila en Release, regenera repo.json a partir del manifiesto empaquetado, sube los cambios
# y crea el release de GitHub con latest.zip.

$ErrorActionPreference = 'Stop'
Set-Location $PSScriptRoot

dotnet build src/AstralES/AstralES.csproj -c Release | Out-Host
if ($LASTEXITCODE -ne 0) { throw 'Falló la compilación.' }

$out = 'src/AstralES/bin/Release/AstralES'
$manifest = Get-Content "$out/AstralES.json" -Raw -Encoding UTF8 | ConvertFrom-Json
$tag = "v$($manifest.AssemblyVersion)"

if (git tag --list $tag) { throw "La versión $tag ya está publicada: sube <Version> en el .csproj." }

# Siempre el último release, así repo.json no tiene que cambiar el enlace en cada versión.
$zip = 'https://github.com/AstralMoonlight/FFXIV-AstralES/releases/latest/download/latest.zip'
$manifest | Add-Member DownloadLinkInstall $zip
$manifest | Add-Member DownloadLinkTesting $zip
$manifest | Add-Member DownloadLinkUpdate $zip
$manifest | Add-Member IsHide $false
$manifest | Add-Member IsTestingExclusive $false
$manifest | Add-Member LastUpdate ([DateTimeOffset]::UtcNow.ToUnixTimeSeconds())

$json = ConvertTo-Json -InputObject @($manifest) -Depth 5
[IO.File]::WriteAllText("$PSScriptRoot/repo.json", $json, (New-Object Text.UTF8Encoding $false))

git add -A
git commit -m "Publicar $tag"
git push
gh release create $tag "$out/latest.zip" --title "AstralES $tag" --notes "AstralES $tag"
