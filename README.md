# 🧾 Goods Receipt — وصل استلام البضائع

A desktop application for creating, managing, and printing goods receipts. Built with **C# / .NET 8 WinForms** and **SQLite**, designed for Arabic RTL environments with IQD currency support.

---

## ✨ Features

- **Receipt Creation** — Add items manually or from a saved product catalog, with quantity and unit price inputs
- **Product Catalog** — Maintain a reusable product database with default prices
- **Receipt History** — Browse, search, and reprint past receipts
- **Smart Printing** — Auto-detects paper size and adapts layout:
  - 📄 **A4** — Full-page tabular layout
  - 🖨️ **80mm Thermal** — Compact receipt format
  - 🖨️ **58mm Thermal** — Ultra-compact receipt format
- **Print Preview** — Preview receipts before printing with zoom support
- **Multi-Copy Printing** — Configure 1–5 copies per print (defaults to 2)
- **Printer Persistence** — Remembers your last selected printer between sessions
- **Company Settings** — Configure company name, address, and phone number for receipt headers
- **Arabic RTL** — Full right-to-left interface and print layout
- **IQD Currency** — Iraqi Dinar formatting throughout

---

## 🛠️ Tech Stack

| Component       | Technology                              |
| --------------- | --------------------------------------- |
| **Framework**   | .NET 8 (Windows Forms)                  |
| **Language**     | C# 12                                  |
| **Database**     | SQLite via EF Core 8                   |
| **Printing**     | System.Drawing.Printing (PrintDocument)|
| **Platform**     | Windows x64                            |

---

## 📦 Prerequisites

- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0) (for building from source)
- Windows 10/11

---

## 🚀 Getting Started

### Option 1: Run from Source

```bash
# Clone the repository
git clone https://github.com/hisham2630/Goods-Receipt.git
cd Goods-Receipt

# Restore dependencies & run
dotnet restore
dotnet run
```

### Option 2: Published Executable

A self-contained executable is available in the [`publish/`](publish/) folder. No .NET SDK required — just download and run `GoodsReceipt.exe`.

---

## 🏗️ Project Structure

```
GoodsReceipt/
├── Program.cs                          # Application entry point
├── GoodsReceipt.csproj                 # Project configuration (.NET 8)
│
├── Data/
│   ├── AppDbContext.cs                 # EF Core SQLite context
│   └── DatabaseInitializer.cs          # Database seeding & migrations
│
├── Models/
│   ├── Receipt.cs                      # Receipt header (number, customer, date, total)
│   ├── ReceiptItem.cs                  # Receipt line items (product, qty, price, subtotal)
│   ├── Product.cs                      # Product catalog entries
│   └── AppSettings.cs                  # Persisted application settings
│
├── Services/
│   ├── PrintEngine.cs                  # Core print logic with paper auto-detection
│   ├── ReceiptService.cs               # Receipt CRUD operations
│   ├── ProductService.cs               # Product catalog CRUD operations
│   └── SettingsService.cs              # Application settings management
│
└── Forms/
    ├── MainForm.cs / .Designer.cs      # Main receipt entry form
    ├── SettingsForm.cs / .Designer.cs   # Company info configuration
    ├── ProductCatalogForm.cs / .Designer.cs  # Product catalog management
    └── ReceiptHistoryForm.cs / .Designer.cs  # Receipt history & reprint
```

---

## 🖨️ How Printing Works

The `PrintEngine` automatically detects the selected printer's paper width:

| Paper Width      | Detected As     | Layout                          |
| ---------------- | --------------- | ------------------------------- |
| **< 65mm**       | 58mm Thermal    | Ultra-compact, minimal margins  |
| **65mm – 100mm** | 80mm Thermal    | Compact receipt format          |
| **> 100mm**      | A4              | Full-page with table borders    |

All layouts include:
- Company header (name, address, phone)
- Receipt number and date
- Itemized table (product, quantity, unit price, subtotal)
- Grand total in IQD

---

## 📸 Usage

1. **Launch** the app → Main receipt form opens in Arabic RTL
2. **Add items** — Select from the product catalog dropdown or type a product name, set quantity and price, then click **Add**
3. **Preview** — Click the preview button to see how the receipt will look on your selected printer
4. **Print** — Select your printer, set copy count, and print
5. **History** — Access past receipts to view or reprint them

---

## ⚙️ Configuration

On first launch, a SQLite database (`goodsreceipt.db`) is created automatically. Use the **Settings** form to configure:

- 🏢 Company Name
- 📍 Company Address
- 📞 Phone Number

These values appear in the header of every printed receipt.

---

## 📄 License

This project is provided as-is for personal and commercial use.

---

## 🤝 Contributing

Contributions are welcome! Feel free to open issues or submit pull requests.

1. Fork the repository
2. Create a feature branch (`git checkout -b feature/my-feature`)
3. Commit your changes (`git commit -m 'Add my feature'`)
4. Push to the branch (`git push origin feature/my-feature`)
5. Open a Pull Request
