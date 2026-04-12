# 🦕 Jurassic Park - Dinosaur Management System

A C# console application for managing and tracking dinosaurs across park zones and sectors, featuring ASCII art animations and an interactive multi-level menu system.
 
---

##  Table of Contents

- [Overview](#overview)
- [Features](#features)
- [Menu Structure](#menu-structure)
- [Animations](#animations)
- [Queries Available](#queries-available)
- [Getting Started](#getting-started)
- [Commit History](#commit-history)

---

## Overview

Jurassic Park Management System is a console-based application built in C# that allows park guardians to manage, consult, and track all registered dinosaurs. The system includes animated loading screens, a multi-level navigation menu, and a complete set of queries grouped by category.
 
---

## Features

- 🦕Multi-level interactive menu with submenus and back navigation
-  15 queries grouped into 3 categories
-  ASCII art animated loading screens for each action https://www.asciiart.eu/search?q=dinosaur&m=natural
-  Color-coded progress bars
-  Search by ID, registration code, zone, and sector
-  Statistics and scientific reports

---

## Animations

| Function | Trigger | ASCII | Bar Style |
|---|---|---|---|
| `Load()` | App startup | Dinosaur side view | `=` `>` `.` |
| `LoadSubmenu()` | Enter submenu | Gate / door | `#` `>` ` ` |
| `LoadExitSubmenu()` | Exit submenu | Simple figure | `=` `>` `.` |
| `LoadExitMain()` | Exit system | Large dinosaur | `█` `▓` `░` |

## Queries Available

###  General Consultations
- List all registered dinosaurs (general report)
- View dinosaur detail by ID (individual query)
- View dinosaur detail by registration code (email)
- List all dinosaurs from a specific park zone (city equivalent)
- List all dinosaurs from a park sector (country equivalent)

###  Filters & Searches
- List all dinosaurs older than a specific age
- List all dinosaurs of a specific type (carnivore/herbivore)
- View which dinosaurs have no tracking device (phone)
- View which dinosaurs have no registered location (address)
- List latest registered dinosaurs (ordered by creation date)
- List dinosaurs sorted alphabetically by species

###  Statistics & Reports
- Show full names and registration codes (for scientific reports)
- Count total dinosaurs registered in the system
- Count how many dinosaurs are in each zone
- Count how many dinosaurs are in each sector

---

## Getting Started

### Requirements

- .NET 9.0 or higher
- Compatible terminal with UTF-8 support for ASCII art

### Run

```bash
git clone https://github.com/EstelarRiwi/NeoGenesis.git
cd NeoGenesis
dotnet run
```
 
---