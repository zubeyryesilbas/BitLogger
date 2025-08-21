# 📝 BITLogger

A simple and flexible **colored logging system** for Unity.  
With `BITLogger`, you can print logs in different colors, add custom headers, and keep your console output organized.  

---

## ✨ Features
- 🎨 Colored logs (supports multiple predefined colors)
- 🏷️ Optional headers (e.g. `[NETWORK]`, `[GAMEPLAY]`)
- ⚠️ Warning & ❌ Error log wrappers
- 🔧 Easy to extend

---

## 📦 Installation
Simply add the `BITLogger.cs` file into your Unity project (e.g. `Assets/Scripts/Utilities/Logging/`).

---

## 🚀 Usage

### Basic Log
```csharp
BITLogger.Log("Player connected", BITLogger.LogColor.Green);
