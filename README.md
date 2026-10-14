# AstralES

Plugin de [Dalamud](https://github.com/goatcorp/Dalamud) que traduce FFXIV al español latino: los tooltips de habilidades, rasgos y estados (buffs y debuffs) y la historia principal.

Los nombres propios (habilidades, estados, medidores, jobs, personajes, lugares, misiones) se mantienen en inglés, tal como aparecen en el juego y en las guías.

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
- Habilidades, rasgos y estados de **Black Mage** (con Thaumaturge), **White Mage**, **Sage**, **Bard**, **Dancer**, **Monk**, **Viper**, **Dark Knight** y **Dragoon** (con Lancer).
- Historia principal (diálogos, cinemáticas, Journal y Duty List): el inicio en las tres ciudades hasta "Close to Home", y toda la parte de Gridania hasta "The Gridanian Envoy". Limsa Lominsa y Ul'dah vienen después.

Lo que no tiene traducción se muestra en inglés, igual que siempre.

## Comandos

- `/astrales`: activa o desactiva la traducción.
- `/astrales diag`: activa o desactiva el diagnóstico en `/xllog` (para reportar líneas que no se traducen).
