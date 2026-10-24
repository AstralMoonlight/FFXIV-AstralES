namespace AstralES.Translation;

public static partial class Spanish
{
    private static void Interface(Action<string, string> add)
    {
        // Online statuses (OnlineStatus sheet). Game Master, PvP, Free Company and Grand Company
        // stay as they are.
        add("Game QA", "Control de calidad");
        add("Event Participant", "Participante del evento");
        add("Disconnected", "Desconectado");
        add("Waiting for Friend List Approval", "Esperando aprobación para la Friend List");
        add("Waiting for Linkshell Approval", "Esperando aprobación de la Linkshell");
        add("Waiting for Free Company Approval", "Esperando aprobación de la Free Company");
        add("Not Found", "No encontrado");
        add("Offline", "Fuera de línea");
        add("Online", "En línea");
        add("Busy", "Ocupado");
        add("Playing Triple Triad", "Jugando Triple Triad");
        add("Viewing Cutscene", "Viendo una cinemática");
        add("Using a Chocobo Porter", "Usando un chocobo de transporte");
        add("Away from Keyboard", "Ausente");
        add("Camera Mode", "Modo de cámara");
        add("Looking for Repairs", "Busca reparaciones");
        add("Looking to Repair", "Ofrece reparaciones");
        add("Looking to Meld Materia", "Ofrece engarzar materia");
        add("Role-playing", "Haciendo rol");
        add("Looking for Party", "Busca grupo");
        add("Sword for Hire", "Espada de alquiler");
        add("Waiting for Duty Finder", "Esperando el Duty Finder");
        add("Recruiting Party Members", "Recluta miembros para el grupo");
        add("Battle Mentor", "Mentor de combate");
        add("PvE Mentor", "Mentor PvE");
        add("Trade Mentor", "Mentor de oficios");
        add("PvP Mentor", "Mentor PvP");
        add("Returner", "De regreso");
        add("New Adventurer", "Principiante");
        add("Trial Adventurer", "Cuenta de prueba");
        add("Alliance Leader", "Líder de la alianza");
        add("Alliance Party Leader", "Líder de grupo de la alianza");
        add("Alliance Party Member", "Miembro de grupo de la alianza");
        add("Party Leader", "Líder del grupo");
        add("Party Member", "Miembro del grupo");
        add("Party Leader (Cross-world)", "Líder del grupo (entre mundos)");
        add("Party Member (Cross-world)", "Miembro del grupo (entre mundos)");
        add("Another World", "Otro mundo");
        add("Sharing Duty", "En el mismo duty");
        add("Similar Duty", "Duty similar");
        add("In Duty", "En un duty");

        // Target markers and waymarks (Marker, FieldMarker). "Waymark A" stays.
        add("Target to Attack {0}", "Objetivo a atacar {0}");
        add("Target to Bind {0}", "Objetivo a inmovilizar {0}");
        add("Target to Ignore {0}", "Objetivo a ignorar {0}");
        add("Square", "Cuadrado");
        add("Circle", "Círculo");
        add("Plus", "Cruz");
        add("Triangle", "Triángulo");
        add("Clear Waymarks", "Quitar waymarks");

        // ExtraCommand: Group Pose, Idling Camera, Alarm and Command Panel. The names stay.
        add("Perform a group pose, repeating the last executed emote or action on loop. Camera position, lighting, and color filter can be all be adjusted in the command settings.",
            "Haz una Group Pose que repite en bucle el último emote o la última acción. La posición de la cámara, la iluminación y el filtro de color se ajustan en la configuración del comando.");
        add("Enable the idling camera. While active, the idling camera will randomly toggle between nearby PCs and NPCs. Executing the command with a PC or NPC targeted will center the camera on that target. Camera position, lighting, and color filter can be all be adjusted in the command settings.",
            "Activa la Idling Camera. Mientras está activa, la cámara pasa al azar de un PC o NPC cercano a otro. Si ejecutas el comando con un PC o NPC como objetivo, la cámara se centra en él. La posición de la cámara, la iluminación y el filtro de color se ajustan en la configuración del comando.");
        add("Enable alarm. Alarms can be set to go off while in game and are deleted upon logout.",
            "Activa una alarma. Las alarmas suenan mientras juegas y se borran al cerrar sesión.");
        add("Displays the Command Panel.", "Muestra el Command Panel.");
        add("Freely register various actions and commands including mounts, minions, emotes, and gear sets for easy access and execution.",
            "Registra a gusto acciones y comandos, como monturas, minions, emotes y gear sets, para tenerlos a mano y ejecutarlos con facilidad.");

        foreach (var command in new[] { "grouppose", "idlingcamera", "alarm", "commandpanel" })
            add($"Text Command: /{command}", $"Comando de texto: /{command}");

        add("Key Mapping:  Available", "Asignación de teclas: disponible");

        // PvP quick chat (QuickChatTransient). The example phrase under each description stays,
        // like the chat it shows.
        foreach (var (en, es) in new[] { ("Crystalline Conflict", "Crystalline Conflict"), ("the Feast", "The Feast") })
        {
            add($"Fixed phrase available only during {en}.", $"Frase fija, disponible solo en {es}.");
            add($"Variable phrase available only during {en}.", $"Frase variable, disponible solo en {es}.");
        }

        add("Uses name and recast time of action in additional action slot {0}.",
            "Usa el nombre y el tiempo de reutilización de la acción del espacio {0} de acción adicional.");
        add("Displays current job and limit gauge progress.", "Muestra el job actual y el progreso del medidor de límite.");
        add("Displays percentage of MP remaining.", "Muestra el porcentaje de MP que queda.");
        add("Displays percentage of TP remaining.", "Muestra el porcentaje de TP que queda.");
        add("Uses current target.", "Usa el objetivo actual.");
        add("Uses current target and adds a countdown time above their head.",
            "Usa el objetivo actual y le pone una cuenta regresiva sobre la cabeza.");
        add("Applies to targeted party member.", "Se aplica al miembro del grupo que tienes como objetivo.");
        add("Displays current job.", "Muestra el job actual.");
        add("Informs party of availability of Purify.", "Avisa al grupo si Purify está disponible.");
        add("Informs party of availability of Guard.", "Avisa al grupo si Guard está disponible.");
    }
}
