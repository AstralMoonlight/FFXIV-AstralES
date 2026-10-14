# AstralES

Plugin de [Dalamud](https://github.com/goatcorp/Dalamud) que traduce al español latino los tooltips de FFXIV: las descripciones de habilidades, rasgos y estados (buffs y debuffs).

Los nombres propios (habilidades, estados, medidores, jobs) se mantienen en inglés, tal como aparecen en la barra de acciones y en las guías.

## Instalación

1. En el juego, abre la configuración de Dalamud con `/xlsettings`.
2. Ve a **Experimental → Custom Plugin Repositories** y agrega esta URL:

   ```
   https://raw.githubusercontent.com/AstralMoonlight/FFXIV-AstralES/main/repo.json
   ```

3. Activa la casilla de la URL, guarda y abre el instalador con `/xlplugins`.
4. Busca **AstralES** e instálalo.

## Qué está traducido

- Acciones generales (Sprint, Teleport, Limit Break…) y acciones de rol.
- Habilidades, rasgos y estados de **Black Mage** (con Thaumaturge), **White Mage**, **Sage**, **Bard**, **Dancer**, **Monk**, **Viper** y **Dark Knight**.

Lo que no tiene traducción se muestra en inglés, igual que siempre.

## Comandos

- `/astrales`: activa o desactiva la traducción.
- `/astrales diag`: activa o desactiva el diagnóstico en `/xllog` (para reportar líneas que no se traducen).
