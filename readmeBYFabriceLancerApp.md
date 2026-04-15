# readmeBYFabriceLancerApp

Ce fichier contient les commandes pour **builder et lancer** toutes les apps du repo sur **Android**.

## Pré-requis (une seule fois)

Vérifier que le workload MAUI est installé:

```bash
dotnet workload list
```

Optionnel: vérifier les SDK .NET installés:

```bash
dotnet --list-sdks
```

## 1) Exercice 1 — Alignment

```bash
cd "/Users/fabricekouonang/Documents/mauiTest/mslearn-dotnetmaui-customize-xaml-pages-layout/exercise1/Alignment"
dotnet build -f net10.0-android
dotnet run -f net10.0-android
```

## 2) Exercice 2 — TipCalculator

```bash
cd "/Users/fabricekouonang/Documents/mauiTest/mslearn-dotnetmaui-customize-xaml-pages-layout/exercise2/TipCalculator"
dotnet build -f net10.0-android
dotnet run -f net10.0-android
```

## 3) Exercice 3 — TipCalculator

```bash
cd "/Users/fabricekouonang/Documents/mauiTest/mslearn-dotnetmaui-customize-xaml-pages-layout/exercise3/TipCalculator"
dotnet build -f net10.0-android
dotnet run -f net10.0-android
```

## 4) Multi-page apps — Astronomy (exercice 1)

```bash
cd "/Users/fabricekouonang/Documents/mauiTest/mslearn-dotnetmaui-customize-xaml-pages-layout/mslearn-dotnetmaui-create-multi-page-apps/exercise1/start/Astronomy/Astronomy"
dotnet build -f net10.0-android
dotnet run -f net10.0-android
```

## 5) Multi-page apps — Astronomy (exercice 3)

```bash
cd "/Users/fabricekouonang/Documents/mauiTest/mslearn-dotnetmaui-customize-xaml-pages-layout/mslearn-dotnetmaui-create-multi-page-apps/exercise3/start/Astronomy/Astronomy"
dotnet build -f net10.0-android
dotnet run -f net10.0-android
```

## 6) MVVM — part4-exercise1

Sur ce projet, `dotnet run` peut échouer (target `Run` manquante). Utiliser la cible MSBuild `Run`:

```bash
cd "/Users/fabricekouonang/Documents/mauiTest/mslearn-dotnetmaui-customize-xaml-pages-layout/mvvm/part4-exercise1"
dotnet build -f net9.0-android
dotnet build -t:Run -f net9.0-android
```

## 7) MVVM — part6-exercise2

```bash
cd "/Users/fabricekouonang/Documents/mauiTest/mslearn-dotnetmaui-customize-xaml-pages-layout/mvvm/part6-exercise2"
dotnet build -f net9.0-android
dotnet build -t:Run -f net9.0-android
```

