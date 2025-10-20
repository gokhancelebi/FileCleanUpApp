# 🧹 FileCleanupApp

A lightweight C# console utility that scans a given folder and deletes files older than a specified number of days.  
Useful for cleaning up logs, temporary files, or cache directories automatically.

---

## 🚀 Features

- Delete files older than a configurable number of days  
- Accepts **named CLI arguments** (e.g. `--folder`, `--days`)  
- Safe and simple — shows detailed console output  
- Easily extendable with additional flags (e.g. `--dry-run`, `--ext`, `--include-subfolders`)

---

## 🛠️ Requirements

- [.NET SDK 9.0+](https://dotnet.microsoft.com/download)
- Windows, Linux, or macOS terminal

---

## 📦 Setup

Clone this repository and navigate to the project folder:

```bash
git clone https://github.com/gokhancelebi/FileCleanupApp.git
cd FileCleanupApp
