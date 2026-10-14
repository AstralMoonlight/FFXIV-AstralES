namespace AstralES.Translation;

public static partial class Spanish
{
    private static void Role(Action<string, string> add)
    {
        // Role actions

        add("Reduces damage taken by {0}%.", "Reduce un {0}% el daño recibido.");
        add("Additional Effect: Increases HP recovery via healing actions on self by {0}%",
            "Efecto adicional: Aumenta un {0}% la recuperación de HP que recibes por acciones de curación");
        add("Gesture threateningly, placing yourself at the top of a target's enmity list while gaining additional enmity.",
            "Hace un gesto amenazante que te coloca en lo alto de la lista de enemistad del objetivo y te otorga enemistad adicional.");
        add("Reduces damage dealt by nearby enemies by {0}%.", "Reduce un {0}% el daño que infligen los enemigos cercanos.");
        add("Diverts {0}% of enmity to target party member.", "Transfiere el {0}% de tu enemistad al miembro del grupo seleccionado.");
        add("Interrupts the use of a target's action.", "Interrumpe la acción que está usando el objetivo.");
        add("Stuns target.", "Aturde al objetivo.");
        add("Instantly restores own HP.", "Restaura tus HP al instante.");
        add("Cure Potency: {0}", "Potencia de curación: {0}");
        add("Converts a portion of physical damage dealt into HP.", "Convierte en HP una parte del daño físico que infliges.");
        add("Nullifies all action direction requirements.", "Anula todos los requisitos de dirección de las acciones.");
        add("Nullifies most knockback and draw-in effects.", "Anula la mayoría de los efectos de empuje y atracción.");
        add("Additional Effect: Nullifies most knockback and draw-in effects",
            "Efecto adicional: Anula la mayoría de los efectos de empuje y atracción");
        add("Additional Effect: When you are struck by a physical attack, the striker will be afflicted with Slow +{0}%",
            "Efecto adicional: Cuando recibes un ataque físico, el atacante sufre Slow +{0}%");
        add("Lowers target's physical damage dealt by {0}% and magic damage dealt by {1}%.",
            "Reduce un {0}% el daño físico y un {1}% el daño mágico que inflige el objetivo.");
        add("Binds target.", "Inmoviliza al objetivo.");
        add("Target unbound if damage taken.", "El objetivo se libera si recibe daño.");
        add("Afflicts target with Heavy +{0}%.", "Aplica Heavy +{0}% al objetivo.");
        add("Increases movement speed of self and nearby party members.",
            "Aumenta tu velocidad de movimiento y la de los miembros del grupo cercanos.");
        add("Spells can be cast without interruption.", "Los hechizos se pueden lanzar sin interrupción.");
        add("Next spell is cast immediately.", "El siguiente hechizo se lanza al instante.");
        add("Gradually restores own MP.", "Restaura tu MP de forma gradual.");
        add("Removes a single detrimental effect from target.", "Elimina un efecto perjudicial del objetivo.");
        add("Instantly draws target party member to your side. Cannot be used outside of combat or when target is suffering from certain enfeeblements.",
            "Atrae al instante al miembro del grupo seleccionado a tu lado. No se puede usar fuera de combate ni cuando el objetivo sufre ciertos efectos negativos.");
        add("Afflicts target with Sleep.", "Aplica Sleep al objetivo.");
        add("Puts target and all nearby enemies to sleep.", "Duerme al objetivo y a todos los enemigos cercanos.");

        // Role actions: statuses

        add("Overwhelming drowsiness is preventing the execution of actions.", "Una somnolencia abrumadora impide ejecutar acciones.");
        add("Weaponskill cast time and recast time, spell cast time and recast time, and auto-attack delay are increased.",
            "Aumentan el tiempo de lanzamiento y de reutilización de técnicas de arma y hechizos, y el retraso del ataque automático.");
        add("Weaponskill and spell cast time and recast time are increased.",
            "Aumentan el tiempo de lanzamiento y de reutilización de técnicas de arma y hechizos.");
        add("Auto-attack delay as well as weaponskill and spell cast and recast time are increased.",
            "Aumentan el retraso del ataque automático y el tiempo de lanzamiento y de reutilización de técnicas de arma y hechizos.");
        add("Movement speed is reduced.", "Se reduce la velocidad de movimiento.");
        add("Chocobo speed is reduced.", "Se reduce la velocidad del chocobo.");
        add("Damage taken is reduced.", "Se reduce el daño recibido.");
        add("Damage dealt is reduced.", "Se reduce el daño infligido.");
        add("Physical and magic damage are reduced.", "Se reducen el daño físico y el mágico.");
        add("Damage taken is reduced and HP recovery via healing actions is increased.",
            "Se reduce el daño recibido y aumenta la recuperación de HP por acciones de curación.");
        add("Damage taken is reduced while HP recovered via healing actions is increased.",
            "Se reduce el daño recibido y aumenta el HP recuperado por acciones de curación.");
        add("Physical attacks generate HP equal to a portion of damage dealt.",
            "Los ataques físicos generan HP equivalentes a una parte del daño infligido.");
        add("Damage dealt is increased, and attacks generate HP equal to a portion of damage dealt.",
            "Aumenta el daño infligido y los ataques generan HP equivalentes a una parte del daño infligido.");
        add("Spells cannot be interrupted by taking damage.", "Los hechizos no se interrumpen al recibir daño.");
        add("Next spell will require no time to cast.", "El siguiente hechizo no requiere tiempo de lanzamiento.");
        add("The next spell will be cast immediately.", "El siguiente hechizo se lanza al instante.");
        add("Restoring MP over time.", "Restaurando MP de forma gradual.");
        add("Slowing enemies struck by physical attacks. Immune to most knockback and draw-in effects.",
            "Ralentiza a los enemigos que te golpean con ataques físicos. Inmune a la mayoría de los efectos de empuje y atracción.");
        add("All action direction requirements are nullified.", "Se anulan todos los requisitos de dirección de las acciones.");
        add("Damage taken is reduced. Impervious to the next stun, sleep, bind, heavy, silence, knockback, or draw-in effect.",
            "Se reduce el daño recibido. Inmune al siguiente efecto de aturdimiento, sueño, inmovilización, pesadez, silencio, empuje o atracción.");
        add("Weakening enemies when attacked. Damage taken is reduced.", "Debilita a los enemigos que te atacan. Se reduce el daño recibido.");
        add("Sustaining increased damage from target who executed Feint.", "Recibiendo más daño del objetivo que usó Feint.");
    }
}
