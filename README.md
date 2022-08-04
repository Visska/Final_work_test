# Формирование массива строк с длинной элементов равной 3 из уже имеющегося массива строк
---

### Объявим и инициализируем переменную *resultArrayLegth*
---

### Создадим метод **lengthNewArray**, которым найдём количество элементов размером 3 и менее, в имеющемся массиве строк
 1. Объявим и инициализируем переменную счетчик __count__
 2. С помощью цикла **_for_** пройдём по массиву:
    *  Если длинна элемента массива равна или меньше 3, увеличим __count__ на 1
 3. Вернем получившееся значение __count__ в переменную *resultArrayLegth*

---
### Создадим новый массив _**resultArray**_ с длинной *resultArrayLegth*
---

### Создадим метод **createArrayLengthThree** , чтобы заполнить наш массив _**resultArray**_ элементами с длинной 3 и менее из имеющегося массива
 1. Объявим и инициализируем переменную счетчик __index__
 2. С помощью цикла **_for_** пройдём по имеющемуся массиву:
    * Если длинна элемента массива равна или меньше 3:
      - запишем этот элемент в массив _**resultArray**_
      - увеличим значение __index__ на 1
 3. Вернем получившийся массив **resultArray** в  _**resultArray**_
---
### Выведем в консоль получившийся массив _**resultArray**_