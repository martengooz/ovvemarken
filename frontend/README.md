## Installation

Install Node.js v12+

### Windows
Install [Git bash for Windows](https://gitforwindows.org/)

### Windows and Linux
Install necessary npm packages
``` bash
npm i
```

#### VsCode extensions
* `ESLint` - Automatic linting of js(x) files.
    * Add the following to vscodes `settings.json` file for automatic linting on save. 
        ```
        "editor.codeActionsOnSave": {
            "source.fixAll": true
        }
        ```

## Running 
### Dev server
Start development server with hot reload. 
```
npm run start
```

### Build for production 
Creates standalone html files and js bundles in `dist/` directory.
```
npm run build
```

### Linting
Run `npm run lint` or use ESLint plugin for your IDE.