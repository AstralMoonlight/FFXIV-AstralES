namespace AstralES.Translation;

public static partial class Spanish
{
    private static void Ast(Action<string, string> add)
    {
        // Astrologian: actions

        add("Additional Effect: {0}% chance next Benefic II will restore critical HP",
            "Efecto adicional: {0}% de probabilidad de que el siguiente Benefic II sea una curación crítica");
        add("Reduces cast times for spells by {0} seconds.", "Reduce {0} segundos el tiempo de lanzamiento de los hechizos.");
        add("Potency increases up to {0} as the target's HP decreases, reaching its maximum value when the target has {1}% HP or less.",
            "La potencia aumenta hasta {0} a medida que bajan los HP del objetivo, y llega al máximo cuando el objetivo tiene el {1}% de HP o menos.");
        add("Generate an aetheric bond with target party member. Each time you cast a single-target healing spell on yourself or a party member, the party member with whom you have the bond will also recover HP equaling {0}% of the original spell.",
            "Crea un vínculo etéreo con el miembro del grupo seleccionado. Cada vez que lances un hechizo de curación de un solo objetivo sobre ti o sobre un miembro del grupo, el miembro vinculado también recupera HP equivalentes al {0}% del hechizo original.");
        add("Creates a celestial ring {0} yalms around the caster.", "Crea un anillo celestial de {0} yalms alrededor de quien lo lanza.");
        add("Additional Effect: Reduces damage taken by {0}% for self and any party members within {1} yalms and applies Wheel of Fortune to self and any party members within {2} yalms",
            "Efecto adicional: Reduce un {0}% el daño que reciben tú y los miembros del grupo en un radio de {1} yalms, y aplica Wheel of Fortune a ti y a los miembros del grupo en un radio de {2} yalms");
        add("Wheel of Fortune Effect: Regen", "Efecto de Wheel of Fortune: Regen");
        add("Wheel of Fortune will be applied continuously to self and all party members standing within the celestial ring.",
            "Wheel of Fortune se aplica de forma continua a ti y a todos los miembros del grupo que estén dentro del anillo celestial.");
        add("Collective Unconscious effect ends upon using another action or moving (including facing a different direction).",
            "El efecto de Collective Unconscious termina al usar otra acción o al moverte (incluido girar hacia otra dirección).");
        add("Deploys an Earthly Star in the designated area and grants the effect of Earthly Dominance.",
            "Coloca una Earthly Star en la zona indicada y otorga el efecto de Earthly Dominance.");
        add("Executing Stellar Detonation while under the effect of Earthly Dominance creates a Stellar Burst dealing unaspected damage with a potency of {0} to all nearby enemies. Also restores own HP and the HP of all nearby party members.",
            "Usar Stellar Detonation bajo el efecto de Earthly Dominance crea un Stellar Burst que inflige daño sin elemento con una potencia de {0} a todos los enemigos cercanos. También restaura tus HP y los de todos los miembros del grupo cercanos.");
        add("After {0}s, Earthly Dominance effect is changed to Giant Dominance.", "Después de {0} s, el efecto de Earthly Dominance pasa a Giant Dominance.");
        add("Waiting {0}s or executing Stellar Detonation while under the effect of Giant Dominance creates a Stellar Explosion dealing unaspected damage with a potency of {1} to all nearby enemies. Also restores own HP and the HP of all nearby party members.",
            "Esperar {0} s o usar Stellar Detonation bajo el efecto de Giant Dominance crea una Stellar Explosion que inflige daño sin elemento con una potencia de {1} a todos los enemigos cercanos. También restaura tus HP y los de todos los miembros del grupo cercanos.");
        add("While under the effect of Earthly Dominance, detonates the currently deployed Earthly Star, creating a Stellar Burst that deals unaspected damage with a potency of {0} to all nearby enemies.",
            "Bajo el efecto de Earthly Dominance, detona la Earthly Star colocada y crea un Stellar Burst que inflige daño sin elemento con una potencia de {0} a todos los enemigos cercanos.");
        add("While under the effect of Giant Dominance, detonates the currently deployed Earthly Star, creating a Stellar Explosion that deals unaspected damage with a potency of {0} to all nearby enemies.",
            "Bajo el efecto de Giant Dominance, detona la Earthly Star colocada y crea una Stellar Explosion que inflige daño sin elemento con una potencia de {0} a todos los enemigos cercanos.");
        add("Additional Effect: Restores own HP and the HP of all nearby party members",
            "Efecto adicional: Restaura tus HP y los de todos los miembros del grupo cercanos");
        add("Increases damage dealt by self and nearby party members by {0}%.", "Aumenta un {0}% el daño que infligen tú y los miembros del grupo cercanos.");
        add("Additional Effect: Grants Divining", "Efecto adicional: Otorga Divining");
        add("Additional Effect: Grants Suntouched", "Efecto adicional: Otorga Suntouched");
        add("Additional Sect Effect: Erects a magicked barrier which nullifies damage equaling {0}% of the amount of HP restored",
            "Efecto adicional de secta: Levanta una barrera mágica que anula daño equivalente al {0}% de los HP restaurados");
        add("Reads your fortune and those of nearby party members, granting them Horoscope.",
            "Lee tu fortuna y la de los miembros del grupo cercanos, y les otorga Horoscope.");
        add("Effect upgraded to Horoscope Helios upon receiving the effects of Helios or Aspected Helios.",
            "El efecto mejora a Horoscope Helios al recibir los efectos de Helios o Aspected Helios.");
        add("Effect upgraded to Horoscope Helios upon receiving the effects of Helios or Helios Conjunction.",
            "El efecto mejora a Horoscope Helios al recibir los efectos de Helios o Helios Conjunction.");
        add("Restores the HP of those under either effect when the cards are read a second time or the effect expires.",
            "Restaura los HP de quienes tengan cualquiera de los dos efectos cuando se leen las cartas por segunda vez o cuando el efecto expira.");
        add("Horoscope Cure Potency: {0}", "Potencia de curación de Horoscope: {0}");
        add("Horoscope Helios Cure Potency: {0}", "Potencia de curación de Horoscope Helios: {0}");
        add("Potency is determined by the Horoscope effect of party members. Effect expires upon execution.",
            "La potencia depende del efecto de Horoscope de los miembros del grupo. El efecto expira al usarla.");
        add("Horoscope Potency: {0}", "Potencia de Horoscope: {0}");
        add("Horoscope Helios Potency: {0}", "Potencia de Horoscope Helios: {0}");
        add("Additional Effect: When casting Aspected Benefic or Aspected Helios, erects a magicked barrier which nullifies damage",
            "Efecto adicional: Al lanzar Aspected Benefic o Aspected Helios, levanta una barrera mágica que anula daño");
        add("Additional Effect: When casting Aspected Benefic or Helios Conjunction, erects a magicked barrier which nullifies damage",
            "Efecto adicional: Al lanzar Aspected Benefic o Helios Conjunction, levanta una barrera mágica que anula daño");
        add("Aspected Benefic Effect: Nullifies damage equaling {0}% of the amount of HP restored",
            "Efecto de Aspected Benefic: Anula daño equivalente al {0}% de los HP restaurados");
        add("Aspected Helios Effect: Nullifies damage equaling {0}% of the amount of HP restored",
            "Efecto de Aspected Helios: Anula daño equivalente al {0}% de los HP restaurados");
        add("Helios Conjunction Effect: Nullifies damage equaling {0}% of the amount of HP restored",
            "Efecto de Helios Conjunction: Anula daño equivalente al {0}% de los HP restaurados");
        add("Reduces damage taken by self or target party member by {0}%.", "Reduce un {0}% el daño que recibes tú o el miembro del grupo seleccionado.");
        add("Additional Effect: Restores HP at the end of the effect's duration", "Efecto adicional: Restaura HP al terminar la duración del efecto");
        add("Deals unaspected damage to all nearby enemies with a potency of {0} for the first enemy, and {1}% less for all remaining enemies.",
            "Inflige daño sin elemento a todos los enemigos cercanos con una potencia de {0} al primer enemigo y {1}% menos a los demás.");
        add("Deals unaspected damage to target and all enemies nearby it with a potency of {0} for the first enemy and {1}% less for all remaining enemies.",
            "Inflige daño sin elemento al objetivo y a todos los enemigos cercanos con una potencia de {0} al primer enemigo y {1}% menos a los demás.");
        add("Additional Effect: Grants Macrocosmos to self and all nearby party members",
            "Efecto adicional: Otorga Macrocosmos a ti y a todos los miembros del grupo cercanos");
        add("For the effect's duration, {0}% of damage taken is compiled.", "Mientras dura el efecto, se acumula el {0}% del daño recibido.");
        add("Restores HP equal to a cure of {0} potency plus compiled damage when the effect expires or upon execution of Microcosmos.",
            "Al expirar el efecto o al usar Microcosmos, restaura HP equivalentes a una curación de potencia {0} más el daño acumulado.");
        add("Amount restored cannot exceed the target's maximum HP.", "La cantidad restaurada no puede superar los HP máximos del objetivo.");
        add("Triggers the healing effect of Macrocosmos, restoring HP equal to a cure of {0} potency plus {1}% of compiled damage.",
            "Activa la curación de Macrocosmos, que restaura HP equivalentes a una curación de potencia {0} más el {1}% del daño acumulado.");
        add("Draws the Balance, the Arrow, and the Spire from your divining deck.",
            "Saca the Balance, the Arrow y the Spire de tu baraja adivinatoria.");
        add("Draws the Balance, the Arrow, the Spire, and the Lord of Crowns from your divining deck.",
            "Saca the Balance, the Arrow, the Spire y the Lord of Crowns de tu baraja adivinatoria.");
        add("Draws the Spear, the Bole, and the Ewer from your divining deck.",
            "Saca the Spear, the Bole y the Ewer de tu baraja adivinatoria.");
        add("Draws the Spear, the Bole, the Ewer, and the Lady of Crowns from your divining deck.",
            "Saca the Spear, the Bole, the Ewer y the Lady of Crowns de tu baraja adivinatoria.");
        add("Upon execution, Play I changes to The Balance, Play II changes to The Arrow, Play III changes to The Spire, and Astral Draw changes to Umbral Draw.",
            "Al usarla, Play I se convierte en The Balance, Play II en The Arrow, Play III en The Spire y Astral Draw en Umbral Draw.");
        add("Upon execution, Play I changes to The Balance, Play II changes to The Arrow, Play III changes to The Spire, Minor Arcana changes to Lord of Crowns, and Astral Draw changes to Umbral Draw.",
            "Al usarla, Play I se convierte en The Balance, Play II en The Arrow, Play III en The Spire, Minor Arcana en Lord of Crowns y Astral Draw en Umbral Draw.");
        add("Upon execution, Play I changes to The Spear, Play II changes to The Bole, Play III changes to The Ewer, and Umbral Draw changes to Astral Draw.",
            "Al usarla, Play I se convierte en The Spear, Play II en The Bole, Play III en The Ewer y Umbral Draw en Astral Draw.");
        add("Upon execution, Play I changes to The Spear, Play II changes to The Bole, Play III changes to The Ewer, Minor Arcana changes to Lady of Crowns, and Umbral Draw changes to Astral Draw.",
            "Al usarla, Play I se convierte en The Spear, Play II en The Bole, Play III en The Ewer, Minor Arcana en Lady of Crowns y Umbral Draw en Astral Draw.");
        add("Shares a recast timer with Umbral Draw.", "Comparte tiempo de reutilización con Umbral Draw.");
        add("Shares a recast timer with Astral Draw.", "Comparte tiempo de reutilización con Astral Draw.");
        add("Plays the drawn arcanum after executing Astral Draw or Umbral Draw.", "Juega el arcano que sacaste con Astral Draw o Umbral Draw.");
        add("Astral Draw Effect: Action changes to The Balance", "Efecto de Astral Draw: La acción se convierte en The Balance");
        add("Astral Draw Effect: Action changes to The Arrow", "Efecto de Astral Draw: La acción se convierte en The Arrow");
        add("Astral Draw Effect: Action changes to The Spire", "Efecto de Astral Draw: La acción se convierte en The Spire");
        add("Astral Draw Effect: Action changes to Lord of Crowns", "Efecto de Astral Draw: La acción se convierte en Lord of Crowns");
        add("Umbral Draw Effect: Action changes to The Spear", "Efecto de Umbral Draw: La acción se convierte en The Spear");
        add("Umbral Draw Effect: Action changes to The Bole", "Efecto de Umbral Draw: La acción se convierte en The Bole");
        add("Umbral Draw Effect: Action changes to The Ewer", "Efecto de Umbral Draw: La acción se convierte en The Ewer");
        add("Umbral Draw Effect: Action changes to Lady of Crowns", "Efecto de Umbral Draw: La acción se convierte en Lady of Crowns");
        add("Increases damage dealt by a party member or self by {0}% if target is melee DPS or tank, or {1}% for all other roles.",
            "Aumenta el daño que inflige un miembro del grupo o tú: un {0}% si el objetivo es DPS cuerpo a cuerpo o tanque, o un {1}% para los demás roles.");
        add("Increases damage dealt by a party member or self by {0}% if target is ranged DPS or healer, or {1}% for all other roles.",
            "Aumenta el daño que inflige un miembro del grupo o tú: un {0}% si el objetivo es DPS a distancia o sanador, o un {1}% para los demás roles.");
        add("Grants healing over time effect to a party member or self.", "Otorga un efecto de curación periódica a un miembro del grupo o a ti.");
        add("Can only be executed while Divining.", "Solo se puede usar bajo el efecto de Divining.");
        add("Can only be executed while Suntouched.", "Solo se puede usar bajo el efecto de Suntouched.");
        add("※Astral Draw changes to Umbral Draw when requirements for execution are met.",
            "※Astral Draw se convierte en Umbral Draw cuando se cumplen los requisitos para usarla.");
        add("※Minor Arcana changes to Lord of Crowns when requirements for execution are met.",
            "※Minor Arcana se convierte en Lord of Crowns cuando se cumplen los requisitos para usarla.");
        add("※Minor Arcana changes to Lady of Crowns when requirements for execution are met.",
            "※Minor Arcana se convierte en Lady of Crowns cuando se cumplen los requisitos para usarla.");
        add("※Play I changes to The Balance when requirements for execution are met.",
            "※Play I se convierte en The Balance cuando se cumplen los requisitos para usarla.");
        add("※Play II changes to The Arrow when requirements for execution are met.",
            "※Play II se convierte en The Arrow cuando se cumplen los requisitos para usarla.");
        add("※Play III changes to The Spire when requirements for execution are met.",
            "※Play III se convierte en The Spire cuando se cumplen los requisitos para usarla.");
        add("※Play I changes to The Spear when requirements for execution are met.",
            "※Play I se convierte en The Spear cuando se cumplen los requisitos para usarla.");
        add("※Play II changes to The Bole when requirements for execution are met.",
            "※Play II se convierte en The Bole cuando se cumplen los requisitos para usarla.");
        add("※Play III changes to The Ewer when requirements for execution are met.",
            "※Play III se convierte en The Ewer cuando se cumplen los requisitos para usarla.");

        // Astrologian: traits

        add("Grants a {0}% chance that your next Benefic II will restore critical HP.",
            "Otorga un {0}% de probabilidad de que tu siguiente Benefic II sea una curación crítica.");
        add("Upgrades Combust to Combust II.", "Mejora Combust a Combust II.");
        add("Upgrades Combust II to Combust III.", "Mejora Combust II a Combust III.");
        add("Upgrades Malefic to Malefic II.", "Mejora Malefic a Malefic II.");
        add("Upgrades Malefic II to Malefic III.", "Mejora Malefic II a Malefic III.");
        add("Upgrades Malefic III to Malefic IV.", "Mejora Malefic III a Malefic IV.");
        add("Upgrades Malefic IV to Fall Malefic.", "Mejora Malefic IV a Fall Malefic.");
        add("Upgrades Gravity to Gravity II.", "Mejora Gravity a Gravity II.");
        add("Upgrades Aspected Helios to Helios Conjunction.", "Mejora Aspected Helios a Helios Conjunction.");
        add("Reduces Lightspeed recast time to {0} seconds.", "Reduce el tiempo de reutilización de Lightspeed a {0} segundos.");
        add("Allows the accumulation of charges for consecutive uses of Essential Dignity.",
            "Permite acumular cargas para usar Essential Dignity de forma consecutiva.");
        add("Allows the accumulation of charges for consecutive uses of Celestial Intersection.",
            "Permite acumular cargas para usar Celestial Intersection de forma consecutiva.");
        add("Allows a third charge of Essential Dignity.", "Permite una tercera carga de Essential Dignity.");
        add("Increases the healing potency of Benefic to {0}, Helios to {1}, Benefic II to {2}, Aspected Benefic to {3}, Aspected Benefic's Regen effect to {4}, Aspected Helios to {5}, and Aspected Helios's Regen effect to {6}.",
            "Aumenta la potencia de curación de Benefic a {0}, Helios a {1}, Benefic II a {2}, Aspected Benefic a {3}, el efecto Regen de Aspected Benefic a {4}, Aspected Helios a {5} y el efecto Regen de Aspected Helios a {6}.");
        add("Lord of Crowns can be drawn when executing Astral Draw, and Lady of Crowns can be drawn when executing Umbral Draw.",
            "Permite sacar Lord of Crowns al usar Astral Draw y Lady of Crowns al usar Umbral Draw.");
        add("Grants Divining upon executing Divination.", "Otorga Divining al usar Divination.");
        add("Grants Suntouched upon executing Neutral Sect.", "Otorga Suntouched al usar Neutral Sect.");
        add("Increases the potency of Combust III's damage over time to {0}, Fall Malefic to {1}, Gravity II to {2}, and Macrocosmos to {3}.",
            "Aumenta la potencia del daño periódico de Combust III a {0}, la de Fall Malefic a {1}, la de Gravity II a {2} y la de Macrocosmos a {3}.");

        // Astrologian: statuses

        add("Restoring TP over time.", "Restaurando TP de forma gradual.");
        add("Proximity of a theoretical sun is causing damage over time.", "La cercanía de un sol teórico causa daño periódico.");
        add("Spell casting time is reduced.", "Se reduce el tiempo de lanzamiento de los hechizos.");
        add("Spell casting time and MP cost are reduced by {0}% and {1}% respectively.",
            "Se reducen el tiempo de lanzamiento de los hechizos un {0}% y su costo de MP un {1}%.");
        add("Spell cast and recast times are reduced.", "Se reducen el tiempo de lanzamiento y de reutilización de los hechizos.");
        add("An aetheric bond is created with a party member. Each time a single-target healing spell is cast, that member will recover partial HP.",
            "Se creó un vínculo etéreo con un miembro del grupo. Cada vez que se lanza un hechizo de curación de un solo objetivo, ese miembro recupera parte de los HP.");
        add("An aetheric bond is created with a party astrologian. Each time a single-target healing spell is cast by the astrologian, you will recover partial HP.",
            "Se creó un vínculo etéreo con un astrologian del grupo. Cada vez que el astrologian lanza un hechizo de curación de un solo objetivo, recuperas parte de los HP.");
        add("An area of mind attunement is healing party members.", "Una zona de sintonía mental cura a los miembros del grupo.");
        add("An area of mind attunement is created, allowing regeneration of HP over time for all who enter.",
            "Se creó una zona de sintonía mental que regenera HP de forma gradual a quien entre en ella.");
        add("An area of mind attunement is created, reducing damage taken for all who enter.",
            "Se creó una zona de sintonía mental que reduce el daño que recibe quien entre en ella.");
        add("An earthly star is in your control.", "Controlas una estrella terrenal.");
        add("Primed to receive the healing effects of Horoscope.", "Preparado para recibir la curación de Horoscope.");
        add("Helios is upgraded to Aspected Helios, while Benefic is upgraded to Aspected Benefic.",
            "Helios mejora a Aspected Helios y Benefic mejora a Aspected Benefic.");
        add("Restores HP when effect duration expires or the astrologian who granted this effect executes Microcosmos. Healing potency is based on damage taken and compiled over the duration of the effect.",
            "Restaura HP cuando expira el efecto o cuando el astrologian que lo otorgó usa Microcosmos. La potencia de curación depende del daño recibido y acumulado mientras dura el efecto.");
        add("Restores HP when the astrologian who granted this effect executes Microcosmos.",
            "Restaura HP cuando el astrologian que otorgó este efecto usa Microcosmos.");
        add("Weaponskill and spell cast and recast time are reduced. Movement speed is also increased.",
            "Se reducen el tiempo de lanzamiento y de reutilización de técnicas de arma y hechizos. También aumenta la velocidad de movimiento.");
        add("Able to execute Oracle.", "Permite usar Oracle.");
        add("Able to execute Sun Sign.", "Permite usar Sun Sign.");
        add("The Lady of Crowns card is drawn.", "Sacaste la carta Lady of Crowns.");
        add("The Lord of Crowns card is drawn.", "Sacaste la carta Lord of Crowns.");
    }
}
