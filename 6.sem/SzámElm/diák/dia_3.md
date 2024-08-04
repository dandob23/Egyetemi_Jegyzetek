### Többszalagos Turing-gép

**Formális definíció**:  
\[ T = \langle k, \Sigma, Q, q_0, F, \delta \rangle \]

- \( k \): szalagok száma, \( k \geq 1 \)
- \( \Sigma \): szalagjelek (betűk) halmaza, \( \triangleright, \sqcup \in \Sigma \)
- \( Q \): állapotok halmaza, \( Q \ne \emptyset \)
- \( q_0 \): kezdőállapot, \( q_0 \in Q \)
- \( F \): elfogadó állapotok halmaza, \( F \subseteq Q \)
- \( \delta \): (állapot)átmenetfüggvény

**Átmenetfüggvény**:  
Milyen paraméterekkel és milyen függvényértékkel?

- 1 db. vezérlő, azaz 1 db. állapot
- \( k \) db. szalag van, ezért:
  - \( k \) db. betűt olvas: \( \sigma_1, \ldots, \sigma_k \)
  - \( k \) db. betűt ír: \( \sigma_1', \ldots, \sigma_k' \)
  - \( k \) db. mozgást végez: \( m_1, \ldots, m_k \)

\[ \delta(q, \sigma_1, \ldots, \sigma_k) = (q', \sigma_1', m_1, \ldots, \sigma_k', m_k) \]

### Többszalagos Turing-gép használata

\[ T = \langle k, \Sigma, Q, q_0, F, \delta \rangle \]

- \( k \): szalagok száma, \( k \geq 1 \)
- \( \Sigma \): szalagjelek (betűk) halmaza, \( \triangleright, \sqcup \in \Sigma \)
- \( Q \): állapotok halmaza, \( Q \ne \emptyset \)
- \( q_0 \): kezdőállapot, \( q_0 \in Q \)
- \( F \): elfogadó állapotok halmaza, \( F \subseteq Q \)
- \( \delta \): (állapot)átmenetfüggvény,
  \[ \delta: Q \times \Sigma^k \rightarrow Q \times \Sigma^k \times \{ \leftarrow, -, \rightarrow \}^k \]
  
\[ \delta(q, \sigma_1, \ldots, \sigma_k) = (q', \sigma_1', m_1, \ldots, \sigma_k', m_k) \]

**Feltétel**:  
Ha \( \sigma_i = \triangleright \), akkor \( \sigma_i' = \triangleright \) és \( m_i = \rightarrow \).

### Konfigurációk

**Egyszalagos Turing-gép esetén**:  
\[ (q, u, v) \]
ahol \( q \in Q \) és \( u, v \in \Sigma^* \)

**Többszalagos Turing-gép esetén**:  
\[ (q, u_1, v_1, \ldots, u_k, v_k) \]
ahol \( q \in Q \) és \( u_i, v_i \in \Sigma^* \)

### Szalagok funkciói

1. szalag = inputszalag  
Az input szó induláskor ide helyezzük.

\( k \)-dik szalag = outputszalag  
Megálláskor az output szót innen olvashatjuk ki.

**Többi szalag**: munkaszalagok  
A futtatás során átmeneti adatok tárolására.

### Kezdő- és megállási konfigurációk

**Kezdőkonfiguráció**:
- Az \( x \) input az 1. szalagon
- Többi szalag „üres”

\[ (q_0, \triangleright, x, \triangleright, \epsilon, \ldots, \triangleright, \epsilon) \]

**Megállási konfiguráció**:
\[ (q, u_1 \sigma_1, v_1, \ldots, u_k \sigma_k, v_k) \]
ahol \( \delta(q, \sigma_1, \ldots, \sigma_k) \) nincs értelmezve

### Output meghatározása

**Ha van olyan megállási konfiguráció**:  
\[ (q, \triangleright u_1, v_1, \ldots, \triangleright u_k, v_k) \]
hogy
\[ (q_0, \triangleright, x, \triangleright, \epsilon, \ldots, \triangleright, \epsilon) \rightarrow^t (q, \triangleright u_1, v_1, \ldots, \triangleright u_k, v_k) \]

- Ha \( q \notin F \), akkor \( T \) elutasítja \( x \)-et
- Ha \( q \in F \), akkor \( T \) elfogadja \( x \)-et és az output \( u_k v_k \).

### Örökölt fogalmak

**Időkorlát**  
**Eldöntött nyelv**  
**Felismert nyelv**