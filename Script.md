# Forecast
Forecast (Wetter w�re eine alt. Benennung) 
neues Blazor-Control.
Etwas HTML/Bootstrap [https://getbootstrap.com/docs/4.5/components/card/]
FetchData etwas umgebaut.

## Tipps
### Komponenten
Um Blazor entwickelt sich eine starke Infrastruktur. 
Zahlreiche kommerzielle und nicht-kommerzielle Angebote werben um die Aufmerksamkeit der Entwickler.

- Radzen 
[Radzen]

    [https://blazor.radzen.com/]
- MatBlazor [][https://www.matblazor.com/]
  - 
### Unterst�tzt der Browser Webassembly?
```javascript
    <script src="_framework/blazor.webassembly.js" autostart="false"></script>
    <script>
        const supported = (function () {
            try {
                if (typeof WebAssembly === "object"  && typeof WebAssembly.instantiate === "function") {
                    const module = new WebAssembly.Module(
                        Uint8Array.of(0x0, 0x61, 0x73, 0x6d, 0x01, 0x00, 0x00, 0x00)
                    );
                    if (module instanceof WebAssembly.Module)
                        return new WebAssembly.Instance(module) instanceof WebAssembly.Instance;
                }
            }
            catch (ex) {

            }
            return false;
        })();

        if (supported) {
            Blazor.start({});
        }
        else {
            window.location = window.location + "BrowserNotSupported.html"
        }
    </script>
```
[Wael Kdouh][https://medium.com/@waelkdouh/how-to-detect-unsupported-browsers-under-a-blazor-webassembly-application-bc11ab0ee015]