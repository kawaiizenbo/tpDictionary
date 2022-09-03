using System;

using System.Collections.Generic;
using System.Text;

namespace tpDictionary
{
    public class WordsList
    {
        public static Dictionary<string, WordInfo> Words { get; set; }

        public WordsList()
        {
            Words = new Dictionary<string, WordInfo>
            {
                { "a", new WordInfo("a", "particle", "(emphasis, emotion or confirmation)", "", "") },
                { "akesi", new WordInfo("akesi", "noun", "reptile, amphibian", "", "") },
                { "ala", new WordInfo("ala", "adjective", "no, not, zero", "", "") },
                { "alasa", new WordInfo("alasa", "verb", "to hunt, forage", "pre-verb", "try to") },
                { "ale", new WordInfo("ale", "adjective", "all; abundant, countless, bountiful, every, plentiful", "noun", "abundance, everything, life, universe") },
                { "ali", new WordInfo("ali", "adjective", "all; abundant, countless, bountiful, every, plentiful", "noun", "abundance, everything, life, universe") },
                { "anpa", new WordInfo("anpa", "adjective", "bowing down, downward, humble, lowly, dependent", "noun", "area below or under") },
                { "ante", new WordInfo("ante", "adjective", "different, altered, changed, other", "", "") },
                { "anu", new WordInfo("anu", "particle", "or", "", "") },
                { "awen", new WordInfo("awen", "adjective", "enduring, kept, protected, safe, waiting, staying", "pre-verb", "to continue to") },
                { "e", new WordInfo("e", "particle", "(before the direct object)", "", "") },
                { "epiku", new WordInfo("epiku", "adjective", "epic, awesome, amazing", "", "") },
                { "esun", new WordInfo("esun", "noun", "market, shop, fair, bazaar, business transaction", "", "") },
                { "ijo", new WordInfo("ijo", "noun", "thing, phenomenon, object, matter", "", "") },
                { "ike", new WordInfo("ike", "adjective", "bad, negative; non-essential, irrelevant", "", "") },
                { "ilo", new WordInfo("ilo", "noun", "tool, implement, machine, device", "", "") },
                { "insa", new WordInfo("insa", "noun", "centre, content, inside, between; internal organ, stomach", "", "") },
                { "jaki", new WordInfo("jaki", "adjective", "disgusting, obscene, sickly, toxic, unclean, unsanitary", "", "") },
                { "jan", new WordInfo("jan", "noun", "human being, person, somebody", "", "") },
                { "jasima", new WordInfo("jasima", "verb", "reflect, reverse", "adjective", "opposite") },
                { "jelo", new WordInfo("jelo", "adjective", "yellow, yellowish", "", "") },
                { "jo", new WordInfo("jo", "verb", "to have, carry, contain, hold", "", "") },
                { "kala", new WordInfo("kala", "noun", "fish, marine animal, sea creature", "", "") },
                { "kalama", new WordInfo("kalama", "verb", "to produce a sound; recite, utter aloud", "", "") },
                { "kama", new WordInfo("kama", "adjective", "arriving, coming, future, summoned", "pre-verb", "to become, manage to, succeed in") },
                { "kasi", new WordInfo("kasi", "noun", "plant, vegetation; herb, leaf", "", "") },
                { "ken", new WordInfo("ken", "pre-verb", "to be able to, be allowed to, can, may", "adjective", "possible") },
                { "kepeken", new WordInfo("kepeken", "preposition", "to use, with, by means of", "", "") },
                { "kijetesantakalu", new WordInfo("kijetesantakalu", "noun", "procyonid, Musteloidea", "", "") },
                { "kili", new WordInfo("kili", "noun", "fruit, vegetable, mushroom", "", "") },
                { "kin", new WordInfo("kin", "particle", "(emphasis, emotion or confirmation)", "", "") },
                { "kipisi", new WordInfo("kipisi", "verb", "split, cut, divide", "noun", "slice, segment, division") },
                { "kiwen", new WordInfo("kiwen", "noun", "hard object, metal, rock, stone", "", "") },
                { "ko", new WordInfo("ko", "noun", "clay, clinging form, dough, semi-solid, paste, powder", "", "") },
                { "kokosila", new WordInfo("kokosila", "verb", "speak another language in a Toki Pona only environment", "", "") },
                { "kon", new WordInfo("kon", "noun", "air, breath; essence, spirit; hidden reality, unseen agent", "", "") },
                { "ku", new WordInfo("ku", "adjective", "interact with Toki Pona Dictionary", "", "") },
                { "kule", new WordInfo("kule", "adjective", "colourful, pigmented, painted", "", "") },
                { "kulupu", new WordInfo("kulupu", "noun", "community, company, group, nation, society, tribe", "", "") },
                { "kute", new WordInfo("kute", "noun", "ear", "verb", "to hear, listen; pay attention to, obey") },
                { "la", new WordInfo("la", "particle", "(between the context phrase and the main sentence)", "", "") },
                { "lanpan", new WordInfo("lanpan", "verb", "steal, seize, grab", "", "") },
                { "lape", new WordInfo("lape", "adjective", "sleeping, resting", "", "") },
                { "laso", new WordInfo("laso", "adjective", "blue, green", "", "") },
                { "lawa", new WordInfo("lawa", "noun", "head, mind", "verb", "to control, direct, guide, lead, own, plan, regulate, rule") },
                { "leko", new WordInfo("leko", "noun", "square, cube, block, stair, brick", "", "") },
                { "len", new WordInfo("len", "noun", "cloth, clothing, fabric, textile; cover, layer of privacy", "", "") },
                { "lete", new WordInfo("lete", "adjective", "cold, cool; uncooked, raw", "", "") },
                { "li", new WordInfo("li", "particle", "between any subject except mi alone or sina alone and its verb; also to introduce a new verb for the same subject", "", "") },
                { "lili", new WordInfo("lili", "adjective", "little, small, short; few; a bit; young", "", "") },
                { "linja", new WordInfo("linja", "noun", "long and flexible thing; cord, hair, rope, thread, yarn", "", "") },
                { "lipu", new WordInfo("lipu", "noun", "flat object; book, document, card, paper, record, website", "", "") },
                { "loje", new WordInfo("loje", "adjective", "red, reddish", "", "") },
                { "lon", new WordInfo("lon", "preposition", "located at, present at, real, true, existing", "", "") },
                { "luka", new WordInfo("luka", "noun", "arm, hand, tactile organ", "number", "five") },
                { "lukin", new WordInfo("lukin", "verb", "to look at, see, examine, observe, read, watch; obey", "pre-verb", "to seek, look for, try to") },
                { "lupa", new WordInfo("lupa", "noun", "door, hole, orifice, window", "", "") },
                { "ma", new WordInfo("ma", "noun", "earth, land; outdoors, world; country, territory; soil", "", "") },
                { "mama", new WordInfo("mama", "noun", "parent, ancestor; creator, originator; caretaker, sustainer", "", "") },
                { "mani", new WordInfo("mani", "noun", "money, cash, savings, wealth; large domesticated animal", "", "") },
                { "meli", new WordInfo("meli", "noun", "woman, female, feminine person; wife", "", "") },
                { "meso", new WordInfo("meso", "adjective", "average, moderate, medium", "", "") },
                { "mi", new WordInfo("mi", "noun", "I, me, we, us", "", "") },
                { "mije", new WordInfo("mije", "noun", "man, male, masculine person; husband", "", "") },
                { "misikeke", new WordInfo("misikeke", "noun", "medication, medicine, cure", "", "") },
                { "moku", new WordInfo("moku", "verb", "to eat, drink, consume, swallow, ingest", "", "") },
                { "moli", new WordInfo("moli", "adjective", "dead, dying", "", "") },
                { "monsi", new WordInfo("monsi", "noun", "back, behind, rear", "", "") },
                { "monsuta", new WordInfo("monsuta", "adjective", "scary, disturbing", "noun", "monster, demon") },
                { "mu", new WordInfo("mu", "particle", "(animal noise or communication)", "", "") },
                { "mun", new WordInfo("mun", "noun", "moon, night sky object, star", "", "") },
                { "musi", new WordInfo("musi", "adjective", "artistic, entertaining, frivolous, playful, recreational", "", "") },
                { "mute", new WordInfo("mute", "adjective", "many, a lot, more, much, several, very", "noun", "quantity") },
                { "n", new WordInfo("n", "particle", "um, mmm, hmm", "", "") },
                { "namako", new WordInfo("namako", "adjective", "additional, another, extra", "", "") },
                { "nanpa", new WordInfo("nanpa", "particle", "-th (ordinal number)", "noun", "numbers") },
                { "nasa", new WordInfo("nasa", "adjective", "unusual, strange; silly; drunk, intoxicated", "", "") },
                { "nasin", new WordInfo("nasin", "noun", "way, custom, doctrine, method, path, road", "", "") },
                { "nena", new WordInfo("nena", "noun", "bump, button, hill, mountain, nose, protuberance", "", "") },
                { "ni", new WordInfo("ni", "adjective", "that, this", "", "") },
                { "nimi", new WordInfo("nimi", "noun", "name, word", "", "") },
                { "noka", new WordInfo("noka", "noun", "foot, leg, organ of locomotion; bottom, lower part", "", "") },
                { "o", new WordInfo("o", "particle", "hey! O! (vocative or imperative", "", "") },
                { "oko", new WordInfo("oko", "noun", "eye", "", "") },
                { "olin", new WordInfo("olin", "verb", "to love, have compassion for, respect, show affection to", "", "") },
                { "ona", new WordInfo("ona", "noun", "he, she, it, they", "", "") },
                { "open", new WordInfo("open", "verb", "to begin, start; open; turn on", "pre-verb", "begin to") },
                { "pakala", new WordInfo("pakala", "adjective", "", "", "") },
                { "pali", new WordInfo("pali", "verb", "to do, take action on, work on; build, make, prepare", "", "") },
                { "palisa", new WordInfo("palisa", "noun", "long hard thing; branch, rod, stick", "", "") },
                { "pan", new WordInfo("pan", "noun", "cereal, grain; barley, corn, oat, rice, wheat; bread, pasta", "", "") },
                { "pana", new WordInfo("pana", "verb", "to give, send, emit, provide, put, release", "", "") },
                { "pi", new WordInfo("pi", "particle", "of", "", "") },
                { "pilin", new WordInfo("pilin", "noun", "heart (physical or emotional)", "adjective", "feeling (an emotion, a direct experience)") },
                { "pimeja", new WordInfo("pimeja", "adjective", "black, dark, unlit", "", "") },
                { "pini", new WordInfo("pini", "adjective", "ago, completed, ended, finished, past", "pre-verb", "finish") },
                { "pipi", new WordInfo("pipi", "noun", "bug, insect, ant, spider", "", "") },
                { "poka", new WordInfo("poka", "noun", "hip, side; next to, nearby, vicinity", "", "") },
                { "poki", new WordInfo("poki", "noun", "container, bag, bowl, box, cup, cupboard, drawer, vessel", "", "") },
                { "pona", new WordInfo("pona", "adjective", "good, positive, useful; friendly, peaceful; simple", "", "") },
                { "pu", new WordInfo("pu", "adjective", "interacting with the official Toki Pona book", "", "") },
                { "sama", new WordInfo("sama", "adjective", "same, similar; each other; sibling, peer, fellow", "preposition", "as, like") },
                { "seli", new WordInfo("seli", "noun", "fire; cooking element, chemical reaction, heat source", "", "") },
                { "selo", new WordInfo("selo", "noun", "outer form, outer layer; bark, peel, shell, skin; boundary", "", "") },
                { "seme", new WordInfo("seme", "particle", "what? which?", "", "") },
                { "sewi", new WordInfo("sewi", "noun", "area above, highest part, something elevated", "adjective", "awe-inspiring, divine, sacred, supernatural") },
                { "sijelo", new WordInfo("sijelo", "noun", "body (of person or animal), physical state, torso", "", "") },
                { "sike", new WordInfo("sike", "noun", "round or circular thing; ball, circle, cycle, sphere, wheel", "adjective", "of one year") },
                { "sin", new WordInfo("sin", "adjective", "new, fresh", "", "") },
                { "sina", new WordInfo("sina", "noun", "you", "", "") },
                { "sinpin", new WordInfo("sinpin", "noun", "face, foremost, front, wall", "", "") },
                { "sitelen", new WordInfo("sitelen", "noun", "image, picture, representation, symbol, mark, writing", "", "") },
                { "soko", new WordInfo("soko", "noun", "mushroom, fungus", "", "") },
                { "sona", new WordInfo("sona", "verb", "to know, be skilled in, be wise about, have information on", "pre-verb", "to know how to") },
                { "soweli", new WordInfo("soweli", "noun", "animal, beast, land mammal", "", "") },
                { "suli", new WordInfo("suli", "adjective", "big, heavy, large, long, tall; important; adult", "", "") },
                { "suno", new WordInfo("suno", "noun", "sun; light, brightness, glow, radiance, shine; light source", "", "") },
                { "supa", new WordInfo("supa", "noun", "horizontal surface, thing to put or rest something on", "", "") },
                { "suwi", new WordInfo("suwi", "adjective", "sweet, fragrant; cute, innocent, adorable", "", "") },
                { "tan", new WordInfo("tan", "preposition", "by, from, because of", "", "") },
                { "taso", new WordInfo("taso", "particle", "but, however", "adjective", "only") },
                { "tawa", new WordInfo("tawa", "preposition", "going to, toward; for; from the perspective of", "adjective", "moving") },
                { "telo", new WordInfo("telo", "noun", "water, liquid, fluid, wet substance; beverage", "", "") },
                { "tenpo", new WordInfo("tenpo", "noun", "time, duration, moment, occasion, period, situation", "", "") },
                { "toki", new WordInfo("toki", "verb", "to communicate, say, speak, say, talk, use language, think", "", "") },
                { "tomo", new WordInfo("tomo", "noun", "indoor space; building, home, house, room", "", "") },
                { "tonsi", new WordInfo("tonsi", "noun", "non-binary person, transgender person, gender non-conforming person, intersex person", "", "") },
                { "tu", new WordInfo("tu", "number", "two", "", "") },
                { "unpa", new WordInfo("unpa", "verb", "to have sexual or marital relations with", "", "") },
                { "uta", new WordInfo("uta", "noun", "mouth, lips, oral cavity, jaw", "", "") },
                { "utala", new WordInfo("utala", "verb", "to battle, challenge, compete against, struggle against", "", "") },
                { "walo", new WordInfo("walo", "adjective", "white, whitish; light-coloured, pale", "", "") },
                { "wan", new WordInfo("wan", "adjective", "unique, united", "number", "one") },
                { "waso", new WordInfo("waso", "noun", "bird, flying creature, winged animal", "", "") },
                { "wawa", new WordInfo("wawa", "adjective", "strong, powerful; confident, sure; energetic, intense", "", "") },
                { "weka", new WordInfo("weka", "adjective", "absent, away, ignored", "", "") },
                { "wile", new WordInfo("wile", "pre-verb", "must, need, require, should, want, wish", "", "") },
            };
        }
    }

    public class WordInfo
    {
        public WordInfo(string _name, string _type1, string _def1, string _type2, string _def2)
        {
            name = _name;
            type1 = _type1;
            def1 = _def1;
            type2 = _type2;
            def2 = _def2;
        }
        public string name { get; set; }
        public string type1 { get; set; }
        public string def1 { get; set; }
        public string type2 { get; set; }
        public string def2 { get; set; }
    }
}
