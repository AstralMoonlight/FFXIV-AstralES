<p align="center">
  <img src=".github/banner.svg" alt="AstralES: Final Fantasy XIV en español latino" width="100%">
</p>

<p align="center">
  <a href="https://github.com/AstralMoonlight/FFXIV-AstralES/releases/latest"><img src="https://img.shields.io/github/v/release/AstralMoonlight/FFXIV-AstralES?style=flat-square&label=versi%C3%B3n&color=4338ca" alt="Versión"></a>
  <a href="https://github.com/AstralMoonlight/FFXIV-AstralES/releases"><img src="https://img.shields.io/github/downloads/AstralMoonlight/FFXIV-AstralES/total?style=flat-square&label=descargas&color=4338ca" alt="Descargas"></a>
  <img src="https://img.shields.io/badge/Dalamud-API%2015-4338ca?style=flat-square" alt="Dalamud API 15">
  <img src="https://img.shields.io/badge/idioma-espa%C3%B1ol%20latino-d4a017?style=flat-square" alt="Idioma: español latino">
</p>

<p align="center">
  Plugin de <a href="https://github.com/goatcorp/Dalamud">Dalamud</a> que traduce al español los tooltips de combate y la historia principal de FFXIV.
</p>

<p align="center">
  <a href="#instalación">Instalación</a> ·
  <a href="#jobs">Jobs</a> ·
  <a href="#historia">Historia</a> ·
  <a href="#misiones-de-clase">Misiones de clase</a> ·
  <a href="#comandos">Comandos</a>
</p>

---

## Qué hace

- **Tooltips de combate:** habilidades, rasgos y estados (buffs y debuffs).
- **Historia principal:** diálogos, cinemáticas, Journal y Duty List.
- **Nombres en inglés:** habilidades, estados, medidores, jobs, personajes, lugares y misiones quedan tal como aparecen en el juego y en las guías. Solo se traduce el texto que los rodea.

Lo que todavía no tiene traducción se muestra en inglés, como siempre.

## Instalación

1. En el juego, abre la configuración de Dalamud con `/xlsettings`.
2. Ve a **Experimental → Custom Plugin Repositories** y agrega esta URL:

   ```
   https://raw.githubusercontent.com/AstralMoonlight/FFXIV-AstralES/main/repo.json
   ```

3. Activa la casilla de la URL, guarda y abre el instalador con `/xlplugins`.
4. Busca **AstralES** e instálalo.

## Jobs

**9 de 23 jobs traducidos**, con sus clases base. Las acciones de rol y las generales (Sprint, Teleport, Limit Break…) también están traducidas, con sus estados.

| Rol | Job | Habilidades, rasgos y estados |
|---|---|---|
| **Tank** | Paladin (Gladiator) | ![Pendiente][no] |
| | Warrior (Marauder) | ![Pendiente][no] |
| | Dark Knight | ![Traducido][ok] |
| | Gunbreaker | ![Pendiente][no] |
| **Healer** | White Mage (Conjurer) | ![Traducido][ok] |
| | Scholar (Arcanist) | ![Pendiente][no] |
| | Astrologian | ![Pendiente][no] |
| | Sage | ![Traducido][ok] |
| **Melee** | Monk (Pugilist) | ![Traducido][ok] |
| | Dragoon (Lancer) | ![Traducido][ok] |
| | Ninja (Rogue) | ![Pendiente][no] |
| | Samurai | ![Pendiente][no] |
| | Reaper | ![Pendiente][no] |
| | Viper | ![Traducido][ok] |
| **Ranged** | Bard (Archer) | ![Traducido][ok] |
| | Machinist | ![Pendiente][no] |
| | Dancer | ![Traducido][ok] |
| **Caster** | Black Mage (Thaumaturge) | ![Traducido][ok] |
| | Summoner (Arcanist) | ![Pendiente][no] |
| | Red Mage | ![Pendiente][no] |
| | Pictomancer | ![Pendiente][no] |
| **Limitado** | Blue Mage | ![Pendiente][no] |
| | Beastmaster | ![Pendiente][no] |

Los jobs pendientes ya muestran en español algunas líneas que comparten con otros (duraciones, efectos comunes), pero la mayor parte de su texto sigue en inglés.

## Historia

| Expansión | Parte | Estado |
|---|---|---|
| **A Realm Reborn** | 2.0: inicio en Gridania, Limsa Lominsa o Ul'dah, hasta "The Ultimate Weapon" | ![Traducido][ok] |
| | The Binding Coil of Bahamut | ![Traducido][ok] |
| | Crystal Tower | ![Traducido][ok] |
| | 2.1–2.55: desde "The Price of Principles" | ![Pendiente][no] |
| | Primals de ARR (Hard y Extreme) | ![Pendiente][no] |
| **Heavensward** | | ![Pendiente][no] |
| **Stormblood** | | ![Pendiente][no] |
| **Shadowbringers** | | ![Pendiente][no] |
| **Endwalker** | | ![Pendiente][no] |
| **Dawntrail** | | ![Pendiente][no] |

## Misiones de clase

| Misiones | Niveles | Estado |
|---|---|---|
| Lancer | 1–30 | ![Traducido][ok] |
| Archer | 1–30 | ![Traducido][ok] |
| Thaumaturge | 1–30 | ![Traducido][ok] |
| Dragoon | | ![Pendiente][no] |
| Resto de clases y jobs | | ![Pendiente][no] |

## Comandos

| Comando | Qué hace |
|---|---|
| `/astrales` | Activa o desactiva la traducción. |
| `/astrales diag` | Activa o desactiva el diagnóstico en `/xllog`. |

## Reportar un error

Si una línea sale en inglés o mal traducida, activa `/astrales diag`, repite lo que la mostró y abre un [issue](https://github.com/AstralMoonlight/FFXIV-AstralES/issues) con lo que aparece en `/xllog`.

[ok]: https://img.shields.io/badge/-Traducido-2ea043?style=flat-square
[no]: https://img.shields.io/badge/-Pendiente-6e7681?style=flat-square
