namespace AstralES.Translation;

public static partial class Spanish
{
    private static void Sch(Action<string, string> add)
    {
        // Scholar: actions

        add("Restores {0}% of maximum MP.", "Restaura un {0}% de los MP máximos.");
        add("Additional Effect: Aetherflow III", "Efecto adicional: Aetherflow III");
        add("Additional Effect: Increases Faerie Gauge by {0}", "Efecto adicional: Aumenta {0} el Faerie Gauge");
        add("Faerie Gauge Cost: {0}", "Costo de Faerie Gauge: {0}");
        add("Additional Effect: Grants Galvanize to target, nullifying damage equaling {0}% of the amount of HP restored. When critical HP is restored, also grants Catalyze, nullifying damage equaling {1}% the amount of HP restored.",
            "Efecto adicional: Otorga Galvanize al objetivo, que anula daño equivalente al {0}% de los HP restaurados. Si la curación es crítica, también otorga Catalyze, que anula daño equivalente al {1}% de los HP restaurados.");
        add("Effect cannot be stacked with certain sage barrier effects.", "No se acumula con ciertos efectos de barrera de un sage.");
        add("Effect cannot be stacked with Seraphic Illumination.", "No se acumula con Seraphic Illumination.");
        add("Effect cannot be stacked with Fey Illumination.", "No se acumula con Fey Illumination.");
        add("Effect cannot be stacked with Dissipation.", "No se acumula con Dissipation.");
        add("Creates a designated area in which party members will only suffer {0}% of all damage inflicted.",
            "Crea una zona en la que los miembros del grupo solo sufren el {0}% del daño infligido.");
        add("Gradually restores the HP of all nearby party members.", "Restaura de forma gradual los HP de todos los miembros del grupo cercanos.");
        add("Gradually restores the HP of self and all party members within a radius of {0} yalms.",
            "Restaura de forma gradual tus HP y los de todos los miembros del grupo en un radio de {0} yalms.");
        add("Restores the HP of all nearby party members.", "Restaura los HP de todos los miembros del grupo cercanos.");
        add("Increases healing magic potency of all nearby party members by {0}%, while reducing magic damage taken by all nearby party members by {1}%.",
            "Aumenta un {0}% la potencia de la magia curativa de todos los miembros del grupo cercanos y reduce un {1}% el daño mágico que reciben.");
        add("Increases healing magic potency of nearby party members by {0}%, while reducing magic damage taken by nearby party members by {1}%.",
            "Aumenta un {0}% la potencia de la magia curativa de los miembros del grupo cercanos y reduce un {1}% el daño mágico que reciben.");
        add("Extends Galvanize effect cast on self or target party member to other nearby party members.",
            "Extiende a los demás miembros del grupo cercanos el efecto de Galvanize que tienes tú o el miembro del grupo seleccionado.");
        add("Duration: Time remaining on original effect", "Duración: el tiempo que le quede al efecto original");
        add("No effect when target is not under the effect of Galvanize.", "No tiene efecto si el objetivo no está bajo el efecto de Galvanize.");
        add("Transforms the next Galvanize and Catalyze statuses into HP recovery equaling the amount of damage reduction intended for the barrier.",
            "Convierte los siguientes estados de Galvanize y Catalyze en una recuperación de HP igual al daño que iba a anular la barrera.");
        add("Orders your faerie away while granting you a full Aetherflow stack. Also increases healing magic potency by {0}%.",
            "Despide a tu hada y te otorga todas las acumulaciones de Aetherflow. También aumenta un {0}% la potencia de la magia curativa.");
        add("Current faerie will return once the effect expires.", "Tu hada vuelve cuando termina el efecto.");
        add("Summon Eos cannot be executed while under the effect of Dissipation.", "No se puede usar Summon Eos bajo el efecto de Dissipation.");
        add("Can only be executed while a faerie is summoned and you are in combat.", "Solo se puede usar en combate y con un hada invocada.");
        add("Can only be executed while a faerie or Seraph is summoned and you are in combat.", "Solo se puede usar en combate y con un hada o Seraph invocados.");
        add("Grants self or target party member the effect of Excogitation, restoring HP when member's HP falls to {0}% or below, or upon effect duration expiration.",
            "Otorga a ti o al miembro del grupo seleccionado el efecto de Excogitation, que restaura HP cuando sus HP bajan al {0}% o menos, o al terminar la duración del efecto.");
        add("Increases rate at which target takes critical hits by {0}%.", "Aumenta un {0}% la probabilidad de que el objetivo reciba golpes críticos.");
        add("Additional Effect: Grants Impact Imminent", "Efecto adicional: Otorga Impact Imminent");
        add("Orders faerie to execute Fey Union with target party member. Effect ends upon reuse.",
            "Ordena a tu hada formar Fey Union con el miembro del grupo seleccionado. El efecto termina al volver a usarla.");
        add("Fey Union Effect: Gradually restores HP of party member with which faerie has a Fey Union.",
            "Efecto de Fey Union: Restaura de forma gradual los HP del miembro del grupo unido al hada por Fey Union.");
        add("Gradually restores HP of party member with which faerie has a Fey Union.",
            "Restaura de forma gradual los HP del miembro del grupo unido al hada por Fey Union.");
        add("Faerie Gauge is depleted by {0} periodically while HP is restored. Fey Union effect fades upon execution of other faerie actions or when party member moves from within {1} yalms of the faerie.",
            "El Faerie Gauge baja {0} periódicamente mientras se restauran los HP. El efecto de Fey Union termina al usar otras acciones del hada o si el miembro del grupo se aleja más de {1} yalms del hada.");
        add("The Faerie Gauge increases when a faerie is summoned and an Aetherflow action is successfully executed while in combat.",
            "El Faerie Gauge aumenta al usar con éxito una acción de Aetherflow en combate con un hada invocada.");
        add("The Faerie Gauge increases when a faerie or Seraph is summoned and an Aetherflow action is successfully executed while in combat.",
            "El Faerie Gauge aumenta al usar con éxito una acción de Aetherflow en combate con un hada o Seraph invocados.");
        add("Dissolves current Fey Union.", "Disuelve la Fey Union actual.");
        add("Orders faerie to execute Whispering Dawn.", "Ordena a tu hada usar Whispering Dawn.");
        add("Whispering Dawn Effect: Gradually restores the HP of all nearby party members",
            "Efecto de Whispering Dawn: Restaura de forma gradual los HP de todos los miembros del grupo cercanos");
        add("Orders faerie to execute Whispering Dawn. If Seraph is summoned, orders her to execute Angel's Whisper.",
            "Ordena a tu hada usar Whispering Dawn. Si Seraph está invocada, le ordena usar Angel's Whisper.");
        add("Whispering Dawn/Angel's Whisper Effect: Gradually restores the HP of all nearby party members",
            "Efecto de Whispering Dawn/Angel's Whisper: Restaura de forma gradual los HP de todos los miembros del grupo cercanos");
        add("Orders faerie to execute Fey Illumination.", "Ordena a tu hada usar Fey Illumination.");
        add("Fey Illumination Effect: Increases healing magic potency of all nearby party members by {0}%, while reducing magic damage taken by all nearby party members by {1}%",
            "Efecto de Fey Illumination: Aumenta un {0}% la potencia de la magia curativa de todos los miembros del grupo cercanos y reduce un {1}% el daño mágico que reciben");
        add("Orders faerie to execute Fey Illumination. If Seraph is summoned, orders her to execute Seraphic Illumination.",
            "Ordena a tu hada usar Fey Illumination. Si Seraph está invocada, le ordena usar Seraphic Illumination.");
        add("Fey Illumination/Seraphic Illumination Effect: Increases healing magic potency of all nearby party members by {0}%, while reducing magic damage taken by all nearby party members by {1}%",
            "Efecto de Fey Illumination/Seraphic Illumination: Aumenta un {0}% la potencia de la magia curativa de todos los miembros del grupo cercanos y reduce un {1}% el daño mágico que reciben");
        add("Allows the execution of Adloquium, Succor, Indomitability, or Excogitation without consuming resources while also ensuring critical HP is restored.",
            "Permite usar Adloquium, Succor, Indomitability o Excogitation sin consumir recursos y garantiza que la curación sea crítica.");
        add("Allows the execution of Adloquium, Concitation, Indomitability, or Excogitation without consuming resources while also ensuring critical HP is restored.",
            "Permite usar Adloquium, Concitation, Indomitability o Excogitation sin consumir recursos y garantiza que la curación sea crítica.");
        add("Orders faerie to execute Fey Blessing.", "Ordena a tu hada usar Fey Blessing.");
        add("Fey Blessing Effect: Restores the HP of all nearby party members", "Efecto de Fey Blessing: Restaura los HP de todos los miembros del grupo cercanos");
        add("Summons the faerie Eos to fight at your side. When set to guard, automatically casts Embrace on party members who suffer damage.",
            "Invoca al hada Eos para que luche a tu lado. En modo de guardia, lanza automáticamente Embrace sobre los miembros del grupo que reciben daño.");
        add("Summons Seraph to fight at your side. When set to guard, automatically casts Seraphic Veil on party members who suffer damage.",
            "Invoca a Seraph para que luche a tu lado. En modo de guardia, lanza automáticamente Seraphic Veil sobre los miembros del grupo que reciben daño.");
        add("Cannot summon Seraph unless a pet is already summoned. Current pet will leave the battlefield while Seraph is present, and return once gone.",
            "Solo se puede invocar a Seraph si ya hay una mascota invocada. Tu mascota actual se retira mientras Seraph está presente y vuelve cuando se va.");
        add("Orders Seraph to execute Consolation.", "Ordena a Seraph usar Consolation.");
        add("Consolation Effect: Restores the HP of all nearby party members", "Efecto de Consolation: Restaura los HP de todos los miembros del grupo cercanos");
        add("Increases maximum HP of a party member or self by {0}% and restores the amount increased.",
            "Aumenta un {0}% los HP máximos de un miembro del grupo o los tuyos y restaura la cantidad aumentada.");
        add("Additional Effect: Increases HP recovery via healing actions by {0}%",
            "Efecto adicional: Aumenta un {0}% la recuperación de HP por acciones de curación");
        add("Grants Expedience and Desperate Measures to all nearby party members.", "Otorga Expedience y Desperate Measures a todos los miembros del grupo cercanos.");
        add("Expedience Effect: Increases movement speed", "Efecto de Expedience: Aumenta la velocidad de movimiento");
        add("Desperate Measures Effect: Reduces damage taken by {0}%", "Efecto de Desperate Measures: Reduce un {0}% el daño recibido");
        add("Deals unaspected damage over time to target and all enemies nearby it.",
            "Inflige daño sin elemento periódico al objetivo y a todos los enemigos cercanos.");
        add("Can only be executed while under the effect of Impact Imminent.", "Solo se puede usar bajo el efecto de Impact Imminent.");
        add("Can only be executed while under the effect of Seraphism.", "Solo se puede usar bajo el efecto de Seraphism.");
        add("Additional Effect: Changes Adloquium to Manifestation and Concitation to Accession",
            "Efecto adicional: Adloquium se convierte en Manifestation y Concitation en Accession");
        add("Additional Effect: Resets Emergency Tactics recast timer and reduces its recast timer to {0}s",
            "Efecto adicional: Reinicia el tiempo de reutilización de Emergency Tactics y lo reduce a {0} s");
        add("※Adloquium changes to Manifestation when requirements for execution are met.",
            "※Adloquium se convierte en Manifestation cuando se cumplen los requisitos para usarla.");
        add("※Concitation changes to Accession when requirements for execution are met.",
            "※Concitation se convierte en Accession cuando se cumplen los requisitos para usarla.");

        // Scholar: traits

        add("Upgrades Bio to Bio II.", "Mejora Bio a Bio II.");
        add("Upgrades Bio II to Biolysis.", "Mejora Bio II a Biolysis.");
        add("Upgrades Art of War to Art of War II.", "Mejora Art of War a Art of War II.");
        add("Upgrades Succor to Concitation.", "Mejora Succor a Concitation.");
        add("Upgrades Ruin to Broil and increases the potency of Ruin II to {0}, and Art of War to {1}.",
            "Mejora Ruin a Broil y aumenta la potencia de Ruin II a {0} y la de Art of War a {1}.");
        add("Upgrades Broil to Broil II and increases the potency of Ruin II to {0}.", "Mejora Broil a Broil II y aumenta a {0} la potencia de Ruin II.");
        add("Upgrades Broil II to Broil III and increases the potency of Ruin II to {0}.", "Mejora Broil II a Broil III y aumenta a {0} la potencia de Ruin II.");
        add("Upgrades Broil III to Broil IV and increases the potency of Ruin II to {0}.", "Mejora Broil III a Broil IV y aumenta a {0} la potencia de Ruin II.");
        add("Adds an additional effect to Sacred Soil that grants healing over time.", "Agrega a Sacred Soil un efecto adicional de curación periódica.");
        add("Increases the healing potency of Physick to {0}, Embrace to {1}, and Seraphic Veil to {2}.",
            "Aumenta la potencia de curación de Physick a {0}, Embrace a {1} y Seraphic Veil a {2}.");
        add("Increases the barrier potency of Adloquium to {0}% the amount healed and Succor to {1}% the amount healed.",
            "Aumenta la potencia de la barrera de Adloquium al {0}% de lo curado y la de Succor al {1}% de lo curado.");
        add("Reduces Deployment Tactics recast time to {0} seconds.", "Reduce el tiempo de reutilización de Deployment Tactics a {0} segundos.");
        add("Reduces Recitation recast time to {0} seconds.", "Reduce el tiempo de reutilización de Recitation a {0} segundos.");
        add("Grants Impact Imminent upon using Chain Stratagem.", "Otorga Impact Imminent al usar Chain Stratagem.");
        add("Increases the potency of Biolysis's damage over time effect to {0} and Broil IV to {1}.",
            "Aumenta la potencia del daño periódico de Biolysis a {0} y la de Broil IV a {1}.");

        // Scholar: statuses

        add("Next Succor will cost no MP.", "El siguiente Succor no cuesta MP.");
        add("Contagions are spreading, causing damage over time.", "Un contagio se propaga y causa daño periódico.");
        add("Lungs are failing, causing damage over time.", "Los pulmones fallan y causan daño periódico.");
        add("An area of land has been sanctified, reducing damage taken for all who enter.",
            "Una zona quedó santificada y reduce el daño que recibe quien entre en ella.");
        add("A circle of sanctified earth is healing party members and reducing damage taken within its bounds.",
            "Un círculo de tierra santificada cura a los miembros del grupo y reduce el daño que reciben dentro de él.");
        add("Magic defense and healing magic potency are increased.", "Aumentan la defensa mágica y la potencia de la magia curativa.");
        add("The next Galvanize and Catalyze statuses are transformed into HP recovery equaling the amount of damage reduction intended for their barriers.",
            "Los siguientes estados de Galvanize y Catalyze se convierten en una recuperación de HP igual al daño que iban a anular sus barreras.");
        add("Rate at which critical hits are taken is increased.", "Aumenta la probabilidad de recibir golpes críticos.");
        add("Allowing regeneration of HP over time.", "Permite regenerar HP de forma gradual.");
        add("The next Adloquium, Succor, Indomitability, or Excogitation executed will cost no MP or Aetherflow stacks and will restore critical HP.",
            "El siguiente Adloquium, Succor, Indomitability o Excogitation no cuesta MP ni acumulaciones de Aetherflow y su curación es crítica.");
        add("The next Adloquium, Concitation, Indomitability, or Excogitation executed will cost no MP or Aetherflow stacks and will restore critical HP.",
            "El siguiente Adloquium, Concitation, Indomitability o Excogitation no cuesta MP ni acumulaciones de Aetherflow y su curación es crítica.");
        add("Rapid decomposition of the flesh is reducing HP recovery.", "Una rápida descomposición de la carne reduce la recuperación de HP.");
        add("Damage dealt and potency of all HP restoration actions are increased.",
            "Aumentan el daño infligido y la potencia de todas las acciones de recuperación de HP.");
        add("Maximum HP is increased and HP recovery via healing actions is increased.",
            "Aumentan los HP máximos y la recuperación de HP por acciones de curación.");
        add("Suffering damage over time.", "Recibiendo daño periódico.");
        add("Adloquium and Biolysis effects are enhanced.", "Se potencian los efectos de Adloquium y Biolysis.");
        add("Manifesting Seraph to assist in battle.", "Manifestando a Seraph para que ayude en combate.");
        add("Hasty Touch is upgraded to Daring Touch.", "Hasty Touch mejora a Daring Touch.");
        add("Able to execute Baneful Impaction.", "Permite usar Baneful Impaction.");
        add("Self and nearby party members are regenerating HP over time.", "Tú y los miembros del grupo cercanos regeneran HP de forma gradual.");
        add("Broil IV is upgraded to Seraphic Halo.", "Broil IV mejora a Seraphic Halo.");
    }
}
