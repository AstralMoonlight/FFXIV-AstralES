namespace AstralES.Translation;

public static partial class Spanish
{
    private static void General(Action<string, string> add)
    {
        // General actions (GeneralAction sheet)

        add("Automatically attack your current target at a set interval determined by your weapon.",
            "Ataca automáticamente a tu objetivo actual a un intervalo fijo determinado por tu arma.");
        add("Make a spring from the ground or other base by flexion and sudden muscular extension of the legs.",
            "Se impulsa desde el suelo u otra superficie flexionando y extendiendo de golpe los músculos de las piernas.");
        add("Spend energy stored in your party's limit gauge to execute a powerful battle technique. The technique executed is determined by the role of the party member who initiates it.",
            "Gasta la energía acumulada en el medidor de límite del grupo para ejecutar una poderosa técnica de combate. La técnica depende del rol del miembro del grupo que la activa.");
        add("Tank: Increase party defense (area of effect: {0}y).", "Tanque: Aumenta la defensa del grupo (área de efecto: {0} y).");
        add("Melee: Single-target attack.", "Cuerpo a cuerpo: Ataque a un solo objetivo.");
        add("Ranged: Attack to all targets in a straight line (range: {0}y).",
            "A distancia: Ataque a todos los objetivos en línea recta (alcance: {0} y).");
        add("Caster: Area of effect attack ({0}y/{1}y/{2}y).", "Lanzador: Ataque en área ({0} y/{1} y/{2} y).");
        add("Healer: HP restoration. Raise at level {0} (area of effect: {1}y).",
            "Sanador: Restaura HP. Resucita en el nivel {0} (área de efecto: {1} y).");
        add("※If target is not weakened at the time of Raise, the target will be restored in a non-weakened state. If target is weakened at the time of Raise, the weakness counter will reset.",
            "※Si el objetivo no está debilitado al resucitar, vuelve sin debilitamiento. Si ya está debilitado al resucitar, el contador de debilitamiento se reinicia.");
        add("Increases movement speed.", "Aumenta la velocidad de movimiento.");
        add("Duration: {0}s ({1}s when not in combat)", "Duración: {0} s ({1} s fuera de combate)");
        add("※Unavailable in PvP.", "※No disponible en PvP.");
        add("Additional Effect: Grants Jog when the effect expires", "Efecto adicional: Otorga Jog cuando termina el efecto");
        add("Jog Effect: Movement speed is increased", "Efecto de Jog: Aumenta la velocidad de movimiento");
        add("Effect ends when enmity is generated. Has no effect in battle.",
            "El efecto termina al generar enemistad. No tiene efecto en combate.");
        add("Break down an item into one or more of its original materials.",
            "Descompone un objeto en uno o más de sus materiales originales.");
        add("Use dark matter to mend damaged equipment.", "Usa materia oscura para reparar equipo dañado.");
        add("Reduce your body to aether and instantly teleport to any aetheryte to which you have previously attuned. Requires a gil fee paid upon arrival at your destination.",
            "Convierte tu cuerpo en éter y te teletransporta al instante a cualquier aetheryte con el que te hayas sintonizado. Requiere pagar una tarifa en gil al llegar al destino.");
        add("Instantly return to your current home point.", "Regresa al instante a tu punto de origen actual.");
        add("Summon a mount at random.", "Invoca una montura al azar.");
        add("Summon a minion at random.", "Invoca un minion al azar.");
        add("Summon a random flying mount.", "Invoca una montura voladora al azar.");
        add("Dismount your current mount.", "Baja de tu montura actual.");
        add("Affix materia onto weapons and armor.", "Inserta materia en armas y armaduras.");
        add("Affix materia onto weapons and armor. Can also affix materia to items with no slots remaining, but success is not guaranteed.",
            "Inserta materia en armas y armaduras. También puede insertarla en objetos sin ranuras libres, pero el éxito no está garantizado.");
        add("Extract the aether from an item with a complete spiritbond, and then recrystallize the resulting residue into a concentrated substance known as “materia.”",
            "Extrae el éter de un objeto con el spiritbond completo y recristaliza el residuo en una sustancia concentrada conocida como “materia”.");
        add("Use dye to color gear.", "Usa tinte para colorear el equipo.");
        add("Use a glamour prism to cast an optical illusion upon a piece of equipment, thus altering its appearance.",
            "Usa un prisma de glamour para proyectar una ilusión óptica sobre una pieza de equipo y cambiar su apariencia.");
        add("Create a set of multiple glamours to apply at once.", "Crea un conjunto de varios glamours para aplicarlos de una vez.");
        add("Break down an item to its aetherial components.", "Descompone un objeto en sus componentes etéreos.");
        add("Toggle forward through nearby enemies.", "Recorre hacia adelante los enemigos cercanos.");
        add("Toggle back through nearby enemies.", "Recorre hacia atrás los enemigos cercanos.");
        add("Put down the object you are carrying.", "Suelta el objeto que llevas.");
        add("Stow personal effects.", "Guarda tus pertenencias.");
        add("Remove a timeworn map from its glass prison and unlock its mysteries.",
            "Saca un mapa antiguo de su prisión de cristal y descubre sus misterios.");
        add("Locate a buried treasure coffer within a {0}-yalm radius and extract it from the ground.",
            "Localiza un cofre del tesoro enterrado en un radio de {0} yalms y lo saca del suelo.");
        add("Execute a duty-specific action.", "Ejecuta una acción propia del contenido.");
        add("Execute a phantom action.", "Ejecuta una acción fantasma.");
        add("Change the order of hotbar-assigned actions.", "Cambia el orden de las acciones asignadas a la barra.");
        add("Selects target marked as target to attack. Cycles through targets numbered from lowest to highest when multiple targets are marked.",
            "Selecciona el objetivo marcado para atacar. Si hay varios marcados, los recorre del número menor al mayor.");
        add("Selects target marked as target to bind. Cycles through targets numbered from lowest to highest when multiple targets are marked.",
            "Selecciona el objetivo marcado para inmovilizar. Si hay varios marcados, los recorre del número menor al mayor.");
        add("Selects target marked as target to ignore. Cycles through targets numbered from lowest to highest when multiple targets are marked.",
            "Selecciona el objetivo marcado para ignorar. Si hay varios marcados, los recorre del número menor al mayor.");
        add("Selects target marked with a square.", "Selecciona el objetivo marcado con un cuadrado.");
        add("Selects target marked with a circle.", "Selecciona el objetivo marcado con un círculo.");
        add("Selects target marked with a plus.", "Selecciona el objetivo marcado con una cruz.");
        add("Selects target marked with a triangle.", "Selecciona el objetivo marcado con un triángulo.");
        add("View the next Strategy Board.", "Muestra el siguiente Strategy Board.");
        add("View the previous Strategy Board.", "Muestra el Strategy Board anterior.");

        // General actions: statuses

        add("Teetering on the brink of consciousness.", "Al borde de perder el conocimiento.");
        add("Aetherially entwined with the temporal manifold. You will be stunned and drawn back to your aetherial trace when this effect expires.",
            "Vínculo etéreo con el entramado temporal. Al expirar este efecto, sufrirás aturdimiento y volverás a tu rastro etéreo.");
        add("Activity is severely impeded.", "La actividad está gravemente limitada.");
    }
}
