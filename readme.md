# Theatrical Players Refactoring Kata (Català)

Aquest repositori conté una traducció al català de la kata publicada per Emily Bache (amb el permís de l’autor de la kata, Martin Fowler):

- Kata d’Emily Bache: https://github.com/emilybache/Theatrical-Players-Refactoring-Kata
- Perfil de l’autora: https://github.com/emilybache

---

# Sobre aquesta kata

El primer capítol del llibre:

> _Refactoring: Improving the Design of Existing Code (2nd Edition)_  
> de Martin Fowler

presenta un exemple complet de refactorització basat en aquest exercici.

- Llibre oficial: https://www.thoughtworks.com/books/refactoring2

> [!TIP]
> El [primer capítol està disponible gratuïtament](https://www.thoughtworks.com/content/dam/thoughtworks/documents/books/bk_Refactoring2-free-chapter_en.pdf) a la mateixa web.

Aquest repositori conté el punt de partida de la kata en .NET 10 i en català, juntament amb tests automatitzats per practicar la refactorització.

Emily Bache també va publicar un vídeo explicant l’exercici i el seu objectiu:

- Vídeo: https://youtu.be/TjIrKEaOiVw

---

# Objectiu de la kata

Aquesta kata està pensada per practicar tècniques de **refactorització de codi** sobre una base de codi existent.

L’exercici consisteix a millorar la qualitat interna del codi sense modificar-ne el comportament extern.

És especialment útil per practicar:

- Extract Function
- Rename Variable
- Move Function
- Eliminació de duplicació
- Separació de responsabilitats
- Introducció de polimorfisme
- Refactorització guiada per tests

---

# Context de l’exercici

L’aplicació genera factures d’una companyia teatral.

Cada client ha assistit a diverses representacions (`Representacio`) i el sistema ha de calcular:

- L’import detallat de cada obra
- El cost total
- Els punts de fidelització

Hi ha diferents tipus d’obres teatrals. El codi inicial només sap calcular factures per a:

- `tragèdia`, amb exemples com _Terra baixa_ i _Mar i cel_
- `comèdia`, amb exemples com _Pel davant i pel darrere_

Cada tipus suportat té regles de càlcul diferents.

El problema és que el codi inicial funciona, però és difícil de mantenir i ampliar.

---

# Què s’hauria de modificar

La refactorització acostuma a estar motivada per nous requisits.

Al llibre, Martin Fowler afegeix funcionalitat per:

- generar la factura en HTML, a més del format de text existent
- afegir nous tipus d’obres teatrals
  - per exemple `costumista`, amb _El cafè de la Marina_
  - o `drama`, amb _Maria Rosa_

L’objectiu és evolucionar el sistema sense degradar-ne el disseny.

---

# Tests automatitzats

Al llibre, Fowler comenta que el primer pas abans de refactoritzar és assegurar-se que existeix una bona base de tests automatitzats.

El llibre original no inclou els tests, així que Emily Bache va afegir-ne utilitzant una estratègia d’_Approval Testing_:

- Explicació de l’[Approval Testing](https://medium.com/97-things/approval-testing-33946cde4aa8)

L’Approval Testing és una tècnica molt útil per:

- posar sota test codi existent
- detectar regressions
- refactoritzar amb més seguretat

És recomanable revisar els tests abans de començar i entendre:

- què cobreixen
- què NO cobreixen
- quins errors podrien quedar sense detectar durant la refactorització

---

# Estratègia recomanada

Una possible seqüència de treball és:

1. Executar els tests existents
2. Entendre el flux del programa
3. Aplicar petites refactoritzacions
4. Executar els tests després de cada canvi
5. Repetir

És important treballar amb passos petits i continus.

---

# Agraïments

Gràcies a Martin Fowler per permetre l’ús del codi original de l’exemple del llibre.

Codi original creat per Emily Bache:  
https://github.com/emilybache

Aquest repositori és un fork traduït i adaptat al català amb petites modificacions.
