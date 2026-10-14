# AstralES

Plugin de [Dalamud](https://github.com/goatcorp/Dalamud) que traduce FFXIV al español latino: los tooltips de habilidades, rasgos y estados (buffs y debuffs) y la historia principal.

Los nombres propios (habilidades, estados, medidores, jobs, personajes, lugares, misiones) se mantienen en inglés, tal como aparecen en el juego y en las guías. Lo que todavía no tiene traducción se muestra en inglés, como siempre.

## Instalación

1. En el juego, abre la configuración de Dalamud con `/xlsettings`.
2. Ve a **Experimental → Custom Plugin Repositories** y agrega esta URL:

   ```
   https://raw.githubusercontent.com/AstralMoonlight/FFXIV-AstralES/main/repo.json
   ```

3. Activa la casilla de la URL, guarda y abre el instalador con `/xlplugins`.
4. Busca **AstralES** e instálalo.

## Clases y jobs

Habilidades, rasgos y estados de cada job, incluida su clase base.

| Rol | Job | Estado |
|---|---|---|
| Tank | Paladin (Gladiator) | Pendiente |
| Tank | Warrior (Marauder) | Pendiente |
| Tank | Dark Knight | ✅ Traducido |
| Tank | Gunbreaker | Pendiente |
| Healer | White Mage (Conjurer) | ✅ Traducido |
| Healer | Scholar (Arcanist) | Pendiente |
| Healer | Astrologian | Pendiente |
| Healer | Sage | ✅ Traducido |
| Melee | Monk (Pugilist) | ✅ Traducido |
| Melee | Dragoon (Lancer) | ✅ Traducido |
| Melee | Ninja (Rogue) | Pendiente |
| Melee | Samurai | Pendiente |
| Melee | Reaper | Pendiente |
| Melee | Viper | ✅ Traducido |
| Ranged | Bard (Archer) | ✅ Traducido |
| Ranged | Machinist | Pendiente |
| Ranged | Dancer | ✅ Traducido |
| Caster | Black Mage (Thaumaturge) | ✅ Traducido |
| Caster | Summoner (Arcanist) | Pendiente |
| Caster | Red Mage | Pendiente |
| Caster | Pictomancer | Pendiente |
| Limitado | Blue Mage | Pendiente |
| Limitado | Beastmaster | Pendiente |

También están traducidas las acciones de rol y las acciones generales (Sprint, Teleport, Limit Break…), con sus estados.

Los jobs pendientes ya muestran en español algunas líneas que comparten con otros (duraciones, efectos comunes), pero la mayor parte del texto sigue en inglés.

## Historia

Diálogos, cinemáticas, Journal y Duty List.

| Parte | Estado |
|---|---|
| A Realm Reborn 2.0: inicio en Gridania, Limsa Lominsa o Ul'dah, hasta "The Ultimate Weapon" | ✅ Traducido |
| The Binding Coil of Bahamut | ✅ Traducido |
| Crystal Tower | ✅ Traducido |
| A Realm Reborn 2.1–2.55 ("The Price of Principles" en adelante) | Pendiente |
| Primals de ARR (Hard y Extreme) | Pendiente |
| Heavensward, Stormblood, Shadowbringers, Endwalker y Dawntrail | Pendiente |

## Misiones de clase y job

| Misiones | Estado |
|---|---|
| Lancer (nivel 1 a 30) | ✅ Traducido |
| Archer (nivel 1 a 30) | ✅ Traducido |
| Thaumaturge (nivel 1 a 30) | ✅ Traducido |
| Dragoon | Pendiente |
| Resto de clases y jobs | Pendiente |

## Comandos

- `/astrales`: activa o desactiva la traducción.
- `/astrales diag`: activa o desactiva el diagnóstico en `/xllog`, para reportar líneas que no se traducen.
