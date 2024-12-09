### **7.9.1. UML állapotgép diagram**

#### **Eredeti példa: Ajtó állapotai**

```plantuml
@startuml
[*] -down-> Nyitva : Létrehoz
Nyitva -down-> Csukva : Bezár
Csukva --> Nyitva : Kinyit
Csukva -right-> Zárva : KulcsraZár
Zárva --> Csukva : KulccsalNyit
Nyitva --> [*] : Megszüntet
Csukva --> [*] : Megszüntet
Zárva --> [*] : Megszüntet
@enduml
```

---

#### **Átirat: Lift állapotai**

```plantuml
@startuml
[*] -down-> Nyugalmi : Bekapcsol
Nyugalmi -down-> Mozgásban : Elindít
Mozgásban -right-> Meghibásodott : Hiba
Meghibásodott --> Nyugalmi : Javítás
Mozgásban -left-> Nyugalmi : Megállít
Nyugalmi --> [*] : Kikapcsol
Mozgásban --> [*] : Kikapcsol
Meghibásodott --> [*] : Kikapcsol
@enduml
```

---

### **Felhasznált elemek**

- **Kezdőállapot:** `[ * ]` jelöli.
- **Végállapot:** `[ * ]` jelöli.
- **Állapotok:** Lekerekített téglalapok (pl. *Nyitva*, *Csukva*, *Zárva* vagy *Nyugalmi*, *Mozgásban*, *Meghibásodott*).
- **Állapotátmenetek:** Nyilak, amelyek eseményeket/metódushívásokat reprezentálnak.