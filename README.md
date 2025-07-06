# JsonVisualizer – SkiaSharp Edition

Cross‑platform version that uses **SkiaSharp** (no System.Drawing).

## Prerequisites
* .NET 8 SDK
* On Windows everything else is bundled; on Linux/macOS SkiaSharp works out‑of‑the‑box.

## Build & Run
```bash
dotnet restore
dotnet run
```

After completion open:
* `Output/report.html`
* `Output/piechart.png`

## Notes
* SkiaSharp 2.88.6 (no known vulnerabilities).
* Rows < 100 hours are highlighted in the HTML report.