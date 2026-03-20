# Murrendy Converter

A lightweight Windows desktop currency converter built with **C# / WinForms (.NET 8)**.  
Real-time exchange rates powered by the free [Frankfurter API](https://www.frankfurter.app/).

![.NET 8](https://img.shields.io/badge/.NET-8.0-512BD4?style=flat-square&logo=dotnet)
![Platform](https://img.shields.io/badge/platform-Windows-0078D4?style=flat-square&logo=windows)
![License](https://img.shields.io/badge/license-MIT-green?style=flat-square)

---

## Screenshot

> _Add a screenshot here — `docs/screenshot.png`_

---

## Features

- 🌍 Fetches all available currencies from the Frankfurter API on startup
- 🔄 Swap button to instantly reverse the conversion direction
- ⚡ Async HTTP calls — UI never freezes during requests
- 🎨 Dark theme UI (GitHub-inspired color palette)

---

## Tech Stack

| Layer | Technology |
|---|---|
| Language | C# 12 |
| Framework | .NET 8 — WinForms |
| HTTP | `System.Net.Http.HttpClient` |
| JSON parsing | `Newtonsoft.Json` 13.0.4 |
| Exchange rates | [Frankfurter API](https://www.frankfurter.app/) (free, no key required) |

---

## Getting Started

### Prerequisites

- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- Windows (WinForms is Windows-only)

### Run locally

```bash
git clone https://github.com/YOUR_USERNAME/MurrendyConverter.git
cd MurrendyConverter
dotnet run
```

### Build for release

```bash
dotnet publish -c Release -r win-x64 --self-contained
```

Output will be in `bin/Release/net8.0-windows/win-x64/publish/`.

---

## How It Works

1. On load, the app calls `GET /currencies` to populate both dropdowns.
2. When the user clicks **Convert**, it calls `GET /latest?from={FROM}&to={TO}`.
3. The returned rate is multiplied by the input value and displayed.

```
User input  →  Frankfurter API  →  rate × value  →  result label
```

---

## Project Structure

```
MurrendyConverter/
├── Form1.cs              # UI logic & API calls
├── Form1.Designer.cs     # WinForms layout (dark theme)
├── Program.cs            # Entry point
├── RoundedButton.cs      # Custom control (WIP)
└── MurrendyConverter.csproj
```

---

## Known Limitations

- `decimal.Parse` uses the system locale — entering `1,000.00` vs `1.000,00` depends on the OS regional settings. Locale-aware parsing is planned.
- No offline/cache fallback if the API is unreachable.
- `RoundedButton` component is not yet implemented.

---

## Roadmap

- [ ] Locale-safe number input
- [ ] Conversion history panel
- [ ] Finish `RoundedButton` custom control
- [ ] Unit tests for `ConvertCurrency`

---

## License

MIT © Murrendy
