namespace AstralES.Translation;

public static partial class Spanish
{
    private static void Bst(Action<string, string> add)
    {
        // Beastmaster: actions

        add("Target cannot be incapacitated by this attack.", "Este ataque no puede dejar fuera de combate al objetivo.");
        add("Additional Effect: Marks target with Interest Captured", "Efecto adicional: Marca al objetivo con Interest Captured");
        add("Interest Captured Effect: Forges a pact with the targeted beast should you succeed in their subdual",
            "Efecto de Interest Captured: Sella un pacto con la bestia seleccionada si logras someterla");
        add("Success is determined upon defeating targets under the effect of Interest Captured.",
            "El éxito se decide al derrotar a objetivos bajo el efecto de Interest Captured.");
        add("An entry in the Master's Bestiary will be added upon successful subdual, allowing the beast to be summoned as a familiar.",
            "Si logras someterla, se agrega una entrada al Master's Bestiary y puedes invocar a la bestia como familiar.");
        add("Success rate is inversely proportional to the target's HP at the time of execution. Furthermore, success rate increases if the target is a lower level than you.",
            "La probabilidad de éxito es inversamente proporcional a los HP del objetivo al usarla. Además, aumenta si el objetivo es de menor nivel que tú.");
        add("Ineffective against targets whose level is higher than your own.", "No tiene efecto contra objetivos de mayor nivel que el tuyo.");
        add("Summons a familiar to fight at your side.", "Invoca a un familiar para que luche a tu lado.");
        add("During combat, recast timer cooldown will begin once your familiar has retreated. Retreat outside of combat will not affect recast timer.",
            "En combate, el tiempo de reutilización empieza a correr cuando tu familiar se retira. Retirarlo fuera de combate no afecta el tiempo de reutilización.");
        add("Additional Effect: Grants One with Nature", "Efecto adicional: Otorga One with Nature");
        add("Additional Effect: Resets Tempered Release recast timer", "Efecto adicional: Reinicia el tiempo de reutilización de Tempered Release");
        add("Additional Effect: Resets Borrow recast timer", "Efecto adicional: Reinicia el tiempo de reutilización de Borrow");
        add("Summons your <sheet(Pet,<sheet(XBMPet,gnum{0})>,{1})> to fight at your side.",
            "Invoca a tu <sheet(Pet,<sheet(XBMPet,gnum{0})>,{1})> para que luche a tu lado.");
        add("Investigates a targeted beast's probability of Capture.", "Investiga la probabilidad de Capture de la bestia seleccionada.");
        add("Can be executed while mounted, but only when grounded.", "Se puede usar montado, pero solo en tierra.");
        add("Combo Action: Smash Axe", "Acción de combo: Smash Axe");
        add("Combo Bonus: Increases TP Gauge by {0}", "Bonificación de combo: Aumenta {0} el TP Gauge");
        add("Potency increases up to {0} as TP nears maximum. All TP will be expended upon execution.",
            "La potencia aumenta hasta {0} a medida que los TP se acercan al máximo. Al usarla, se gastan todos los TP.");
        add("Minimum TP Gauge Cost: {0}", "Costo mínimo de TP Gauge: {0}");
        add("Instinctual Affinity: Rampant", "Afinidad instintiva: Rampant");
        add("Additional Effect: Grants Rampant Heart", "Efecto adicional: Otorga Rampant Heart");
        add("Instinctual skills may be executed sequentially to deal additional damage, which is determined by the skill that completes the combo.",
            "Las técnicas instintivas se pueden usar en secuencia para infligir daño adicional, que depende de la técnica que completa el combo.");
        add("Executing a Rampant skill while under the effect of Volant Heart will complete a Sunstrider intentional combo, dealing greater additional damage.",
            "Usar una técnica Rampant bajo el efecto de Volant Heart completa un combo intencional Sunstrider, que inflige más daño adicional.");
        add("Instinctual skills do not share a recast timer with any other actions.",
            "Las técnicas instintivas no comparten tiempo de reutilización con ninguna otra acción.");
        add("Combo Action: Axeblade Bite", "Acción de combo: Axeblade Bite");
        add("Upon using Borrow, changes to an action dependent on Kinship.", "Al usar Borrow, se convierte en una acción que depende de Kinship.");
        add("Beast Kinship Effect: Action reduces physical vulnerability", "Efecto de Beast Kinship: La acción reduce la vulnerabilidad física");
        add("Vile Kinship Effect: Action increases block rate", "Efecto de Vile Kinship: La acción aumenta la tasa de bloqueo");
        add("Cloud Kinship Effect: Action bolsters movement", "Efecto de Cloud Kinship: La acción mejora el movimiento");
        add("Seed Kinship Effect: Action inflicts poison and weakening effects", "Efecto de Seed Kinship: La acción aplica veneno y efectos debilitantes");
        add("Wave Kinship Effect: Action deals ranged magic damage to a single target",
            "Efecto de Wave Kinship: La acción inflige daño mágico a distancia a un solo objetivo");
        add("Scale Kinship Effect: Action absorbs magic damage", "Efecto de Scale Kinship: La acción absorbe daño mágico");
        add("Soul Kinship Effect: Action delivers an attack that interrupts a single target",
            "Efecto de Soul Kinship: La acción realiza un ataque que interrumpe a un solo objetivo");
        add("Ash Kinship Effect: Action removes a detrimental effect", "Efecto de Ash Kinship: La acción elimina un efecto perjudicial");
        add("Instinctual Affinity: Durant", "Afinidad instintiva: Durant");
        add("Additional Effect: Grants Durant Heart", "Efecto adicional: Otorga Durant Heart");
        add("Executing a Durant skill while under the effect of Rampant Heart will complete a Moonstalker intentional combo, dealing greater additional damage.",
            "Usar una técnica Durant bajo el efecto de Rampant Heart completa un combo intencional Moonstalker, que inflige más daño adicional.");
        add("Instinctual Affinity: Eldritch", "Afinidad instintiva: Eldritch");
        add("Additional Effect: Grants Eldritch Heart", "Efecto adicional: Otorga Eldritch Heart");
        add("Executing an Eldritch skill while under the effect of Durant Heart will complete a Sunstrider intentional combo, dealing greater additional damage.",
            "Usar una técnica Eldritch bajo el efecto de Durant Heart completa un combo intencional Sunstrider, que inflige más daño adicional.");
        add("Instinctual Affinity: Volant", "Afinidad instintiva: Volant");
        add("Additional Effect: Grants Volant Heart", "Efecto adicional: Otorga Volant Heart");
        add("Executing a Volant skill while under the effect of Eldritch Heart will complete a Moonstalker intentional combo, dealing greater additional damage.",
            "Usar una técnica Volant bajo el efecto de Eldritch Heart completa un combo intencional Moonstalker, que inflige más daño adicional.");
        add("Orders your familiar to execute a controlled ability.", "Ordena a tu familiar usar una habilidad controlada.");
        add("Can only be executed while in combat and under the effect of One with Nature.",
            "Solo se puede usar en combate y bajo el efecto de One with Nature.");
        add("Additional Effect: Grants Lingering Vantage", "Efecto adicional: Otorga Lingering Vantage");
        add("Orders your familiar to execute Aetheric Burst.", "Ordena a tu familiar usar Aetheric Burst.");
        add("Aetheric Burst Effect: Deals unaspected damage to target and all enemies nearby it with a potency of {0}",
            "Efecto de Aetheric Burst: Inflige daño sin elemento con una potencia de {0} al objetivo y a todos los enemigos cercanos");
        add("Familiar retreats from combat upon execution.", "Al usarla, el familiar se retira del combate.");
        add("Additional Effect: Increases Familiar TP Gauge by {0}", "Efecto adicional: Aumenta {0} el Familiar TP Gauge");
        add("Lingering Vantage Potency: {0}", "Potencia con Lingering Vantage: {0}");
        add("Rushes forward and delivers an attack to target and all enemies nearby it with a potency of {0}",
            "Se lanza hacia delante y realiza un ataque con una potencia de {0} al objetivo y a todos los enemigos cercanos");
        add("Borrows aether from your summoned familiar to gain Kinship according to its classification.",
            "Toma éter de tu familiar invocado para obtener Kinship según su clasificación.");
        add("Beastkin Familiar Effect: Grants Beast Kinship", "Efecto con un familiar Beastkin: Otorga Beast Kinship");
        add("Vilekin Familiar Effect: Grants Vile Kinship", "Efecto con un familiar Vilekin: Otorga Vile Kinship");
        add("Cloudkin Familiar Effect: Grants Cloud Kinship", "Efecto con un familiar Cloudkin: Otorga Cloud Kinship");
        add("Seedkin Familiar Effect: Grants Seed Kinship", "Efecto con un familiar Seedkin: Otorga Seed Kinship");
        add("Wavekin Familiar Effect: Grants Wave Kinship", "Efecto con un familiar Wavekin: Otorga Wave Kinship");
        add("Scalekin Familiar Effect: Grants Scale Kinship", "Efecto con un familiar Scalekin: Otorga Scale Kinship");
        add("Soulkin Familiar Effect: Grants Soul Kinship", "Efecto con un familiar Soulkin: Otorga Soul Kinship");
        add("Ashkin Familiar Effect: Grants Ash Kinship", "Efecto con un familiar Ashkin: Otorga Ash Kinship");
        add("Changes Beast Mode into an action according to your familiar's classification.",
            "Convierte Beast Mode en una acción según la clasificación de tu familiar.");
        add("Expiration timer is halted while your familiar is summoned.", "El tiempo restante se detiene mientras tu familiar está invocado.");
        add("Can only be executed while under the effect of One with Nature.", "Solo se puede usar bajo el efecto de One with Nature.");
        add("Spends all stacks of Natural Instinct to increase Familiar TP Gauge.",
            "Gasta todas las acumulaciones de Natural Instinct para aumentar el Familiar TP Gauge.");
        add("Standard Familiar TP Gauge Increase: {0}", "Aumento base del Familiar TP Gauge: {0}");
        add("Each stack of Natural Instinct increases Familiar TP Gauge by {0}.", "Cada acumulación de Natural Instinct aumenta {0} el Familiar TP Gauge.");
        add("Spends all stacks of Mastered Instinct to increase TP Gauge.", "Gasta todas las acumulaciones de Mastered Instinct para aumentar el TP Gauge.");
        add("Standard TP Gauge Increase: {0}", "Aumento base del TP Gauge: {0}");
        add("Each stack of Mastered Instinct increases TP Gauge by {0}.", "Cada acumulación de Mastered Instinct aumenta {0} el TP Gauge.");
        add("Orders your familiar to execute an instinctual skill.", "Ordena a tu familiar usar una técnica instintiva.");
        add("Additional Effect: Grants Volant Heart, Rampant Heart, Durant Heart, or Eldritch Heart",
            "Efecto adicional: Otorga Volant Heart, Rampant Heart, Durant Heart o Eldritch Heart");
        add("Effects granted by this action may be paired with beastmaster instinctual skills to create combos.",
            "Los efectos que otorga esta acción se pueden combinar con técnicas instintivas de beastmaster para crear combos.");

        // Beastmaster: traits

        add("Allows for TP Gauge accumulation upon landing certain weaponskill combos.",
            "Permite acumular TP Gauge al acertar ciertos combos de técnicas de arma.");
        add("Allows for Familiar TP Gauge accumulation upon the landing of auto-attacks or Aetheric Burst.",
            "Permite acumular Familiar TP Gauge al acertar ataques automáticos o Aetheric Burst.");
        add("Grants the effect of One with Nature upon summoning a familiar.", "Otorga el efecto de One with Nature al invocar a un familiar.");
        add("Grants {0} stack of Natural Instinct upon completing a combo with a familiar instinctual skill.",
            "Otorga {0} acumulación de Natural Instinct al completar un combo con una técnica instintiva del familiar.");
        add("Grants {0} stack of Mastered Instinct upon completing a combo with a beastmaster instinctual skill.",
            "Otorga {0} acumulación de Mastered Instinct al completar un combo con una técnica instintiva de beastmaster.");
        add("Grants Lingering Vantage upon using Tempered Release.", "Otorga Lingering Vantage al usar Tempered Release.");
        add("Grants Lingering Vantage upon using Borrow.", "Otorga Lingering Vantage al usar Borrow.");
        add("Allows the accumulation of charges for consecutive uses of Shield Charge.",
            "Permite acumular cargas para usar Shield Charge de forma consecutiva.");
        add("Increases the potency of Smash Axe to {0} and Shield Charge to {1}.", "Aumenta la potencia de Smash Axe a {0} y la de Shield Charge a {1}.");
        add("Resets the recast timer for Tempered Release upon summoning a familiar.",
            "Reinicia el tiempo de reutilización de Tempered Release al invocar a un familiar.");
        add("Resets the recast timer for Borrow upon summoning a familiar.", "Reinicia el tiempo de reutilización de Borrow al invocar a un familiar.");
        add("Reduces Rally recast time to {0} seconds.", "Reduce el tiempo de reutilización de Rally a {0} segundos.");
        add("Reduces Rallying Cheer recast time to {0} seconds.", "Reduce el tiempo de reutilización de Rallying Cheer a {0} segundos.");
        add("Upgrades Avalanche Axe to Brutal Rage, Mistral Axe to Hawkish Talons, Spinning Axe to Risen Fall, and Gale Axe to Calamity upon accumulating {0} TP.",
            "Al acumular {0} TP, mejora Avalanche Axe a Brutal Rage, Mistral Axe a Hawkish Talons, Spinning Axe a Risen Fall y Gale Axe a Calamity.");

        // Beastmaster: statuses

        add("Storing lightning energy. Resistance to lightning damage is reduced.",
            "Acumula energía de rayo. Se reduce la resistencia al daño de rayo.");
        add("Shrunk to a fraction of your normal size. Movement speed and damage dealt is reduced while damage taken is increased.",
            "Encogido a una fracción de su tamaño normal. Se reducen la velocidad de movimiento y el daño infligido, y aumenta el daño recibido.");
        add("The order to charge has been given.", "Se dio la orden de cargar.");
        add("Feeling Volant. Using instinctual skills with a Rampant affinity will trigger an intentional combo.",
            "Con ánimo Volant. Usar técnicas instintivas de afinidad Rampant activa un combo intencional.");
        add("Feeling Rampant. Using instinctual skills with a Durant affinity will trigger an intentional combo.",
            "Con ánimo Rampant. Usar técnicas instintivas de afinidad Durant activa un combo intencional.");
        add("Feeling Durant. Using instinctual skills with an Eldritch affinity will trigger an intentional combo.",
            "Con ánimo Durant. Usar técnicas instintivas de afinidad Eldritch activa un combo intencional.");
        add("Feeling Eldritch. Using instinctual skills with a Volant affinity will trigger an intentional combo.",
            "Con ánimo Eldritch. Usar técnicas instintivas de afinidad Volant activa un combo intencional.");
        add("Striding boldly beneath the sun. Using instinctual skills with a Moonstalker affinity will trigger an infinitive combo.",
            "Avanza con audacia bajo el sol. Usar técnicas instintivas de afinidad Moonstalker activa un combo infinitivo.");
        add("Stealthily stalking the moon. Using instinctual skills with a Sunstrider affinity will trigger an infinitive combo.",
            "Acecha a la luna con sigilo. Usar técnicas instintivas de afinidad Sunstrider activa un combo infinitivo.");
        add("Communing with the wilds. Able to execute Tempered Release.", "En comunión con la naturaleza. Permite usar Tempered Release.");
        add("Communing with the wilds. Able to execute Tempered Release or Borrow.",
            "En comunión con la naturaleza. Permite usar Tempered Release o Borrow.");
        add("Borrowing aether from a beastkin familiar. Able to execute Beastskin.", "Toma éter de un familiar beastkin. Permite usar Beastskin.");
        add("Borrowing aether from a vilekin familiar. Able to execute Vileskin.", "Toma éter de un familiar vilekin. Permite usar Vileskin.");
        add("Borrowing aether from a cloudkin familiar. Able to execute Cloud Skim.", "Toma éter de un familiar cloudkin. Permite usar Cloud Skim.");
        add("Borrowing aether from a seedkin familiar. Able to execute Seedsower.", "Toma éter de un familiar seedkin. Permite usar Seedsower.");
        add("Borrowing aether from a wavekin familiar. Able to execute Quelling Wave.", "Toma éter de un familiar wavekin. Permite usar Quelling Wave.");
        add("Borrowing aether from a scalekin familiar. Able to execute Scaleskin.", "Toma éter de un familiar scalekin. Permite usar Scaleskin.");
        add("Borrowing aether from a soulkin familiar. Able to execute Soul Crush.", "Toma éter de un familiar soulkin. Permite usar Soul Crush.");
        add("Borrowing aether from an ashkin familiar. Able to execute Scouring Ash.", "Toma éter de un familiar ashkin. Permite usar Scouring Ash.");
        add("Next Parting Blow will deal increased damage.", "El siguiente Parting Blow inflige más daño.");
        add("Weighing worthiness. Alliance will be determined upon incapacitation.",
            "Evalúa si eres digno. La alianza se decide al quedar fuera de combate.");
    }
}
