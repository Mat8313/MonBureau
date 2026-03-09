# 🖥️ MonBureau

Une application de bureau développée en **C#** avec le framework **Avalonia UI**, suivant le pattern architectural **MVVM** (Model-View-ViewModel).

## 📋 Description

MonBureau est une application desktop multiplateforme construite avec Avalonia UI. Elle propose une interface graphique moderne et est structurée selon les bonnes pratiques du développement C# avec une séparation claire entre la logique métier et l'interface utilisateur.

## 🛠️ Technologies utilisées

- **Langage** : C# (.NET)
- **Framework UI** : [Avalonia UI](https://avaloniaui.net/)
- **Architecture** : MVVM (Model-View-ViewModel)
- **IDE recommandé** : Visual Studio 2022 / Visual Studio Code

## 📁 Structure du projet

```
MonBureau/
├── Assets/          # Ressources statiques (polices, icônes...)
├── Images/          # Images utilisées dans l'application
├── Videos/          # Vidéos intégrées à l'application
├── ViewModels/      # Logique métier et binding (MVVM)
├── Views/           # Interfaces graphiques (.axaml)
├── App.axaml        # Point d'entrée de l'interface
├── App.axaml.cs     # Code-behind de l'application
├── Program.cs       # Point d'entrée du programme
└── ViewLocator.cs   # Résolution automatique des vues
```

## 🚀 Installation & lancement

### Prérequis

- [.NET SDK](https://dotnet.microsoft.com/download) (version compatible avec le projet)
- Visual Studio 2022 **ou** la CLI .NET

### Cloner le dépôt

```bash
git clone https://github.com/Mat8313/MonBureau.git
cd MonBureau
```

### Lancer l'application

```bash
dotnet run --project MonBureau/MonBureau.csproj
```

Ou bien ouvrir `MonBureau.slnx` dans Visual Studio 2022 et lancer avec `F5`.

## 🏗️ Build

```bash
dotnet build MonBureau/MonBureau.csproj
```

## 🤝 Contributeurs

- [@Mat8313](https://github.com/Mat8313) — Matis BILLET
- [@MatisBILLET](https://github.com/MatisBILLET)

## 📄 Licence

Ce projet est privé. Tous droits réservés.
