namespace AstralES.Translation;

public static partial class Spanish
{
    private static void Generic(Action<string, string> add)
    {
        // Generic

        add("Potency: {0}", "Potencia: {0}");
        add("Duration: {0}s", "Duración: {0} s");
        add("Maximum Charges: {0}", "Cargas máximas: {0}");
        add("Fully restores MP.", "Restaura todo el MP.");
        add("Unable to cast if bound.", "No se puede usar bajo el efecto de inmovilización.");
        add("Cannot be executed while bound.", "No se puede usar bajo el efecto de inmovilización.");
        add("※This action cannot be assigned to a hotbar.", "※Esta acción no se puede asignar a una barra de acciones.");
        add("Maximum Stacks: {0}", "Acumulaciones máximas: {0}");
        add("Cancels auto-attack upon execution.", "Cancela el ataque automático al usarse.");
        add("Movement speed is increased.", "Aumenta la velocidad de movimiento.");
        add("Movement speed is increased. Effect ends upon entering battle.", "Aumenta la velocidad de movimiento. El efecto termina al entrar en combate.");

        // Action tooltip labels (Addon sheet 699–716). They only change if they reach the
        // ActionDetail string array; static labels from the window's layout are not touched here.

        add("Instant", "Instantáneo");
        add("Cast", "Lanzamiento");
        add("Recast", "Reutilización");
        add("HP Cost", "Costo de HP");
        add("MP Cost", "Costo de MP");
        add("TP Cost", "Costo de TP");
        add("Range", "Alcance");
        add("Radius", "Radio");
        add("Acquired", "Obtenido");
        add("Affinity", "Afinidad");
        add("Spell", "Hechizo");
        add("Ability", "Habilidad");
        add("Weaponskill", "Técnica de arma");
        add("{0}y", "{0} y");
        add("{0}s", "{0} s");
        add("Lv. {0}", "Nv. {0}");
    }
}
