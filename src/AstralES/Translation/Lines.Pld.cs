namespace AstralES.Translation;

public static partial class Spanish
{
    private static void Pld(Action<string, string> add)
    {
        // Paladin: actions

        add("Combo Action: Fast Blade", "Acción de combo: Fast Blade");
        add("Combo Action: Riot Blade", "Acción de combo: Riot Blade");
        add("Combo Action: Total Eclipse", "Acción de combo: Total Eclipse");
        add("Combo Action: Confiteor", "Acción de combo: Confiteor");
        add("Combo Action: Blade of Faith", "Acción de combo: Blade of Faith");
        add("Combo Action: Blade of Truth", "Acción de combo: Blade of Truth");
        add("Combo Bonus: Grants Atonement Ready", "Bonificación de combo: Otorga Atonement Ready");
        add("Combo Bonus: Grants Divine Might", "Bonificación de combo: Otorga Divine Might");
        add("Additional Effect: Grants Goring Blade Ready", "Efecto adicional: Otorga Goring Blade Ready");
        add("Additional Effect: Grants Confiteor Ready", "Efecto adicional: Otorga Confiteor Ready");
        add("Additional Effect: Grants Supplication Ready", "Efecto adicional: Otorga Supplication Ready");
        add("Additional Effect: Grants Sepulchre Ready", "Efecto adicional: Otorga Sepulchre Ready");
        add("Additional Effect: Grants Blade of Honor Ready", "Efecto adicional: Otorga Blade of Honor Ready");
        add("Additional Effect: Damage over time", "Efecto adicional: Daño periódico");
        add("Block incoming attacks.", "Bloquea los ataques recibidos.");
        add("Take all damage intended for another party member as long as said member remains within {0} yalms.",
            "Recibes todo el daño dirigido a otro miembro del grupo mientras este permanezca en un radio de {0} yalms.");
        add("Does not activate with certain attacks.", "No se activa con ciertos ataques.");
        add("Oath Gauge Cost: {0}", "Costo de Oath Gauge: {0}");
        add("Renders you impervious to most attacks.", "Te vuelve inmune a la mayoría de los ataques.");
        add("Divine Might Effect: Allows next Holy Spirit or Holy Circle to be cast immediately with increased potency",
            "Efecto de Divine Might: El siguiente Holy Spirit o Holy Circle se lanza al instante y con más potencia");
        add("Divine Might Effect: Allows next Holy Spirit to be cast immediately with increased potency",
            "Efecto de Divine Might: El siguiente Holy Spirit se lanza al instante y con más potencia");
        add("Divine Might Potency: {0}", "Potencia con Divine Might: {0}");
        add("Requiescat Potency: {0}", "Potencia con Requiescat: {0}");
        add("The effect of Divine Might will be prioritized over Requiescat when under the effect of both.",
            "Si estás bajo el efecto de ambos, Divine Might tiene prioridad sobre Requiescat.");
        add("Creates a barrier around self and all party members near you that absorbs damage equivalent to {0}% of your maximum HP.",
            "Crea una barrera alrededor de ti y de todos los miembros del grupo cercanos que absorbe daño equivalente al {0}% de tus HP máximos.");
        add("Additional Effect: Restores target's HP", "Efecto adicional: Restaura los HP del objetivo");
        add("Additional Effect: Restores to self {0}% of HP restored to target if target is a party member",
            "Efecto adicional: Si el objetivo es un miembro del grupo, recuperas el {0}% de los HP que se le restauraron");
        add("Reduces target party member's damage taken by {0}%.", "Reduce un {0}% el daño que recibe el miembro del grupo seleccionado.");
        add("Additional Effect: Increases damage reduction by an additional {0}% if Rampart or Sentinel are active",
            "Efecto adicional: Reduce el daño un {0}% más si Rampart o Sentinel están activos");
        add("Additional Effect: Increases damage reduction by an additional {0}% if Rampart or Guardian are active",
            "Efecto adicional: Reduce el daño un {0}% más si Rampart o Guardian están activos");
        add("Additional Effect: Grants Knight's Resolve to target", "Efecto adicional: Otorga Knight's Resolve al objetivo");
        add("Additional Effect: Grants Knight's Resolve", "Efecto adicional: Otorga Knight's Resolve");
        add("Knight's Resolve Effect: Reduces damage taken by {0}%", "Efecto de Knight's Resolve: Reduce un {0}% el daño recibido");
        add("Additional Effect: Grants Knight's Benediction to target", "Efecto adicional: Otorga Knight's Benediction al objetivo");
        add("Additional Effect: Grants Knight's Benediction", "Efecto adicional: Otorga Knight's Benediction");
        add("Knight's Benediction Effect: Gradually restores HP", "Efecto de Knight's Benediction: Restaura HP de forma gradual");
        add("Additional Effect: Grants {0} stacks of Requiescat", "Efecto adicional: Otorga {0} acumulaciones de Requiescat");
        add("Requiescat Effect: Increases the potency of Holy Spirit and spells will require no cast time",
            "Efecto de Requiescat: Aumenta la potencia de Holy Spirit y los hechizos no requieren tiempo de lanzamiento");
        add("Requiescat Effect: Increases the potency of Holy Spirit and Holy Circle, and spells will require no cast time",
            "Efecto de Requiescat: Aumenta la potencia de Holy Spirit y Holy Circle, y los hechizos no requieren tiempo de lanzamiento");
        // The game writes two spaces after "Holy Spirit," in these two.
        add("Requiescat Effect: Increases the potency of Holy Spirit,  Holy Circle, and Confiteor, and spells will require no cast time",
            "Efecto de Requiescat: Aumenta la potencia de Holy Spirit, Holy Circle y Confiteor, y los hechizos no requieren tiempo de lanzamiento");
        add("Requiescat Effect: Increases the potency of Holy Spirit,  Holy Circle, and all Confiteor combo actions, and spells will require no cast time",
            "Efecto de Requiescat: Aumenta la potencia de Holy Spirit, Holy Circle y todas las acciones del combo de Confiteor, y los hechizos no requieren tiempo de lanzamiento");
        add("Requiescat Effect: Increases the potency of Holy Spirit, Holy Circle, and all Confiteor combo actions, and spells will require no cast time",
            "Efecto de Requiescat: Aumenta la potencia de Holy Spirit, Holy Circle y todas las acciones del combo de Confiteor, y los hechizos no requieren tiempo de lanzamiento");
        add("Increases block rate to {0}% and creates a designated area in a cone behind you in which party members will only suffer {1}% of all damage inflicted.",
            "Aumenta la tasa de bloqueo al {0}% y crea una zona en cono detrás de ti en la que los miembros del grupo solo sufren el {1}% del daño infligido.");
        add("Rushes target and delivers an attack with a potency of {0}.",
            "Te desplaza rápidamente hasta el objetivo y realiza un ataque con una potencia de {0}.");
        add("Additional Effect: Erects a magicked barrier which nullifies damage equivalent to a heal of {0} potency",
            "Efecto adicional: Levanta una barrera mágica que anula daño equivalente a una curación de potencia {0}");
        add("Cancels the effect of Iron Will.", "Cancela el efecto de Iron Will.");
        add("Can only be executed while under the effect of Goring Blade Ready.", "Solo se puede usar bajo el efecto de Goring Blade Ready.");
        add("Can only be executed while under the effect of Atonement Ready.", "Solo se puede usar bajo el efecto de Atonement Ready.");
        add("Can only be executed while under the effect of Supplication Ready.", "Solo se puede usar bajo el efecto de Supplication Ready.");
        add("Can only be executed while under the effect of Sepulchre Ready.", "Solo se puede usar bajo el efecto de Sepulchre Ready.");
        add("Can only be executed while under the effect of Blade of Honor Ready.", "Solo se puede usar bajo el efecto de Blade of Honor Ready.");
        add("Can only be executed while under the effect of Confiteor Ready. Effect fades upon execution.",
            "Solo se puede usar bajo el efecto de Confiteor Ready. El efecto desaparece al usarla.");
        add("※Atonement changes to Supplication when requirements for execution are met.",
            "※Atonement se convierte en Supplication cuando se cumplen los requisitos para usarla.");
        add("※Supplication changes to Sepulchre when requirements for execution are met.",
            "※Supplication se convierte en Sepulchre cuando se cumplen los requisitos para usarla.");
        add("※Confiteor changes to Blade of Faith when requirements for execution are met.",
            "※Confiteor se convierte en Blade of Faith cuando se cumplen los requisitos para usarla.");
        add("※Blade of Faith changes to Blade of Truth when requirements for execution are met.",
            "※Blade of Faith se convierte en Blade of Truth cuando se cumplen los requisitos para usarla.");
        add("※Blade of Truth changes to Blade of Valor when requirements for execution are met.",
            "※Blade of Truth se convierte en Blade of Valor cuando se cumplen los requisitos para usarla.");
        add("※Imperator changes to Blade of Honor when requirements for execution are met.",
            "※Imperator se convierte en Blade of Honor cuando se cumplen los requisitos para usarla.");

        // Paladin: traits

        add("Halves MP cost for all spells while preventing casting interruptions via damage taken. Grants the following effects after successfully completing a combo with Royal Authority:",
            "Reduce a la mitad el costo de MP de todos los hechizos y evita que el daño recibido interrumpa su lanzamiento. Otorga los siguientes efectos al completar un combo con Royal Authority:");
        add("Grants the following effects after successfully completing a combo with Prominence:",
            "Otorga los siguientes efectos al completar un combo con Prominence:");
        add("Increases Oath Gauge by {0} each time an auto-attack lands.", "Aumenta {0} el Oath Gauge cada vez que acierta un ataque automático.");
        add("Restores MP when using Riot Blade or Spirits Within.", "Restaura MP al usar Riot Blade o Spirits Within.");
        add("Upgrades Rage of Halone to Royal Authority.", "Mejora Rage of Halone a Royal Authority.");
        add("Upgrades Sheltron to Holy Sheltron.", "Mejora Sheltron a Holy Sheltron.");
        add("Upgrades Spirits Within to Expiacion.", "Mejora Spirits Within a Expiacion.");
        add("Upgrades Sentinel to Guardian.", "Mejora Sentinel a Guardian.");
        add("Upgrades Requiescat to Imperator.", "Mejora Requiescat a Imperator.");
        add("Extends the duration of Sheltron to {0} seconds.", "Extiende a {0} segundos la duración de Sheltron.");
        add("Extends the duration of Intervention to {0} seconds.", "Extiende a {0} segundos la duración de Intervention.");
        add("Grants the effect of Confiteor Ready upon landing Requiescat.", "Otorga el efecto de Confiteor Ready al acertar Requiescat.");
        add("Grants Atonement Ready after successfully completing a combo with Royal Authority.",
            "Otorga Atonement Ready al completar un combo con Royal Authority.");
        add("Grants Knight's Resolve to target, reducing damage taken by {0}%.",
            "Otorga Knight's Resolve al objetivo, que reduce un {0}% el daño recibido.");
        add("Grants Knight's Benediction to target, gradually restoring HP over time.",
            "Otorga Knight's Benediction al objetivo, que restaura HP de forma gradual.");
        add("Adds a healing effect to Holy Spirit, Holy Circle, and Confiteor.", "Agrega un efecto de curación a Holy Spirit, Holy Circle y Confiteor.");
        add("Adds a healing effect to Divine Veil.", "Agrega un efecto de curación a Divine Veil.");
        add("Increases the potency of Fast Blade to {0}, Riot Blade to {1}, Royal Authority to {2}, Holy Spirit to {3}, Atonement to {4}, Supplication to {5}, and Sepulchre to {6}.",
            "Aumenta la potencia de Fast Blade a {0}, Riot Blade a {1}, Royal Authority a {2}, Holy Spirit a {3}, Atonement a {4}, Supplication a {5} y Sepulchre a {6}.");
        add("Increases the potency of Fast Blade to {0}, Riot Blade to {1}, Royal Authority to {2}, Holy Spirit to {3}, Atonement to {4}, Supplication to {5}, Sepulchre to {6}, Confiteor to {7}, Blade of Faith to {8}, Blade of Truth to {9}, and Blade of Valor to {10}.",
            "Aumenta la potencia de Fast Blade a {0}, Riot Blade a {1}, Royal Authority a {2}, Holy Spirit a {3}, Atonement a {4}, Supplication a {5}, Sepulchre a {6}, Confiteor a {7}, Blade of Faith a {8}, Blade of Truth a {9} y Blade of Valor a {10}.");
        add("Grants the effect of Blade of Honor Ready upon landing Blade of Valor.", "Otorga el efecto de Blade of Honor Ready al acertar Blade of Valor.");
        add("Imperator changes to Blade of Honor while under the effect of Blade of Honor Ready.",
            "Imperator se convierte en Blade of Honor bajo el efecto de Blade of Honor Ready.");
        add("Grants Goring Blade Ready upon executing Fight or Flight.", "Otorga Goring Blade Ready al usar Fight or Flight.");

        // Paladin: statuses

        add("Blocking incoming attacks.", "Bloqueando los ataques recibidos.");
        add("Auto-attacks are enhanced.", "Los ataques automáticos están potenciados.");
        add("Protecting a party member.", "Protegiendo a un miembro del grupo.");
        add("Protecting an ally.", "Protegiendo a un aliado.");
        add("Impervious to most attacks.", "Inmune a la mayoría de los ataques.");
        add("Upon HP recovery via healing magic, a damage-reducing barrier is created.",
            "Al recuperar HP mediante magia curativa, se crea una barrera que reduce el daño.");
        add("Next attack will be blocked.", "El siguiente ataque se bloquea.");
        add("An area of land has been granted protection, reducing damage taken for all who enter.",
            "Una zona quedó protegida y reduce el daño que recibe quien entre en ella.");
        add("Potency of certain actions is increased and spells require no time to cast.",
            "Aumenta la potencia de ciertas acciones y los hechizos no requieren tiempo de lanzamiento.");
        add("Spells require no time to cast and consume no MP.", "Los hechizos no requieren tiempo de lanzamiento ni consumen MP.");
        add("Damage dealt and potency of all HP restoration actions are reduced.",
            "Se reducen el daño infligido y la potencia de todas las acciones de recuperación de HP.");
        add("A holy barrier is nullifying damage. When barrier is completely absorbed, creates a barrier around all nearby party members.",
            "Una barrera sagrada está anulando el daño. Cuando se absorbe por completo, crea una barrera alrededor de todos los miembros del grupo cercanos.");
        add("Next Holy Spirit or Holy Circle will deal increased damage and require no cast time.",
            "El siguiente Holy Spirit o Holy Circle inflige más daño y no requiere tiempo de lanzamiento.");
        add("Able to execute Atonement.", "Permite usar Atonement.");
        add("Able to execute Confiteor.", "Permite usar Confiteor.");
        add("Able to execute Supplication.", "Permite usar Supplication.");
        add("Able to execute Sepulchre.", "Permite usar Sepulchre.");
        add("Able to execute Blade of Honor.", "Permite usar Blade of Honor.");
        add("Able to execute Goring Blade.", "Permite usar Goring Blade.");
        add("Relentlessly striking nearest target with auto-attacks. Immune to certain status effects, as well as most knockback and draw-in effects.",
            "Atacando sin descanso al objetivo más cercano con ataques automáticos. Inmune a ciertos efectos de estado y a la mayoría de los efectos de empuje y atracción.");
    }
}
