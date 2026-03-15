# Project structure
```bash
WinFormsApp/            <-- Project root
├─ Core/             <-- Core engine logic
├─ Input/            <-- Input simulation
├─ Scripting/        <-- Script parsing and command definitions
├─ Execution/        <-- Macro runner / execution engine
├─ GUI/              <-- WinForms forms, controls, UI logic
├─ Utils/            <-- Helpers, logging, configuration, common utilities
├─ Scripts/          <-- user scripts, contains examples too
├─ Resources/        <-- Images, icons, embedded assets if need be, probably not
├─ WinFormsApp.csproj   <-- Project file
├─ Program.cs        <-- Entry point starts WinForms app
```