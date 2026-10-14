namespace AstralES.Translation;

public static partial class Spanish
{
    private static void War(Action<string, string> add)
    {
        // Warrior: actions

        add("Combo Action: Heavy Swing", "Acción de combo: Heavy Swing");
        add("Combo Action: Maim", "Acción de combo: Maim");
        add("Combo Action: Overpower", "Acción de combo: Overpower");
        add("Combo Bonus: Increases Beast Gauge by {0}", "Bonificación de combo: Aumenta {0} el Beast Gauge");
        add("Combo Bonus: Grants Surging Tempest, increasing damage dealt by {0}%",
            "Bonificación de combo: Otorga Surging Tempest, que aumenta un {0}% el daño infligido");
        add("Extends Surging Tempest duration by {0}s to a maximum of {1}s.", "Extiende {0} s la duración de Surging Tempest, hasta un máximo de {1} s.");
        add("Additional Effect: Extends Surging Tempest duration by {0}s to a maximum of {1}s",
            "Efecto adicional: Extiende {0} s la duración de Surging Tempest, hasta un máximo de {1} s");
        add("Beast Gauge Cost: {0}", "Costo de Beast Gauge: {0}");
        add("Increases Beast Gauge by {0}.", "Aumenta {0} el Beast Gauge.");
        add("Grants {0} stacks of Berserk, each stack guaranteeing weaponskill attacks are critical and direct hits.",
            "Otorga {0} acumulaciones de Berserk; cada una garantiza que los ataques con técnicas de arma sean golpes críticos y directos.");
        add("Grants {0} stacks of Inner Release, each stack allowing the use of Fell Cleave or Decimate without cost and guaranteeing they are critical and direct hits.",
            "Otorga {0} acumulaciones de Inner Release; cada una permite usar Fell Cleave o Decimate sin costo y garantiza que sean golpes críticos y directos.");
        add("Increases damage dealt when under an effect that raises critical hit rate or direct hit rate.",
            "Aumenta el daño infligido bajo un efecto que eleve la tasa de golpe crítico o de golpe directo.");
        add("Increases maximum HP by {0}% and restores the amount increased.", "Aumenta un {0}% los HP máximos y restaura la cantidad aumentada.");
        add("Brace yourself for an enemy onslaught, preventing most attacks from reducing your HP to less than {0}.",
            "Te preparas para la embestida enemiga e impides que la mayoría de los ataques bajen tus HP de {0}.");
        add("When a target is selected, halts their movement with chains.", "Si hay un objetivo seleccionado, lo inmoviliza con cadenas.");
        add("Reduces damage taken by {0}% and delivers an attack with a potency of {1} every time you suffer physical damage.",
            "Reduce un {0}% el daño recibido y realiza un ataque con una potencia de {1} cada vez que sufres daño físico.");
        add("Additional Effect: Grants Nascent Chaos", "Efecto adicional: Otorga Nascent Chaos");
        // Levels 72-79: the game itself drops the line break before "Maximum Charges".
        add("Nascent Chaos Effect: When Beast Gauge is {0} or greater, changes Decimate to Chaotic CycloneMaximum Charges: {1}",
            "Efecto de Nascent Chaos: Cuando el Beast Gauge es de {0} o más, Decimate se convierte en Chaotic CycloneCargas máximas: {1}");
        add("Nascent Chaos Effect: When Beast Gauge is {0} or greater, changes Decimate to Chaotic Cyclone and Fell Cleave to Inner Chaos",
            "Efecto de Nascent Chaos: Cuando el Beast Gauge es de {0} o más, Decimate se convierte en Chaotic Cyclone y Fell Cleave en Inner Chaos");
        add("Delivers an attack to all nearby enemies with a potency of {0}.", "Realiza un ataque a todos los enemigos cercanos con una potencia de {0}.");
        add("Delivers a critical direct hit with a potency of {0}.", "Realiza un golpe crítico directo con una potencia de {0}.");
        add("Delivers a critical direct hit with a potency of {0} to all nearby enemies.",
            "Realiza un golpe crítico directo con una potencia de {0} a todos los enemigos cercanos.");
        add("Delivers a critical direct hit to target and all enemies nearby it with a potency of {0} for the first enemy, and {1}% less for all remaining enemies.",
            "Realiza un golpe crítico directo al objetivo y a todos los enemigos cercanos con una potencia de {0} al primer enemigo y {1}% menos a los demás.");
        add("Jumps to the target and delivers a critical direct hit to target and all enemies nearby it with a potency of {0} for the first enemy, and {1}% less for all remaining enemies.",
            "Salta hacia el objetivo y realiza un golpe crítico directo al objetivo y a todos los enemigos cercanos con una potencia de {0} al primer enemigo y {1}% menos a los demás.");
        add("Additional Effect: Restores HP with each weaponskill successfully delivered",
            "Efecto adicional: Restaura HP con cada técnica de arma acertada");
        add("Restores own HP.", "Restaura tus HP.");
        add("Additional Effect: Gradually restores HP", "Efecto adicional: Restaura HP de forma gradual");
        add("Shares a recast timer with Nascent Flash.", "Comparte tiempo de reutilización con Nascent Flash.");
        add("Shares a recast timer with Raw Intuition.", "Comparte tiempo de reutilización con Raw Intuition.");
        add("Shares a recast timer with Bloodwhetting.", "Comparte tiempo de reutilización con Bloodwhetting.");
        add("Shares a recast timer with Orogeny.", "Comparte tiempo de reutilización con Orogeny.");
        add("Shares a recast timer with Upheaval.", "Comparte tiempo de reutilización con Upheaval.");
        add("Creates a barrier around self and all nearby party members that absorbs damage totaling {0}% of maximum HP.",
            "Crea una barrera alrededor de ti y de todos los miembros del grupo cercanos que absorbe daño por un total del {0}% de los HP máximos.");
        add("Dispels Thrill of Battle, Vengeance, and Raw Intuition, increasing damage absorbed by {0}% for each effect removed.",
            "Disipa Thrill of Battle, Vengeance y Raw Intuition, y aumenta un {0}% el daño absorbido por cada efecto eliminado.");
        add("Dispels Thrill of Battle, Vengeance, and Bloodwhetting, increasing damage absorbed by {0}% for each effect removed.",
            "Disipa Thrill of Battle, Vengeance y Bloodwhetting, y aumenta un {0}% el daño absorbido por cada efecto eliminado.");
        add("Dispels Thrill of Battle, Damnation, and Bloodwhetting, increasing damage absorbed by {0}% for each effect removed.",
            "Disipa Thrill of Battle, Damnation y Bloodwhetting, y aumenta un {0}% el daño absorbido por cada efecto eliminado.");
        add("Additional Effect: Grants Inner Strength, nullifying Stun, Sleep, Bind, Heavy, and most knockback and draw-in effects",
            "Efecto adicional: Otorga Inner Strength, que anula Stun, Sleep, Bind, Heavy y la mayoría de los efectos de empuje y atracción");
        add("Additional Effect: Grants Primal Rend Ready", "Efecto adicional: Otorga Primal Rend Ready");
        add("Additional Effect: Grants Primal Ruination Ready", "Efecto adicional: Otorga Primal Ruination Ready");
        add("Additional Effect: Grants a stack of Burgeoning Fury upon successfully landing Fell Cleave or Decimate, up to a maximum of {0}",
            "Efecto adicional: Otorga una acumulación de Burgeoning Fury al acertar Fell Cleave o Decimate, hasta un máximo de {0}");
        add("At maximum stacks, become Wrathful, changing Inner Release to Primal Wrath.",
            "Con el máximo de acumulaciones pasas a Wrathful, e Inner Release se convierte en Primal Wrath.");
        add("Additional Effect: Reduces the recast time of Infuriate by {0} seconds",
            "Efecto adicional: Reduce {0} segundos el tiempo de reutilización de Infuriate");
        add("Grants Nascent Flash to self and Nascent Glint to target party member.",
            "Te otorga Nascent Flash y otorga Nascent Glint al miembro del grupo seleccionado.");
        add("Nascent Flash Effect: Restores HP with each weaponskill successfully delivered",
            "Efecto de Nascent Flash: Restaura HP con cada técnica de arma acertada");
        add("Nascent Glint Effect: Restores HP equaling {0}% of that recovered by Nascent Flash while also reducing damage taken by {1}%",
            "Efecto de Nascent Glint: Restaura HP equivalentes al {0}% de lo que recupera Nascent Flash y además reduce un {1}% el daño recibido");
        add("Additional Effect: Grants Stem the Flow to target, reducing damage taken by {0}%",
            "Efecto adicional: Otorga Stem the Flow al objetivo, que reduce un {0}% el daño recibido");
        add("Additional Effect: Grants Stem the Tide to target, nullifying damage equivalent to a heal of {0} potency",
            "Efecto adicional: Otorga Stem the Tide al objetivo, que anula daño equivalente a una curación de potencia {0}");
        add("Additional Effect: Grants Stem the Flow", "Efecto adicional: Otorga Stem the Flow");
        add("Stem the Flow Effect: Reduces damage taken by {0}%", "Efecto de Stem the Flow: Reduce un {0}% el daño recibido");
        add("Additional Effect: Grants Stem the Tide", "Efecto adicional: Otorga Stem the Tide");
        add("Stem the Tide Effect: Creates a barrier around self that absorbs damage equivalent to a heal of {0} potency",
            "Efecto de Stem the Tide: Crea una barrera alrededor de ti que absorbe daño equivalente a una curación de potencia {0}");
        add("Additional Effect: Grants Primeval Impulse when the effect expires or damage is taken",
            "Efecto adicional: Otorga Primeval Impulse cuando el efecto termina o al recibir daño");
        add("Primeval Impulse Effect: Healing over time", "Efecto de Primeval Impulse: Curación periódica");
        add("Cancels the effect of Defiance.", "Cancela el efecto de Defiance.");
        add("Can only be executed while under the effect of Nascent Chaos. Effect fades upon execution.",
            "Solo se puede usar bajo el efecto de Nascent Chaos. El efecto termina al usarla.");
        add("Can only be executed while under the effect of Primal Rend Ready, granted by Inner Release.",
            "Solo se puede usar bajo el efecto de Primal Rend Ready, que otorga Inner Release.");
        add("Can only be executed while under the effect of Primal Ruination Ready.", "Solo se puede usar bajo el efecto de Primal Ruination Ready.");
        add("Can only be executed when Wrathful.", "Solo se puede usar en estado Wrathful.");
        add("※Decimate changes to Chaotic Cyclone when requirements for execution are met.",
            "※Decimate se convierte en Chaotic Cyclone cuando se cumplen los requisitos para usarla.");
        add("※Fell Cleave changes to Inner Chaos when requirements for execution are met.",
            "※Fell Cleave se convierte en Inner Chaos cuando se cumplen los requisitos para usarla.");
        add("※Inner Release changes to Primal Wrath when requirements for execution are met.",
            "※Inner Release se convierte en Primal Wrath cuando se cumplen los requisitos para usarla.");
        add("※Primal Rend changes to Primal Ruination when requirements for execution are met.",
            "※Primal Rend se convierte en Primal Ruination cuando se cumplen los requisitos para usarla.");

        // Warrior: traits

        add("Reduces Infuriate recast time by {0} seconds upon landing Fell Cleave or Decimate on most targets.",
            "Reduce {0} segundos el tiempo de reutilización de Infuriate al acertar Fell Cleave o Decimate sobre la mayoría de los objetivos.");
        add("Upgrades Berserk to Inner Release.", "Mejora Berserk a Inner Release.");
        add("Upgrades Inner Beast to Fell Cleave.", "Mejora Inner Beast a Fell Cleave.");
        add("Upgrades Steel Cyclone to Decimate.", "Mejora Steel Cyclone a Decimate.");
        add("Upgrades Raw Intuition to Bloodwhetting.", "Mejora Raw Intuition a Bloodwhetting.");
        add("Upgrades Vengeance to Damnation.", "Mejora Vengeance a Damnation.");
        add("Increases Beast Gauge when landing Maim or Storm's Path in a combo.", "Aumenta el Beast Gauge al acertar Maim o Storm's Path en combo.");
        add("Increases Beast Gauge when landing Mythril Tempest in a combo.", "Aumenta el Beast Gauge al acertar Mythril Tempest en combo.");
        add("Infuriate grants the effect of Nascent Chaos, upgrading Decimate to Chaotic Cyclone when the Beast Gauge is {0} or greater. Upon reaching level {1}, Nascent Chaos will also upgrade Fell Cleave to Inner Chaos.",
            "Infuriate otorga el efecto de Nascent Chaos, que mejora Decimate a Chaotic Cyclone cuando el Beast Gauge es de {0} o más. Al llegar al nivel {1}, Nascent Chaos también mejora Fell Cleave a Inner Chaos.");
        add("Adds an additional effect to Thrill of Battle that increases HP recovery via healing actions by {0}%.",
            "Agrega a Thrill of Battle un efecto adicional que aumenta un {0}% la recuperación de HP por acciones de curación.");
        add("Adds a healing effect to Shake It Off.", "Agrega un efecto de curación a Shake It Off.");
        add("Extends the duration of Nascent Flash and Nascent Glint to {0} seconds.", "Extiende a {0} segundos la duración de Nascent Flash y Nascent Glint.");
        add("Grants Stem the Flow to target, reducing damage taken by {0}%.", "Otorga Stem the Flow al objetivo, que reduce un {0}% el daño recibido.");
        add("Grants Stem the Tide to target, nullifying damage equivalent to a heal of {0} potency.",
            "Otorga Stem the Tide al objetivo, que anula daño equivalente a una curación de potencia {0}.");
        add("Grants healing over time to self.", "Te otorga curación periódica.");
        add("Allows a third charge of Onslaught.", "Permite una tercera carga de Onslaught.");
        add("Increases the potency of Heavy Swing to {0}, Maim to {1}, Storm's Path to {2}, and Storm's Eye to {3}.",
            "Aumenta la potencia de Heavy Swing a {0}, Maim a {1}, Storm's Path a {2} y Storm's Eye a {3}.");
        add("Increases the potency of Heavy Swing to {0}, Maim to {1}, Storm's Path to {2}, Storm's Eye to {3}, Fell Cleave to {4}, and Upheaval to {5}.",
            "Aumenta la potencia de Heavy Swing a {0}, Maim a {1}, Storm's Path a {2}, Storm's Eye a {3}, Fell Cleave a {4} y Upheaval a {5}.");
        add("Grants a stack of Burgeoning Fury upon landing Fell Cleave or Decimate while under the effect of Inner Release.",
            "Otorga una acumulación de Burgeoning Fury al acertar Fell Cleave o Decimate bajo el efecto de Inner Release.");
        add("At maximum stacks, become Wrathful, upgrading Inner Release to Primal Wrath.",
            "Con el máximo de acumulaciones pasas a Wrathful, e Inner Release mejora a Primal Wrath.");
        add("Grants the effect of Primal Ruination Ready after executing Primal Rend.", "Otorga el efecto de Primal Ruination Ready después de usar Primal Rend.");

        // Warrior: statuses

        add("Unable to move.", "No puedes moverte.");
        add("Unable to move until effect fades.", "No puedes moverte hasta que termine el efecto.");
        add("Unable to move until effect fades. Most attacks cannot reduce your HP to less than {0}.",
            "No puedes moverte hasta que termine el efecto. La mayoría de los ataques no pueden bajar tus HP de {0}.");
        add("All weaponskill attacks are both critical and direct hits. Damage dealt when under an effect that raises critical hit rate or direct hit rate is increased.",
            "Todos los ataques con técnicas de arma son golpes críticos y directos. El daño aumenta bajo un efecto que eleve la tasa de golpe crítico o de golpe directo.");
        add("Beast Gauge consumption for Fell Cleave and Decimate is reduced to {0}. Attacks with these weaponskills are guaranteed critical and direct hits. Damage dealt when under an effect that raises critical hit rate or direct hit rate is increased.",
            "El consumo de Beast Gauge de Fell Cleave y Decimate se reduce a {0}. Los ataques con estas técnicas de arma son siempre golpes críticos y directos. El daño aumenta bajo un efecto que eleve la tasa de golpe crítico o de golpe directo.");
        add("Maximum HP is increased.", "Aumentan los HP máximos.");
        add("Enhanced Thrill of Battle Effect: HP recovery via healing actions is increased.",
            "Efecto de Enhanced Thrill of Battle: Aumenta la recuperación de HP por acciones de curación.");
        add("Damage taken is reduced while inflicting a portion of sustained damage back to its source.",
            "Se reduce el daño recibido y se devuelve parte del daño sufrido a su origen.");
        add("Damage taken is reduced while inflicting a portion of sustained damage back to its source. HP will be restored over time when effect expires.",
            "Se reduce el daño recibido y se devuelve parte del daño sufrido a su origen. Al terminar el efecto, se restauran HP de forma gradual.");
        add("Chance to parry is increased.", "Aumenta la probabilidad de parar ataques.");
        add("Damage taken is reduced and HP is restored with each weaponskill successfully delivered.",
            "Se reduce el daño recibido y se restauran HP con cada técnica de arma acertada.");
        add("Damage taken from Outburst and Ruin spells cast by arcanists and summoners is increased.",
            "Aumenta el daño recibido de los hechizos Outburst y Ruin que lanzan arcanists y summoners.");
        add("All Stun, Heavy, Bind, Silence, Half-asleep, Sleep, Deep Freeze, knockback, and draw-in effects are nullified. Potency of certain weaponskills is also increased. Movement speed is also increased.",
            "Se anulan todos los efectos de Stun, Heavy, Bind, Silence, Half-asleep, Sleep, Deep Freeze, empuje y atracción. También aumenta la potencia de ciertas técnicas de arma. También aumenta la velocidad de movimiento.");
        add("All Stun, Sleep, Bind, Heavy, and most knockback and draw-in effects are nullified.",
            "Se anulan todos los efectos de Stun, Sleep, Bind y Heavy, y la mayoría de los de empuje y atracción.");
        add("A highly effective defensive maneuver is nullifying damage.", "Una maniobra defensiva muy eficaz anula el daño.");
        add("Restoring HP with each weaponskill successfully delivered.", "Restaurando HP con cada técnica de arma acertada.");
        add("Receiving {0}% of all HP recovered by the warrior who granted this status via Nascent Flash. Damage taken is reduced.",
            "Recibe el {0}% de todos los HP que recupera con Nascent Flash el warrior que otorgó este estado. Se reduce el daño recibido.");
        add("Damage taken is reduced, and receiving {0}% of all HP absorbed by the warrior who granted this status via Nascent Flash.",
            "Se reduce el daño recibido y recibe el {0}% de todos los HP que absorbe con Nascent Flash el warrior que otorgó este estado.");
        add("Accumulating sufficient wrath in the Beast Gauge will upgrade Decimate to Chaotic Cyclone.",
            "Acumular suficiente furia en el Beast Gauge mejora Decimate a Chaotic Cyclone.");
        add("Fell Cleave will be upgraded to Inner Chaos once learned.", "Fell Cleave mejorará a Inner Chaos cuando la aprendas.");
        add("A barrier is preventing damage.", "Una barrera está evitando el daño.");
        add("Absorbing HP with each physical attack delivered.", "Absorbiendo HP con cada ataque físico realizado.");
        add("Absorbing HP with each physical attack delivered. Damage taken is also reduced.",
            "Absorbiendo HP con cada ataque físico realizado. Además, se reduce el daño recibido.");
        add("Weaponskills generate HP equal to the amount of damage dealt.", "Las técnicas de arma generan HP iguales al daño infligido.");
        add("Fury is building within you. At {0} stacks, effect changes to Wrathful, allowing you to execute Primal Wrath.",
            "La furia crece en tu interior. Con {0} acumulaciones, el efecto pasa a Wrathful y permite usar Primal Wrath.");
        add("Able to execute Primal Rend.", "Permite usar Primal Rend.");
        add("Able to execute Primal Ruination.", "Permite usar Primal Ruination.");
        add("Able to execute Primal Wrath.", "Permite usar Primal Wrath.");
    }
}
