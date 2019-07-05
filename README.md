# Snake
Visual Programming - Project


Опис на играта „Snake “

Семинарската задача ја опфаќа добро познатата игра „Snake“.Во класичната игра целта е да се развива нашата змија колку што е можно со јадење парчиња кои се поставени по случаен избор во теренот. Змија не може да се добие преку претходно дефинирани ѕидови. Змија може да се движи само десно, лево, врвот и на дното. 
Играта завршува кога нашите змија се судираат со еден од ѕид или се судираат со себе.

Објаснување на имлементацијата на играта

Играта е изработена во програмскиот јазик C#. Играта е направена со користење на една главна форма.
Пред да ја започнете играта имаме 5 опции кои треба да се избере на тежината на играта. Во долниот лев дел имаме 2 етикети со што се покажува резултат и јаде храната.
Имаме 2 копчиња:
  - New Game со што се создава нова игра, места змија во позиции и храна во случајно избрани позиција.
  - Start, кој започнува играта кој е  креирано со “New Game” копчето.

Прв поглед на играта изгледа вака: 

![](https://github.com/aNqa/Snake/blob/master/screenshot/Untitled1.png "")

 
Да се создаде нова игра ние треба да притиснете на "New Game" копчето. По притискање игра изгледа како: 

![](https://github.com/aNqa/Snake/blob/master/screenshot/Untitled2.png "")

По креирањето игра ние треба да притиснеме на "Start" за да ја стартуваме играта.
Ние ќе се обидеме да се развива нашата змија без судир да го зголеми нашето резултат.

![](https://github.com/aNqa/Snake/blob/master/screenshot/Untitled3.png "")
 

Играта ќе заврши кога ќе се судираат со ѕид или себе. По крајот на играта сандаче за пораки ќе се појави што покажува крајот на играта и конечниот резултат.
 
![](https://github.com/aNqa/Snake/blob/master/screenshot/Untitled4.png "")

Подетален опис за изворниот код
Го употребив "Точка" функција да се задржи позицијата на змија и Листа на поени. За насока јас се користи "Вариант за парт" со дефинирани насоки на змија.


Функција за да се провери судир:
 
     private bool isGameOver()
            {
                //Check limits
                if (posX > xMax || posX < xMin || posY > yMax || posY < yMin)
                {
                    return true;
                }
    
                //Eat itself
                if (snakePosition.Any(t => t.X == posX && t.Y == posY))
                {
                    return true;
                }
    
                return false;
            }
 
        
Функција за брзината на змија според тежината:

    private void setGameSpeed()
            {
                switch (speedSelection.SelectedIndex)
                {
                    case 0:
                        gameTimer.Interval = 100;
                        break;
                    case 1:
                        gameTimer.Interval = 75;
                        break;
                    case 2:
                    default:
                        gameTimer.Interval = 50;
                        break;
                    case 3:
                        gameTimer.Interval = 40;
                        break;
                    case 4:
                        gameTimer.Interval = 25;
                        break;
                    case 5:
                        gameTimer.Interval = 10;
                        break;
                }
            }

Функција за насока:

    private void setPositionValues()
            {
                switch (direction)
                {
                    case DirectionEnum.Bot:
                        posY++;
                        break;
                    case DirectionEnum.Top:
                        posY--;
                        break;
                    case DirectionEnum.Left:
                        posX--;
                        break;
                    case DirectionEnum.Right:
                    default:
                        posX++;
                        break;
                }
            }


Функција за цртање на змија:

    private void drawSnake()
            {
                gameArea.Refresh();
                drawBait();
                foreach (Point item in snakePosition)
                {
                    int xVal = item.X * multiplier;
                    int yVal = item.Y * multiplier;
    
                    drawPoint(xVal, yVal);
                }
            }

Prepared by : Ebrar Islami 131541
