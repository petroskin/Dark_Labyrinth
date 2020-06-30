# Dark Labyrinth

## За играта

Суштината на играта може да се извлече од самото име. Како што тоа предложува, целта на играта е во даден лавиринт да се најде патот до крајната точка, со тоа што најголемиот предизвик е тоа што видливоста е ограничена само на полињата околу играчот, т.е. освен тие полиња, лавиринтот е затемнет и не се гледа. Единствен исклучок на ова правило е целта, односно полето на кое треба да стигнеме, кое е видливо во секој момент. Уште една додадена механика е таканаречениот „Портал“, односно поле кое дозволува да стигнеме до друго поле кое не е соседно, а можеби не е ни директно поврзано. Играта има 7 нивоа, кај кои започнувајќи од првото, тежината и сложеноста постепено се зголемуваат.

## Упатство  и како се игра

### Главно мени
![Main menu](https://github.com/petroskin/Dark_Labyrinth/blob/master/mdimage1.png?raw=true)

Главното мени првично се состои од две компоненти - паѓачка листа, во која се бира кое ниво ќе се игра, и копче, со кое започнува даденото ниво. Кога ја започнуваме играта само првото ниво ни е достапно за играње, а со секое поминато ниво се отклучува ново.Во горната лента дадени се опциите “File” и “Help”.
### Лента со алатки - “Help”
“Help” е просто за да даде кратко упатство за кои се контролите за игра и која е целта на играта. 
### Лента со алатки - “File”
“File” нуди можности за напредокот на нивоата. Тука се “Save progress” и “Save progress as…” кои се користат за зачувување на отклучените нивоа во играта, и “Load progress” за вчитување претходно зачувани нивоа. Нивоата ја користат наставката “.dala” и се зачувуваат и се вчитуваат како податоци од самиот податочен систем со тоа што корисникот избира кој податок да се вчита или како да се зачува. Останати функционалности се “Delete progress” кој го враќа корисникот на почеток од играта, и “Exit” со кој се излегува од играта.

### Ниво
![Level](https://github.com/petroskin/Dark_Labyrinth/blob/master/mdimage1.png?raw=true)

Ова е главниот дел на играта. Како што се гледа, поголемиот дел од лавиринтот е затемнет. Како што се движи играчот, така различни делови се откриваат и затемнуваат. Контролите за играта се едноставни - на стрелките се движи играчот, а на ‘space’ копчето користи портал, доколку се наоѓа кај таков. Тие се соодветно прикажани на долната лента - на почетокот на секое ниво кажува дека стрелките се за движење, а кога играчот се наоѓа на портал - дека со ‘space’ се влегува во него.
### Лента со алатки - “Help”
Повторно, “Help” служи за да даде кратко упатство за кои се контролите за игра и која е целта на играта. 
### Лента со алатки - “Game”
Тука се наоѓаат опциите за да се започне нивото од почеток, како и да се врати на главното мени.

### Цел
Кога ќе се постигне целта, односно ќе се пристигне на целното поле, нивото се открива, при што играчот може да ги види сите патишта. Исто така се прикажува соодветна порака, после која се враќа назад на главното мени.

## Опис на имплементацијата

Играта секаде користи Windows Forms контроли и графика, со исклучок на позадината на главното мени, слика која се базира на играта, и човечето кое го означува играчот, кое е превземено од интернет.
Играчот: https://alexs-assets.itch.io/side-view-game-assets

### Поле
“Field” (поле) е абстрактна класа. Секое поле содржи информации за неговите координати. Има функции за цртање, кога се наоѓа во видното поле на играчот, и сенчење, кога не се наоѓа таму. Во овие функции како аргумент се праќа графиката, и според координатите и големините на нивото се исцртува секое поле. Од оваа класа наследуваат достапните патишта, ѕидовите, порталите, како и целта, соодветно класите “Path”, “Wall”, “Portal” и “Goal”.
```c#
public abstract class Field
{
    public int coordX { get;  set; }
    public int coordY { get;  set; }
    public Field(int X, int Y) {...}

    // everything is drawn differently
    public abstract void draw(Graphics g, int panelWidth, int mazeSize);
    //almost everything is shadowed the same
    public virtual void shadow(Graphics g, int panelWidth, int mazeSize) {...}
}
```

### Играч
“Player” (играч) е класата одговорна за играчот кој се движи низ полето. Во оваа класа се памтат координатите на играчот, како и нивото во кое се наоѓа, односно полињата кои го градат нивото. Има функции соодветно за движење во насоките горе, долу, лево и десно, како и за телепортирање, односно поместување до кое било дадено поле, со услов тоа боле да не е ѕид. Функција за цртање не е дадена тука, бидејќи има само еден играч на ниво и таму може тоа да биде спроведено.
```c#
public class Player
{
    public Field [,] fields { get; set; }
    public int coordX { get; set; }
    public int coordY { get; set; }
    public Player(Field[,] gameFields, int X, int Y) {...}
    // Level.MoveDirection is enum with move directions
    public bool move(Level.MoveDirection direction) {...}
    private bool moveUp() {...}
    private bool moveDown() {...}
    private bool moveLeft() {...}
    private bool moveRight() {...}
    public bool teleport(int X, int Y) {...}
}
```

### Ниво
“Level” (ниво) е главната класа на проектот. Примарните компоненти во неа се играч и матрица од полиња. Кога ќе се придвижи играчот се повикува функција move, која го проследува движењето на играчот низ полето, и при секое движење се освежува погледот. Соодветно ако е победено нивото, се прикажуваат сите полиња. Функцијата за освежување на погледот е updateVisibleFields. Таа работи така што чува листа од сите претходни видливи полиња. На секое движење, од таа листа се отстрануваат видните полиња кои се далеку и истите се затемнуваат, а се додаваат и откриваат новите околни полиња. Вклучени се уште некои функции, како drawPlayer, функција одговорна за цртање на играчот на точната позиција.
```c#
public class Level
{
    public Field [,] fields { get;  set; }
    public Path start { get;  set; }
    public Player player { get;  set; }
    public List<Field> visibleFields { get;  set; }
    public bool gameOver { get;  set; }
    public Graphics graphics { get;  set; }
    public int panelWidth { get; set; }
    public MoveDirection lastMove;
    public enum MoveDirection {...}
    public Level(Field [,] gameFields, Player gamePlayer) {...}
    public bool move(MoveDirection direction) {...}
    public bool teleport() {...}
    public void updateVisibleFields() {...}
    public void revealAll() {...}
    public void setGraphics(Graphics g, int panelWidth) {...}
    public void drawPlayer(Graphics g, int panelWidth, MoveDirection prevMove) {...}
}
```
```c#
public void updateVisibleFields()
{
    // Get rid of the far fields first
    for (int i = 0; i < visibleFields.Count; i++)
    {
        Field field = visibleFields.ElementAt(i);
        if (Math.Abs(field.coordX - player.coordX) > 1 || Math.Abs(field.coordY - player.coordY) > 1)
        {
            visibleFields.Remove(field);
            i--;
            field.shadow(graphics, panelWidth, fields.GetLength(0));
        }
    }
    // Get new near fields
    Field[] nearbyFields = { 
                               fields[player.coordX + 1,player.coordY + 1],
                               fields[player.coordX + 1,player.coordY],
                               fields[player.coordX + 1,player.coordY - 1],
                               fields[player.coordX,player.coordY + 1],
                               fields[player.coordX,player.coordY],
                               fields[player.coordX,player.coordY - 1],
                               fields[player.coordX - 1,player.coordY + 1],
                               fields[player.coordX - 1,player.coordY],
                               fields[player.coordX - 1,player.coordY - 1],
                           };
    // Update near fields
    for (int i = 0; i < nearbyFields.Length; i++)
    {
        if (!visibleFields.Contains(nearbyFields[i]))
            visibleFields.Add(nearbyFields[i]);
        nearbyFields[i].draw(graphics, panelWidth, fields.GetLength(0));
    }
    drawPlayer(graphics, panelWidth, lastMove);
}
```

### Нивоа
“Levels” (Нивоа) е класа со неколку статични методи кои враќаат специфично ниво. Овие се долги методи во кои матриците од полиња на нивоата се „цртани рачно“, односно кодирани без посебна постапка бидејќи секое поле е различно и уникатно.
```c#
public class Levels
{
    public static Level level1() {...}
    public static Level level2() {...}
    public static Level level3() {...}
    public static Level level4() {...}
    public static Level level5() {...}
    public static Level level6() {...}
    public static Level level7() {...}
}
```
