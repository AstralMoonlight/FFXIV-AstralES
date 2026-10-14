namespace AstralES.Translation;

public static partial class Spanish
{
    private static void Brd(Action<string, string> add)
    {
        // Archer / Bard: actions

        add("Delivers an attack with a potency of {0}.", "Realiza un ataque con una potencia de {0}.");
        add("Delivers an attack with a potency of {0} to all enemies in a cone before you.",
            "Realiza un ataque con una potencia de {0} a todos los enemigos en un cono frente a ti.");
        add("Delivers an attack with a potency of {0} to target and all enemies nearby it.",
            "Realiza un ataque con una potencia de {0} al objetivo y a todos los enemigos cercanos.");
        add("Delivers an attack with a potency of {0} to all enemies in a straight line before you.",
            "Realiza un ataque con una potencia de {0} a todos los enemigos en línea recta frente a ti.");
        add("Delivers an attack to all enemies in a straight line before you with a potency of {0} for the first enemy, and {1}% less for all remaining enemies.",
            "Realiza un ataque a todos los enemigos en línea recta frente a ti con una potencia de {0} al primer enemigo y {1}% menos a los demás.");
        add("Delivers an attack to target and all enemies nearby it with a potency of {0} for the first enemy, and {1}% less for all remaining enemies.",
            "Realiza un ataque al objetivo y a todos los enemigos cercanos con una potencia de {0} al primer enemigo y {1}% menos a los demás.");
        add("Delivers an attack to target and all enemies nearby it.", "Realiza un ataque al objetivo y a todos los enemigos cercanos.");
        add("Additional Effect: {0}% chance of granting Hawk's Eye", "Efecto adicional: {0}% de probabilidad de otorgar Hawk's Eye");
        add("Can only be executed when under the effect of Hawk's Eye.", "Solo se puede usar bajo el efecto de Hawk's Eye.");
        add("Can only be executed when under the effect of Hawk's Eye or Barrage.", "Solo se puede usar bajo el efecto de Hawk's Eye o Barrage.");
        add("Can only be executed while under the effect of Hawk's Eye.", "Solo se puede usar bajo el efecto de Hawk's Eye.");
        add("Can only be executed while under the effect of Hawk's Eye or Barrage.", "Solo se puede usar bajo el efecto de Hawk's Eye o Barrage.");
        add("Can only be executed while under the effect of Blast Arrow Ready.", "Solo se puede usar bajo el efecto de Blast Arrow Ready.");
        add("Can only be executed while under the effect of Resonant Arrow Ready.", "Solo se puede usar bajo el efecto de Resonant Arrow Ready.");
        add("Can only be executed while under the effect of Radiant Encore Ready.", "Solo se puede usar bajo el efecto de Radiant Encore Ready.");
        add("Additional Effect: Venom", "Efecto adicional: Venom");
        add("Additional Effect: Poison", "Efecto adicional: Poison");
        add("Increases damage dealt by {0}%.", "Aumenta un {0}% el daño infligido.");
        add("Grants Barrage, allowing the use of Straight Shot and Wide Volley. Upon execution, Straight Shot will strike the selected target three times, while Wide Volley's potency will be increased to {0}.",
            "Otorga Barrage, que permite usar Straight Shot y Wide Volley. Al usarlos, Straight Shot golpea tres veces al objetivo seleccionado y la potencia de Wide Volley aumenta a {0}.");
        add("Grants Barrage, allowing the use of Refulgent Arrow and Wide Volley. Upon execution, Refulgent Arrow will strike the selected target three times, while Wide Volley's potency will be increased to {0}.",
            "Otorga Barrage, que permite usar Refulgent Arrow y Wide Volley. Al usarlos, Refulgent Arrow golpea tres veces al objetivo seleccionado y la potencia de Wide Volley aumenta a {0}.");
        add("Grants Barrage, allowing the use of Refulgent Arrow and Shadowbite. Upon execution, Refulgent Arrow will strike the selected target three times, while Shadowbite's potency will be increased to {0}.",
            "Otorga Barrage, que permite usar Refulgent Arrow y Shadowbite. Al usarlos, Refulgent Arrow golpea tres veces al objetivo seleccionado y la potencia de Shadowbite aumenta a {0}.");
        add("Additional Effect: Grants Resonant Arrow Ready", "Efecto adicional: Otorga Resonant Arrow Ready");
        add("Additional Effect: Grants Radiant Encore Ready", "Efecto adicional: Otorga Radiant Encore Ready");
        add("Shares a recast timer with Rain of Death.", "Comparte tiempo de reutilización con Rain of Death.");
        add("Shares a recast timer with Bloodletter.", "Comparte tiempo de reutilización con Bloodletter.");
        add("Shares a recast timer with Heartbreak Shot.", "Comparte tiempo de reutilización con Heartbreak Shot.");
        add("Jump {0} yalms away from current target.", "Salta {0} yalms lejos del objetivo actual.");
        add("Grants Mage's Ballad to self and all party members within {0} yalms, increasing damage dealt by {1}%.",
            "Otorga Mage's Ballad a ti y a todos los miembros del grupo en un radio de {0} yalms, y aumenta un {1}% el daño infligido.");
        add("Grants Army's Paeon to self and all party members within {0} yalms, increasing direct hit rate by {1}%.",
            "Otorga Army's Paeon a ti y a todos los miembros del grupo en un radio de {0} yalms, y aumenta un {1}% la tasa de golpe directo.");
        add("Grants the Wanderer's Minuet to self and all party members within {0} yalms, increasing critical hit rate by {1}%.",
            "Otorga the Wanderer's Minuet a ti y a todos los miembros del grupo en un radio de {0} yalms, y aumenta un {1}% la tasa de golpe crítico.");
        add("Additional Effect: {0}% chance to grant Repertoire", "Efecto adicional: {0}% de probabilidad de otorgar Repertoire");
        add("This effect can trigger repeatedly while singing the Mage's Ballad.", "Este efecto puede activarse varias veces mientras cantas Mage's Ballad.");
        add("This effect can trigger repeatedly while singing the Army's Paeon.", "Este efecto puede activarse varias veces mientras cantas Army's Paeon.");
        add("This effect can trigger repeatedly while singing the Wanderer's Minuet.", "Este efecto puede activarse varias veces mientras cantas the Wanderer's Minuet.");
        add("Repertoire Effect: Reduces the recast time of Bloodletter by {0}s", "Efecto de Repertoire: Reduce {0} s el tiempo de reutilización de Bloodletter");
        add("Repertoire Effect: Reduces the recast time of Bloodletter and Rain of Death by {0}s",
            "Efecto de Repertoire: Reduce {0} s el tiempo de reutilización de Bloodletter y Rain of Death");
        add("Repertoire Effect: Reduces the recast time of Heartbreak Shot and Rain of Death by {0}s",
            "Efecto de Repertoire: Reduce {0} s el tiempo de reutilización de Heartbreak Shot y Rain of Death");
        add("Repertoire Effect: Reduces weaponskill cast time and recast time, spell cast time and recast time, and auto-attack delay by {0}%",
            "Efecto de Repertoire: Reduce un {0}% el tiempo de lanzamiento y de reutilización de técnicas de arma y hechizos, y el retraso del ataque automático");
        add("Repertoire Effect: Allows execution of Pitch Perfect", "Efecto de Repertoire: Permite usar Pitch Perfect");
        add("Can only be executed while in combat.", "Solo se puede usar en combate.");
        add("Can be stacked up to {0} times.", "Se puede acumular hasta {0} veces.");
        add("Additional Effect: Grants Mage's Coda", "Efecto adicional: Otorga Mage's Coda");
        add("Additional Effect: Grants Army's Coda", "Efecto adicional: Otorga Army's Coda");
        add("Additional Effect: Grants Wanderer's Coda", "Efecto adicional: Otorga Wanderer's Coda");
        add("Increases direct hit rate of self and all nearby party members by {0}%.",
            "Aumenta un {0}% tu tasa de golpe directo y la de todos los miembros del grupo cercanos.");
        add("Additional Effect: Grants Repertoire while singing Mage's Ballad, Army's Paeon, or the Wanderer's Minuet",
            "Efecto adicional: Otorga Repertoire mientras cantas Mage's Ballad, Army's Paeon o the Wanderer's Minuet");
        add("Additional Effect: If the target is suffering from a Venomous Bite or Windbite effect inflicted by you, the effect timer is reset",
            "Efecto adicional: Si el objetivo sufre un efecto de Venomous Bite o Windbite que aplicaste, su duración se reinicia");
        add("Additional Effect: If the target is suffering from a Caustic Bite or Stormbite effect inflicted by you, the effect timer is reset",
            "Efecto adicional: Si el objetivo sufre un efecto de Caustic Bite o Stormbite que aplicaste, su duración se reinicia");
        add("Removes one select detrimental effect from self or target party member. If the target is not enfeebled, a barrier is created nullifying the target's next detrimental effect suffered.",
            "Elimina ciertos efectos perjudiciales de ti o del miembro del grupo seleccionado. Si el objetivo no tiene efectos perjudiciales, crea una barrera que anula el siguiente que sufra.");
        add("Delivers an attack to the target and all enemies nearby it. Potency varies with number of Repertoire stacks, dealing full damage for the first enemy, and {0}% less for all remaining enemies.",
            "Realiza un ataque al objetivo y a todos los enemigos cercanos. La potencia depende de las acumulaciones de Repertoire: daño completo al primer enemigo y {0}% menos a los demás.");
        add("{0} Repertoire Stack: {1}", "{0} acumulación de Repertoire: {1}");
        add("{0} Repertoire Stacks: {1}", "{0} acumulaciones de Repertoire: {1}");
        add("Can only be executed when the Wanderer's Minuet is active and you have at least one stack of Repertoire.",
            "Solo se puede usar con the Wanderer's Minuet activo y al menos una acumulación de Repertoire.");
        add("Effect cannot be stacked with machinist's Tactician or dancer's Shield Samba.",
            "No se acumula con el Tactician de un machinist ni con el Shield Samba de un dancer.");
        add("Increases HP recovery via healing actions by {0}% for self and nearby party members.",
            "Aumenta un {0}% la recuperación de HP por acciones de curación tuya y de los miembros del grupo cercanos.");
        add("Barrage Potency: {0}", "Potencia con Barrage: {0}");
        add("Soul Voice Gauge Cost: {0}", "Costo de Soul Voice Gauge: {0}");
        add("Potency increases up to {0} as Soul Voice Gauge exceeds minimum cost.",
            "La potencia aumenta hasta {0} a medida que el Soul Voice Gauge supera el costo mínimo.");
        add("Consumes Soul Voice Gauge upon execution.", "Consume el Soul Voice Gauge al usarse.");
        add("Additional Effect: Grants Blast Arrow Ready upon execution while Soul Voice Gauge is {0} or higher",
            "Efecto adicional: Otorga Blast Arrow Ready si se usa con el Soul Voice Gauge en {0} o más");
        add("※Apex Arrow changes to Blast Arrow when requirements for execution are met.",
            "※Apex Arrow se convierte en Blast Arrow cuando se cumplen los requisitos para usarla.");
        add("Increases damage dealt by self and nearby party members.", "Aumenta el daño que infligen tú y los miembros del grupo cercanos.");
        add("Effectiveness is determined by the number of different Coda active in the Song Gauge.",
            "La eficacia depende de la cantidad de Coda distintas activas en el Song Gauge.");
        add("{0} Coda: {1}%", "{0} Coda: {1}%");
        add("{0} Coda: {1}", "{0} Coda: {1}");
        add("Can only be executed when at least {0} coda is active.", "Solo se puede usar con al menos {0} coda activa.");
        add("Potency is determined by the number of different Coda consumed in the Radiant Finale executed prior, dealing full damage for the first enemy, and {0}% less for all remaining enemies.",
            "La potencia depende de la cantidad de Coda distintas consumidas en el Radiant Finale anterior: daño completo al primer enemigo y {0}% menos a los demás.");

        // Archer / Bard: traits

        add("Adds to Heavy Shot a {0}% chance to grant Hawk's Eye.", "Agrega a Heavy Shot un {0}% de probabilidad de otorgar Hawk's Eye.");
        add("Adds to Quick Nock a {0}% chance to grant Hawk's Eye.", "Agrega a Quick Nock un {0}% de probabilidad de otorgar Hawk's Eye.");
        add("Adds to Stormbite, Caustic Bite, and Iron Jaws a {0}% chance to grant Hawk's Eye.",
            "Agrega a Stormbite, Caustic Bite e Iron Jaws un {0}% de probabilidad de otorgar Hawk's Eye.");
        add("Increases base action damage by {0}%.", "Aumenta un {0}% el daño base de las acciones.");
        add("Upgrades Venomous Bite and Windbite to Caustic Bite and Stormbite respectively.",
            "Mejora Venomous Bite y Windbite a Caustic Bite y Stormbite, respectivamente.");
        add("Guarantees the trigger of the additional effects for current Mage's Ballad, Army's Paeon, and the Wanderer's Minuet when Empyreal Arrow hits a target.",
            "Garantiza que se activen los efectos adicionales de Mage's Ballad, Army's Paeon y the Wanderer's Minuet activos cuando Empyreal Arrow acierta a un objetivo.");
        add("Upgrades Straight Shot to Refulgent Arrow.", "Mejora Straight Shot a Refulgent Arrow.");
        add("Upgrades Heavy Shot to Burst Shot.", "Mejora Heavy Shot a Burst Shot.");
        add("Upgrades Quick Nock to Ladonsbite.", "Mejora Quick Nock a Ladonsbite.");
        add("Upgrades Wide Volley to Shadowbite.", "Mejora Wide Volley a Shadowbite.");
        add("Upgrades Bloodletter to Heartbreak Shot.", "Mejora Bloodletter a Heartbreak Shot.");
        add("While under the effect of Army's Paeon with at least one stack of Repertoire, singing Mage's Ballad or the Wanderer's Minuet will grant Army's Muse, reducing weaponskill cast time and recast time, spell cast time and recast time, and auto-attack delay.",
            "Bajo el efecto de Army's Paeon con al menos una acumulación de Repertoire, cantar Mage's Ballad o the Wanderer's Minuet otorga Army's Muse, que reduce el tiempo de lanzamiento y de reutilización de técnicas de arma y hechizos, y el retraso del ataque automático.");
        add("Allowing the effect of Army's Paeon and accumulated stacks of Repertoire to expire without singing Mage's Ballad or the Wanderer's Minuet will grant Army's Ethos.",
            "Dejar que expiren el efecto de Army's Paeon y las acumulaciones de Repertoire sin cantar Mage's Ballad o the Wanderer's Minuet otorga Army's Ethos.");
        add("While under the effect of Army's Ethos, singing Mage's Ballad or the Wanderer's Minuet will grant Army's Muse. Both Army's Ethos and Army's Muse require stacks of Repertoire, the number of which will determine the potency of the latter.",
            "Bajo el efecto de Army's Ethos, cantar Mage's Ballad o the Wanderer's Minuet otorga Army's Muse. Army's Ethos y Army's Muse requieren acumulaciones de Repertoire, y su cantidad determina la potencia de Army's Muse.");
        add("{0} Repertoire:  {1}%", "{0} Repertoire: {1}%");
        add("Increases Soul Voice Gauge by {0} each time Repertoire is granted.", "Aumenta {0} el Soul Voice Gauge cada vez que se otorga Repertoire.");
        add("Allows a third charge of Bloodletter and Rain of Death.", "Permite una tercera carga de Bloodletter y Rain of Death.");
        add("Grants Blast Arrow Ready upon executing Apex Arrow after the Soul Voice Gauge has reached {0} or higher.",
            "Otorga Blast Arrow Ready al usar Apex Arrow con el Soul Voice Gauge en {0} o más.");
        add("Apex Arrow becomes Blast Arrow while under this effect.", "Apex Arrow se convierte en Blast Arrow bajo este efecto.");
        add("Reduces Troubadour recast time to {0} seconds.", "Reduce el tiempo de reutilización de Troubadour a {0} segundos.");
        add("Grants Mage's Coda, Army's Coda, or Wanderer's Coda upon singing Mage's Ballad, Army's Paeon, or the Wanderer's Minuet respectively.",
            "Otorga Mage's Coda, Army's Coda o Wanderer's Coda al cantar Mage's Ballad, Army's Paeon o the Wanderer's Minuet, respectivamente.");
        add("Grants Resonant Arrow Ready upon executing Barrage.", "Otorga Resonant Arrow Ready al usar Barrage.");
        add("Improves Troubadour's damage reduction effect to {0}%.", "Aumenta al {0}% la reducción de daño de Troubadour.");
        add("Grants Radiant Encore Ready upon executing Radiant Finale.", "Otorga Radiant Encore Ready al usar Radiant Finale.");
        add("Increases the potency of Empyreal Arrow to {0}, Sidewinder to {1}, Refulgent Arrow to {2}, Burst Shot to {3}, and Apex Arrow to {4} up to {5}.",
            "Aumenta la potencia de Empyreal Arrow a {0}, la de Sidewinder a {1}, la de Refulgent Arrow a {2}, la de Burst Shot a {3} y la de Apex Arrow de {4} hasta {5}.");

        // Archer / Bard: statuses

        add("Toxins are causing damage over time.", "Las toxinas causan daño periódico.");
        add("Dexterity is increased and all attacks are guaranteed to land.", "Aumenta la destreza y todos los ataques aciertan.");
        add("Damage dealt is increased.", "Aumenta el daño infligido.");
        add("Damage dealt by weaponskills is increased.", "Aumenta el daño de las técnicas de arma.");
        add("Able to execute Straight Shot and Wide Volley.", "Permite usar Straight Shot y Wide Volley.");
        add("Able to execute Refulgent Arrow and Wide Volley.", "Permite usar Refulgent Arrow y Wide Volley.");
        add("Able to execute Refulgent Arrow and Shadowbite.", "Permite usar Refulgent Arrow y Shadowbite.");
        add("Able to execute Straight Shot", "Permite usar Straight Shot");
        add("Able to execute Straight Shot and Wide Volley", "Permite usar Straight Shot y Wide Volley");
        add("Able to execute Refulgent Arrow and Wide Volley", "Permite usar Refulgent Arrow y Wide Volley");
        add("Able to execute Refulgent Arrow and Shadowbite", "Permite usar Refulgent Arrow y Shadowbite");
        add("Able to execute Blast Arrow.", "Permite usar Blast Arrow.");
        add("Able to execute Pitch Perfect.", "Permite usar Pitch Perfect.");
        add("Able to execute Resonant Arrow.", "Permite usar Resonant Arrow.");
        add("Able to execute Radiant Encore.", "Permite usar Radiant Encore.");
        add("Straight Shot will strike the selected target three times, while Wide Volley's potency will be increased.",
            "Straight Shot golpea tres veces al objetivo seleccionado y aumenta la potencia de Wide Volley.");
        add("Refulgent Arrow will strike the selected target three times, while Wide Volley's potency will be increased.",
            "Refulgent Arrow golpea tres veces al objetivo seleccionado y aumenta la potencia de Wide Volley.");
        add("Refulgent Arrow will strike the selected target three times, while Shadowbite's potency will be increased.",
            "Refulgent Arrow golpea tres veces al objetivo seleccionado y aumenta la potencia de Shadowbite.");
        add("Wounds are exposed to the elements, causing wind damage over time.", "Las heridas expuestas a los elementos causan daño de viento periódico.");
        add("Wounds are exposed to the elements, causing damage over time.", "Las heridas expuestas a los elementos causan daño periódico.");
        add("Critical hit rate is increased.", "Aumenta la tasa de golpe crítico.");
        add("Direct hit rate is increased.", "Aumenta la tasa de golpe directo.");
        add("Using MP to gradually restore the MP of nearby party members. Damage dealt is reduced.",
            "Usa MP para restaurar de forma gradual el MP de los miembros del grupo cercanos. Se reduce el daño infligido.");
        add("Using MP to gradually refresh the TP of self and nearby party members. Damage dealt is reduced.",
            "Usa MP para recuperar de forma gradual el TP tuyo y de los miembros del grupo cercanos. Se reduce el daño infligido.");
        add("Gradually regenerating TP.", "Regenerando TP de forma gradual.");
        add("Evasion is reduced.", "Se reduce la evasión.");
        add("Strength is transcending that of mere mortals.", "La fuerza trasciende la de los simples mortales.");
        add("Striking multiple times per weaponskill.", "Golpea varias veces con cada técnica de arma.");
        add("Auto-attack delay as well as weaponskill and spell cast and recast time are reduced.",
            "Se reducen el retraso del ataque automático y el tiempo de lanzamiento y de reutilización de técnicas de arma y hechizos.");
        add("Weaponskill and spell cast and recast time are reduced.",
            "Se reduce el tiempo de lanzamiento y de reutilización de técnicas de arma y hechizos.");
        add("Singing Mage's Ballad or the Wanderer's Minuet will grant the effect of Army's Muse.",
            "Cantar Mage's Ballad o the Wanderer's Minuet otorga el efecto de Army's Muse.");
        add("Playing a most radiant finale.", "Interpretando un final de lo más radiante.");
    }
}
