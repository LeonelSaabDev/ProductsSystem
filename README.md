# 📦 Products System

Aplicación web full stack orientada a la **gestión de productos, clientes y ventas**, desarrollada con **Angular** en el frontend y **ASP.NET Core Web API** en el backend.

El proyecto está enfocado en la organización de datos, buenas prácticas de arquitectura y comunicación frontend–backend mediante API REST.

---

## 🚀 Funcionalidades principales

### 🛒 Productos

* Listado de productos
* Alta, edición y eliminación
* Manejo de precios y stock

### 👤 Clientes

* Listado de clientes
* Alta, edición y eliminación
* Asociación con ventas

---

## 🧱 Arquitectura

### Backend

* **ASP.NET Core Web API**
* **Entity Framework Core**
* Patrón **Repository**
* DTOs para transferencia de datos
* Base de datos SQL Server

### Frontend

* **Angular**
* Componentes standalone
* Servicios HTTP
* Formularios con `ngModel`
* Diseño simple y responsive

---

## 📂 Estructura del proyecto

```
ProductsSystem/
 ├── Backend/   → API REST en ASP.NET Core
 └── Frontend/  → Aplicación Angular
```

---

## ⚙️ Instalación y ejecución

### Backend

1. Abrir el proyecto en Visual Studio
2. Configurar la cadena de conexión en `appsettings.json`
3. Ejecutar migraciones si es necesario
4. Iniciar el proyecto (API)

### Frontend

```bash
npm install
ng serve
```

---

## 🧠 Objetivo del proyecto

Este proyecto fue desarrollado con fines de **aprendizaje y portfolio**, aplicando conceptos reales de:

* CRUD
* Relaciones entre entidades
* Arquitectura limpia
* Comunicación API REST
* Desarrollo full stack

---

## 👨‍💻 Autor

**Leonel Saab**
Desarrollador Full Stack Jr.
Enfocado en **C# / .NET / Angular**

📌 Proyecto creado como parte de mi portfolio profesional
