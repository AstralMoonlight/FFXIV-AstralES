# Usage: python -I tools/msq/ver.py <carpeta de msq/en> <número> [x]
# Prints each line of msq/en/<carpeta>/<número>-*.tsv as "key without prefix<TAB>English", and under it
# the Japanese original from msq/ja/ (skipping SEQ and TODO). With a third argument, English only.
import glob, os, sys
sys.stdout.reconfigure(encoding='utf-8')

folder, n = sys.argv[1:3]
en = glob.glob(f'msq/en/{folder}/{n}-*.tsv')[0].replace(os.sep, '/')

def read(path):
    if not os.path.exists(path):
        return {}
    return {r[0]: r[-1] for r in (l.split('\t') for l in open(path, encoding='utf-8').read().splitlines()[1:])}

E, J = read(en), read(en.replace('/en/', '/ja/'))
prefix = 'TEXT_' + en.split('/')[-1].split('-', 1)[-1][:-4].upper() + '_'
for k, v in E.items():
    short = k.replace(prefix, '')
    print(f'{short}\t{v}')
    if J.get(k) and len(sys.argv) < 4 and not short.startswith(('SEQ', 'TODO')):
        print(f'  JA\t{J[k]}')
