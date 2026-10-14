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
  <a href="#misiones-de-clase-y-job">Misiones de clase y job</a> ·
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

| Expansión | Parche | Contenido | Estado |
|---|---|---|---|
| **A Realm Reborn** | 2.0 | Historia principal: inicio en Gridania, Limsa Lominsa o Ul'dah, hasta "The Ultimate Weapon" | ![Traducido][ok] |
| | | Raid de 8: The Binding Coil of Bahamut | ![Traducido][ok] |
| | | Raid de alianza (24): Crystal Tower | ![Traducido][ok] |
| **Post A Realm Reborn** | 2.1–2.55 | Historia principal, de "The Price of Principles" a "Before the Dawn" | ![Traducido][ok] |
| | | Primals de ARR (Hard y Extreme) | ![Traducido][ok] |
| **Heavensward** | 3.0 | Historia principal | ![Pendiente][no] |
| | | Raid de 8: Alexander (Gordias, Midas, Creator) | ![Pendiente][no] |
| | | Raid de alianza (24): Shadow of Mhach | ![Pendiente][no] |
| **Post Heavensward** | 3.1–3.56 | Historia principal | ![Pendiente][no] |
| **Stormblood** | 4.0 | Historia principal | ![Pendiente][no] |
| | | Raid de 8: Omega (Deltascape, Sigmascape, Alphascape) | ![Pendiente][no] |
| | | Raid de alianza (24): Return to Ivalice | ![Pendiente][no] |
| **Post Stormblood** | 4.1–4.56 | Historia principal | ![Pendiente][no] |
| **Shadowbringers** | 5.0 | Historia principal | ![Pendiente][no] |
| | | Raid de 8: Eden (Gate, Verse, Promise) | ![Pendiente][no] |
| | | Raid de alianza (24): YoRHa: Dark Apocalypse | ![Pendiente][no] |
| **Post Shadowbringers** | 5.1–5.55 | Historia principal | ![Pendiente][no] |
| **Endwalker** | 6.0 | Historia principal | ![Pendiente][no] |
| | | Raid de 8: Pandæmonium (Asphodelos, Abyssos, Anabaseios) | ![Traducido][ok] |
| | | Raid de alianza (24): Myths of the Realm | ![Pendiente][no] |
| **Post Endwalker** | 6.1–6.58 | Historia principal | ![Pendiente][no] |
| **Dawntrail** | 7.0 | Historia principal | ![Pendiente][no] |
| | | Raid de 8: Arcadion (Light-heavyweight, Cruiserweight, Heavyweight) | ![Pendiente][no] |
| | | Raid de alianza (24): Echoes of Vana'diel | ![Pendiente][no] |
| **Post Dawntrail** | 7.1 en adelante | Historia principal | ![Pendiente][no] |

## Misiones de clase y job

### Clases (nivel 1 a 30)

| Rol | Clase | Estado |
|---|---|---|
| **Tank** | Gladiator | ![Pendiente][no] |
| | Marauder | ![Pendiente][no] |
| **Healer** | Conjurer | ![Pendiente][no] |
| **Melee** | Pugilist | ![Pendiente][no] |
| | Lancer | ![Traducido][ok] |
| | Rogue | ![Pendiente][no] |
| **Ranged** | Archer | ![Traducido][ok] |
| **Caster** | Thaumaturge | ![Traducido][ok] |
| | Arcanist | ![Pendiente][no] |

### Jobs

| Rol | Job | Niveles | Estado |
|---|---|---|---|
| **Tank** | Paladin | 30–100 | ![Pendiente][no] |
| | Warrior | 30–100 | ![Pendiente][no] |
| | Dark Knight | 30–100 | ![Pendiente][no] |
| | Gunbreaker | 60–100 | ![Pendiente][no] |
| **Healer** | White Mage | 30–100 | ![Pendiente][no] |
| | Scholar | 30–100 | ![Pendiente][no] |
| | Astrologian | 30–100 | ![Pendiente][no] |
| | Sage | 70–100 | ![Pendiente][no] |
| **Melee** | Monk | 30–100 | ![Pendiente][no] |
| | Dragoon | 30–100 | ![Pendiente][no] |
| | Ninja | 30–100 | ![Pendiente][no] |
| | Samurai | 50–100 | ![Pendiente][no] |
| | Reaper | 70–100 | ![Pendiente][no] |
| | Viper | 80–100 | ![Pendiente][no] |
| **Ranged** | Bard | 30–100 | ![Pendiente][no] |
| | Machinist | 30–100 | ![Pendiente][no] |
| | Dancer | 60–100 | ![Pendiente][no] |
| **Caster** | Black Mage | 30–100 | ![Pendiente][no] |
| | Summoner | 30–100 | ![Pendiente][no] |
| | Red Mage | 50–100 | ![Pendiente][no] |
| | Pictomancer | 80–100 | ![Pendiente][no] |
| **Limitado** | Blue Mage | | ![Pendiente][no] |
| | Beastmaster | | ![Pendiente][no] |

## Comandos

| Comando | Qué hace |
|---|---|
| `/astrales` | Activa o desactiva la traducción. |
| `/astrales diag` | Activa o desactiva el diagnóstico en `/xllog`. |

## Reportar un error

Si una línea sale en inglés o mal traducida, activa `/astrales diag`, repite lo que la mostró y abre un [issue](https://github.com/AstralMoonlight/FFXIV-AstralES/issues) con lo que aparece en `/xllog`.

[ok]: https://img.shields.io/badge/-Traducido-2ea043?style=flat-square
[no]: https://img.shields.io/badge/-Pendiente-6e7681?style=flat-square
