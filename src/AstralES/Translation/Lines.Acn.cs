namespace AstralES.Translation;

public static partial class Spanish
{
    // Arcanist is the base class of both Summoner and Scholar.
    private static void Acn(Action<string, string> add)
    {
        // Arcanist: actions

        add("Aetherflow Gauge Cost: {0}", "Costo de Aetherflow Gauge: {0}");
        add("Additional Effect: Aetherflow II", "Efecto adicional: Aetherflow II");
        add("Shares a recast timer with Energy Siphon.", "Comparte tiempo de reutilización con Energy Siphon.");
        add("Additional Effect: Grants Further Ruin", "Efecto adicional: Otorga Further Ruin");
        add("Summons Carbuncle to your side.", "Invoca a Carbuncle a tu lado.");
        add("Orders Carbuncle to execute Radiant Aegis.", "Ordena a Carbuncle usar Radiant Aegis.");
        add("Radiant Aegis Effect: Creates a barrier around self that absorbs damage totaling {0}% of your maximum HP",
            "Efecto de Radiant Aegis: Crea una barrera a tu alrededor que absorbe daño por un total del {0}% de tus HP máximos");
        // Carbuncle's own Radiant Aegis (action 25841): not in GameData, but it has its own text.
        add("Creates a barrier around you that absorbs damage totaling {0}% of your maximum HP.",
            "Crea una barrera a tu alrededor que absorbe daño por un total del {0}% de tus HP máximos.");
        add("Can only be executed while Carbuncle is summoned.", "Solo se puede usar mientras Carbuncle está invocado.");
        add("Can only be executed in combat and while Carbuncle is summoned.", "Solo se puede usar en combate y mientras Carbuncle está invocado.");
        add("Grants Aethercharge, increasing the potency of Ruin, Ruin II, and Ruin III by {0}, and Outburst by {1}.",
            "Otorga Aethercharge, que aumenta {0} la potencia de Ruin, Ruin II y Ruin III, y {1} la de Outburst.");
        add("Additional Effect: Grants Ruby Arcanum", "Efecto adicional: Otorga Ruby Arcanum");
        add("Additional Effect: Grants Ruby Arcanum and Topaz Arcanum", "Efecto adicional: Otorga Ruby Arcanum y Topaz Arcanum");
        add("Additional Effect: Grants Ruby Arcanum, Topaz Arcanum, and Emerald Arcanum", "Efecto adicional: Otorga Ruby Arcanum, Topaz Arcanum y Emerald Arcanum");
        add("Summons Ruby Carbuncle, and orders it to execute Glittering Ruby.", "Invoca a Ruby Carbuncle y le ordena usar Glittering Ruby.");
        add("Summons Topaz Carbuncle, and orders it to execute Glittering Topaz.", "Invoca a Topaz Carbuncle y le ordena usar Glittering Topaz.");
        add("Summons Emerald Carbuncle, and orders it to execute Glittering Emerald.", "Invoca a Emerald Carbuncle y le ordena usar Glittering Emerald.");
        add("Glittering Ruby Effect: Rushes target and deals fire damage with a potency of {0}",
            "Efecto de Glittering Ruby: Se lanza contra el objetivo e inflige daño de fuego con una potencia de {0}");
        add("Glittering Topaz Effect: Rushes target and deals earth damage with a potency of {0}",
            "Efecto de Glittering Topaz: Se lanza contra el objetivo e inflige daño de tierra con una potencia de {0}");
        add("Glittering Emerald Effect: Deals wind damage with a potency of {0}", "Efecto de Glittering Emerald: Inflige daño de viento con una potencia de {0}");
        add("Additional Effect: Grants {0} stacks of Fire Attunement", "Efecto adicional: Otorga {0} acumulaciones de Fire Attunement");
        add("Additional Effect: Grants {0} stacks of Earth Attunement", "Efecto adicional: Otorga {0} acumulaciones de Earth Attunement");
        add("Additional Effect: Grants {0} stacks of Wind Attunement", "Efecto adicional: Otorga {0} acumulaciones de Wind Attunement");
        add("Fire Attunement Effect: Gemshine and Precious Brilliance become fire-aspected",
            "Efecto de Fire Attunement: Gemshine y Precious Brilliance pasan a ser de fuego");
        add("Earth Attunement Effect: Gemshine and Precious Brilliance become earth-aspected",
            "Efecto de Earth Attunement: Gemshine y Precious Brilliance pasan a ser de tierra");
        add("Wind Attunement Effect: Gemshine and Precious Brilliance become wind-aspected",
            "Efecto de Wind Attunement: Gemshine y Precious Brilliance pasan a ser de viento");
        add("Can only be executed while under the effect of Ruby Arcanum and Carbuncle is summoned.",
            "Solo se puede usar bajo el efecto de Ruby Arcanum y mientras Carbuncle está invocado.");
        add("Can only be executed while under the effect of Topaz Arcanum and Carbuncle is summoned.",
            "Solo se puede usar bajo el efecto de Topaz Arcanum y mientras Carbuncle está invocado.");
        add("Can only be executed while under the effect of Emerald Arcanum and Carbuncle is summoned.",
            "Solo se puede usar bajo el efecto de Emerald Arcanum y mientras Carbuncle está invocado.");
        add("Current pet will leave the battlefield while Ruby Carbuncle is present, and return once gone.",
            "Tu mascota actual se retira mientras Ruby Carbuncle está presente y vuelve cuando se va.");
        add("Current pet will leave the battlefield while Topaz Carbuncle is present, and return once gone.",
            "Tu mascota actual se retira mientras Topaz Carbuncle está presente y vuelve cuando se va.");
        add("Current pet will leave the battlefield while Emerald Carbuncle is present, and return once gone.",
            "Tu mascota actual se retira mientras Emerald Carbuncle está presente y vuelve cuando se va.");
        add("Channel the energies of your active elemental attunement to attack your enemy.",
            "Canaliza la energía de tu sintonía elemental activa para atacar a tu enemigo.");
        add("Channel the energies of your active elemental attunement to attack multiple enemies.",
            "Canaliza la energía de tu sintonía elemental activa para atacar a varios enemigos.");
        add("Fire Attunement Effect: Deal fire damage to a single target", "Efecto de Fire Attunement: Inflige daño de fuego a un solo objetivo");
        add("Earth Attunement Effect: Deal earth damage to a single target", "Efecto de Earth Attunement: Inflige daño de tierra a un solo objetivo");
        add("Wind Attunement Effect: Deal wind damage to a single target", "Efecto de Wind Attunement: Inflige daño de viento a un solo objetivo");
        add("Fire Attunement Effect: Deal fire damage to a target and all enemies nearby it",
            "Efecto de Fire Attunement: Inflige daño de fuego al objetivo y a todos los enemigos cercanos");
        add("Earth Attunement Effect: Deal earth damage to a target and all enemies nearby it",
            "Efecto de Earth Attunement: Inflige daño de tierra al objetivo y a todos los enemigos cercanos");
        add("Wind Attunement Effect: Deal wind damage to a target and all enemies nearby it",
            "Efecto de Wind Attunement: Inflige daño de viento al objetivo y a todos los enemigos cercanos");

        // Arcanist: traits

        add("Increases base action damage and HP restoration by {0}%. Also increases base damage and HP restoration of your pet by {1}%.",
            "Aumenta un {0}% el daño base y la restauración de HP de tus acciones. También aumenta un {1}% el daño base y la restauración de HP de tu mascota.");
        add("Upgrades Ruin to Ruin II.", "Mejora Ruin a Ruin II.");
        add("Grants Ruby Arcanum and Topaz Arcanum upon executing Aethercharge.", "Otorga Ruby Arcanum y Topaz Arcanum al usar Aethercharge.");
        add("Grants Ruby Arcanum, Topaz Arcanum, and Emerald Arcanum upon executing Aethercharge.",
            "Otorga Ruby Arcanum, Topaz Arcanum y Emerald Arcanum al usar Aethercharge.");

        // Arcanist: statuses

        add("Aether is gathering in the body.", "El éter se acumula en el cuerpo.");
        add("Able to cast Ruin IV.", "Permite lanzar Ruin IV.");
        add("Able to execute Ruin IV.", "Permite usar Ruin IV.");
        add("Damage taken is significantly reduced. Unable to act.", "Se reduce mucho el daño recibido. No puede actuar.");
        add("Damage taken is reduced, and a magicked barrier is nullifying damage.", "Se reduce el daño recibido y una barrera mágica está anulando el daño.");
    }
}
