# Backward Sentences 🔄

A tiny C# /.NET 8 console program that reads **N** sentences and prints them back with the words in reverse order:

```
Input                               Output
-----                               ------
3                                   Case 1: red sit is This
This is sit red                     Case 2: foobar
foobar                              Case 3: base your all
all your base
```

The project was built as an interview technical‑assessment, demonstrating:

* **T‑D‑D**.
* **Light SOLID** – pure domain logic in `ReverseSentenceHelper`, UI helpers separated, no over‑engineering.
* **Unit tests** with xUnit.
* **Small, intention‑revealing Git commits**.

---

## 🛠 Prerequisites

| Tool | Minimum version | Notes |
|------|-----------------|-------|
| **Visual Studio 2022** | 17.10 (any edition) | Workloads: “.NET desktop development” & “ASP.NET and web” |
| **.NET SDK** | 8.0.x | Installed automatically with the workload |
| **Git** | any | VS has built‑in UI, or use CLI |

---

## 🚀 Quick start (Visual Studio 2022)

1. **Clone**  
   ```bash
   git clone https://github.com/your‑org/BackwardSentences.git
   cd BackwardSentences
   ```

2. **Open** `BackwardSentences.sln` in VS.

3. **Build & Test**  
   *Build* → *Rebuild Solution* (Ctrl‑Shift‑B)  
   *Test* → *Run All Tests* (Ctrl‑R, V) – you should see green ticks.

4. **Run**  
   *Debug* → *Start Without Debugging* (Ctrl‑F5).  
   Enter the number of sentences, then each sentence.  
   The program prints the results after all inputs are submitted.

---

## 🔍 Running from the CLI

```bash
# restore & test
dotnet test
```

---

## 📂 Project structure

```
|- BackwardSentences/        # console app (.NET 8)
|  └─ Program.cs             # banner, helpers, domain logic (single file)
|- BackwardSentences.Tests/  # xUnit tests
|  └─ ReverseSentenceTests.cs
|- README.md                 # you are here
```

---

## 🧪 Testing philosophy

| Level   | Tool  | Example cases |
|---------|-------|---------------|
| **Unit** | xUnit | happy path, single word, multiple spaces, empty string |
| Manual  | ‑‑    | console I/O validation, invalid number prompts |

The console helpers remain thin wrappers; deeper UI testing would inject `TextReader/TextWriter`, but that was unnecessary for the assessment scope.

---

## 🏗 Design notes

* **SRP** – `ReverseSentenceHelper` contains only reversal logic; UI helpers handle validation; `Program` orchestrates flow.
* **Open/Closed** – input/output sources are easily swapped by adjusting helpers.
* **No premature abstractions** – kept within a single `.cs` file to match assessment rules.

---

## ➕ Potential next steps

* Inject `TextReader/TextWriter` and add unit tests for UI helpers.
* Add BenchmarkDotNet benchmarks for alternative reversal strategies (`Span<char>`, manual parse).
* Package as a global `dotnet‑tool`.

---
