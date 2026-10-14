namespace AstralES.Translation;

public static partial class Spanish
{
    private static void Whm(Action<string, string> add)
    {
        // Conjurer / White Mage: actions

        add("Deals earth damage with a potency of {0}.", "Inflige daño de tierra con una potencia de {0}.");
        add("Deals wind damage with a potency of {0}.", "Inflige daño de viento con una potencia de {0}.");
        add("Deals unaspected damage with a potency of {0} to all nearby enemies.",
            "Inflige daño sin elemento con una potencia de {0} a todos los enemigos cercanos.");
        add("Additional Effect: Wind damage over time", "Efecto adicional: Daño de viento periódico");
        add("Additional Effect: Unaspected damage over time", "Efecto adicional: Daño sin elemento periódico");
        add("Additional Effect: Stun", "Efecto adicional: Stun");
        add("Additional Effect: Regen", "Efecto adicional: Regen");
        add("Restores target's HP.", "Restaura los HP del objetivo.");
        add("Restores all of a target's HP.", "Restaura todos los HP del objetivo.");
        add("Restores own HP and the HP of all nearby party members.", "Restaura tus HP y los de todos los miembros del grupo cercanos.");
        add("Restores own or target party member's HP and all party members nearby target.",
            "Restaura tus HP o los del miembro del grupo seleccionado, y los de todos los miembros del grupo cercanos al objetivo.");
        add("Additional Effect: Restores own HP and the HP of nearby party members",
            "Efecto adicional: Restaura tus HP y los de los miembros del grupo cercanos");
        add("Additional Effect: Restores {0}% of maximum MP", "Efecto adicional: Restaura el {0}% del MP máximo");
        add("Additional Effect: {0}% chance next Cure II will cost no MP",
            "Efecto adicional: {0}% de probabilidad de que el siguiente Cure II no consuma MP");
        add("Resurrects target to a weakened state.", "Resucita al objetivo en estado debilitado.");
        add("Reduces spell cast time and recast time, and auto-attack delay by {0}%.",
            "Reduce un {0}% el tiempo de lanzamiento y de reutilización de los hechizos y el retraso del ataque automático.");
        add("Additional Effect: Grants {0} stacks of Sacred Sight", "Efecto adicional: Otorga {0} acumulaciones de Sacred Sight");
        add("Grants healing over time effect to target.", "Otorga al objetivo un efecto de curación periódica.");
        add("Envelops a designated area in a veil of succor, granting healing over time to self and any party members who enter.",
            "Cubre el área designada con un velo de socorro que otorga curación periódica a ti y a los miembros del grupo que entren.");
        add("Additional Effect: Increases HP recovery via healing actions on party members in the designated area by {0}%",
            "Efecto adicional: Aumenta un {0}% la recuperación de HP por acciones de curación de los miembros del grupo dentro del área");
        add("Next action is executed without MP cost.", "La siguiente acción se ejecuta sin costo de MP.");
        add("Creates a barrier around self or target party member that absorbs damage equivalent to a heal of {0} potency.",
            "Crea una barrera alrededor de ti o del miembro del grupo seleccionado que absorbe daño equivalente a una curación de potencia {0}.");
        add("Creates a barrier around self and all party members near you that absorbs damage equivalent to a heal of {0} potency.",
            "Crea una barrera alrededor de ti y de todos los miembros del grupo cercanos que absorbe daño equivalente a una curación de potencia {0}.");
        add("Grants Confession to self and nearby party members, reducing damage taken by {0}%.",
            "Otorga Confession a ti y a los miembros del grupo cercanos, y reduce un {0}% el daño recibido.");
        add("Party members under the effect of Confession will receive additional healing upon receiving HP recovery via Medica, Medica II, or Cure III.",
            "Los miembros del grupo bajo el efecto de Confession reciben curación adicional al recuperar HP con Medica, Medica II o Cure III.");
        add("Party members under the effect of Confession will receive additional healing upon receiving HP recovery via Medica, Medica II, Cure III, or Afflatus Rapture.",
            "Los miembros del grupo bajo el efecto de Confession reciben curación adicional al recuperar HP con Medica, Medica II, Cure III o Afflatus Rapture.");
        add("Party members under the effect of Confession will receive additional healing upon receiving HP recovery via Medica, Medica III, Cure III, or Afflatus Rapture.",
            "Los miembros del grupo bajo el efecto de Confession reciben curación adicional al recuperar HP con Medica, Medica III, Cure III o Afflatus Rapture.");
        add("Healing Gauge Cost: {0} Lily", "Costo de Healing Gauge: {0} Lily");
        add("Additional Effect: Nourishes the Blood Lily", "Efecto adicional: Nutre la Blood Lily");
        add("Can only be executed when the Blood Lily is in full bloom.", "Solo se puede usar cuando la Blood Lily está en plena floración.");
        add("Increases healing magic potency by {0}%, while reducing damage taken by self and all party members within a radius of {1} yalms by {2}%.",
            "Aumenta un {0}% la potencia de la magia curativa y reduce un {2}% el daño que reciben tú y todos los miembros del grupo en un radio de {1} yalms.");
        add("Additional Effect: Grants Divine Grace", "Efecto adicional: Otorga Divine Grace");
        add("Reduces damage taken by a party member or self by {0}%.", "Reduce un {0}% el daño que recibe un miembro del grupo o tú.");
        add("Places a healing blossom at the designated location and grants {0} stacks of Liturgy of the Bell to self.",
            "Coloca una flor curativa en el lugar designado y te otorga {0} acumulaciones de Liturgy of the Bell.");
        add("Taking damage will expend {0} stack of Liturgy of the Bell to heal self and all party members within a radius of {1} yalms.",
            "Al recibir daño se gasta {0} acumulación de Liturgy of the Bell para curarte a ti y a todos los miembros del grupo en un radio de {1} yalms.");
        add("The effect of this action can only be triggered once per second.", "El efecto de esta acción solo se puede activar una vez por segundo.");
        add("Any remaining stacks of Liturgy of the Bell will trigger an additional healing effect when time expires or upon executing this action a second time.",
            "Las acumulaciones restantes de Liturgy of the Bell activan una curación adicional cuando se agota el tiempo o al usar esta acción por segunda vez.");
        add("Cure Potency: {0} for every remaining stack of Liturgy of the Bell",
            "Potencia de curación: {0} por cada acumulación restante de Liturgy of the Bell");
        add("This action does not share a recast timer with any other actions.", "Esta acción no comparte tiempo de reutilización con ninguna otra.");
        add("Quickly dash {0} yalms forward.", "Avanza rápidamente {0} yalms.");
        add("Can only be executed while Sacred Sight is active.", "Solo se puede usar mientras Sacred Sight está activo.");
        add("Can only be executed while Divine Grace is active.", "Solo se puede usar mientras Divine Grace está activo.");
        add("Additional Effect: Grants Divine Aura when barrier effect expires",
            "Efecto adicional: Otorga Divine Aura cuando expira el efecto de la barrera");
        add("Divine Aura Effect: Healing over time", "Efecto de Divine Aura: Curación periódica");

        // Conjurer / White Mage: traits

        add("Grants a {0}% chance that after casting Cure, the MP cost for your next Cure II will be {1}.",
            "Otorga un {0}% de probabilidad de que, tras lanzar Cure, el costo de MP de tu siguiente Cure II sea {1}.");
        add("Upgrades Stone to Stone II.", "Mejora Stone a Stone II.");
        add("Upgrades Stone II to Stone III.", "Mejora Stone II a Stone III.");
        add("Upgrades Stone III to Stone IV.", "Mejora Stone III a Stone IV.");
        add("Upgrades Stone IV to Glare.", "Mejora Stone IV a Glare.");
        add("Upgrades Glare to Glare III.", "Mejora Glare a Glare III.");
        add("Upgrades Aero to Aero II.", "Mejora Aero a Aero II.");
        add("Upgrades Aero II to Dia.", "Mejora Aero II a Dia.");
        add("Upgrades Holy to Holy III.", "Mejora Holy a Holy III.");
        add("Upgrades Medica II to Medica III.", "Mejora Medica II a Medica III.");
        add("Adds a Lily to your Healing Gauge for every {0} seconds you are engaged in combat, up to a maximum of {1}.",
            "Agrega una Lily a tu Healing Gauge por cada {0} segundos en combate, hasta un máximo de {1}.");
        add("Adds a Blood Lily to the Healing Gauge that blooms after three uses of Afflatus Solace or Afflatus Rapture.",
            "Agrega al Healing Gauge una Blood Lily que florece tras tres usos de Afflatus Solace o Afflatus Rapture.");
        add("Adds an additional effect to Asylum that increases HP recovery via healing actions by {0}%.",
            "Agrega a Asylum un efecto adicional que aumenta un {0}% la recuperación de HP por acciones de curación.");
        add("Increases the healing potency of Cure to {0}, Medica to {1}, Cure II to {2}, Regen to {3}, Cure III to {4}, Medica II to {5}, Medica II's Regen effect to {6}, Afflatus Solace to {7}, and Afflatus Rapture to {8}.",
            "Aumenta la potencia de curación de Cure a {0}, Medica a {1}, Cure II a {2}, Regen a {3}, Cure III a {4}, Medica II a {5}, el efecto Regen de Medica II a {6}, Afflatus Solace a {7} y Afflatus Rapture a {8}.");
        add("Allows the accumulation of charges for consecutive uses of Divine Benison.",
            "Permite acumular cargas para usar Divine Benison de forma consecutiva.");
        add("Allows the accumulation of charges for consecutive uses of Tetragrammaton.",
            "Permite acumular cargas para usar Tetragrammaton de forma consecutiva.");
        add("Presence of Mind grants {0} stacks of Sacred Sight upon execution.", "Presence of Mind otorga {0} acumulaciones de Sacred Sight al usarse.");
        add("Temperance grants Divine Grace upon execution.", "Temperance otorga Divine Grace al usarse.");
        add("Increases the potency of Dia and its damage over time to {0}, Afflatus Misery to {1}, and Glare III to {2}.",
            "Aumenta la potencia de Dia y de su daño periódico a {0}, la de Afflatus Misery a {1} y la de Glare III a {2}.");

        // Conjurer / White Mage: statuses

        add("Unable to execute actions.", "No puede ejecutar acciones.");
        add("Unable to act.", "No puede actuar.");
        add("Unable to act and taking increased damage.", "No puede actuar y recibe más daño.");
        add("Sustaining wind damage over time.", "Recibiendo daño de viento periódico.");
        add("Sustaining damage over time.", "Recibiendo daño periódico.");
        add("Regenerating HP over time.", "Regenerando HP de forma gradual.");
        add("Restoring HP over time for self and nearby party members.", "Restaurando HP de forma gradual a ti y a los miembros del grupo cercanos.");
        add("Next Cure II will not require any MP to cast.", "El siguiente Cure II no consume MP.");
        add("Next spell cast consumes no MP.", "El siguiente hechizo no consume MP.");
        add("Spell cast times, recast times, and auto-attack delay are reduced.",
            "Se reducen el tiempo de lanzamiento y de reutilización de los hechizos y el retraso del ataque automático.");
        add("Plunged into the depths of misery. Damage taken is increased.", "En las profundidades de la miseria. Aumenta el daño recibido.");
        add("Damage taken is increased.", "Aumenta el daño recibido.");
        add("A veil of succor is healing party members in the area.", "Un velo de socorro está curando a los miembros del grupo en el área.");
        add("A holy blessing from the gods is nullifying damage.", "Una bendición sagrada de los dioses está anulando el daño.");
        add("A magicked barrier is nullifying damage.", "Una barrera mágica está anulando el daño.");
        add("A holy barrier is nullifying damage.", "Una barrera sagrada está anulando el daño.");
        add("Sins are confessed, partially diminishing damage accrued. Additional HP is recovered when receiving the healing effect of certain spells cast by the white mage who granted this effect.",
            "Los pecados fueron confesados, lo que reduce en parte el daño acumulado. Se recupera HP adicional al recibir la curación de ciertos hechizos del white mage que otorgó este efecto.");
        add("Healing magic potency is increased.", "Aumenta la potencia de la magia curativa.");
        add("Healing magic potency is increased while damage taken by nearby party members is reduced.",
            "Aumenta la potencia de la magia curativa y se reduce el daño que reciben los miembros del grupo cercanos.");
        add("HP recovery via healing actions is increased.", "Aumenta la recuperación de HP por acciones de curación.");
        add("Triggers a healing effect upon taking damage, when duration expires, or upon executing Liturgy of the Bell a second time.",
            "Activa una curación al recibir daño, al terminar la duración o al usar Liturgy of the Bell por segunda vez.");
        add("Able to execute Glare IV.", "Permite usar Glare IV.");
        add("Able to execute Divine Caress.", "Permite usar Divine Caress.");
    }
}
