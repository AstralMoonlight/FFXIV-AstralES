# Usage: python -I tools/msq/revisar.py [ejemplos por regla]
# Recorre todo msq/es y cuenta las líneas que rompen reglas mecánicas de la guía (rayas, Hm, signos, Lord...).
# Algunas reglas dan falsos positivos ("vale" verbo, "vosotros" arcaico); se revisan a mano.
import glob, os, re, sys, collections
sys.stdout.reconfigure(encoding='utf-8')
R=os.path.join(os.path.dirname(os.path.abspath(__file__)),'..','..','msq').replace(chr(92),'/')+'/'
OK={'espacio-tiempo','cofre-ataúd','hacen-inventan','ciudad-estado'}
def pairs():
    for f in glob.glob(R+'es/**/*.tsv',recursive=True):
        e=f.replace(chr(92),'/').replace('/msq/es/','/msq/en/')
        if not os.path.exists(e): continue
        en={l.split('\t')[0]:l.split('\t')[-1] for l in open(e,encoding='utf-8').read().splitlines()[1:]}
        for l in open(f,encoding='utf-8').read().splitlines()[1:]:
            k,t=l.split('\t',1); yield os.path.relpath(f,R+'es'),k,en.get(k,''),t
def glued(en,es):
    if not re.search(r'\w[─―]\w',en): return []
    return [m.group(0) for m in re.finditer(r'(\w+)-(\w+)',es) if not (m.group(0) in OK or m.group(2).lower().startswith(m.group(1).lower()) or m.group(2)[0].isupper() or re.search(r'\d',m.group(0)))]
checks={
 'raya_pegada': glued,
 'raya_juego': lambda en,es: re.findall(r'[─―]',es),
 'angulares': lambda en,es: re.findall(r'[«»]',es),
 'curvas': lambda en,es: re.findall(r'[“”‘’]',es),
 'hm_a_mm': lambda en,es: re.findall(r'\bMm+\b',es) if re.search(r'\bHm+\b',en) and not re.search(r'\bMm',en) else [],
 'signos_desparejos': lambda en,es: (lambda t: ['?¡'] if t.count('?')!=t.count('¿') or t.count('!')!=t.count('¡') else [])(re.sub(r'\w-(\s|$)','',re.sub(r'<[^>]*>|^\(-[^)]*-\)','',es))),
 'espacio_doble': lambda en,es: re.findall(r'\S  +\S',es),
 'espacio_antes_signo': lambda en,es: re.findall(r'\w [,.;:](?!\.)',es),
 'españolismo': lambda en,es: re.findall(r'(?:^|[¡¿.] ?)Vale[,.!]|(?:coger|cogí|enfad\w+|guay|majo|ya puestos|ordenador|zumo)',es),
 'igual_ingles': lambda en,es: ['=' ] if en.strip()==es.strip() and len(en)>25 and re.search(r' (the|and|you|is) ',en) else [],
 'lord_minus': lambda en,es: re.findall(r'\blord (?=[A-Z])',es) if re.search(r'\bLord [A-Z]',en) else [],
}
c=collections.Counter(); ex=collections.defaultdict(list)
for f,k,en,es in pairs():
    for n,fn in checks.items():
        r=fn(en,es)
        if r: c[n]+=1; ex[n].append((f,k,r[:3]))
for n in checks:
    print(n,c[n]); 
    for x in ex[n][:int(sys.argv[1]) if len(sys.argv)>1 else 4]: print('   ',x)
