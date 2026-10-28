# ConsoleMusic

Reproductor personal de música para Windows, ejecutado desde la consola. Lee archivos MP3 de la carpeta `music`, los reproduce en orden aleatorio y vuelve a mezclar la lista al terminar.

## Uso

Coloca tus archivos `.mp3` en `music` junto al ejecutable y ábrelo. Si la carpeta no existe, la aplicación la crea. Si no encuentra canciones, muestra un mensaje.

Para ejecutarlo desde el código fuente, se necesita el SDK de .NET 9:

```powershell
dotnet run
```

## Crear ejecutables

Desde la carpeta del proyecto, publica una versión autocontenida para la arquitectura deseada:

```powershell
dotnet publish .\ConsoleMusic.csproj -c Release -r win-x64 --self-contained true -p:PublishSingleFile=true
dotnet publish .\ConsoleMusic.csproj -c Release -r win-x86 --self-contained true -p:PublishSingleFile=true
```

La publicación incluye el ejecutable y la carpeta `music`. La aplicación usa WASAPI para reproducir audio en Windows.

## Tareas

### Hecho

- [x] Buscar archivos MP3 en `music` y crear la carpeta si falta.
- [x] Mezclar aleatoriamente las canciones y reproducirlas en un ciclo continuo.
- [x] Mostrar mensajes cuando no hay música o no se puede acceder a ella.

### Ideas para más adelante

- [ ] Investigar e implementar la descarga de música desde YouTube.
- [ ] Crear un sitio web privado para emitir una radio personal 24/7 con mi música favorita.

## Nota

Este es un proyecto personal para uso propio. 
