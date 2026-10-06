# LabDTO (solución inicial)

Solución de partida para el ejercicio de DTOs. Abrí `LabDTO.sln` con Rider y corré el proyecto
`LabDTO.Web` (perfil `http`): la app queda en http://localhost:5080.

```
LabDTO.sln
├── LabDTO.Domain/           entidades de dominio (Usuario)
├── LabDTO.BusinessLogic/    lógica de negocio (UsuarioServicio)   → referencia a Domain
└── LabDTO.Web/              frontend Blazor (página Usuarios)     → referencia a BusinessLogic
```

Requiere el SDK de .NET 9.
