namespace AstralES.Translation;

public static partial class Spanish
{
    private static void Mch(Action<string, string> add)
    {
        // Machinist: actions

        add("Deploys a single-target battle turret which attacks using Volley Fire, dealing damage with a potency of {0}.",
            "Despliega una torreta de combate de objetivo único que ataca con Volley Fire e inflige daño con una potencia de {0}.");
        add("Potency increases as Battery Gauge exceeds required cost at time of deployment, up to a maximum of {0}.",
            "La potencia aumenta cuanto más supere el Battery Gauge el costo requerido al desplegarla, hasta un máximo de {0}.");
        add("Battery Gauge Cost: {0}", "Costo de Battery Gauge: {0}");
        add("Consumes Battery Gauge upon execution.", "Al usarla, consume el Battery Gauge.");
        add("Shuts down when time expires or upon execution of Rook Overdrive.", "Se apaga al terminar el tiempo o al usar Rook Overdrive.");
        add("Shares a recast timer with Rook Overdrive.", "Comparte tiempo de reutilización con Rook Overdrive.");
        add("Additional Effect: Increases Heat Gauge by {0}", "Efecto adicional: Aumenta {0} el Heat Gauge");
        add("Combo Action: Split Shot or Heated Split Shot", "Acción de combo: Split Shot o Heated Split Shot");
        add("Combo Bonus: Increases Heat Gauge by {0}", "Bonificación de combo: Aumenta {0} el Heat Gauge");
        add("Additional Effect: Increases Battery Gauge by {0}", "Efecto adicional: Aumenta {0} el Battery Gauge");
        add("Combo Action: Slug Shot or Heated Slug Shot", "Acción de combo: Slug Shot o Heated Slug Shot");
        add("Combo Bonus: Increases Battery Gauge by {0}", "Bonificación de combo: Aumenta {0} el Battery Gauge");
        add("Guarantees that next weaponskill is a critical direct hit.", "Garantiza que la siguiente técnica de arma sea un golpe crítico directo.");
        add("This action does not affect damage over time effects.", "Esta acción no afecta a los efectos de daño periódico.");
        add("Covers target's body in a slow-burning pitch. Action is changed to Detonator for the duration of the effect.",
            "Cubre el cuerpo del objetivo con una brea de combustión lenta. Mientras dura el efecto, la acción se convierte en Detonator.");
        add("Deals damage when time expires or upon executing Detonator.", "Inflige daño al terminar el tiempo o al usar Detonator.");
        add("Potency is increased by {0} for each of your own weaponskills you land prior to the end of the effect.",
            "La potencia aumenta {0} por cada técnica de arma propia que aciertes antes de que termine el efecto.");
        add("Lowers target's damage dealt by {0}%.", "Reduce un {0}% el daño que inflige el objetivo.");
        add("Additional Effect: Reduces the recast time of both Gauss Round and Ricochet by {0}s",
            "Efecto adicional: Reduce {0} s el tiempo de reutilización de Gauss Round y de Ricochet");
        add("Can only be executed when firearm is Overheated.", "Solo se puede usar cuando el arma de fuego está Overheated.");
        add("Combo Action: Heated Split Shot", "Acción de combo: Heated Split Shot");
        add("Combo Action: Heated Slug Shot", "Acción de combo: Heated Slug Shot");
        add("Grants Hypercharged.", "Otorga Hypercharged.");
        add("Additional Effect: Grants Full Metal Machinist", "Efecto adicional: Otorga Full Metal Machinist");
        add("Orders the rook autoturret to use Rook Overload.", "Ordena a la torreta rook que use Rook Overload.");
        add("Rook Overload Potency: {0}", "Potencia de Rook Overload: {0}");
        add("The rook autoturret shuts down after execution. If this action is not used manually while the rook autoturret is active, it will be triggered automatically immediately before shutting down.",
            "La torreta rook se apaga después de usarla. Si no se usa manualmente mientras la torreta rook está activa, se activa sola justo antes de que se apague.");
        add("Shares a recast timer with Rook Autoturret.", "Comparte tiempo de reutilización con Rook Autoturret.");
        add("Delivers damage over time to all enemies in a cone before you.", "Inflige daño periódico a todos los enemigos en un cono frente a ti.");
        add("Shares a recast timer with Bioblaster.", "Comparte tiempo de reutilización con Bioblaster.");
        add("Shares a recast timer with Drill.", "Comparte tiempo de reutilización con Drill.");
        add("Deploys an Automaton Queen to fight at your side.", "Despliega una Automaton Queen que lucha a tu lado.");
        add("Potency of Automaton Queen actions increases as Battery Gauge exceeds required cost at time of deployment.",
            "La potencia de las acciones de Automaton Queen aumenta cuanto más supere el Battery Gauge el costo requerido al desplegarla.");
        add("Shuts down when time expires or upon execution of Queen Overdrive.", "Se apaga al terminar el tiempo o al usar Queen Overdrive.");
        add("Shares a recast timer with Queen Overdrive.", "Comparte tiempo de reutilización con Queen Overdrive.");
        add("Orders the Automaton Queen to use Pile Bunker.", "Ordena a la Automaton Queen que use Pile Bunker.");
        add("Pile Bunker Potency: {0}", "Potencia de Pile Bunker: {0}");
        add("The Automaton Queen shuts down after execution. If this action is not used manually while the Automaton Queen is active, it will be triggered automatically immediately before shutting down.",
            "La Automaton Queen se apaga después de usarla. Si no se usa manualmente mientras la Automaton Queen está activa, se activa sola justo antes de que se apague.");
        add("Shares a recast timer with Automaton Queen.", "Comparte tiempo de reutilización con Automaton Queen.");
        add("If this action is not used manually while the Automaton Queen is active, it will be triggered automatically immediately before shutting down.",
            "Si no se usa manualmente mientras la Automaton Queen está activa, se activa sola justo antes de que se apague.");
        add("Ends the effect of Wildfire, dealing damage to the target.", "Termina el efecto de Wildfire e inflige daño al objetivo.");
        add("Can only be executed while under the effect of Wildfire.", "Solo se puede usar bajo el efecto de Wildfire.");
        add("※Wildfire changes to Detonator when requirements for execution are met.",
            "※Wildfire se convierte en Detonator cuando se cumplen los requisitos para usarla.");
        add("Effect cannot be stacked with bard's Troubadour or dancer's Shield Samba.",
            "No se acumula con el Troubadour de un bard ni con el Shield Samba de un dancer.");
        add("Grants {0} stacks of Overheated.", "Otorga {0} acumulaciones de Overheated.");
        add("Overheated Effect: Increases the potency of single-target weaponskills by {0}",
            "Efecto de Overheated: Aumenta {0} la potencia de las técnicas de arma de objetivo único");
        add("Heat Gauge Cost: {0}", "Costo de Heat Gauge: {0}");
        add("Overheated effect only applicable to machinist job actions.", "El efecto de Overheated solo se aplica a las acciones del job machinist.");
        add("Grants {0} stacks of Overheated, each stack allowing the execution of Heat Blast.",
            "Otorga {0} acumulaciones de Overheated; cada una permite usar Heat Blast.");
        add("Grants {0} stacks of Overheated, each stack allowing the execution of Heat Blast or Auto Crossbow.",
            "Otorga {0} acumulaciones de Overheated; cada una permite usar Heat Blast o Auto Crossbow.");
        add("Grants {0} stacks of Overheated, each stack allowing the execution of Blazing Shot or Auto Crossbow.",
            "Otorga {0} acumulaciones de Overheated; cada una permite usar Blazing Shot o Auto Crossbow.");
        add("Additional Effect: Grants Excavator Ready", "Efecto adicional: Otorga Excavator Ready");
        add("Additional Effect: Reduces the recast time of both Double Check and Checkmate by {0}s",
            "Efecto adicional: Reduce {0} s el tiempo de reutilización de Double Check y de Checkmate");
        add("Can only be executed while under the effect of Excavator Ready.", "Solo se puede usar bajo el efecto de Excavator Ready.");
        add("※Chain Saw changes to Excavator when requirements for execution are met.",
            "※Chain Saw se convierte en Excavator cuando se cumplen los requisitos para usarla.");
        add("This action is not affected by Reassemble.", "Reassemble no afecta a esta acción.");
        add("Can only be executed while under the effect of Full Metal Machinist.", "Solo se puede usar bajo el efecto de Full Metal Machinist.");

        // Machinist: traits

        add("Increases base action damage and autoturret damage by {0}%.", "Aumenta un {0}% el daño base de las acciones y el daño de la torreta.");
        add("Upgrades Split Shot to Heated Split Shot.", "Mejora Split Shot a Heated Split Shot.");
        add("Upgrades Slug Shot to Heated Slug Shot.", "Mejora Slug Shot a Heated Slug Shot.");
        add("Upgrades Clean Shot to Heated Clean Shot.", "Mejora Clean Shot a Heated Clean Shot.");
        add("Upgrades Hot Shot to Air Anchor.", "Mejora Hot Shot a Air Anchor.");
        add("Allows a third charge of Gauss Round and Ricochet.", "Permite una tercera carga de Gauss Round y Ricochet.");
        add("Improves Wildfire's potency increase for landing weaponskills to {0}.",
            "Aumenta a {0} el aumento de potencia de Wildfire por cada técnica de arma acertada.");
        add("Upgrades Rook Autoturret and Rook Overdrive to Automaton Queen and Queen Overdrive respectively.",
            "Mejora Rook Autoturret y Rook Overdrive a Automaton Queen y Queen Overdrive, respectivamente.");
        add("Upgrades Spread Shot to Scattergun.", "Mejora Spread Shot a Scattergun.");
        add("Allows the accumulation of charges for consecutive uses of Reassemble.",
            "Permite acumular cargas para usar Reassemble de forma consecutiva.");
        add("After executing Pile Bunker, the Automaton Queen will also execute Crowned Collider.",
            "Después de usar Pile Bunker, la Automaton Queen también usa Crowned Collider.");
        add("Reduces Tactician recast time to {0} seconds.", "Reduce el tiempo de reutilización de Tactician a {0} segundos.");
        add("Increases the potency of Heated Split Shot to {0}, Heated Slug Shot to {1}, and Heated Clean Shot to {2}.",
            "Aumenta la potencia de Heated Split Shot a {0}, Heated Slug Shot a {1} y Heated Clean Shot a {2}.");
        add("Upgrades Heat Blast to Blazing Shot.", "Mejora Heat Blast a Blazing Shot.");
        add("Upgrades Gauss Round to Double Check and Ricochet to Checkmate.", "Mejora Gauss Round a Double Check y Ricochet a Checkmate.");
        add("Allows the accumulation of charges for consecutive uses of Drill and Bioblaster.",
            "Permite acumular cargas para usar Drill y Bioblaster de forma consecutiva.");
        add("Grants Excavator Ready upon executing Chain Saw.", "Otorga Excavator Ready al usar Chain Saw.");
        add("Chain Saw changes to Excavator while under the effect of Excavator Ready.",
            "Chain Saw se convierte en Excavator bajo el efecto de Excavator Ready.");
        add("Improves Tactician's damage reduction effect to {0}%.", "Aumenta al {0}% la reducción de daño de Tactician.");
        add("Grants Full Metal Machinist upon executing Barrel Stabilizer.", "Otorga Full Metal Machinist al usar Barrel Stabilizer.");
        add("Increases the potency of Auto Crossbow to {0}, Heated Split Shot to {1}, Drill to {2}, Heated Slug Shot to {3}, Heated Clean Shot to {4}, Blazing Shot to {5}, Air Anchor to {6}, and Chain Saw to {7}.",
            "Aumenta la potencia de Auto Crossbow a {0}, Heated Split Shot a {1}, Drill a {2}, Heated Slug Shot a {3}, Heated Clean Shot a {4}, Blazing Shot a {5}, Air Anchor a {6} y Chain Saw a {7}.");

        // Machinist: statuses

        add("Battle turret is overcharged.", "La torreta de combate está sobrecargada.");
        add("Autoturret auto-attack mode is disabled.", "El modo de ataque automático de la torreta está desactivado.");
        add("Physical damage dealt is increased.", "Aumenta el daño físico infligido.");
        add("Damage is being accumulated with each weaponskill landed by the machinist who applied the effect.",
            "Acumula daño con cada técnica de arma que acierta el machinist que aplicó el efecto.");
        add("Emitting a gout of searing flames in a cone before you, dealing damage over time.",
            "Lanza un chorro de llamas abrasadoras en un cono frente a ti que inflige daño periódico.");
        add("Emitting a gout of searing flames in a cone, dealing damage over time.",
            "Lanza un chorro de llamas abrasadoras en un cono que inflige daño periódico.");
        add("Currently afflicting an enemy with Wildfire.", "Hay un enemigo bajo el efecto de tu Wildfire.");
        add("Potency of single-target weaponskills is increased.", "Aumenta la potencia de las técnicas de arma de objetivo único.");
        add("Potency of single-target weaponskills is increased. Able to execute Heat Blast.",
            "Aumenta la potencia de las técnicas de arma de objetivo único. Permite usar Heat Blast.");
        add("Potency of single-target weaponskills is increased. Able to execute Heat Blast and Auto Crossbow.",
            "Aumenta la potencia de las técnicas de arma de objetivo único. Permite usar Heat Blast y Auto Crossbow.");
        add("Potency of single-target weaponskills is increased. Able to execute Blazing Shot and Auto Crossbow.",
            "Aumenta la potencia de las técnicas de arma de objetivo único. Permite usar Blazing Shot y Auto Crossbow.");
        add("Firearm is generating heat. Becomes Overheated when {0} stacks are accumulated.",
            "El arma de fuego se está calentando. Pasa a Overheated al llegar a {0} acumulaciones.");
        add("Able to execute Blazing Shot. Movement speed is also increased.", "Permite usar Blazing Shot. También aumenta la velocidad de movimiento.");
        add("Unleashing power beyond physical limitations and taking damage over time.",
            "Desata un poder más allá de los límites físicos y recibe daño periódico.");
        add("Able to execute Hypercharge.", "Permite usar Hypercharge.");
        add("Able to execute Excavator.", "Permite usar Excavator.");
        add("Able to execute Full Metal Field.", "Permite usar Full Metal Field.");
    }
}
