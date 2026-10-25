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
  <a href="#otras-misiones">Otras misiones</a> ·
  <a href="#eventos-de-temporada">Eventos</a> ·
  <a href="#viaje-y-transporte">Transporte</a> ·
  <a href="#mensajes-del-chat">Chat</a> ·
  <a href="#ventanas-de-ayuda">Ayuda</a> ·
  <a href="#menús-e-interfaz">Menús</a> ·
  <a href="#comandos">Comandos</a>
</p>

---

## Qué hace

- **Tooltips de combate:** habilidades, rasgos y estados (buffs y debuffs).
- **Historia principal:** diálogos, cinemáticas sin voz, Journal y Duty List.
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

**Los 23 jobs traducidos**, con sus clases base. Las acciones de rol y las generales (Sprint, Teleport, Limit Break…) también están traducidas, con sus estados.

| Rol | Job | Habilidades, rasgos y estados |
|---|---|---|
| **Tank** | Paladin (Gladiator) | ![Traducido][ok] |
| | Warrior (Marauder) | ![Traducido][ok] |
| | Dark Knight | ![Traducido][ok] |
| | Gunbreaker | ![Traducido][ok] |
| **Healer** | White Mage (Conjurer) | ![Traducido][ok] |
| | Scholar (Arcanist) | ![Traducido][ok] |
| | Astrologian | ![Traducido][ok] |
| | Sage | ![Traducido][ok] |
| **Melee** | Monk (Pugilist) | ![Traducido][ok] |
| | Dragoon (Lancer) | ![Traducido][ok] |
| | Ninja (Rogue) | ![Traducido][ok] |
| | Samurai | ![Traducido][ok] |
| | Reaper | ![Traducido][ok] |
| | Viper | ![Traducido][ok] |
| **Ranged** | Bard (Archer) | ![Traducido][ok] |
| | Machinist | ![Traducido][ok] |
| | Dancer | ![Traducido][ok] |
| **Caster** | Black Mage (Thaumaturge) | ![Traducido][ok] |
| | Summoner (Arcanist) | ![Traducido][ok] |
| | Red Mage | ![Traducido][ok] |
| | Pictomancer | ![Traducido][ok] |
| **Limitado** | Blue Mage | ![Traducido][ok] |
| | Beastmaster | ![Traducido][ok] |

## Historia

| Expansión | Parche | Contenido | Estado |
|---|---|---|---|
| **A Realm Reborn** | 2.0 | Historia principal: inicio en Gridania, Limsa Lominsa o Ul'dah, hasta "The Ultimate Weapon" | ![Traducido][ok] |
| | | Raid de 8: The Binding Coil of Bahamut | ![Traducido][ok] |
| | | Raid de alianza (24): Crystal Tower | ![Traducido][ok] |
| **Post A Realm Reborn** | 2.1–2.55 | Historia principal, de "The Price of Principles" a "Before the Dawn" | ![Traducido][ok] |
| | | Primals de ARR (Hard y Extreme) | ![Traducido][ok] |
| **Heavensward** | 3.0 | Historia principal, de "Coming to Ishgard" a "Heavensward" | ![Traducido][ok] |
| | | Raid de 8: Alexander (Gordias, Midas, Creator) | ![Traducido][ok] |
| | | Raid de alianza (24): Shadow of Mhach | ![Traducido][ok] |
| **Post Heavensward** | 3.1–3.56 | Historia principal, de "An Uncertain Future" a "The Far Edge of Fate" | ![Traducido][ok] |
| | | Primals: Warring Triad (Sephirot, Sophia, Zurvan) | ![Traducido][ok] |
| | | Frases de combate de dungeons y trials | ![Traducido][ok] |
| **Stormblood** | 4.0 | Historia principal, de "Beyond the Great Wall" a "Stormblood" | ![Traducido][ok] |
| | | Raid de 8: Omega (Deltascape, Sigmascape, Alphascape) | ![Traducido][ok] |
| | | Raid de alianza (24): Return to Ivalice | ![Traducido][ok] |
| | | Frases de combate de dungeons, trials, ultimates y batallas de misión | ![Traducido][ok] |
| **Post Stormblood** | 4.1–4.56 | Historia principal, de "Arenvald's Adventure" a "A Requiem for Heroes" | ![Traducido][ok] |
| | | Primals: The Four Lords (Byakko, Suzaku, Seiryu) | ![Traducido][ok] |
| **Shadowbringers** | 5.0 | Historia principal, de "The Syrcus Trench" a "Shadowbringers" | ![Traducido][ok] |
| | | Raid de 8: Eden (Gate, Verse, Promise) | ![Traducido][ok] |
| | | Raid de alianza (24): YoRHa: Dark Apocalypse | ![Traducido][ok] |
| **Post Shadowbringers** | 5.1–5.55 | Historia principal, de "Shaken Resolve" a "Death Unto Dawn" | ![Traducido][ok] |
| **Endwalker** | 6.0 | Historia principal, de "The Next Ship to Sail" a "Endwalker" | ![Traducido][ok] |
| | | Raid de 8: Pandæmonium (Asphodelos, Abyssos, Anabaseios) | ![Traducido][ok] |
| | | Raid de alianza (24): Myths of the Realm | ![Traducido][ok] |
| **Post Endwalker** | 6.1–6.58 | Historia principal, de "Newfound Adventure" a "The Coming Dawn" | ![Traducido][ok] |
| **Dawntrail** | 7.0 | Historia principal, de "A New World to Explore" a "Dawntrail" | ![Traducido][ok] |
| | | Raid de 8: Arcadion (Light-heavyweight, Cruiserweight, Heavyweight) | ![Traducido][ok] |
| | | Raid de alianza (24): Echoes of Vana'diel | ![Traducido][ok] |
| **Post Dawntrail** | 7.1–7.3 | Historia principal, de "A Royal Invitation" a "The Promise of Tomorrow" | ![Traducido][ok] |
| | 7.4 | Historia principal, de "With the Winds" a "Windborne" | ![Traducido][ok] |

## Cinemáticas con voz

Desde la 2.2, el texto de las cinemáticas con voz no está en las misiones sino en hojas aparte, una o más por parche. Por eso se ven en inglés aunque la historia de esa expansión esté traducida. En un parche a medias, la columna de líneas muestra traducidas / total. Las cinemáticas de A Realm Reborn 2.0 sí están dentro de cada misión y ya salen en español.

| Expansión | Parche | Líneas | Estado |
|---|---|---|---|
| **Post A Realm Reborn** | 2.2 | 261 | ![Traducido][ok] |
|  | 2.3 | 218 | ![Traducido][ok] |
|  | 2.4 | 508 | ![Traducido][ok] |
|  | 2.5–2.55 | 537 | ![Traducido][ok] |
| **Heavensward** | 3.0 | 1.232 | ![Traducido][ok] |
| **Post Heavensward** | 3.1 | 203 | ![Traducido][ok] |
|  | 3.2 | 283 | ![Traducido][ok] |
|  | 3.3 | 200 | ![Traducido][ok] |
|  | 3.4 | 353 | ![Traducido][ok] |
|  | 3.5–3.56 | 270 | ![Traducido][ok] |
| **Stormblood** | 4.0 | 1.775 | ![Traducido][ok] |
| **Post Stormblood** | 4.1 | 310 | ![Traducido][ok] |
|  | 4.2 | 289 | ![Traducido][ok] |
|  | 4.3 | 251 | ![Traducido][ok] |
|  | 4.4 | 341 | ![Traducido][ok] |
|  | 4.5–4.56 | 475 | ![Traducido][ok] |
| **Shadowbringers** | 5.0 | 3.106 | ![Traducido][ok] |
| **Post Shadowbringers** | 5.1 | 296 | ![Traducido][ok] |
|  | 5.2 | 408 | ![Traducido][ok] |
|  | 5.3 | 647 | ![Traducido][ok] |
|  | 5.4 | 378 | ![Traducido][ok] |
|  | 5.5–5.55 | 449 | ![Traducido][ok] |
| **Endwalker** | 6.0 | 5.240 | ![Traducido][ok] |
| **Post Endwalker** | 6.1 | 550 | ![Traducido][ok] |
|  | 6.2 | 483 | ![Traducido][ok] |
|  | 6.3 | 420 | ![Traducido][ok] |
|  | 6.4 | 552 | ![Traducido][ok] |
|  | 6.5–6.58 | 729 | ![Traducido][ok] |
| **Dawntrail** | 7.0 | 3.637 | ![Traducido][ok] |
| **Post Dawntrail** | 7.1 | 252 | ![Traducido][ok] |
|  | 7.2 | 408 | ![Traducido][ok] |
|  | 7.3 | 591 | ![Traducido][ok] |
|  | 7.4 | 517 | ![Traducido][ok] |
|  | 7.5 en adelante | 681 | ![Traducido][ok] |

## Misiones de clase y job

### Clases (nivel 1 a 30)

| Rol | Clase | Estado |
|---|---|---|
| **Tank** | Gladiator | ![Traducido][ok] |
| | Marauder | ![Traducido][ok] |
| **Healer** | Conjurer | ![Traducido][ok] |
| **Melee** | Pugilist | ![Traducido][ok] |
| | Lancer | ![Traducido][ok] |
| | Rogue | ![Traducido][ok] |
| **Ranged** | Archer | ![Traducido][ok] |
| **Caster** | Thaumaturge | ![Traducido][ok] |
| | Arcanist | ![Traducido][ok] |

### Jobs

| Rol | Job | Niveles | Estado |
|---|---|---|---|
| **Tank** | Paladin | 30–100 | ![Traducido][ok] |
| | Warrior | 30–100 | ![Traducido][ok] |
| | Dark Knight | 30–100 | ![Traducido][ok] |
| | Gunbreaker | 60–100 | ![Traducido][ok] |
| **Healer** | White Mage | 30–100 | ![Traducido][ok] |
| | Scholar | 30–100 | ![Traducido][ok] |
| | Astrologian | 30–100 | ![Traducido][ok] |
| | Sage | 70–100 | ![Traducido][ok] |
| **Melee** | Monk | 30–100 | ![Traducido][ok] |
| | Dragoon | 30–100 | ![Traducido][ok] |
| | Ninja | 30–100 | ![Traducido][ok] |
| | Samurai | 50–100 | ![Traducido][ok] |
| | Reaper | 70–100 | ![Traducido][ok] |
| | Viper | 80–100 | ![Traducido][ok] |
| **Ranged** | Bard | 30–100 | ![Traducido][ok] |
| | Machinist | 30–100 | ![Traducido][ok] |
| | Dancer | 60–100 | ![Traducido][ok] |
| **Caster** | Black Mage | 30–100 | ![Traducido][ok] |
| | Summoner | 30–100 | ![Traducido][ok] |
| | Red Mage | 50–100 | ![Traducido][ok] |
| | Pictomancer | 80–100 | ![Traducido][ok] |
| **Limitado** | Blue Mage | 1–70 | ![Traducido][ok] |
| | Beastmaster | | ![Pendiente][no] |

## Otras misiones

Misiones fuera de la historia que desbloquean funciones del juego.

| Misión | Desbloquea | Estado |
|---|---|---|
| Beauty Is Only Scalp Deep | Cambio de peinado (estilista) | ![Traducido][ok] |
| If I Had a Glamour | Glamours | ![Traducido][ok] |
| Color Your World | Tintes | ![Traducido][ok] |

## Eventos de temporada

Solo se ven mientras dura el evento.

| Evento | Contenido | Estado |
|---|---|---|
| All Saints' Wake 2026 (Halloween) | "We Scare Bears", "Grim and Grisly Games" y los diálogos de los NPC del evento | ![Traducido][ok] |
| Fall Guys (Blunderville, Gold Saucer) | "Just Crowning Around", los diálogos de los NPC de Blunderville Square y los objetivos y avisos de la ronda | ![Traducido][ok] |

## Viaje y transporte

Mensajes y menús de los aetherytes, el Aethernet y los porters (chocobos, halcones, amaros y alpacas).

| Qué | Ejemplo | Estado |
|---|---|---|
| Aetherytes y Aethernet (70 líneas) | Menú del aetheryte (Set Home Point, Aethernet...), "You have attuned yourself to all the Aethernet shards in Gridania..." de cada ciudad, los aetherytes que no responden y los viajes de cosmic exploration | ![Traducido][ok] |
| Chocobo, falcon, amaro y alpaca porters (179 líneas) | "Well met, traveler! Might I interest you in a chocobo porter?", avisos de nivel, explicaciones y confirmación del viaje | ![Traducido][ok] |

## Mensajes del chat

El plugin traduce los mensajes del sistema (los que no tienen remitente) que ya están en su tabla, en el chat y en los mensajes grandes en pantalla; por ahora, los del evento de Fall Guys. Lo que dicen los NPC y los jugadores sigue en inglés. Estas son todas las hojas del juego de donde sale lo que se ve en el chat.

| Hoja | Qué sale en el chat | Estado |
|---|---|---|
| `LogMessage` | Avisos del sistema y del combate: experiencia y nivel, objetos y gil, misiones aceptadas y completadas, habilidades aprendidas, logros, lugares descubiertos, santuarios e instancias de zona, estados ganados y perdidos, acciones de cada personaje, emotes, errores. Traducidos los de Blunderville | ![En curso][wip] |
| Hojas de misión (`quest/`) | Lo que dicen los NPC en las ventanas de diálogo y en combate (líneas `BATTLETALK`). La traducción ya existe en `msq/es/`: falta mostrarla en el chat | ![Pendiente][no] |
| `InstanceContentTextData` | Lo que dicen los jefes en mazmorras, trials y raids. La traducción ya existe en `msq/es/duties/`: falta mostrarla en el chat | ![Pendiente][no] |
| Hojas `custom/` | Diálogos de NPC fuera de las misiones (eventos de temporada, aetherytes, porters). La traducción ya existe para las que están en `msq/es/events/` y `msq/es/transport/` | ![Pendiente][no] |
| `NpcYell` | Gritos de NPC en el mundo abierto y en los FATE | ![Pendiente][no] |
| `TextCommand` | Ayuda y errores de los comandos de texto (`/help`, comandos mal escritos) | ![Pendiente][no] |
| `Completion` | Frases del autotraductor que escriben los jugadores | — |
| `Quest`, `Achievement`, `PlaceName`, `Action`, `Status`, `ClassJob`, `Item`, `BNpcName`, `ENpcResident`, `Fate`, `ContentFinderCondition` | Nombres dentro de los avisos (misiones, logros, lugares, habilidades, estados, clases, objetos, enemigos, NPC, FATE, instancias). Quedan en inglés | — |

## Ventanas de ayuda

Las guías que el juego abre solas la primera vez que se hace algo (Active Help) y se pueden volver a leer desde el menú de ayuda, más los tutoriales propios de algunos contenidos y la descripción de los objetos clave.

| Hoja | Qué sale | Tamaño | Estado |
|---|---|---|---|
| `HowTo`, `HowToCategory` | Títulos y categorías de Active Help ("Basic Controls"...) | 278 textos | ![Pendiente][no] |
| `HowToPage` | Las páginas de cada guía de Active Help ("Non-player characters (NPCs) offering quests can be recognized by the exclamation marks...") | 664 textos, unas 24.000 palabras | ![Pendiente][no] |
| `ContentsTutorial`, `ContentsTutorialPage` | Tutoriales de contenidos especiales (Bozjan Southern Front...) | 41 textos | ![Pendiente][no] |
| `EventTutorial`, `EventTutorialPage` | Tutoriales de mecánicas de eventos y misiones (Transport...) | 81 textos | ![Pendiente][no] |
| `MultipleHelp`, `MultipleHelpString` | Ayudas de varias páginas (Raid Finder Help...) | 64 textos | ![Pendiente][no] |
| `EventItemHelp` | Descripción de los objetos clave de misión, en su tooltip ("A simple wooden hairpin treasured by young Aunillie...") | 3.221 textos, unas 52.000 palabras | ![Pendiente][no] |
| `GuidePageString`, `GuideTitle` | Job Gauge Details: la explicación de los medidores de cada job ("Oath Gauge"...) | 163 textos, unas 4.400 palabras | ![Pendiente][no] |
| `Description`, `DescriptionString`, `DescriptionStandAloneTransient` | Guías de contenidos y minijuegos ("Doman Mahjong for Beginners", "About Orthos Aetherpool Gear"...) | 1.729 textos, unas 55.700 palabras | ![Pendiente][no] |

## Menús e interfaz

Las ventanas del juego ya muestran en español la mayor parte de su texto fijo: títulos, secciones, opciones, botones, confirmaciones y mensajes (hoja `Addon`), y también los menús de Keybind y Log Settings. Los nombres de ventanas, menús y atributos quedan en inglés. Siguen en inglés la pantalla de título y la de personajes (hoja `Lobby`), las ayudas de botones del mando y algunas etiquetas que el juego arma con datos del mando. Estas son las hojas del juego de donde sale su texto. Los nombres propios (monturas, minions, canciones, logros, instancias) quedan en inglés, como en el resto del plugin, y el tamaño cuenta solo lo que se traduce.

### Ventanas y sistema

| Hoja | Qué sale | Tamaño | Estado |
|---|---|---|---|
| `Addon` | Casi todo el texto fijo de las ventanas: títulos, pestañas, botones, etiquetas, confirmaciones y las opciones de System Configuration y Character Configuration ("OK", "Gear", "Race Ability"...) | 14.180 textos (9.395 distintos), unas 49.000 palabras | ![Traducido][ok] |
| `AddonTransient` | Ayudas de botones al pie de las ventanas cuando se juega con mando ("Move   Confirm   Cancel") y otras etiquetas | 565 textos, unas 6.000 palabras | ![Pendiente][no] |
| `Lobby` | Pantalla de título, selección de mundo y de personaje, y creación de personaje con las descripciones de razas, clanes y clases ("Start Game"...) | 1.030 textos, unas 9.600 palabras | ![Pendiente][no] |
| `Error` | Errores al conectarse, al crear personajes y al visitar otros mundos. Quedan en inglés los dos que llevan datos (la fila de espera, la plataforma) | 63 textos, unas 1.000 palabras | ![Traducido][ok] |
| `MainCommand`, `MainCommandCategory` | Menú principal: cada comando y su descripción ("Displays gear stored in your Armoury Chest...") | 205 textos, unas 1.600 palabras | ![Traducido][ok] |
| `ExtraCommand` | Group Pose, Idling Camera, Alarm y Command Panel, con su descripción | 8 textos | ![Traducido][ok] |
| `ConfigKey` | Acciones de Keybind ("Steer", "Hotbar 9 - Slot 5"...). Los nombres de ventanas y canales del chat quedan en inglés | 416 textos, unas 1.800 palabras | ![Traducido][ok] |
| `Platform` | Botones del mando ("Right Stick", "X Button"...). Las siglas (LB, R2) y los nombres de tiendas y redes quedan | 163 textos | ![Traducido][ok] |
| `Hud` | Elementos de HUD Layout ("Hotbar 1", "Action Help"...). Son nombres de ventanas y medidores: quedan en inglés | 106 textos | ![Traducido][ok] |
| `LogFilter` | Filtros del chat en Log Settings, con su descripción y un ejemplo ("Damage dealt by unengaged enemies."). Los ejemplos quedan en inglés, como el chat | 469 textos, unas 3.300 palabras | ![Traducido][ok] |
| `OnlineStatus` | Estados en línea ("Busy", "Looking for Party"...) | 47 textos | ![Traducido][ok] |
| `Marker`, `FieldMarker` | Marcadores de objetivo y waymarks ("Target to Attack 1"...) | 26 textos | ![Traducido][ok] |
| `QuickChat`, `QuickChatTransient` | Mensajes de Quick Chat y su explicación. La frase de ejemplo queda en inglés, como el chat | 79 textos, unas 560 palabras | ![Traducido][ok] |

### Duty Finder y diario

| Hoja | Qué sale | Tamaño | Estado |
|---|---|---|---|
| `ContentType`, `ContentRoulette`, `ContentUICategory` | Duty Finder: tipos de contenido, ruletas con su descripción y categorías ("Duty Roulette: Leveling"...) | 186 textos, unas 2.300 palabras | ![Pendiente][no] |
| `ContentFinderConditionTransient` | Descripción de cada instancia en el Duty Finder ("Named after a man-eating creature from Padjal lore...") | 620 textos, unas 46.000 palabras | ![Pendiente][no] |
| `ContentsNote`, `ContentsNoteCategory` | Challenge Log: retos, descripciones y categorías | 194 textos, unas 1.100 palabras | ![Pendiente][no] |
| `JournalSection`, `JournalCategory` | Secciones y categorías del Journal ("Main Scenario (A Realm Reborn through Endwalker)"...) | 142 textos | ![Pendiente][no] |
| `QuestRedoChapterUI`, `QuestRedoChapterUITab`, `QuestRedoChapterUICategory` | New Game+: capítulos, pestañas y el resumen de cada capítulo | 600 textos, unas 13.800 palabras | ![Pendiente][no] |
| `AchievementKind`, `AchievementCategory`, `Achievement` | Logros: categorías y la descripción de cada uno | 4.095 textos, unas 33.900 palabras | ![Pendiente][no] |

### Personaje, colecciones y grupos

| Hoja | Qué sale | Tamaño | Estado |
|---|---|---|---|
| `BaseParam` | Atributos de la ventana de personaje y su descripción ("Strength", "Tenacity"...) | 112 textos, unas 650 palabras | ![Pendiente][no] |
| `GuardianDeity` | Descripción de los Twelve en la creación de personaje y en el perfil | 12 textos, unas 750 palabras | ![Pendiente][no] |
| `ItemUICategory`, `ItemSearchCategory`, `ClassJobActionUICategory` | Categorías de objetos, del Market Board y de Actions & Traits ("Primary Arms"...) | 234 textos | ![Pendiente][no] |
| `MountTransient` | Mount Guide: descripción, historia y cita de cada montura | 1.071 textos, unas 26.000 palabras | ![Pendiente][no] |
| `CompanionTransient` | Minion Guide: descripción, historia, cita y habilidad de cada minion | 2.942 textos, unas 50.700 palabras | ![Pendiente][no] |
| `OrnamentTransient` | Descripción de los Fashion Accessories | 56 textos | ![Pendiente][no] |
| `Orchestrion`, `OrchestrionCategory` | Orchestrion: dónde se consigue cada canción y las categorías | 899 textos, unas 6.700 palabras | ![Pendiente][no] |
| `Emote`, `EmoteCategory` | Lista de emotes y sus categorías ("Surprised"...) | 308 textos | ![Pendiente][no] |
| `CharaCardBase`, `CharaCardDecoration`, `CharaCardDesignCategory`, `CharaCardDesignPreset`, `CharaCardHeader`, `CharaCardPlayStyle` | Adventurer Plate: fondos, marcos, decoraciones, diseños y estilos de juego | 1.160 textos, unas 2.300 palabras | ![Pendiente][no] |
| `BannerBg`, `BannerDecoration`, `BannerDesignPreset`, `BannerFrame`, `BannerObtainHintType`, `BannerTimeline` | Retratos: fondos, marcos, decoraciones, poses y dónde se consigue cada uno | 1.753 textos, unas 5.300 palabras | ![Pendiente][no] |
| `FCRights`, `FCAuthority`, `FCAuthorityCategory`, `FCHierarchy`, `FCProfile`, `FCReputation`, `FCChestName`, `FCActivity`, `FCActivityCategory`, `CompanyAction` | Free company: permisos, rangos, perfil, reputación, cofre, registro de actividad y acciones de la compañía | 335 textos, unas 1.500 palabras | ![Pendiente][no] |
| `HousingPlacement`, `HousingUnplacement`, `HousingMateAuthority`, `MateAuthorityCategory`, `FurnitureCatalogCategory`, `YardCatalogCategory`, `HousingAppeal` | Vivienda: avisos al colocar y quitar muebles, permisos y categorías del catálogo | 102 textos, unas 1.000 palabras | ![Pendiente][no] |
| `GilShop`, `SpecialShop`, `TopicSelect` | Opciones de las tiendas al hablar con un vendedor ("Purchase Items", "Seasonal Event"...) | 2.080 textos (957 distintos), unas 7.600 palabras | ![Pendiente][no] |
| `NotebookDivision`, `NotebookDivisionCategory`, `CraftType`, `GatheringType` | Crafting Log y Gathering Log: divisiones por nivel y categorías ("Master Recipes", "Woodworking"...) | 150 textos | ![Pendiente][no] |

## Comandos

| Comando | Qué hace |
|---|---|
| `/astrales` | Activa o desactiva la traducción. |
| `/astrales diag` | Activa o desactiva el diagnóstico en `/xllog`. |

## Reportar un error

Si una línea sale en inglés o mal traducida, activa `/astrales diag`, repite lo que la mostró y abre un [issue](https://github.com/AstralMoonlight/FFXIV-AstralES/issues) con lo que aparece en `/xllog`.

[ok]: https://img.shields.io/badge/-Traducido-2ea043?style=flat-square
[no]: https://img.shields.io/badge/-Pendiente-6e7681?style=flat-square
[wip]: https://img.shields.io/badge/-En%20curso-d29922?style=flat-square
