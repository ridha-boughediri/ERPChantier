# ERPChantier - Application Mobile de Gestion de Chantier

## 📱 Description

ERPChantier est une application mobile développée avec .NET MAUI pour la gestion complète des chantiers de construction. Cette solution permet aux équipes de terrain et aux gestionnaires de projet de suivre efficacement l'avancement des travaux, gérer les équipes, et coordonner les activités sur les chantiers.

## 🚀 Fonctionnalités

### 📋 Gestion des Chantiers
- Vue d'ensemble de tous les chantiers actifs
- Détails complets de chaque chantier
- Suivi de l'avancement des projets
- Gestion des statuts et priorités

### 📊 Tableau Kanban
- Organisation visuelle des tâches
- Colonnes personnalisables (À faire, En cours, Terminé)
- Glisser-déposer pour déplacer les tâches
- Suivi en temps réel de l'avancement

### ✅ Gestion des Tâches
- Création et assignation de tâches
- Définition des priorités et échéances
- Suivi du statut d'avancement
- Commentaires et notes sur les tâches

### 📅 Calendrier
- Vue calendrier des échéances
- Planification des interventions
- Gestion des rendez-vous
- Synchronisation des événements

### 👥 Gestion d'Équipe
- Annuaire des membres de l'équipe
- Assignation des responsabilités
- Suivi de la disponibilité
- Communication interne

### 📄 Documents
- Stockage centralisé des documents
- Plans, photos, rapports
- Partage sécurisé de fichiers
- Versioning des documents

### 📈 Rapports
- Génération de rapports d'avancement
- Statistiques de performance
- Tableaux de bord personnalisés
- Export des données

### 💬 Messagerie
- Chat intégré pour la communication
- Messages par chantier ou équipe
- Notifications en temps réel
- Historique des conversations

### 👤 Profil Utilisateur
- Gestion du profil personnel
- Paramètres de l'application
- Préférences utilisateur
- Authentification sécurisée

## 🛠️ Technologies Utilisées

- **.NET MAUI** - Framework de développement multiplateforme
- **C#** - Langage de programmation principal
- **XAML** - Interface utilisateur déclarative
- **MVVM Pattern** - Architecture Model-View-ViewModel
- **Git** - Contrôle de version

## 📱 Plateformes Supportées

- **Android** (API 21+)
- **iOS** (iOS 11+)
- **Windows** (Windows 10+)
- **macOS** (macOS 10.15+)

## 🏗️ Architecture

L'application suit le pattern MVVM (Model-View-ViewModel) avec une architecture claire :

```
ERPChantier/
├── Models/           # Modèles de données
│   ├── Chantier.cs
│   ├── Tache.cs
│   ├── Membre.cs
│   ├── Message.cs
│   └── ...
├── Views/            # Interfaces utilisateur
│   ├── ChantiersPage.xaml
│   ├── KanbanPage.xaml
│   ├── TaskListPage.xaml
│   └── ...
├── ViewModels/       # Logique de présentation
│   └── ChatViewModel.cs
├── Converters/       # Convertisseurs de données
│   └── BoolConverters.cs
├── Resources/        # Ressources (styles, images, fonts)
│   ├── Styles/
│   ├── Images/
│   └── Fonts/
└── Platforms/        # Code spécifique aux plateformes
    ├── Android/
    ├── iOS/
    ├── Windows/
    └── MacCatalyst/
```

## 🚀 Installation et Configuration

### Prérequis

- Visual Studio 2022 ou Visual Studio Code
- .NET 8.0 SDK
- Workload .NET MAUI installé

### Étapes d'installation

1. **Cloner le repository**
   ```bash
   git clone https://github.com/ridha-boughediri/ERPChantier.git
   cd ERPChantier
   ```

2. **Restaurer les packages NuGet**
   ```bash
   dotnet restore
   ```

3. **Compiler le projet**
   ```bash
   dotnet build
   ```

4. **Lancer l'application**
   ```bash
   # Pour Android
   dotnet build -t:Run -f net8.0-android
   
   # Pour Windows
   dotnet build -t:Run -f net8.0-windows10.0.19041.0
   ```

## 🔧 Configuration de Développement

### Android
- SDK Android 34 ou supérieur
- Émulateur Android ou appareil physique
- Débogage USB activé

### iOS
- Xcode 15 ou supérieur
- Simulateur iOS ou appareil physique
- Compte développeur Apple (pour déploiement sur appareil)

### Windows
- Windows 10 version 1809 ou supérieure
- Windows App SDK

## 📝 Utilisation

1. **Démarrage** : Lancez l'application et connectez-vous
2. **Navigation** : Utilisez le menu principal pour accéder aux différentes sections
3. **Chantiers** : Consultez et gérez vos chantiers depuis l'onglet Chantiers
4. **Tâches** : Organisez vos tâches avec le tableau Kanban
5. **Équipe** : Gérez les membres de votre équipe
6. **Communication** : Utilisez la messagerie intégrée pour communiquer

## 🤝 Contribution

Les contributions sont les bienvenues ! Pour contribuer :

1. Fork le projet
2. Créez une branche pour votre fonctionnalité (`git checkout -b feature/AmazingFeature`)
3. Committez vos changements (`git commit -m 'Add some AmazingFeature'`)
4. Push vers la branche (`git push origin feature/AmazingFeature`)
5. Ouvrez une Pull Request

## 📄 Licence

Ce projet est sous licence MIT. Voir le fichier `LICENSE` pour plus de détails.

## 📞 Contact

**Ridha Boughediri**
- GitHub: [@ridha-boughediri](https://github.com/ridha-boughediri)
- Email: [votre-email@example.com]

## 🔄 Roadmap

- [ ] Intégration avec des APIs externes
- [ ] Mode hors ligne avec synchronisation
- [ ] Notifications push
- [ ] Géolocalisation des chantiers
- [ ] Reconnaissance vocale pour les rapports
- [ ] Intelligence artificielle pour l'optimisation des tâches

---

**ERPChantier** - Simplifiez la gestion de vos chantiers avec une solution mobile moderne et intuitive.
