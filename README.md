# Getting Started with Create React App

This project was bootstrapped with [Create React App](https://github.com/facebook/create-react-app).

## Available Scripts

In the project directory, you can run:

### `npm start`

Runs the app in the development mode.\
Open [http://localhost:3000](http://localhost:3000) to view it in your browser.

The page will reload when you make changes.\
You may also see any lint errors in the console.

### `npm test`

Launches the test runner in the interactive watch mode.\
See the section about [running tests](https://facebook.github.io/create-react-app/docs/running-tests) for more information.

### `npm run build`

Builds the app for production to the `build` folder.\
It correctly bundles React in production mode and optimizes the build for the best performance.

The build is minified and the filenames include the hashes.\
Your app is ready to be deployed!

See the section about [deployment](https://facebook.github.io/create-react-app/docs/deployment) for more information.

### `npm run eject`

**Note: this is a one-way operation. Once you `eject`, you can't go back!**

If you aren't satisfied with the build tool and configuration choices, you can `eject` at any time. This command will remove the single build dependency from your project.

Instead, it will copy all the configuration files and the transitive dependencies (webpack, Babel, ESLint, etc) right into your project so you have full control over them. All of the commands except `eject` will still work, but they will point to the copied scripts so you can tweak them. At this point you're on your own.

You don't have to ever use `eject`. The curated feature set is suitable for small and middle deployments, and you shouldn't feel obligated to use this feature. However we understand that this tool wouldn't be useful if you couldn't customize it when you are ready for it.

## Learn More

You can learn more in the [Create React App documentation](https://facebook.github.io/create-react-app/docs/getting-started).

To learn React, check out the [React documentation](https://reactjs.org/).

### Code Splitting

This section has moved here: [https://facebook.github.io/create-react-app/docs/code-splitting](https://facebook.github.io/create-react-app/docs/code-splitting)

### Analyzing the Bundle Size

This section has moved here: [https://facebook.github.io/create-react-app/docs/analyzing-the-bundle-size](https://facebook.github.io/create-react-app/docs/analyzing-the-bundle-size)

### Making a Progressive Web App

This section has moved here: [https://facebook.github.io/create-react-app/docs/making-a-progressive-web-app](https://facebook.github.io/create-react-app/docs/making-a-progressive-web-app)

### Advanced Configuration

This section has moved here: [https://facebook.github.io/create-react-app/docs/advanced-configuration](https://facebook.github.io/create-react-app/docs/advanced-configuration)

### Deployment

This section has moved here: [https://facebook.github.io/create-react-app/docs/deployment](https://facebook.github.io/create-react-app/docs/deployment)

### `npm run build` fails to minify

This section has moved here: [https://facebook.github.io/create-react-app/docs/troubleshooting#npm-run-build-fails-to-minify](https://facebook.github.io/create-react-app/docs/troubleshooting#npm-run-build-fails-to-minify)
# Site Web du Club IA

## Description
Le site web du Club IA est une plateforme conçue pour promouvoir les activités, les projets et les événements du club, tout en offrant un espace d'interaction, de collaboration et d'apprentissage pour ses membres et partenaires. 

Ce projet vise également à simplifier les inscriptions, les paiements sécurisés, et la gestion des initiatives internes telles que **DevLab Factory**, **Maths & IA Insights**, et **InnoTalk**.

---

## Fonctionnalités principales

### Promouvoir le club IA
- Présentation des réalisations, projets, et événements du club.
- Visibilité accrue à l'extérieur grâce à des sections comme **Actualités** et **Galerie**.

### Engager les membres
- Accès aux ressources, formations, et opportunités de compétition.
- Forums internes et profils personnalisables.

### Simplifier les inscriptions et paiements
- Formulaire d'inscription avec paiement sécurisé.
- Génération automatique de reçus.

### Organiser et suivre les projets
- Suivi des projets internes comme **DevLab Factory**.
- Espaces dédiés pour la collaboration et le suivi des initiatives.

### Favoriser la collaboration
- Encouragement à la participation externe aux projets du club.
- Espaces pour présenter les comités, leurs missions et activités.

---

## Structure du projet

### Arborescence principale

```plaintext
src/
├── components/                 # Composants réutilisables
├── pages/                      # Pages principales du site
├── hooks/                      # Hooks personnalisés
├── context/                    # Gestion des états globaux
├── services/                   # Gestion des API et services
├── styles/                     # Fichiers de style CSS/SCSS
├── assets/                     # Ressources statiques (images, icônes)
├── utils/                      # Fonctions utilitaires
├── routes/                     # Gestion des routes
├── tests/                      # Tests unitaires et d'intégration
├── App.js                      # Composant racine
├── index.js                    # Point d'entrée de l'application
└── config.js                   # Variables globales de configuration
