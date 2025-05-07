# Minijuego Aviones

Este es un pequeño juego de aviones creado en Unity y usando C# de lenguaje. Se ha usado Visual Studio Code para la parte de programación.

## Cómo jugar

- Mueve la nave para esquivar enemigos.
- La nave dispara sola.
- Cada vez los enemigos aparecerán más rápido, caerán más rápido y la nave disparará más rápido.
- El juego termina cuando la nave se choca con un enemigo o un enemigo toca la Tierra.

## Objetivo del repositorio

Este proyecto está creado para practicar Unity, C# y gestión de versiones con Git y GitHub usando GitFlow.


## 📲 Cómo exportar este proyecto para iPhone (iOS)

### ✅ Requisitos previos

- Tener **Xcode instalado**.
- Tener una cuenta de Apple (gratuita vale para pruebas en tu dispositivo).
- Tener instalado el módulo **iOS Build Support en Unity** (Unity Hub → Installs → Add Modules).

---

### 🚀 Pasos para exportar desde Unity

#### 1️⃣ Configurar plataforma iOS

- Abrir Unity.
- Ir a `File → Build Profile`.
- Seleccionar **iOS** y pulsar `Switch Platform`.

---


#### 2️⃣ Eliminar paquetes innecesarios

- Abrir `Window → Package Manager`.
- Buscar **Test Framework**.
- Pulsar `Remove` para eliminarlo.

---

#### 3️⃣ Crear el proyecto de Xcode

- Ir a `File → Build Profile`.
- Seleccionar las escenas necesarias.
- Pulsar `Build`.
- Guardar en una carpeta vacía (ejemplo: `/Documents/MinijuegoAviones/XcodeProject`).

---

### 🚀 Pasos en Xcode

#### 4️⃣ Abrir el proyecto

- Abrir el archivo `Unity-iPhone.xcworkspace` con Xcode.

#### 5️⃣ Configurar firma

- Ir a `Signing & Capabilities`.
- Activar `Automatically manage signing`.
- Seleccionar tu cuenta de Apple.

#### 6️⃣ Compilar e instalar en tu iPhone

- Conectar tu iPhone.
- Seleccionar tu iPhone en Xcode.
- Pulsar `Run ▶️` para instalar la app.

Si el iPhone muestra "Desarrollador no confiable":

- Ir a `Ajustes → General → Gestión de dispositivos → Confiar en tu Apple ID`.

✅ ¡Listo! La app se instalará y podrás jugar en tu iPhone.

---
