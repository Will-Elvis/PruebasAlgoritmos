# Diagrama de Clases — Módulo Configuración (Domain)

```mermaid
classDiagram
    direction LR

    class Institucion {
        <<Entidad>>
        +Guid Id
        +Domicilio Domicilio
        +Coordenadas? Coordenadas
        +string Nombre
        +string? Codigo
        +string TelefonoContacto
        +string? CorreoElectronicoContacto
        +bool Activa
        +int RevisionUbicacion
        +Institucion(Domicilio domicilio)
    }

    class Domicilio {
        <<Value Object / sealed record>>
        +string Calle
        +string Numero
        +string Localidad
        +string Provincia
        +string? CodigoPostal
        +string? Complemento
        +string? Piso
        +string? Departamento
        +string? Barrio
        +Domicilio(string calle, string numero, string localidad, string provincia, string? codigoPostal, string? complemento, string? piso, string? departamento, string? barrio)
    }

    class Coordenadas {
        <<Value Object / sealed record>>
        +decimal Latitud
        +decimal Longitud
        +Coordenadas(decimal latitud, decimal longitud)
    }

    Institucion *-- "1" Domicilio : composición obligatoria
    Institucion *-- "0..1" Coordenadas : composición opcional
