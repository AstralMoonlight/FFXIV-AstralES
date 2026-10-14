# Usage: python -I tools/msq/guardar.py <msq/en/.../NNNN-Id.tsv> <draft.tsv> <msq/es/.../NNNN-Id.tsv>
# The draft has one line per row: the key without its TEXT_<ID>_ prefix, a tab, and the Spanish.
# Checks every English key has a Spanish line, the same macros (gender <if> aside) and the same
# emote commands (/doubt...), then writes the Spanish file. Exits 1 and lists problems otherwise.
import os, re, sys

en_path, draft_path, out_path = sys.argv[1:4]
en = [l.split('\t') for l in open(en_path, encoding='utf-8').read().splitlines()[1:]]
prefix = 'TEXT_' + en_path.replace('\\', '/').split('/')[-1].split('-', 1)[-1][:-4].upper() + '_'
es = {}
for l in open(draft_path, encoding='utf-8').read().splitlines():
    if l.strip():
        k, v = l.split('\t')
        es[prefix + k] = v

keys = [r[0] for r in en]
problems = [f'falta {k}' for k in keys if k not in es] + [f'sobra {k}' for k in es if k not in keys]

def macros(t):
    t = t.replace('\\<', '')
    return sorted(m for m in re.findall(r'<(/?[a-zA-Z][a-zA-Z0-9]*|--)[(>]', t) if m != 'if')

def emotes(t):
    return sorted(re.findall(r'(?<![\w<])/[a-z]+\b', t))

for k, _, text in en:
    if k in es:
        if macros(text) != macros(es[k]):
            problems.append(f'macros {k}: {macros(text)} != {macros(es[k])}')
        if emotes(text) != emotes(es[k]):
            problems.append(f'emotes {k}: {emotes(text)} != {emotes(es[k])}')
        if '<if(' not in text and '<if(' in es[k] and 'gnum4' not in es[k]:
            problems.append(f'if nuevo sin gnum4 {k}')

if problems:
    print('\n'.join(problems))
    sys.exit(1)

os.makedirs(os.path.dirname(out_path), exist_ok=True)
open(out_path, "w", encoding='utf-8', newline='\n').write('key\ttext\n' + ''.join(f'{k}\t{es[k]}\n' for k in keys))
print(len(keys), 'lineas ->', out_path)
