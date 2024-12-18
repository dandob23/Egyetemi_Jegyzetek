### **8. Vektorok, mátrixok, homogén koordináták és vetítések**

Az alábbiakban összefoglalom a vektorok és mátrixok alapjait, a homogén koordináták szerepét, valamint a transzformációkat és vetítéseket.

---

## **1. Vektorok és mátrixok**

### **1.1 Vektorok**
- Egy **vektor** egy irányított szakasz, amelynek van **irányítottsága** és **hossza**.
- **Definíció**:
  
$$\mathbf{v} = (x, y) \quad \text{(2D)}, \quad \mathbf{v} = (x, y, z) \quad \text{(3D)}$$

- **Műveletek**:
  1. **Összeadás**:
     
$$\mathbf{v} + \mathbf{u} = (v_x + u_x, v_y + u_y, v_z + u_z)$$

  2. **Skalárral szorzás**:

$$k \cdot \mathbf{v} = (k v_x, k v_y, k v_z)$$

  4. **Skaláris szorzat**:

$$\mathbf{v} \cdot \mathbf{u} = v_x u_x + v_y u_y + v_z u_z$$

  5. **Vektoriális szorzat** (3D-ben):

$$\mathbf{v} \times \mathbf{u} = \begin{vmatrix}\mathbf{i} & \mathbf{j} & \mathbf{k} \\ v_x & v_y & v_z \\ u_x & u_y & u_z \end{vmatrix}$$

### **1.2 Mátrixok**
- Egy **mátrix** egy számtábla, amely sorokból és oszlopokból áll. 
- **Definíció**:
  
$$A = \begin{bmatrix}a_{11} & a_{12} & \dots & a_{1n} \\ a_{21} & a_{22} & \dots & a_{2n} \\ \vdots & \vdots & \ddots & \vdots \\ a_{m1} & a_{m2} & \dots & a_{mn} \end{bmatrix}$$

- **Műveletek**:
  1. **Mátrix-vektor szorzás**:
     
$$\mathbf{A} \cdot \mathbf{v} = \begin{bmatrix}a_{11} & a_{12} & a_{13} \\ a_{21} & a_{22} & a_{23} \\ a_{31} & a_{32} & a_{33} \end{bmatrix} \begin{bmatrix} v_x \\ v_y \\ v_z \end{bmatrix} = \begin{bmatrix} a_{11}v_x + a_{12}v_y + a_{13}v_z \\ a_{21}v_x + a_{22}v_y + a_{23}v_z \\ a_{31}v_x + a_{32}v_y + a_{33}v_z \end{bmatrix}$$

---

## **2. Homogén koordináták**

### **Motiváció**:
- A homogén koordináták a transzformációk egységes kezelésére szolgálnak (pl. eltolás, forgatás, nyújtás).
- Hagyományos koordinátákkal az eltolás **nem kezelhető** mátrixművelettel, míg homogén koordinátákban igen.

### **Definíció**:
- Egy $(x, y)$ pont homogén koordinátája $(x, y, w)$, ahol $w \neq 0$.
- A visszavetítés:

$$(x, y, w) \to \left( \frac{x}{w}, \frac{y}{w} \right)$$

### **Homogén transzformációk mátrixa**:
- **Általános forma (3x3 2D-ben)**:

$$\mathbf{T} = \begin{bmatrix} a & b & tx \\ c & d & ty \\ 0 & 0 & 1 \end{bmatrix}$$

---

## **3. Vetítések**

A vetítés a 3D objektumok leképezése 2D síkra. Két fő típus:

### **3.1 Párhuzamos vetítés**
- Az objektumot párhuzamos vetítési sugarakkal vetítjük a síkra.
- **Ortografikus vetítés**:
  - A vetítés iránya merőleges a képsíkra.
  - **Példa**: Műszaki rajzok.
- **Axonometrikus vetítés**:
  - Nem feltétlenül merőleges, de a térbeli arányokat megtartja (pl. izometrikus vetítés).

### **3.2 Centrális (perspektivikus) vetítés**
- A vetítési sugarak egy közös pontból (a vetítési középpontból) indulnak ki.
- **Vetítési mátrix**:
  
$$P = \begin{bmatrix} 1 & 0 & 0 & 0 \\ 0 & 1 & 0 & 0 \\ 0 & 0 & 1 & 0 \\ 0 & 0 & \frac{1}{d} & 0 \end{bmatrix}$$

Ahol $d$ a vetítési távolság.

---

## **4. Ponttranszformációk**

### **4.1 Egybevágósági transzformációk**
- Megtartják az alakzat formáját és méretét.
- **Példák**:
  - **Eltolás**:
    
$$ \mathbf{T} = \begin{bmatrix} 1 & 0 & tx \\ 0 & 1 & ty \\ 0 & 0 & 1 \end{bmatrix}$$

  - **Forgatás** (2D-ben):

$$ \mathbf{R} = \begin{bmatrix} \cos\theta & -\sin\theta & 0 \\ \sin\theta & \cos\theta & 0 \\ 0 & 0 & 1 \end{bmatrix}$$

### **4.2 Hasonlósági transzformációk**
- Megtartják az arányokat, de méretezhetnek.
- **Példa**: Nyújtás (méretezés):

$$\mathbf{S} = \begin{bmatrix} sx & 0 & 0 \\ 0 & sy & 0 \\ 0 & 0 & 1 \end{bmatrix}$$

### **4.3 Affin transzformációk**
- Általános lineáris transzformációk, amelyek egy pontot a síkon belül másik pontba képeznek.
- **Mátrix**:
  
$$ \mathbf{A} = \begin{bmatrix} a & b & tx \\ c & d & ty \\ 0 & 0 & 1 \end{bmatrix}$$

---

## **5. Window-Viewport transzformáció**

### **Definíció**:
- Egy 2D képet (window) egy másik 2D területre (viewport) vetítünk, például átméretezéshez vagy nagyításhoz.

### **Lépések**:
1. **Window koordináták átváltása normál koordinátákra**:
   
$$ x' = \frac{x - x_\text{min}}{x_\text{max} - x_\text{min}}, \quad y' = \frac{y - y_\text{min}}{y_\text{max} - y_\text{min}}$$

2. **Normál koordináták átváltása viewport koordinátákra**:

$$ x_v = x_v^\text{min} + x'(x_v^\text{max} - x_v^\text{min}), \quad y_v = y_v^\text{min} + y'(y_v^\text{max} - y_v^\text{min})$$

---

### **Összefoglaló táblázat**

| **Fogalom**                      | **Magyarázat**                                                                                 |
|----------------------------------|---------------------------------------------------------------------------------------------|
| **Vektorok és mátrixok**         | Alapvető eszközök a transzformációkhoz (pl. eltolás, forgatás, nyújtás).                      |
| **Homogén koordináták**          | Egységes formát biztosítanak a transzformációk (különösen az eltolás) kezelésére.             |
| **Vetítések**                    | 3D objektumok 2D síkra való leképezése (párhuzamos, centrális).                              |
| **Ponttranszformációk**          | Egybevágósági, hasonlósági, és affin transzformációk különböző tulajdonságokkal.              |
| **Window-Viewport transzformáció**| Egy ablak tartalmának egy másik területre való átméretezése.                                  |

---

Ha szeretnéd, egy konkrét transzformációs példát is részletesen kiszámíthatunk! 😊
